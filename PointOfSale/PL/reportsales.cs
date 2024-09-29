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
    public partial class reportsales : Form
    {
        BL.ClS_Order ord = new BL.ClS_Order();
        public reportsales()
        {
            InitializeComponent();
            this.dfgreport.DataSource = ord.reportOrder("");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dfgreport.DataSource = ord.reportOrder(Text_Search.Text);
            }
            catch
            {
                return;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

            int idordd = Convert.ToInt32(dfgreport.CurrentRow.Cells[0].Value);
            ReportL.rpt_Orders ord = new ReportL.rpt_Orders();
            ReportL.Report_Pro re = new ReportL.Report_Pro();

            ord.SetParameterValue("@ID_ORDd", idordd);
           
            re.crystalReportViewer1.ReportSource = ord;
            re.ShowDialog();
           


        }
    }
}
