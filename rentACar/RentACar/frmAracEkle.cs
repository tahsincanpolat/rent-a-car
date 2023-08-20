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
    public partial class frmAracEkle : Form
    {
        ProjectContext db = new ProjectContext();
        public frmAracEkle()
        {
            InitializeComponent();
        }

        private void btn_arac_ekle_Click(object sender, EventArgs e)
        {
            string base64;

            using (Image image = arabaResim.Image.Clone() as Image)
            {
                base64 = ConvertImageToBase64(image);
            }

            Arabalar arabalar = new Arabalar()
            {
                Plaka = txt_plaka.Text,
                Marka = txt_marka.Text,
                Model = txt_model.Text,
                AracTipi = cmb_arac_tipi.Text,
                Vites = cmb_vites.Text,
                YakitTipi = cmb_yakit_tipi.Text,
                ImageUrl = base64,
                Fiyat = Convert.ToDouble(txt_fiyat.Text),
                AktifMi = false
            };

            db.Arabalars.Add(arabalar);
            db.SaveChanges();
            MessageBox.Show("Araba Başarıyla Eklendi");
        }

        public string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        private void btn_resim_yukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp) | *.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp";
            if(open.ShowDialog() == DialogResult.OK)
            {
                arabaResim.Image = new Bitmap(open.FileName);
                fileName.Text = open.FileName;
            }
        }
    }
}
