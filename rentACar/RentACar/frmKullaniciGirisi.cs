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
    public partial class frmKullaniciGirisi : Form
    {
        ProjectContext db = new ProjectContext();
        string TC = "";
        string sifre = "";
        int id;
        public frmKullaniciGirisi()
        {
            InitializeComponent();
        }


        private void linklbl_kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmKayitOl frmKayitOl = new frmKayitOl();
            frmKayitOl.Show();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            List<Yoneticiler> mst = new List<Yoneticiler>();
            mst = db.Yoneticilers.Where(x => x.TC == txt_TC.Text).ToList();

            foreach (Yoneticiler yonetici in mst)
            {
                TC = yonetici.TC.ToString();
                sifre = yonetici.Sifre.ToString();
                id = yonetici.ID;
            }

            if(TC == txt_TC.Text)
            {
                if(sifre == txt_parola.Text)
                {
                    this.Hide();
                    // Paneli açacağız. Ve panele giriş yapan kullanıcı idsini yolluycaz.
                    frmMusteriPaneli frmMusteriPaneli = new frmMusteriPaneli();
                    frmMusteriPaneli.kid = id.ToString();
                    frmMusteriPaneli.Show();
                }
                else
                {
                    MessageBox.Show("Şifreniz Yanlış!");
                }
            }
            else
            {
                MessageBox.Show("TC Kimlik numarası sistemde mevcut değil!");
            }
        }
    }
}
