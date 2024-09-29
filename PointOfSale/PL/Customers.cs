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
    public partial class Customers : Form
    {
        BL.ClS_Customers cust = new BL.ClS_Customers();
        int Id , posi;
        public Customers()
        {
            InitializeComponent();
            this.dataGridView1.DataSource =  cust.GET_ALL_CSU();
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF; .BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }

        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            
        

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[]  byteImage = ms.ToArray();
            cust.Add_Customers(Text_Name.Text, Text_LName.Text, Text_Phone.Text, Text_Email.Text, byteImage);
            MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dataGridView1.DataSource = cust.GET_ALL_CSU();

            But_Save.Enabled = false;
            BNew.Enabled = true;

            //if (pictureBox1.Image != null)//هذا الشرط لا أحتاجه لكن أجربه في حالة إذا حدث معي خطأ فيتخزين البيانات بدون صورة
            //{
            //    MemoryStream ms = new MemoryStream();
            //    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            //    byteImage = ms.ToArray();
            //    cust.Add_Customers(Text_Name.Text, Text_LName.Text, Text_Phone.Text, Text_Email.Text, byteImage, "with_image");
            //    MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}

            //else
            //{
            //    byteImage = new byte[0];// هذا الحقل تمويه في كلتا الحالتين لن يرسل بيان الصورة
            //    cust.Add_Customers(Text_Name.Text, Text_LName.Text, Text_Phone.Text, Text_Email.Text, byteImage, "without_image");
            //}

        }
        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            Text_Name.Clear();
            Text_LName.Clear();
            Text_Phone.Clear();
            Text_Email.Clear();
            Text_Search.Clear();
            //pictureBox1.Image = null;
            Text_Name.Focus();
            But_Save.Enabled = true;
            BNew.Enabled = false;

        }

        private void Text_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Text_LName.Focus();
            }
        }

        private void Text_LName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Text_Phone.Focus();
            }
        }

        private void Text_Phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Text_Email.Focus();
            }
        }

        private void Text_Email_Click(object sender, EventArgs e)
        {
          
        }

        private void Text_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                But_Save.Focus();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //pictureBox1.Image = null;
                Id =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.Text_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.Text_LName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.Text_Phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.Text_Email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                  byte[] byteImage = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(byteImage);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Id == 0)
            {
                MessageBox.Show("من فضلك حدد العميل أولاً من القائمة");
                return;
            }
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] byteImage = ms.ToArray();
            cust.Edit_Customers(Text_Name.Text, Text_LName.Text, Text_Phone.Text, Text_Email.Text, byteImage,Id);
            MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dataGridView1.DataSource = cust.GET_ALL_CSU();
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            if(Id == 0)
            {
                MessageBox.Show("من فضلك حدد العميل أولاً من القائمة");
                return;
            }
            if (MessageBox.Show("هل تريد حذف هذا العميل", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cust.Delete_Customers(Id);
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.GET_ALL_CSU();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cust.Search_CUS(Text_Search.Text);
            Text_Search.Clear();
        }
        private void Search_OBJ(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = cust.Search_CUS(Text_Search.Text);
          

        }

        private void Text_Search_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Search_OBJ(sender, e);
                    Text_Search.Clear();
                    break;        
                
                  
                    // إذا كنت بحاجة إلى إضافة حالات أخرى استنادًا إلى مفاتيح أخرى، يمكنك تكرار هذا النمط
            }
                
        }

        void navGet(int index)
        {
            //DataTable dt = cust.GET_ALL_CSU();
            DataRowCollection DRC = cust.GET_ALL_CSU().Rows;
            //Id = Convert.ToInt32(DRC[index][0]);//هذا لا أحتاجه لأني لم أجعل الصورة نال فارغة ولكن إذا فعلت سوف أستخدم اي دي
            Text_Name.Text = DRC[index][1].ToString();
            Text_LName.Text = DRC[index][2].ToString();
            Text_Phone.Text = DRC[index][3].ToString();
            Text_Email.Text = DRC[index][4].ToString();
            byte[] byteImage = (byte[])DRC[index][5];
            MemoryStream ms = new MemoryStream(byteImage);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            posi = cust.GET_ALL_CSU().Rows.Count -1;
            navGet(posi);
        }

        private void BtnPrevi_Click(object sender, EventArgs e)
        {
            if( posi == 0)
            {
                MessageBox.Show("هذا هوا اول عنصر");
                return;
            }
            posi -= 1;
            navGet(posi);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (posi == cust.GET_ALL_CSU().Rows.Count-1)
            {
                MessageBox.Show("هذا هوا اخر عنصر");
                return;
            }
            posi += 1;
            navGet(posi);
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            navGet(0);
        }
    }
}
