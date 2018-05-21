namespace MQTT_test_aplikacija_broj_1
{
    partial class pocetnaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pocetnaFrm));
            this.outputSpajanje = new System.Windows.Forms.TextBox();
            this.outputPretplata = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputSpajanje
            // 
            this.outputSpajanje.Enabled = false;
            this.outputSpajanje.Location = new System.Drawing.Point(12, 14);
            this.outputSpajanje.Name = "outputSpajanje";
            this.outputSpajanje.Size = new System.Drawing.Size(181, 22);
            this.outputSpajanje.TabIndex = 0;
            // 
            // outputPretplata
            // 
            this.outputPretplata.Enabled = false;
            this.outputPretplata.Location = new System.Drawing.Point(12, 44);
            this.outputPretplata.Name = "outputPretplata";
            this.outputPretplata.Size = new System.Drawing.Size(181, 22);
            this.outputPretplata.TabIndex = 1;
            // 
            // btnPrijava
            // 
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrijava.Location = new System.Drawing.Point(12, 72);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(149, 60);
            this.btnPrijava.TabIndex = 2;
            this.btnPrijava.Text = "PRIJAVA";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // pocetnaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 470);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.outputPretplata);
            this.Controls.Add(this.outputSpajanje);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "pocetnaFrm";
            this.Text = "MQTT Chat aplikacija";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pocetnaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputSpajanje;
        private System.Windows.Forms.TextBox outputPretplata;
        private System.Windows.Forms.Button btnPrijava;
    }
}

