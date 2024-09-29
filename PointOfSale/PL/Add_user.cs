using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.PL
{
    public partial class Add_user : Form
    {
        public Add_user()
        {
            InitializeComponent();
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
          
            

            if (Text_FName.Text !=string.Empty && Text_Name.Text != string.Empty && Text_Id.Text != string.Empty &&  Text_Pw.Text != string.Empty && Text_CPw.Text != string.Empty &&  combType.Text != string.Empty )
            {

                if (Text_Pw.Text != Text_CPw.Text)
                {
                    MessageBox.Show("كلمة السر غير متطابقة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(Save_User.Text == "حفظ المستخدم")
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    BL.ClS_LOGIN log = new BL.ClS_LOGIN();
                    log.Add_User(Text_FName.Text, Text_Name.Text, Text_Id.Text, Text_Ad.Text, Text_Phone.Text, Text_Pw.Text, byteImage, combType.Text);
                    MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else /* (Save_User.Text == "تعديل المستخدم")*/
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    BL.ClS_LOGIN log = new BL.ClS_LOGIN();
                    log.Edit_User(Text_FName.Text, Text_Name.Text, Text_Id.Text, Text_Ad.Text, Text_Phone.Text, Text_Pw.Text, byteImage, combType.Text);
                    MessageBox.Show("تمت تعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Text_FName.Clear();
                Text_Name.Clear();
                Text_Id.Clear();
                Text_Ad.Clear();
                Text_Phone.Clear();
                Text_Pw.Clear();
                Text_CPw.Clear();
                Text_Name.Focus();






            }
           //else
           // {
           //     MessageBox.Show("أكمل باقي البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Text_CPw_Validated(object sender, EventArgs e)
        {

        }
    }
}
