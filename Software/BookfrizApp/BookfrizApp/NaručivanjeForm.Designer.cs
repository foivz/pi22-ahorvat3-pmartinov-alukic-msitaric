namespace BookfrizApp
{
    partial class NaručivanjeForm
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
            this.comboBoxSaloni = new System.Windows.Forms.ComboBox();
            this.comboBoxUsluge = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRezerviraj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSati = new System.Windows.Forms.NumericUpDown();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usluga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum";
            // 
            // comboBoxSaloni
            // 
            this.comboBoxSaloni.FormattingEnabled = true;
            this.comboBoxSaloni.Location = new System.Drawing.Point(119, 21);
            this.comboBoxSaloni.Name = "comboBoxSaloni";
            this.comboBoxSaloni.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSaloni.TabIndex = 3;
            // 
            // comboBoxUsluge
            // 
            this.comboBoxUsluge.FormattingEnabled = true;
            this.comboBoxUsluge.Location = new System.Drawing.Point(299, 21);
            this.comboBoxUsluge.Name = "comboBoxUsluge";
            this.comboBoxUsluge.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsluge.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(481, 21);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 233);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonRezerviraj
            // 
            this.buttonRezerviraj.Location = new System.Drawing.Point(481, 339);
            this.buttonRezerviraj.Name = "buttonRezerviraj";
            this.buttonRezerviraj.Size = new System.Drawing.Size(132, 40);
            this.buttonRezerviraj.TabIndex = 7;
            this.buttonRezerviraj.Text = "Rezerviraj termin";
            this.buttonRezerviraj.UseVisualStyleBackColor = true;
            this.buttonRezerviraj.Click += new System.EventHandler(this.buttonRezerviraj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vrijeme (u koliko sati)";
            // 
            // numericUpDownSati
            // 
            this.numericUpDownSati.Location = new System.Drawing.Point(481, 54);
            this.numericUpDownSati.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSati.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownSati.Name = "numericUpDownSati";
            this.numericUpDownSati.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownSati.TabIndex = 9;
            this.numericUpDownSati.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.Location = new System.Drawing.Point(633, 21);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(79, 53);
            this.buttonFiltriraj.TabIndex = 10;
            this.buttonFiltriraj.Text = "Pretraži termine";
            this.buttonFiltriraj.UseVisualStyleBackColor = true;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // Naručivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 395);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.numericUpDownSati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRezerviraj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxUsluge);
            this.Controls.Add(this.comboBoxSaloni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Naručivanje";
            this.Text = "Naručivanje";
            this.Load += new System.EventHandler(this.Naručivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSaloni;
        private System.Windows.Forms.ComboBox comboBoxUsluge;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRezerviraj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSati;
        private System.Windows.Forms.Button buttonFiltriraj;
    }
}