namespace BookfrizApp
{
    partial class DodajNovuAkcijuForm
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
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dateTimePickerDatumIsteka = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownCijena = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUsluga = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDodajAkciju = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(53, 23);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(320, 163);
            this.textBoxOpis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Opis";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 211);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Datum isteka";
            // 
            // dateTimePickerDatumIsteka
            // 
            this.dateTimePickerDatumIsteka.Location = new System.Drawing.Point(87, 211);
            this.dateTimePickerDatumIsteka.Name = "dateTimePickerDatumIsteka";
            this.dateTimePickerDatumIsteka.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerDatumIsteka.TabIndex = 3;
            // 
            // numericUpDownCijena
            // 
            this.numericUpDownCijena.Location = new System.Drawing.Point(96, 254);
            this.numericUpDownCijena.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCijena.Name = "numericUpDownCijena";
            this.numericUpDownCijena.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCijena.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Akcijska cijena";
            // 
            // comboBoxUsluga
            // 
            this.comboBoxUsluga.FormattingEnabled = true;
            this.comboBoxUsluga.Location = new System.Drawing.Point(96, 298);
            this.comboBoxUsluga.Name = "comboBoxUsluga";
            this.comboBoxUsluga.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsluga.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usluga";
            // 
            // buttonDodajAkciju
            // 
            this.buttonDodajAkciju.Location = new System.Drawing.Point(216, 342);
            this.buttonDodajAkciju.Name = "buttonDodajAkciju";
            this.buttonDodajAkciju.Size = new System.Drawing.Size(157, 37);
            this.buttonDodajAkciju.TabIndex = 8;
            this.buttonDodajAkciju.Text = "Dodaj akciju";
            this.buttonDodajAkciju.UseVisualStyleBackColor = true;
            this.buttonDodajAkciju.Click += new System.EventHandler(this.buttonDodajAkciju_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(15, 342);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(157, 37);
            this.buttonOdustani.TabIndex = 9;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // DodajNovuAkcijuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 406);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonDodajAkciju);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxUsluga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownCijena);
            this.Controls.Add(this.dateTimePickerDatumIsteka);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOpis);
            this.Name = "DodajNovuAkcijuForm";
            this.Text = "DodajNovuAkciju";
            this.Load += new System.EventHandler(this.DodajNovuAkcijuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumIsteka;
        private System.Windows.Forms.NumericUpDown numericUpDownCijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUsluga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDodajAkciju;
        private System.Windows.Forms.Button buttonOdustani;
    }
}