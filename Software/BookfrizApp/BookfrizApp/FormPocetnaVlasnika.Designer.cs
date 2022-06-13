namespace BookfrizApp
{
    partial class FormPocetnaVlasnika
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNazivSalona = new System.Windows.Forms.Label();
            this.btnProfilSalona = new System.Windows.Forms.Button();
            this.buttonPostaviAkcije = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "POČETNA SALONA";
            // 
            // lblNazivSalona
            // 
            this.lblNazivSalona.AutoSize = true;
            this.lblNazivSalona.Location = new System.Drawing.Point(205, 42);
            this.lblNazivSalona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazivSalona.Name = "lblNazivSalona";
            this.lblNazivSalona.Size = new System.Drawing.Size(46, 17);
            this.lblNazivSalona.TabIndex = 2;
            this.lblNazivSalona.Text = "label2";
            // 
            // btnProfilSalona
            // 
            this.btnProfilSalona.Location = new System.Drawing.Point(52, 83);
            this.btnProfilSalona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfilSalona.Name = "btnProfilSalona";
            this.btnProfilSalona.Size = new System.Drawing.Size(121, 61);
            this.btnProfilSalona.TabIndex = 3;
            this.btnProfilSalona.Text = "Profil salona";
            this.btnProfilSalona.UseVisualStyleBackColor = true;
            this.btnProfilSalona.Click += new System.EventHandler(this.btnProfilSalona_Click);
            // 
            // buttonPostaviAkcije
            // 
            this.buttonPostaviAkcije.Location = new System.Drawing.Point(208, 83);
            this.buttonPostaviAkcije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPostaviAkcije.Name = "buttonPostaviAkcije";
            this.buttonPostaviAkcije.Size = new System.Drawing.Size(120, 61);
            this.buttonPostaviAkcije.TabIndex = 4;
            this.buttonPostaviAkcije.Text = "Postavi akcije";
            this.buttonPostaviAkcije.UseVisualStyleBackColor = true;
            this.buttonPostaviAkcije.Click += new System.EventHandler(this.buttonPostaviAkcije_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(306, 27);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(94, 47);
            this.btnOdjava.TabIndex = 5;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // FormPocetnaVlasnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 398);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.buttonPostaviAkcije);
            this.Controls.Add(this.btnProfilSalona);
            this.Controls.Add(this.lblNazivSalona);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPocetnaVlasnika";
            this.Text = "Bookfriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNazivSalona;
        private System.Windows.Forms.Button btnProfilSalona;
        private System.Windows.Forms.Button buttonPostaviAkcije;
        private System.Windows.Forms.Button btnOdjava;
    }
}