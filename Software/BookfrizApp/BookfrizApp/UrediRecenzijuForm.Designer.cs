namespace BookfrizApp
{
    partial class UrediRecenzijuForm
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
            this.textBoxSalon = new System.Windows.Forms.TextBox();
            this.numericUpDownOcjena = new System.Windows.Forms.NumericUpDown();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.buttonUredi = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcjena)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocjena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salon";
            // 
            // textBoxSalon
            // 
            this.textBoxSalon.Enabled = false;
            this.textBoxSalon.Location = new System.Drawing.Point(39, 43);
            this.textBoxSalon.Name = "textBoxSalon";
            this.textBoxSalon.Size = new System.Drawing.Size(136, 20);
            this.textBoxSalon.TabIndex = 3;
            // 
            // numericUpDownOcjena
            // 
            this.numericUpDownOcjena.Location = new System.Drawing.Point(137, 77);
            this.numericUpDownOcjena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownOcjena.Name = "numericUpDownOcjena";
            this.numericUpDownOcjena.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownOcjena.TabIndex = 4;
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(45, 142);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(265, 148);
            this.textBoxOpis.TabIndex = 5;
            // 
            // buttonUredi
            // 
            this.buttonUredi.Location = new System.Drawing.Point(215, 307);
            this.buttonUredi.Name = "buttonUredi";
            this.buttonUredi.Size = new System.Drawing.Size(95, 53);
            this.buttonUredi.TabIndex = 6;
            this.buttonUredi.Text = "Završi uređivanje";
            this.buttonUredi.UseVisualStyleBackColor = true;
            this.buttonUredi.Click += new System.EventHandler(this.buttonUredi_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(45, 307);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(95, 53);
            this.buttonOdustani.TabIndex = 7;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // UrediRecenzijuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 388);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonUredi);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.numericUpDownOcjena);
            this.Controls.Add(this.textBoxSalon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrediRecenzijuForm";
            this.Text = "UrediRecenzijuForm";
            this.Load += new System.EventHandler(this.UrediRecenzijuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcjena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSalon;
        private System.Windows.Forms.NumericUpDown numericUpDownOcjena;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Button buttonUredi;
        private System.Windows.Forms.Button buttonOdustani;
    }
}