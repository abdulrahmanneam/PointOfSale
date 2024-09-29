using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PointOfSale.PL
{
    public partial class Invoi : Form
    {
        BL.ClS_Order Order = new BL.ClS_Order();
        public Invoi()
        {
            
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.cut_List list = new cut_List();
            list.ShowDialog();
            if (list.dataGridView1 != null)
            {


                this.Text_InfCus.Text = list.dataGridView1.CurrentRow.Cells["ID_CUS"].Value.ToString();
                this.Text_Name.Text = list.dataGridView1.CurrentRow.Cells["First_Name"].Value.ToString();
                this.Text_LName.Text = list.dataGridView1.CurrentRow.Cells["Last_Name"].Value.ToString();
                this.Text_Phone.Text = list.dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
                this.Text_Email.Text = list.dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                byte[] picE = (byte[])list.dataGridView1.CurrentRow.Cells["Image"].Value;
                MemoryStream ms = new MemoryStream(picE);
                 pictureBox1.Image = Image.FromStream(ms);
        
            }

        }
    }
}
