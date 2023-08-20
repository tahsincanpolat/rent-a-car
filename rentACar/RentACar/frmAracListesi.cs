using RentACar.ORM.Context;
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
    public partial class frmAracListesi : Form
    {
        public string kid;
        public int id;
        public string imageBase64;
        ProjectContext db = new ProjectContext();
        public frmAracListesi()
        {
            InitializeComponent();
        }

        private void frmAracListesi_Load(object sender, EventArgs e)
        {
            dgv_AracListesi.DataSource = db.Arabalars.ToList();
            dgv_AracListesi.Columns[6].Visible = false;
            dgv_AracListesi.Columns[8].Visible = false;
            dgv_AracListesi.Columns[9].Visible = false;
            dgv_AracListesi.Columns[10].Visible = false;
        }

        private void dgv_AracListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmAracDetayVeKirala frmAracDetayVeKirala = new frmAracDetayVeKirala();
            id = int.Parse(dgv_AracListesi.CurrentRow.Cells[8].Value.ToString());
            imageBase64 = db.Arabalars.Where(a => a.ID == id).First().ImageUrl?.ToString();
            frmAracDetayVeKirala.kid = kid;
            frmAracDetayVeKirala.id = id;
            frmAracDetayVeKirala.imageBase64 = imageBase64;
            frmAracDetayVeKirala.Show();
        }
    }
}
