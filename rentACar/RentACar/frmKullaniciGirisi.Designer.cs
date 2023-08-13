namespace RentACar
{
    partial class frmKullaniciGirisi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_giris = new System.Windows.Forms.Button();
            this.linklbl_kayit = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(131, 151);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // linklbl_kayit
            // 
            this.linklbl_kayit.AutoSize = true;
            this.linklbl_kayit.Location = new System.Drawing.Point(147, 187);
            this.linklbl_kayit.Name = "linklbl_kayit";
            this.linklbl_kayit.Size = new System.Drawing.Size(43, 13);
            this.linklbl_kayit.TabIndex = 1;
            this.linklbl_kayit.TabStop = true;
            this.linklbl_kayit.Text = "Kayıt Ol";
            this.linklbl_kayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_kayit_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC";
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(91, 62);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(161, 20);
            this.txt_TC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola";
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(91, 110);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(161, 20);
            this.txt_parola.TabIndex = 3;
            // 
            // frmKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 292);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linklbl_kayit);
            this.Controls.Add(this.btn_giris);
            this.Name = "frmKullaniciGirisi";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.LinkLabel linklbl_kayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_parola;
    }
}

