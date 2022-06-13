namespace BookfrizApp
{
    partial class MojeAkcijeForm
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
            this.dataGridViewMojeAkcije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDodajAkciju = new System.Windows.Forms.Button();
            this.buttonObrisiAkciju = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMojeAkcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMojeAkcije
            // 
            this.dataGridViewMojeAkcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMojeAkcije.Location = new System.Drawing.Point(31, 47);
            this.dataGridViewMojeAkcije.Name = "dataGridViewMojeAkcije";
            this.dataGridViewMojeAkcije.Size = new System.Drawing.Size(467, 220);
            this.dataGridViewMojeAkcije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moje akcije";
            // 
            // buttonDodajAkciju
            // 
            this.buttonDodajAkciju.Location = new System.Drawing.Point(416, 292);
            this.buttonDodajAkciju.Name = "buttonDodajAkciju";
            this.buttonDodajAkciju.Size = new System.Drawing.Size(82, 36);
            this.buttonDodajAkciju.TabIndex = 2;
            this.buttonDodajAkciju.Text = "Dodaj akciju";
            this.buttonDodajAkciju.UseVisualStyleBackColor = true;
            this.buttonDodajAkciju.Click += new System.EventHandler(this.buttonDodajAkciju_Click);
            // 
            // buttonObrisiAkciju
            // 
            this.buttonObrisiAkciju.Location = new System.Drawing.Point(308, 292);
            this.buttonObrisiAkciju.Name = "buttonObrisiAkciju";
            this.buttonObrisiAkciju.Size = new System.Drawing.Size(82, 36);
            this.buttonObrisiAkciju.TabIndex = 3;
            this.buttonObrisiAkciju.Text = "Obriši akciju";
            this.buttonObrisiAkciju.UseVisualStyleBackColor = true;
            this.buttonObrisiAkciju.Click += new System.EventHandler(this.buttonObrisiAkciju_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Matej\\Documents\\PI_Projekt\\Software\\BookfrizApp\\BookfrizApp\\Help\\pregled" +
    "akcija.htm";
            // 
            // MojeAkcijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 350);
            this.Controls.Add(this.buttonObrisiAkciju);
            this.Controls.Add(this.buttonDodajAkciju);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMojeAkcije);
            this.Name = "MojeAkcijeForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "MojeAkcijeForm";
            this.Load += new System.EventHandler(this.MojeAkcijeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMojeAkcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMojeAkcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodajAkciju;
        private System.Windows.Forms.Button buttonObrisiAkciju;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}