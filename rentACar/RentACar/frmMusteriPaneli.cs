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
    public partial class frmMusteriPaneli : Form
    {
        public string kid;
        public frmMusteriPaneli()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tsb_arac_ekle_Click(object sender, EventArgs e)
        {
            frmAracEkle frmAracEkle = new frmAracEkle();
            frmAracEkle.Show();
        }
    }
}
