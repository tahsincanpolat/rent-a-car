using RentACar.ORM.Context;
using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmAracDetayVeKirala : Form
    {
        ProjectContext db = new ProjectContext();
        public string kid;
        public int id;
        public int gun;
        public string imageBase64;
        public frmAracDetayVeKirala()
        {
            InitializeComponent();
        }

        private void frmAracDetayVeKirala_Load(object sender, EventArgs e)
        {
            List<Arabalar> arabalars = new List<Arabalar>();
            arabalars = db.Arabalars.Where(a => a.ID == id).ToList();

            foreach (Arabalar araba in arabalars)
            {
                lbl_aracTipi.Text = araba.AracTipi;
                lbl_gunluk_fiyat.Text = araba.Fiyat.ToString();
                lbl_marka.Text = araba.Marka;
                lbl_model.Text = araba.Model;
                lbl_plaka.Text = araba.Plaka;
                lbl_vites.Text = araba.Vites;
                lbl_yakit_tipi.Text = araba.YakitTipi;
                arabaResim.Image = ConvertBase64ToImage(araba.ImageUrl);
            }
        }

        private void dtp_alis_tarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslim_tarihi.Enabled = true;
        }

        private void dtp_teslim_tarihi_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan GunFarki = dtp_teslim_tarihi.Value.Subtract(dtp_alis_tarihi.Value);

            gun = GunFarki.Days;

            if (gun <= 0)
            {
                MessageBox.Show("Lütfen Teslim tarihini alış tarihinden daha ileride bir gün seçiniz");
            }
            else
            {
                double faturaTutari = gun * Convert.ToDouble(lbl_gunluk_fiyat.Text);
                lbl_fatura_tutari.Text = faturaTutari.ToString();
            }
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            if (gun > 0)
            {
                Arabalar arabaVarMi = db.Arabalars.Where(a => a.ID == id && a.AktifMi == true).FirstOrDefault();
                Arabalar arabalar = db.Arabalars.Where(a => a.ID == id).FirstOrDefault();

                if(arabaVarMi != null)
                {
                    MessageBox.Show("Seçtiğiniz araba şuanda kiralık durumda");
                }
                else
                {
                    Kiralama kiralama = new Kiralama
                    {
                        ArabaID = id,
                        YoneticiID = kid,
                        AlisTarihi = dtp_alis_tarihi.Value,
                        TeslimTarihi = dtp_teslim_tarihi.Value,
                        KiralamaSuresi = gun,
                        FaturaTutari = Convert.ToDouble(lbl_fatura_tutari.Text),
                        AktifMi = false
                    };

                    arabalar.AktifMi = true;
                    db.Kiralamas.Add(kiralama);
                    db.SaveChanges();
                    MessageBox.Show("Araç Kiralandı");
                    this.Hide();


                }
            }
            else
            {
                MessageBox.Show("Lütfen Teslim tarihini alış tarihinden daha ileride bir gün seçiniz");
            }
        }

        public Image ConvertBase64ToImage(string base64String)
        {
            if(base64String != "")
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    return Image.FromStream(ms, true);
                }
            }

            return null;
           
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
