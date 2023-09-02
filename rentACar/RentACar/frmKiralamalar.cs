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
    public partial class frmKiralamalar : Form
    {
        public frmKiralamalar()
        {
            InitializeComponent();
        }

        private void frmKiralamalar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'rentACarDataSet1.Kiralamas' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kiralamasTableAdapter.Fill(this.rentACarDataSet1.Kiralamas);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
