namespace MQTT_test_aplikacija_broj_1
{
    partial class prijavaFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prijavaFrm));
            this.inputKorIme = new System.Windows.Forms.TextBox();
            this.inputLozinka = new System.Windows.Forms.TextBox();
            this.btnSpajanje = new System.Windows.Forms.Button();
            this.btnIskljucivanje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputIpAdresa = new System.Windows.Forms.TextBox();
            this.btnRucno = new System.Windows.Forms.RadioButton();
            this.btnAuto = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputPretplate = new System.Windows.Forms.TextBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnPretplati = new System.Windows.Forms.Button();
            this.inputTema = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputTemaObjavi = new System.Windows.Forms.TextBox();
            this.btnObjavi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPoruka = new System.Windows.Forms.TextBox();
            this.outputPoruke = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputKorIme
            // 
            this.inputKorIme.Location = new System.Drawing.Point(28, 95);
            this.inputKorIme.Name = "inputKorIme";
            this.inputKorIme.Size = new System.Drawing.Size(156, 22);
            this.inputKorIme.TabIndex = 2;
            // 
            // inputLozinka
            // 
            this.inputLozinka.Location = new System.Drawing.Point(28, 150);
            this.inputLozinka.Name = "inputLozinka";
            this.inputLozinka.PasswordChar = '*';
            this.inputLozinka.Size = new System.Drawing.Size(156, 22);
            this.inputLozinka.TabIndex = 3;
            this.inputLozinka.UseSystemPasswordChar = true;
            // 
            // btnSpajanje
            // 
            this.btnSpajanje.Location = new System.Drawing.Point(28, 238);
            this.btnSpajanje.Name = "btnSpajanje";
            this.btnSpajanje.Size = new System.Drawing.Size(75, 29);
            this.btnSpajanje.TabIndex = 4;
            this.btnSpajanje.Text = "Poveži se";
            this.btnSpajanje.UseVisualStyleBackColor = true;
            this.btnSpajanje.Click += new System.EventHandler(this.btnSpajanje_Click);
            // 
            // btnIskljucivanje
            // 
            this.btnIskljucivanje.Location = new System.Drawing.Point(109, 238);
            this.btnIskljucivanje.Name = "btnIskljucivanje";
            this.btnIskljucivanje.Size = new System.Drawing.Size(75, 29);
            this.btnIskljucivanje.TabIndex = 5;
            this.btnIskljucivanje.Text = "Isključi vezu";
            this.btnIskljucivanje.UseVisualStyleBackColor = true;
            this.btnIskljucivanje.Click += new System.EventHandler(this.btnIskljucivanje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputIpAdresa);
            this.groupBox1.Controls.Add(this.btnRucno);
            this.groupBox1.Controls.Add(this.btnAuto);
            this.groupBox1.Controls.Add(this.btnSpajanje);
            this.groupBox1.Controls.Add(this.btnIskljucivanje);
            this.groupBox1.Controls.Add(this.inputLozinka);
            this.groupBox1.Controls.Add(this.inputKorIme);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 287);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Povezivanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lozinka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Korisničko ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP Adresa:";
            // 
            // inputIpAdresa
            // 
            this.inputIpAdresa.Location = new System.Drawing.Point(28, 40);
            this.inputIpAdresa.Name = "inputIpAdresa";
            this.inputIpAdresa.Size = new System.Drawing.Size(156, 22);
            this.inputIpAdresa.TabIndex = 7;
            this.inputIpAdresa.Text = "broker.hivemq.com";
            // 
            // btnRucno
            // 
            this.btnRucno.AutoSize = true;
            this.btnRucno.Location = new System.Drawing.Point(49, 213);
            this.btnRucno.Name = "btnRucno";
            this.btnRucno.Size = new System.Drawing.Size(58, 19);
            this.btnRucno.TabIndex = 9;
            this.btnRucno.TabStop = true;
            this.btnRucno.Text = "Ručno";
            this.btnRucno.UseVisualStyleBackColor = true;
            this.btnRucno.CheckedChanged += new System.EventHandler(this.btnRucno_CheckedChanged);
            // 
            // btnAuto
            // 
            this.btnAuto.AutoSize = true;
            this.btnAuto.Location = new System.Drawing.Point(49, 188);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(88, 19);
            this.btnAuto.TabIndex = 7;
            this.btnAuto.TabStop = true;
            this.btnAuto.Text = "Automatsko";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.CheckedChanged += new System.EventHandler(this.btnAuto_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.outputPretplate);
            this.groupBox2.Controls.Add(this.btnOdjava);
            this.groupBox2.Controls.Add(this.btnPretplati);
            this.groupBox2.Controls.Add(this.inputTema);
            this.groupBox2.Location = new System.Drawing.Point(246, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 287);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretplata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tema:";
            // 
            // outputPretplate
            // 
            this.outputPretplate.Enabled = false;
            this.outputPretplate.Location = new System.Drawing.Point(28, 108);
            this.outputPretplate.Multiline = true;
            this.outputPretplate.Name = "outputPretplate";
            this.outputPretplate.Size = new System.Drawing.Size(164, 159);
            this.outputPretplate.TabIndex = 3;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(113, 70);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(79, 26);
            this.btnOdjava.TabIndex = 2;
            this.btnOdjava.Text = "Odjavi";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnPretplati
            // 
            this.btnPretplati.Location = new System.Drawing.Point(28, 70);
            this.btnPretplati.Name = "btnPretplati";
            this.btnPretplati.Size = new System.Drawing.Size(79, 26);
            this.btnPretplati.TabIndex = 1;
            this.btnPretplati.Text = "Pretplati";
            this.btnPretplati.UseVisualStyleBackColor = true;
            this.btnPretplati.Click += new System.EventHandler(this.btnPretplati_Click);
            // 
            // inputTema
            // 
            this.inputTema.Location = new System.Drawing.Point(28, 40);
            this.inputTema.Name = "inputTema";
            this.inputTema.Size = new System.Drawing.Size(164, 22);
            this.inputTema.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.inputTemaObjavi);
            this.groupBox3.Controls.Add(this.btnObjavi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.inputPoruka);
            this.groupBox3.Controls.Add(this.outputPoruke);
            this.groupBox3.Location = new System.Drawing.Point(98, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 374);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Poruke";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tema:";
            // 
            // inputTemaObjavi
            // 
            this.inputTemaObjavi.Location = new System.Drawing.Point(10, 268);
            this.inputTemaObjavi.Name = "inputTemaObjavi";
            this.inputTemaObjavi.Size = new System.Drawing.Size(378, 22);
            this.inputTemaObjavi.TabIndex = 4;
            // 
            // btnObjavi
            // 
            this.btnObjavi.Location = new System.Drawing.Point(399, 323);
            this.btnObjavi.Name = "btnObjavi";
            this.btnObjavi.Size = new System.Drawing.Size(75, 22);
            this.btnObjavi.TabIndex = 3;
            this.btnObjavi.Text = "Pošalji";
            this.btnObjavi.UseVisualStyleBackColor = true;
            this.btnObjavi.Click += new System.EventHandler(this.btnObjavi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Poruka:";
            // 
            // inputPoruka
            // 
            this.inputPoruka.Location = new System.Drawing.Point(13, 323);
            this.inputPoruka.Name = "inputPoruka";
            this.inputPoruka.Size = new System.Drawing.Size(378, 22);
            this.inputPoruka.TabIndex = 1;
            // 
            // outputPoruke
            // 
            this.outputPoruke.Enabled = false;
            this.outputPoruke.Location = new System.Drawing.Point(13, 21);
            this.outputPoruke.Multiline = true;
            this.outputPoruke.Name = "outputPoruke";
            this.outputPoruke.Size = new System.Drawing.Size(461, 209);
            this.outputPoruke.TabIndex = 0;
            // 
            // prijavaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 694);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "prijavaFrm";
            this.Text = "MQTT Chat aplikacija";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.prijavaFrm_FormClosed);
            this.Load += new System.EventHandler(this.prijavaFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox inputKorIme;
        private System.Windows.Forms.TextBox inputLozinka;
        private System.Windows.Forms.Button btnSpajanje;
        private System.Windows.Forms.Button btnIskljucivanje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnRucno;
        private System.Windows.Forms.RadioButton btnAuto;
        private System.Windows.Forms.TextBox inputIpAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox outputPretplate;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnPretplati;
        private System.Windows.Forms.TextBox inputTema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnObjavi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputPoruka;
        private System.Windows.Forms.TextBox outputPoruke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputTemaObjavi;
    }
}