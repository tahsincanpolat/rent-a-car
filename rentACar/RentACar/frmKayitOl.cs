using RentACar.ORM.Context;
using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmKayitOl : Form
    {
        ProjectContext db = new ProjectContext();
        public frmKayitOl()
        {
            InitializeComponent();
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            List<Yoneticiler> mst = new List<Yoneticiler>();
            mst = db.Yoneticilers.ToList();
            bool kullaniciVar = false;
            foreach (var yonetici in mst)
            {
                if(yonetici.TC == txt_tc.Text)
                {
                    kullaniciVar = true;
                }
            }

            if (kullaniciVar)
            {
                MessageBox.Show("Yönetici sistemde mevcut. Başka bir TC giriniz.");
            }
            else
            {
                Yoneticiler yoneticiler = new Yoneticiler()
                {
                    Adi = txt_ad.Text,
                    Soyadi = txt_soyad.Text,
                    EhliyetNo = txt_ehliyetno.Text,
                    TC = txt_tc.Text,
                    Sifre = txt_sifre.Text,
                    Adres = txt_adres.Text,
                    Email = txt_email.Text,
                    Telefon = txt_telefon.Text
                };

                db.Yoneticilers.Add(yoneticiler); // ORM 
                db.SaveChanges();
                MessageBox.Show("Kaydınız başarıyla oluşturuldu.");
                this.Hide();
                frmKullaniciGirisi frmKullaniciGirisi = new frmKullaniciGirisi();
                frmKullaniciGirisi.Show();
            }
        }
    }
}
