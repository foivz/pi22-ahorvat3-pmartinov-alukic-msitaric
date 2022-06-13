namespace BookfrizApp
{
    partial class FormPocetnaKlijenta
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblImeKlijenta = new System.Windows.Forms.Label();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnTrazilica = new System.Windows.Forms.Button();
            this.btnPopisSalona = new System.Windows.Forms.Button();
            this.btnObavijesti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "POČETNA KLIJENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dobrodošao,";
            // 
            // lblImeKlijenta
            // 
            this.lblImeKlijenta.AutoSize = true;
            this.lblImeKlijenta.Location = new System.Drawing.Point(107, 65);
            this.lblImeKlijenta.Name = "lblImeKlijenta";
            this.lblImeKlijenta.Size = new System.Drawing.Size(35, 13);
            this.lblImeKlijenta.TabIndex = 2;
            this.lblImeKlijenta.Text = "label3";
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(184, 28);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(77, 41);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "Moj profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnTrazilica
            // 
            this.btnTrazilica.Location = new System.Drawing.Point(278, 28);
            this.btnTrazilica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrazilica.Name = "btnTrazilica";
            this.btnTrazilica.Size = new System.Drawing.Size(76, 41);
            this.btnTrazilica.TabIndex = 4;
            this.btnTrazilica.Text = "Tražilica salona";
            this.btnTrazilica.UseVisualStyleBackColor = true;
            this.btnTrazilica.Click += new System.EventHandler(this.btnTrazilica_Click);
            // 
            // btnPopisSalona
            // 
            this.btnPopisSalona.Location = new System.Drawing.Point(184, 84);
            this.btnPopisSalona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPopisSalona.Name = "btnPopisSalona";
            this.btnPopisSalona.Size = new System.Drawing.Size(77, 41);
            this.btnPopisSalona.TabIndex = 5;
            this.btnPopisSalona.Text = "Popis salona u blizini";
            this.btnPopisSalona.UseVisualStyleBackColor = true;
            this.btnPopisSalona.Click += new System.EventHandler(this.btnPopisSalona_Click);
            // 
            // btnObavijesti
            // 
            this.btnObavijesti.Location = new System.Drawing.Point(277, 84);
            this.btnObavijesti.Margin = new System.Windows.Forms.Padding(2);
            this.btnObavijesti.Name = "btnObavijesti";
            this.btnObavijesti.Size = new System.Drawing.Size(77, 41);
            this.btnObavijesti.TabIndex = 6;
            this.btnObavijesti.Text = "Obavijesti";
            this.btnObavijesti.UseVisualStyleBackColor = true;
            this.btnObavijesti.Click += new System.EventHandler(this.btnObavijesti_Click_1);
            // 
            // FormPocetnaKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 271);
            this.Controls.Add(this.btnObavijesti);
            this.Controls.Add(this.btnPopisSalona);
            this.Controls.Add(this.btnTrazilica);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.lblImeKlijenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPocetnaKlijenta";
            this.Text = "Bookfriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImeKlijenta;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnTrazilica;
        private System.Windows.Forms.Button btnPopisSalona;
        private System.Windows.Forms.Button btnObavijesti;
    }
}