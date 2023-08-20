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
            }
        }
    }
}
