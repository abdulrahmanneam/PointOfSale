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

namespace PointOfSale.PL
{
    public partial class Product_List : DevExpress.XtraEditors.XtraForm
    {
        BL.CLS_PRODUCTS list = new BL.CLS_PRODUCTS();
        public Product_List()
        {
            InitializeComponent();
            gridControl1.DataSource = list.GET_ALL_Pro();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}