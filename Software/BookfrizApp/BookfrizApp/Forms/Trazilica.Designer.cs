namespace BookfrizApp.Forms
{
    partial class Trazilica
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.cmbUsluga = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.trackCijenaDo = new System.Windows.Forms.TrackBar();
            this.trackCijenaOd = new System.Windows.Forms.TrackBar();
            this.txtCijenaDo = new System.Windows.Forms.TextBox();
            this.txtCijenaOd = new System.Windows.Forms.TextBox();
            this.numOcjena = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackCijenaDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCijenaOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOcjena)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usluga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minimalna ocjena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cijena od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cijena do:";
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(75, 28);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(121, 24);
            this.cmbGrad.TabIndex = 5;
            // 
            // cmbUsluga
            // 
            this.cmbUsluga.FormattingEnabled = true;
            this.cmbUsluga.Location = new System.Drawing.Point(278, 28);
            this.cmbUsluga.Name = "cmbUsluga";
            this.cmbUsluga.Size = new System.Drawing.Size(121, 24);
            this.cmbUsluga.TabIndex = 6;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(464, 120);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 40);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click_1);
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(570, 120);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 40);
            this.btnTrazi.TabIndex = 11;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click_1);
            // 
            // trackCijenaDo
            // 
            this.trackCijenaDo.Location = new System.Drawing.Point(405, 58);
            this.trackCijenaDo.Maximum = 250;
            this.trackCijenaDo.Name = "trackCijenaDo";
            this.trackCijenaDo.Size = new System.Drawing.Size(240, 56);
            this.trackCijenaDo.TabIndex = 12;
            this.trackCijenaDo.Value = 250;
            this.trackCijenaDo.Scroll += new System.EventHandler(this.trackCijenaDo_Scroll);
            // 
            // trackCijenaOd
            // 
            this.trackCijenaOd.Location = new System.Drawing.Point(102, 58);
            this.trackCijenaOd.Maximum = 250;
            this.trackCijenaOd.Name = "trackCijenaOd";
            this.trackCijenaOd.Size = new System.Drawing.Size(219, 56);
            this.trackCijenaOd.TabIndex = 13;
            this.trackCijenaOd.Scroll += new System.EventHandler(this.trackCijenaOd_Scroll);
            // 
            // txtCijenaDo
            // 
            this.txtCijenaDo.Enabled = false;
            this.txtCijenaDo.Location = new System.Drawing.Point(506, 92);
            this.txtCijenaDo.Name = "txtCijenaDo";
            this.txtCijenaDo.Size = new System.Drawing.Size(46, 22);
            this.txtCijenaDo.TabIndex = 14;
            // 
            // txtCijenaOd
            // 
            this.txtCijenaOd.Enabled = false;
            this.txtCijenaOd.Location = new System.Drawing.Point(181, 92);
            this.txtCijenaOd.Name = "txtCijenaOd";
            this.txtCijenaOd.Size = new System.Drawing.Size(55, 22);
            this.txtCijenaOd.TabIndex = 15;
            // 
            // numOcjena
            // 
            this.numOcjena.Location = new System.Drawing.Point(545, 31);
            this.numOcjena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOcjena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOcjena.Name = "numOcjena";
            this.numOcjena.Size = new System.Drawing.Size(120, 22);
            this.numOcjena.TabIndex = 16;
            this.numOcjena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Trazilica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 183);
            this.Controls.Add(this.numOcjena);
            this.Controls.Add(this.txtCijenaOd);
            this.Controls.Add(this.txtCijenaDo);
            this.Controls.Add(this.trackCijenaOd);
            this.Controls.Add(this.trackCijenaDo);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cmbUsluga);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Trazilica";
            this.Text = "Trazilica";
            this.Load += new System.EventHandler(this.Trazilica_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.trackCijenaDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCijenaOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOcjena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.ComboBox cmbUsluga;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TrackBar trackCijenaDo;
        private System.Windows.Forms.TrackBar trackCijenaOd;
        private System.Windows.Forms.TextBox txtCijenaDo;
        private System.Windows.Forms.TextBox txtCijenaOd;
        private System.Windows.Forms.NumericUpDown numOcjena;
    }
}