namespace RentACar
{
    partial class frmMusteriPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriPaneli));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_kiralamalar = new System.Windows.Forms.ToolStripButton();
            this.tsb_arac_ekle = new System.Windows.Forms.ToolStripButton();
            this.tsb_araclarim = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_kiralamalar,
            this.tsb_arac_ekle,
            this.tsb_araclarim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_kiralamalar
            // 
            this.tsb_kiralamalar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsb_kiralamalar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_kiralamalar.Image")));
            this.tsb_kiralamalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_kiralamalar.Name = "tsb_kiralamalar";
            this.tsb_kiralamalar.Size = new System.Drawing.Size(118, 34);
            this.tsb_kiralamalar.Text = "Kiralamalar";
            this.tsb_kiralamalar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsb_arac_ekle
            // 
            this.tsb_arac_ekle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsb_arac_ekle.Image = ((System.Drawing.Image)(resources.GetObject("tsb_arac_ekle.Image")));
            this.tsb_arac_ekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_arac_ekle.Name = "tsb_arac_ekle";
            this.tsb_arac_ekle.Size = new System.Drawing.Size(100, 34);
            this.tsb_arac_ekle.Text = "Araç Ekle";
            this.tsb_arac_ekle.Click += new System.EventHandler(this.tsb_arac_ekle_Click);
            // 
            // tsb_araclarim
            // 
            this.tsb_araclarim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsb_araclarim.Image = ((System.Drawing.Image)(resources.GetObject("tsb_araclarim.Image")));
            this.tsb_araclarim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_araclarim.Name = "tsb_araclarim";
            this.tsb_araclarim.Size = new System.Drawing.Size(104, 34);
            this.tsb_araclarim.Text = "Araçlarım";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(196, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "UBY RENT A CAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMusteriPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMusteriPaneli";
            this.Text = "Panel";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_kiralamalar;
        private System.Windows.Forms.ToolStripButton tsb_arac_ekle;
        private System.Windows.Forms.ToolStripButton tsb_araclarim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}