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
    public partial class Users_List : Form
    {
        BL.ClS_LOGIN search = new BL.ClS_LOGIN();
        Add_user add = new Add_user();
        public Users_List()
        {
            InitializeComponent();
            this.data_searchUs.DataSource = search.SearchUsers("");
        }

        private void button2_Click(object sender, EventArgs e)
        {


            add.Save_User.Text = "حفظ المستخدم";
            add.ShowDialog();
            this.data_searchUs.DataSource = search.SearchUsers("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //BL.ClS_LOGIN search = new BL.ClS_LOGIN();
            //add.Text_FName.Text = this.data_searchUs.CurrentRow.Cells[0].Value.ToString();
            //add.Text_Name.Text = this.data_searchUs.CurrentRow.Cells[1].Value.ToString();
            //add.Text_Id.Text = this.data_searchUs.CurrentRow.Cells[2].Value.ToString();
            //add.Text_Ad.Text = this.data_searchUs.CurrentRow.Cells[3].Value.ToString();
            //add.Text_Phone.Text = this.data_searchUs.CurrentRow.Cells[4].Value.ToString();
            //add.Text_Pw.Text = this.data_searchUs.CurrentRow.Cells[5].Value.ToString();
            //add.pictureBox1.Text = this.data_searchUs.CurrentRow.Cells[6].Value.ToString();
            //add.combType.Text = this.data_searchUs.CurrentRow.Cells[7].Value.ToString();

            //add.Save_User.Text = "تعديل المستخدم";
            //add.ShowDialog();
            //this.data_searchUs.DataSource = search.SearchUsers("");
            if (this.data_searchUs.CurrentRow != null)
            {
                string[] rowData = new string[data_searchUs.Columns.Count];
                for (int i = 0; i < data_searchUs.Columns.Count; i++)
                {
                    rowData[i] = this.data_searchUs.CurrentRow.Cells[i].Value?.ToString();
                }

                BL.ClS_LOGIN search = new BL.ClS_LOGIN();
                SetUserFields(rowData);
                add.Save_User.Text = "تعديل المستخدم";
                add.ShowDialog();
                this.data_searchUs.DataSource = search.SearchUsers("");
            }
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            this.data_searchUs.DataSource = search.SearchUsers(Text_Search.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SetUserFields(string[] rowData)
        {
            if (rowData.Length >= 8)
            {
                add.Text_FName.Text = rowData[0];
                add.Text_Name.Text = rowData[1];
                add.Text_Id.Text = rowData[2];
                add.Text_Ad.Text = rowData[3];
                add.Text_Phone.Text = rowData[4];
                add.Text_Pw.Text = rowData[5];
                add.pictureBox1.Text = rowData[6];
                add.combType.Text = rowData[7];
            }
        }
    }
}