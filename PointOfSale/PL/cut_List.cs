using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.PL
{
    public partial class cut_List : Form
    {
        BL.ClS_Customers CUS = new BL.ClS_Customers();
        public cut_List()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = CUS.GET_ALL_CSU();
            this.dataGridView1.Columns[0].Visible = false;
        }
        private DataGridViewRow selectedRow;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentRow;
            Close();
        }
    }
}
