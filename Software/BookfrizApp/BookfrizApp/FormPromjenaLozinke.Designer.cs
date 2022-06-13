namespace BookfrizApp
{
    partial class FormPromjenaLozinke
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
            this.txtNovaLozinka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaraLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaziStaru = new System.Windows.Forms.Button();
            this.btnPrikaziNovu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(192, 170);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(38, 170);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Location = new System.Drawing.Point(167, 121);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtNovaLozinka.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Upišite novu lozinku:";
            // 
            // txtStaraLozinka
            // 
            this.txtStaraLozinka.Location = new System.Drawing.Point(167, 80);
            this.txtStaraLozinka.Name = "txtStaraLozinka";
            this.txtStaraLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtStaraLozinka.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Upišite staru lozinku:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PROMJENA LOZINKE";
            // 
            // btnPrikaziStaru
            // 
            this.btnPrikaziStaru.Location = new System.Drawing.Point(285, 78);
            this.btnPrikaziStaru.Name = "btnPrikaziStaru";
            this.btnPrikaziStaru.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaziStaru.TabIndex = 14;
            this.btnPrikaziStaru.Text = "Prikaži";
            this.btnPrikaziStaru.UseVisualStyleBackColor = true;
            this.btnPrikaziStaru.Click += new System.EventHandler(this.btnPrikaziStaru_Click);
            // 
            // btnPrikaziNovu
            // 
            this.btnPrikaziNovu.Location = new System.Drawing.Point(285, 118);
            this.btnPrikaziNovu.Name = "btnPrikaziNovu";
            this.btnPrikaziNovu.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaziNovu.TabIndex = 15;
            this.btnPrikaziNovu.Text = "Prikaži";
            this.btnPrikaziNovu.UseVisualStyleBackColor = true;
            this.btnPrikaziNovu.Click += new System.EventHandler(this.btnPrikaziNovu_Click);
            // 
            // FormPromjenaLozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 237);
            this.Controls.Add(this.btnPrikaziNovu);
            this.Controls.Add(this.btnPrikaziStaru);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtNovaLozinka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStaraLozinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPromjenaLozinke";
            this.Text = "Bookfriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtNovaLozinka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaraLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikaziStaru;
        private System.Windows.Forms.Button btnPrikaziNovu;
    }
}