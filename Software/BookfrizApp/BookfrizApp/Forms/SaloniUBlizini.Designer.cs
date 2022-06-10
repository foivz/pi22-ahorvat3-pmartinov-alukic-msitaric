namespace BookfrizApp.Forms
{
    partial class SaloniUBlizini
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
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnOsvježi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapa
            // 
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = false;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemory = 5;
            this.mapa.Location = new System.Drawing.Point(162, 12);
            this.mapa.MarkersEnabled = true;
            this.mapa.MaxZoom = 2;
            this.mapa.MinZoom = 2;
            this.mapa.MouseWheelZoomEnabled = true;
            this.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapa.Name = "mapa";
            this.mapa.NegativeMode = false;
            this.mapa.PolygonsEnabled = true;
            this.mapa.RetryLoadTile = 0;
            this.mapa.RoutesEnabled = true;
            this.mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapa.ShowTileGridLines = false;
            this.mapa.Size = new System.Drawing.Size(682, 454);
            this.mapa.TabIndex = 0;
            this.mapa.Zoom = 0D;
            this.mapa.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.mapa_OnMarkerClick);
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(15, 87);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(100, 22);
            this.txtUlica.TabIndex = 1;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(15, 155);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(100, 22);
            this.txtGrad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ulica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Molimo unesite adresu";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(22, 200);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 54);
            this.btnTrazi.TabIndex = 6;
            this.btnTrazi.Text = "Prikaži na mapi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTraži_Click);
            // 
            // btnOsvježi
            // 
            this.btnOsvježi.Location = new System.Drawing.Point(22, 260);
            this.btnOsvježi.Name = "btnOsvježi";
            this.btnOsvježi.Size = new System.Drawing.Size(75, 48);
            this.btnOsvježi.TabIndex = 7;
            this.btnOsvježi.Text = "Osvježi mapu";
            this.btnOsvježi.UseVisualStyleBackColor = true;
            this.btnOsvježi.Click += new System.EventHandler(this.btnOsvježi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pritisnite na salon ako ga želite otvoriti";
            // 
            // SaloniUBlizini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 478);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOsvježi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.mapa);
            this.Name = "SaloniUBlizini";
            this.Text = "Saloni u blizini";
            this.Load += new System.EventHandler(this.SaloniUBlizini_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapa;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnOsvježi;
        private System.Windows.Forms.Label label4;
    }
}