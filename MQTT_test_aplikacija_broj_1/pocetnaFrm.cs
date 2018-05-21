using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net; //Ukljucena biblioteka za web programiranje
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt; //Ukljucena biblioteka za koristenje MQTT protokola
using uPLibrary.Networking.M2Mqtt.Messages; //Ukljucena biblioteka za slanje/primanje poruka preko MQTT protokola

namespace MQTT_test_aplikacija_broj_1
{
    public partial class pocetnaFrm : Form
    {
        //Prilikom pokretanja pocetne forme instanciramo MQTT klasu i povezujemo se na brokera
        MqttClient Client = new MqttClient("broker.hivemq.com");

        public pocetnaFrm()
        {
            InitializeComponent();
        }

        private void pocetnaForma_Load(object sender, EventArgs e)
        {
            //Rucno podesavanje najnovije verzije protokola
            //Napomena: verziju protokola treba podesiti prije pozivanja Connect() metode
            Client.ProtocolVersion = MqttProtocolVersion.Version_3_1_1;
            //Uspostavljanje veze pomocu korisnickog imena i lozinke
            byte code = Client.Connect(Guid.NewGuid().ToString(), "antglesic", "rukdasik1");

            if(code == 0)
            {
                outputSpajanje.Text = "Spojeni ste";
                outputPretplata.Text = "pretplaceni ste na temu: nogomet";
            }
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            prijavaFrm prijava = new prijavaFrm();
            prijava.Show();
        }
    }
}
