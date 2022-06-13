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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "POČETNA SALONA";
            // 
            // lblNazivSalona
            // 
            this.lblNazivSalona.AutoSize = true;
            this.lblNazivSalona.Location = new System.Drawing.Point(36, 98);
            this.lblNazivSalona.Name = "lblNazivSalona";
            this.lblNazivSalona.Size = new System.Drawing.Size(35, 13);
            this.lblNazivSalona.TabIndex = 2;
            this.lblNazivSalona.Text = "label2";
            // 
            // btnProfilSalona
            // 
            this.btnProfilSalona.Location = new System.Drawing.Point(39, 178);
            this.btnProfilSalona.Name = "btnProfilSalona";
            this.btnProfilSalona.Size = new System.Drawing.Size(75, 23);
            this.btnProfilSalona.TabIndex = 3;
            this.btnProfilSalona.Text = "Profil salona";
            this.btnProfilSalona.UseVisualStyleBackColor = true;
            this.btnProfilSalona.Click += new System.EventHandler(this.btnProfilSalona_Click);
            // 
            // FormPocetnaVlasnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProfilSalona);
            this.Controls.Add(this.lblNazivSalona);
            this.Controls.Add(this.label1);
            this.Name = "FormPocetnaVlasnika";
            this.Text = "Bookfriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNazivSalona;
        private System.Windows.Forms.Button btnProfilSalona;
    }
}