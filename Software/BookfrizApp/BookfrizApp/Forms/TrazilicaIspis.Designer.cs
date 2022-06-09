namespace BookfrizApp.Forms
{
    partial class TrazilicaIspis
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
            this.dgvTrazilica = new System.Windows.Forms.DataGridView();
            this.btnCjenik = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrazilica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrazilica
            // 
            this.dgvTrazilica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrazilica.Location = new System.Drawing.Point(25, 12);
            this.dgvTrazilica.Name = "dgvTrazilica";
            this.dgvTrazilica.RowHeadersWidth = 51;
            this.dgvTrazilica.RowTemplate.Height = 24;
            this.dgvTrazilica.Size = new System.Drawing.Size(934, 393);
            this.dgvTrazilica.TabIndex = 0;
            // 
            // btnCjenik
            // 
            this.btnCjenik.Location = new System.Drawing.Point(832, 416);
            this.btnCjenik.Name = "btnCjenik";
            this.btnCjenik.Size = new System.Drawing.Size(127, 51);
            this.btnCjenik.TabIndex = 1;
            this.btnCjenik.Text = "Prikaži Cjenik na osnovu tražilice";
            this.btnCjenik.UseVisualStyleBackColor = true;
            this.btnCjenik.Click += new System.EventHandler(this.btnCjenik_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(725, 422);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(82, 39);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // TrazilicaIspis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 474);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnCjenik);
            this.Controls.Add(this.dgvTrazilica);
            this.Name = "TrazilicaIspis";
            this.Text = "Ispis tražilice";
            this.Load += new System.EventHandler(this.TrazilicaIspis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrazilica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrazilica;
        private System.Windows.Forms.Button btnCjenik;
        private System.Windows.Forms.Button btnOdustani;
    }
}