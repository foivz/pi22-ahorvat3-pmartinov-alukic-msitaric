namespace BookfrizApp
{
    partial class FormObavijestiKlijenta
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cbBezObavijesti = new System.Windows.Forms.CheckBox();
            this.cbObavijestiJedanSatPrije = new System.Windows.Forms.CheckBox();
            this.cbObavijestiJedanDanPrije = new System.Windows.Forms.CheckBox();
            this.cbSveObavijesti = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(120, 230);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(77, 23);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(37, 230);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(77, 23);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // cbBezObavijesti
            // 
            this.cbBezObavijesti.AutoSize = true;
            this.cbBezObavijesti.Location = new System.Drawing.Point(37, 183);
            this.cbBezObavijesti.Name = "cbBezObavijesti";
            this.cbBezObavijesti.Size = new System.Drawing.Size(91, 17);
            this.cbBezObavijesti.TabIndex = 11;
            this.cbBezObavijesti.Text = "Bez obavijesti";
            this.cbBezObavijesti.UseVisualStyleBackColor = true;
            // 
            // cbObavijestiJedanSatPrije
            // 
            this.cbObavijestiJedanSatPrije.AutoSize = true;
            this.cbObavijestiJedanSatPrije.Location = new System.Drawing.Point(37, 146);
            this.cbObavijestiJedanSatPrije.Name = "cbObavijestiJedanSatPrije";
            this.cbObavijestiJedanSatPrije.Size = new System.Drawing.Size(111, 17);
            this.cbObavijestiJedanSatPrije.TabIndex = 10;
            this.cbObavijestiJedanSatPrije.Text = "Obavijesti sat prije";
            this.cbObavijestiJedanSatPrije.UseVisualStyleBackColor = true;
            // 
            // cbObavijestiJedanDanPrije
            // 
            this.cbObavijestiJedanDanPrije.AutoSize = true;
            this.cbObavijestiJedanDanPrije.Location = new System.Drawing.Point(37, 110);
            this.cbObavijestiJedanDanPrije.Name = "cbObavijestiJedanDanPrije";
            this.cbObavijestiJedanDanPrije.Size = new System.Drawing.Size(115, 17);
            this.cbObavijestiJedanDanPrije.TabIndex = 9;
            this.cbObavijestiJedanDanPrije.Text = "Obavijesti dan prije";
            this.cbObavijestiJedanDanPrije.UseVisualStyleBackColor = true;
            // 
            // cbSveObavijesti
            // 
            this.cbSveObavijesti.AutoSize = true;
            this.cbSveObavijesti.Location = new System.Drawing.Point(37, 78);
            this.cbSveObavijesti.Name = "cbSveObavijesti";
            this.cbSveObavijesti.Size = new System.Drawing.Size(92, 17);
            this.cbSveObavijesti.TabIndex = 8;
            this.cbSveObavijesti.Text = "Sve obavijesti";
            this.cbSveObavijesti.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "OBAVIJESTI";
            // 
            // FormObavijestiKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 316);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cbBezObavijesti);
            this.Controls.Add(this.cbObavijestiJedanSatPrije);
            this.Controls.Add(this.cbObavijestiJedanDanPrije);
            this.Controls.Add(this.cbSveObavijesti);
            this.Controls.Add(this.label1);
            this.Name = "FormObavijestiKlijenta";
            this.Text = "Bookfriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.CheckBox cbBezObavijesti;
        private System.Windows.Forms.CheckBox cbObavijestiJedanSatPrije;
        private System.Windows.Forms.CheckBox cbObavijestiJedanDanPrije;
        private System.Windows.Forms.CheckBox cbSveObavijesti;
        private System.Windows.Forms.Label label1;
    }
}