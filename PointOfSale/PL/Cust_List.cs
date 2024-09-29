using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace PointOfSale.PL
{
    public partial class Cust_List : DevExpress.XtraEditors.XtraForm
    {
        BL.ClS_Customers CUS = new BL.ClS_Customers();
        public Cust_List()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = CUS.GET_ALL_CSU();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        private DataGridViewRow selectedRow;

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentRow;
            Close();
        }
    }
}