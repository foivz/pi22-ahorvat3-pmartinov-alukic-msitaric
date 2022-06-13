namespace BookfrizApp
{
    partial class RecenzijeForm
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
            this.dataGridViewRecenzije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUrediRecenziju = new System.Windows.Forms.Button();
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecenzije
            // 
            this.dataGridViewRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecenzije.Location = new System.Drawing.Point(58, 49);
            this.dataGridViewRecenzije.Name = "dataGridViewRecenzije";
            this.dataGridViewRecenzije.Size = new System.Drawing.Size(519, 225);
            this.dataGridViewRecenzije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moje recenzije";
            // 
            // buttonUrediRecenziju
            // 
            this.buttonUrediRecenziju.Location = new System.Drawing.Point(449, 291);
            this.buttonUrediRecenziju.Name = "buttonUrediRecenziju";
            this.buttonUrediRecenziju.Size = new System.Drawing.Size(128, 41);
            this.buttonUrediRecenziju.TabIndex = 2;
            this.buttonUrediRecenziju.Text = "Dodaj/uredi recenziju";
            this.buttonUrediRecenziju.UseVisualStyleBackColor = true;
            this.buttonUrediRecenziju.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Location = new System.Drawing.Point(58, 291);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(128, 41);
            this.buttonNatrag.TabIndex = 3;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.buttonNatrag_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Matej\\Documents\\PI_Projekt\\Software\\BookfrizApp\\BookfrizApp\\Help\\recenzi" +
    "je.htm";
            // 
            // RecenzijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 360);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.buttonUrediRecenziju);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRecenzije);
            this.Name = "RecenzijeForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "RecenzijeForm";
            this.Load += new System.EventHandler(this.RecenzijeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRecenzije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUrediRecenziju;
        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}