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
    public partial class إضافة_مستخدم : Form
    {
        public إضافة_مستخدم()
        {
            InitializeComponent();
        }

        private void Save_Pro_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] byteImage = ms.ToArray();
            BL.ClS_LOGIN User = new BL.ClS_LOGIN();
            User.NewUsers(Text_Name.Text, Text_FName.Text, Text_ID.Text, Text_Ad.Text, Text_Phone.Text, Text_Pas.Text, byteImage, combType.Text);
            MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Text_Name.Clear();
            Text_FName.Clear();
            Text_ID.Clear();
            Text_Ad.Clear();
            Text_Phone.Clear();
            Text_Pas.Clear();
            Text_CPassword.Clear();
            Text_Name.Focus();
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
    }
}
