namespace BookfrizApp
{
    partial class FormPrijava
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "PRIJAVA";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(29, 154);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 25;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(162, 206);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(75, 23);
            this.btnRegistracija.TabIndex = 24;
            this.btnRegistracija.Text = "Registriraj se";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Location = new System.Drawing.Point(29, 211);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(127, 13);
            this.lblRegistracija.TabIndex = 23;
            this.lblRegistracija.Text = "Nemate korisnički račun?";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(162, 154);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 22;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(127, 108);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(110, 20);
            this.txtLozinka.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lozinka:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(127, 68);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(110, 20);
            this.txtKorisnickoIme.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Korisničko ime:";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(255, 105);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 27;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label1);
            this.Name = "FormPrijava";
            this.Text = "Bookfriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
    }
}