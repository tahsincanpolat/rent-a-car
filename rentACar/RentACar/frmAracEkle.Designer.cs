namespace RentACar
{
    partial class frmAracEkle
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
            this.arabaResim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_arac_tipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_vites = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_yakit_tipi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.btn_resim_yukle = new System.Windows.Forms.Button();
            this.btn_arac_ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arabaResim)).BeginInit();
            this.SuspendLayout();
            // 
            // arabaResim
            // 
            this.arabaResim.Location = new System.Drawing.Point(12, 13);
            this.arabaResim.Name = "arabaResim";
            this.arabaResim.Size = new System.Drawing.Size(252, 208);
            this.arabaResim.TabIndex = 0;
            this.arabaResim.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka";
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(296, 30);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(151, 20);
            this.txt_plaka.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka";
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(509, 30);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(151, 20);
            this.txt_marka.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model";
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(296, 91);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(151, 20);
            this.txt_model.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Araç Tipi";
            // 
            // cmb_arac_tipi
            // 
            this.cmb_arac_tipi.FormattingEnabled = true;
            this.cmb_arac_tipi.Items.AddRange(new object[] {
            "Hatchback",
            "Suv",
            "Sedan"});
            this.cmb_arac_tipi.Location = new System.Drawing.Point(509, 91);
            this.cmb_arac_tipi.Name = "cmb_arac_tipi";
            this.cmb_arac_tipi.Size = new System.Drawing.Size(151, 21);
            this.cmb_arac_tipi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vites";
            // 
            // cmb_vites
            // 
            this.cmb_vites.FormattingEnabled = true;
            this.cmb_vites.Items.AddRange(new object[] {
            "Düz",
            "Otomatik",
            "Yarı Otomatik"});
            this.cmb_vites.Location = new System.Drawing.Point(296, 147);
            this.cmb_vites.Name = "cmb_vites";
            this.cmb_vites.Size = new System.Drawing.Size(151, 21);
            this.cmb_vites.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yakıt Tipi";
            // 
            // cmb_yakit_tipi
            // 
            this.cmb_yakit_tipi.FormattingEnabled = true;
            this.cmb_yakit_tipi.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Lpg",
            "Elektrikli"});
            this.cmb_yakit_tipi.Location = new System.Drawing.Point(509, 147);
            this.cmb_yakit_tipi.Name = "cmb_yakit_tipi";
            this.cmb_yakit_tipi.Size = new System.Drawing.Size(151, 21);
            this.cmb_yakit_tipi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Günlük Fiysat";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(296, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Günlük Fiyat";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(296, 200);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(151, 20);
            this.txt_fiyat.TabIndex = 2;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(509, 200);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(151, 20);
            this.fileName.TabIndex = 2;
            // 
            // btn_resim_yukle
            // 
            this.btn_resim_yukle.Location = new System.Drawing.Point(666, 199);
            this.btn_resim_yukle.Name = "btn_resim_yukle";
            this.btn_resim_yukle.Size = new System.Drawing.Size(110, 21);
            this.btn_resim_yukle.TabIndex = 4;
            this.btn_resim_yukle.Text = "Resim Yükle";
            this.btn_resim_yukle.UseVisualStyleBackColor = true;
            // 
            // btn_arac_ekle
            // 
            this.btn_arac_ekle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_arac_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arac_ekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_arac_ekle.Location = new System.Drawing.Point(12, 255);
            this.btn_arac_ekle.Name = "btn_arac_ekle";
            this.btn_arac_ekle.Size = new System.Drawing.Size(764, 77);
            this.btn_arac_ekle.TabIndex = 5;
            this.btn_arac_ekle.Text = "Araç Ekle";
            this.btn_arac_ekle.UseVisualStyleBackColor = false;
            this.btn_arac_ekle.Click += new System.EventHandler(this.btn_arac_ekle_Click);
            // 
            // frmAracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.btn_arac_ekle);
            this.Controls.Add(this.btn_resim_yukle);
            this.Controls.Add(this.cmb_yakit_tipi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_vites);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_arac_tipi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_marka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_plaka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arabaResim);
            this.Name = "frmAracEkle";
            this.Text = "Araç Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.arabaResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arabaResim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_plaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_arac_tipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_vites;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_yakit_tipi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button btn_resim_yukle;
        private System.Windows.Forms.Button btn_arac_ekle;
    }
}