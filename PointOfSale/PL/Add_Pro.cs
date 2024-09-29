using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PointOfSale.PL
{
    public partial class Add_Pro : Form
    {
        public string state = "add";
        BL.CLS_PRODUCTS pro = new BL.CLS_PRODUCTS();
        public Add_Pro()
        {
            InitializeComponent();
            combCAT.DataSource = pro.GET_ALL_GATEGORIES();
            combCAT.DisplayMember = "Descreption_CAT";
            combCAT.ValueMember = "ID_CAT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF; .BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }

        }

        private void Save_Pro_Click(object sender, EventArgs e)
        {
            try
            {

                if (state == "add")
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    pro.Add_Product(Text_Name.Text, Text_Des.Text, Convert.ToInt32(Text_Qty.Text), Text_Price.Text, byteImage, Convert.ToInt32(combCAT.SelectedValue));
                    MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pro p = new Pro();
                    p.dataGridView1.DataSource = pro.GET_ALL_Pro();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    pro.Edit_pro(Text_Name.Text , Text_Des.Text, Convert.ToInt32(Text_Qty.Text), Text_Price.Text, byteImage, Convert.ToInt32(combCAT.SelectedValue));
                    MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pro p = new Pro();
                    p.dataGridView1.DataSource = pro.GET_ALL_Pro();


                }
                Pro.getNewPro.dataGridView1.DataSource = pro.GET_ALL_Pro();
            }
            catch
            {
                MessageBox.Show("لا توجد أصناف مخزنة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          


        }

        private void Text_Name_Validated(object sender, EventArgs e)
        {
            if(state == "add")
            { 
            DataTable dt = new DataTable();
            dt = pro.VP_ID(Text_Name.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("هذا الإسم موجود مسبقاً","تحذير",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Text_Name.Focus();
                Text_Name.SelectionStart = 0;
                Text_Name.SelectionLength = Text_Name.TextLength;

            }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Text_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
