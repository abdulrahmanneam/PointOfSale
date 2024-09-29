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
    public partial class cus_List : DevExpress.XtraEditors.XtraForm
    {
        BL.ClS_Customers CUS = new BL.ClS_Customers();
      
        public DataGridViewRow selectedRow; // قم بتعريف selectedRow كمتغير عام

        public cus_List()
        {
            InitializeComponent();
            this.gridControl1.DataSource = CUS.GET_ALL_CSU();
            

            this.gridView1.Columns[0].Visible = false;
           
        }


        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            Close();
        }
        

        //private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo info = gridView1.CalcHitInfo(e.Location);

        //    if (info.InRow)
        //    {
        //        int rowIndex = info.RowHandle;

        //        // استخراج البيانات من الصف المحدد
        //        string columnName1 = gridView1.GetRowCellValue(rowIndex, "ID_CUS").ToString();
        //        string columnName2 = gridView1.GetRowCellValue(rowIndex, "First_Name").ToString();
        //        string columnName3 = gridView1.GetRowCellValue(rowIndex, "Last_Name").ToString();
        //        string columnName4 = gridView1.GetRowCellValue(rowIndex, "Phone").ToString();
        //        string columnName5 = gridView1.GetRowCellValue(rowIndex, "Email").ToString();
           
            
        //        // وهكذا لاستخراج البيانات من الأعمدة الأخرى

        //        // عرض البيانات في TextBoxes أو عناصر تحكم أخرى
        //        i.Text_InfCus.Text = columnName1;
        //        i.Text_Name.Text = columnName2;
        //        i.Text_LName.Text = columnName3;
        //        i.Text_Phone.Text = columnName4;
        //        i.Text_Email.Text = columnName5;
        //        //MemoryStream ms = new MemoryStream(picE);
        //        //i.pictureEdit1.Image = Image.FromStream(ms);
        //        //// وهكذا لعرض البيانات في العناصر الأخرى
        //    }
        //}
    }
}