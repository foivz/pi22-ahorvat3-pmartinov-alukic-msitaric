namespace BookfrizApp
{
    partial class AkcijeForm
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
            this.dataGridViewAkcije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFiltrirajAkcije = new System.Windows.Forms.Button();
            this.comboBoxSaloni = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUsluge = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAkcije
            // 
            this.dataGridViewAkcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkcije.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewAkcije.Name = "dataGridViewAkcije";
            this.dataGridViewAkcije.Size = new System.Drawing.Size(591, 150);
            this.dataGridViewAkcije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Akcije";
            // 
            // buttonFiltrirajAkcije
            // 
            this.buttonFiltrirajAkcije.Location = new System.Drawing.Point(517, 207);
            this.buttonFiltrirajAkcije.Name = "buttonFiltrirajAkcije";
            this.buttonFiltrirajAkcije.Size = new System.Drawing.Size(86, 45);
            this.buttonFiltrirajAkcije.TabIndex = 2;
            this.buttonFiltrirajAkcije.Text = "Filtriraj";
            this.buttonFiltrirajAkcije.UseVisualStyleBackColor = true;
            this.buttonFiltrirajAkcije.Click += new System.EventHandler(this.buttonFiltrirajAkcije_Click);
            // 
            // comboBoxSaloni
            // 
            this.comboBoxSaloni.FormattingEnabled = true;
            this.comboBoxSaloni.Location = new System.Drawing.Point(85, 220);
            this.comboBoxSaloni.Name = "comboBoxSaloni";
            this.comboBoxSaloni.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSaloni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usluga";
            // 
            // comboBoxUsluge
            // 
            this.comboBoxUsluge.FormattingEnabled = true;
            this.comboBoxUsluge.Location = new System.Drawing.Point(275, 220);
            this.comboBoxUsluge.Name = "comboBoxUsluge";
            this.comboBoxUsluge.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsluge.TabIndex = 5;
            // 
            // AkcijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxUsluge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSaloni);
            this.Controls.Add(this.buttonFiltrirajAkcije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAkcije);
            this.Name = "AkcijeForm";
            this.Text = "AkcijeForm";
            this.Load += new System.EventHandler(this.AkcijeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAkcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFiltrirajAkcije;
        private System.Windows.Forms.ComboBox comboBoxSaloni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUsluge;
    }
}