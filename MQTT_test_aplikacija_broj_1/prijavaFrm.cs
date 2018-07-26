using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using IPAddressControlLib; //Ukljucena biblioteka za kontrolu formata IP adresa NEPOTREBNO
using uPLibrary.Networking.M2Mqtt; //Ukljucena biblioteka za koristenje MQTT protokola
using uPLibrary.Networking.M2Mqtt.Messages; //Ukljucena biblioteka za slanje/primanje poruka preko MQTT protokola
using System.Diagnostics;

namespace MQTT_test_aplikacija_broj_1
{
    public partial class prijavaFrm : Form
    {
        //Prilikom pokretanja pocetne forme instanciramo MQTT klasu i povezujemo se na brokera
        MqttClient Client = new MqttClient("broker.mqttdashboard.com");
        Korisnik korisnik = new Korisnik();
        int pretplata = 0;
        string output;
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if(this.outputPoruke.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.outputPoruke.Clear();
                foreach(var item in this.korisnik.vratiPoruke())
                {
                    this.outputPoruke.AppendText(item + "\n");
                }
                this.outputPoruke.Update();
            }
        }

        public prijavaFrm()
        {
            InitializeComponent();
        }

        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string zaprimljenaPoruka = Encoding.UTF8.GetString(e.Message);

            //Debug.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);

            output = "";

            if(this.korisnik.vratiBrojPoruka() != 0)
            {
                if (this.korisnik.posljednjaPoruka() != zaprimljenaPoruka.ToString())
                {
                    this.korisnik.novaPoruka(zaprimljenaPoruka);
                    foreach (var elem in this.korisnik.vratiPoruke())
                    {
                        output += elem + "\n";
                    }
                    SetText(output.ToString());
                }
            }
            else
            {
                this.korisnik.novaPoruka(zaprimljenaPoruka);
                foreach (var elem in this.korisnik.vratiPoruke())
                {
                    output += elem + "\n";
                }
                SetText(output.ToString());
            }
            
        }

        private void prijavaFrm_Load(object sender, EventArgs e)
        {
            btnIskljucivanje.Enabled = false;
            btnAuto.Checked = true;
            btnRucno.Checked = false;
            outputPoruke.Enabled = false;
            inputPoruka.Enabled = false;
            btnObjavi.Enabled = false;
        }

        private void btnSpajanje_Click(object sender, EventArgs e)
        {
            if(btnAuto.Checked == true)
            {
                Client = new MqttClient("broker.mqttdashboard.com");
                //Rucno podesavanje najnovije verzije protokola
                //Napomena: verziju protokola treba podesiti prije pozivanja Connect() metode
                Client.ProtocolVersion = MqttProtocolVersion.Version_3_1_1;
            }
            else
            {
                Client = new MqttClient(inputIpAdresa.Text.ToString());               //Rucno podesavanje najnovije verzije protokola
                //Napomena: verziju protokola treba podesiti prije pozivanja Connect() metode
                Client.ProtocolVersion = MqttProtocolVersion.Version_3_1_1;
            }
            korisnik = new Korisnik(1337, inputKorIme.Text.ToString(), inputLozinka.Text.ToString());
            byte code = Client.Connect(Guid.NewGuid().ToString(), inputKorIme.Text.ToString(), inputLozinka.Text.ToString());
            if(code == 0)
            {
                btnSpajanje.Enabled = false;
                btnIskljucivanje.Enabled = true;
                btnAuto.Enabled = false;
                btnRucno.Enabled = false;
                inputKorIme.Enabled = false;
                inputLozinka.Enabled = false;
                MessageBox.Show("Uspješna prijava!");
            }
        }

        private void btnIskljucivanje_Click(object sender, EventArgs e)
        {
            Client.Disconnect();
            btnIskljucivanje.Enabled = false;
            btnSpajanje.Enabled = true;
            btnAuto.Enabled = true;
            btnRucno.Enabled = true;
            inputKorIme.Enabled = true;
            inputLozinka.Enabled = true;
            MessageBox.Show("Uspješna odjava!");
        }

        private void btnAuto_CheckedChanged(object sender, EventArgs e)
        {
            if(btnAuto.Checked == true)
            {
                btnRucno.Checked = false;
                inputIpAdresa.Enabled = false;
            }
        }

        private void btnRucno_CheckedChanged(object sender, EventArgs e)
        {
            if(btnRucno.Checked == true)
            {
                btnAuto.Checked = false;
                inputIpAdresa.Enabled = true;
            }
        }

        private void btnPretplati_Click(object sender, EventArgs e)
        {
            string tema = "zavrsni_rad/" + inputTema.Text.ToString() + "/test";

            pretplata = this.korisnik.dodajTemu(tema);
            if(pretplata == 1)
            {
                Client.Subscribe(new string[] { tema }, new byte[] { 2 });
                pretplacenaTema();
                chat();
            }
            else
            {
                MessageBox.Show("Već ste pretplaćeni na tu temu!");
                chat();
            }
        }
        
        public void pretplacenaTema()
        {
            outputPretplate.Clear();
            foreach(var item in this.korisnik.vratiPopis())
            {
                outputPretplate.AppendText(item + "\n");
            }
            outputPretplate.Update();
        }

        public void odjavljeneTeme()
        {
            outputPretplate.Clear();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            string tema = "zavrsni_rad/" + inputTema.Text.ToString() + "/test";

            pretplata = korisnik.makniTemu(tema);
            if (pretplata == 1)
            {
                Client.Unsubscribe(new string[] { tema });
                odjavljeneTeme();
                pretplacenaTema();
                chat();
            }
            else
            {
                MessageBox.Show("Nema postojeće teme!");
                chat();
            }
        }

        public void chat()
        {
            int pretplate = this.korisnik.vratiBroj();

            if(pretplate > 0)
            {
                inputTemaObjavi.Enabled = true;
                outputPoruke.Enabled = false;
                inputPoruka.Enabled = true;
                btnObjavi.Enabled = true;
            }
            else
            {
                inputTemaObjavi.Enabled = false;
                outputPoruke.Enabled = false;
                inputPoruka.Enabled = false;
                btnObjavi.Enabled = false;
            }
        }

        private void prijavaFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.btnIskljucivanje.Enabled == true)
            {
                this.Client.Disconnect();
            }
            Application.Exit();
        }

        private void btnObjavi_Click(object sender, EventArgs e)
        {
            //Provjera je li unesena poruka ili tema
            if(inputPoruka.Text == "" || inputTemaObjavi.Text == "")
            {
                if(inputPoruka.Text == "")
                {
                    MessageBox.Show("Ne možete poslati praznu poruku!");
                }
                if(inputTemaObjavi.Text == "")
                {
                    MessageBox.Show("Ne možete objaviti na praznu temu!");
                }
            }
            else
            {
                //Tema na koju objavljujemo poruku
                string tema = "zavrsni_rad/" + inputTemaObjavi.Text.ToString() + "/test";

                Client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                //Objava poruke sa QoS 2
                Client.Publish(tema, Encoding.UTF8.GetBytes(inputPoruka.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            }
        }
    }
}
