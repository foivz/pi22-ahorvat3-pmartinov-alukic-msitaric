namespace BookfrizApp.Forms
{
    partial class Cjenik
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
            this.dgvCjenik = new System.Windows.Forms.DataGridView();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnRezervacija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCjenik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCjenik
            // 
            this.dgvCjenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCjenik.Location = new System.Drawing.Point(25, 26);
            this.dgvCjenik.Name = "dgvCjenik";
            this.dgvCjenik.RowHeadersWidth = 51;
            this.dgvCjenik.RowTemplate.Height = 24;
            this.dgvCjenik.Size = new System.Drawing.Size(542, 292);
            this.dgvCjenik.TabIndex = 0;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(353, 348);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(88, 37);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.Location = new System.Drawing.Point(460, 336);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(107, 61);
            this.btnRezervacija.TabIndex = 2;
            this.btnRezervacija.Text = "Odvedi me na rezervaciju";
            this.btnRezervacija.UseVisualStyleBackColor = true;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // Cjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 409);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dgvCjenik);
            this.Name = "Cjenik";
            this.Text = "Cjenik";
            this.Load += new System.EventHandler(this.Cjenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCjenik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCjenik;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnRezervacija;
    }
}