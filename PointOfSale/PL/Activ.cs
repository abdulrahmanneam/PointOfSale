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
    public partial class Activ : Form
    {
        BL.ClS_LOGIN log = new BL.ClS_LOGIN();
        public Activ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(Text_Name.Text, Text_Act.Text);
            if (dt.Rows.Count >0)
            {


                if (dt.Rows[0][7].ToString() == "مدير")
                {
                    Main.getNewMain.العملاء.Enabled = true;
                    Main.getNewMain.المبيعات.Enabled = true;
                    Main.getNewMain.المستخدمين.Enabled = true;
                    Main.getNewMain.المنتج.Enabled = true;
                    Main.getNewMain.accordionControlElement11.Enabled = true;
                    //Main.getNewMain.accordionControlElement12.Enabled = true;
                    Main.getNewMain.accordionControlElement13.Enabled = true;
                    Main.getNewMain.accordionControlElement14.Enabled = true;
                    Main.getNewMain.accordionControlElement15.Enabled = true;
                    Main.getNewMain.accordionControlElement16.Enabled = true;
                    Main.getNewMain.accordionControlElement7.Enabled = true;
                    Main.getNewMain.accordionControlElement18.Enabled = true;
                    Main.getNewMain.accordionControlElement19.Enabled = true;
                    Main.getNewMain.accordionControlElement8.Enabled = true;
                    Main.getNewMain.إستعادة_نسخة.Enabled = true;
                    Main.getNewMain.إنشاء_نسخة.Enabled = true;
                    this.Close();
                }
                else if (dt.Rows[0][7].ToString() == "كاشير")
                {
                    Main.getNewMain.العملاء.Enabled = true;
                    Main.getNewMain.المبيعات.Enabled = true;
                    Main.getNewMain.المستخدمين.Visible = false;
                    Main.getNewMain.المنتج.Enabled = true;
                    Main.getNewMain.accordionControlElement11.Enabled = false;
                    //Main.getNewMain.accordionControlElement12.Enabled = true;
                    Main.getNewMain.accordionControlElement13.Enabled = false;
                    Main.getNewMain.accordionControlElement14.Enabled = false;
                    Main.getNewMain.accordionControlElement15.Enabled = false;
                    Main.getNewMain.accordionControlElement16.Enabled = false;
                    Main.getNewMain.accordionControlElement7.Enabled = true;
                    Main.getNewMain.accordionControlElement18.Enabled = true;
                    Main.getNewMain.accordionControlElement19.Enabled = true;
                    Main.getNewMain.accordionControlElement8.Enabled = true;
                    Main.getNewMain.إستعادة_نسخة.Visible = false;
                    Main.getNewMain.إنشاء_نسخة.Visible = false;
                    this.Close();
                }

            }
            else
            {

                MessageBox.Show("falid");
            }
        }
    }
}
