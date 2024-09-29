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
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace PointOfSale.PL
{
    public partial class invo : DevExpress.XtraEditors.XtraForm
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LCRKM5P\SQLEXPRESS; Initial Catalog=POS; Integrated Security=true");
        BL.ClS_Order Order = new BL.ClS_Order();
        DataTable dt = new DataTable();
        private void creatDT()
        {

            dt.Columns.Add("تصنيف المنتج");
            dt.Columns.Add("إسم المنتج");
            dt.Columns.Add("كمية المنتج");
            dt.Columns.Add("ثمن المنتج");
            dt.Columns.Add("مبلغ البيع");
            dt.Columns.Add("نسبة الخصم %");
            dt.Columns.Add("إجمالي المنتج");
            gridControl1.DataSource = dt;


            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText =("إخيار المنتج");
            //btn.Text = ("بحث");
            //gridView1.Columns.Add(bt);
        }
        public invo()
        {
            InitializeComponent();
            creatDT();
            sizegr();
            Text_CuName.Text = Program.SalesMan;



        }
        void clear()
        {
            textId.Clear();
            textNa.Clear();
            textQty.Clear();
            textPr.Clear();
            textSa.Clear();
            textDi.Clear();
            textTo.Clear();
        }
        void clearD()
        {
            text_inNu.Text = string.Empty;
            text_Des.Text = string.Empty;
            textDate.Text = string.Empty;
            Text_CuName.Text = string.Empty;
            Text_InfCus.Text = string.Empty;
            Text_Name.Text = string.Empty;
            Text_LName.Text = string.Empty;
            Text_Phone.Text = string.Empty;
            Text_Email.Text = string.Empty;
            clear();
            dt.Clear();
            gridControl1.DataSource = null;
            Text_Total.Text = string.Empty;
            pictureEdit1.Image = null;
            btn_Print_inv.Enabled = false;
            But_new_inv.Enabled = true;
            //btn_Print_rc.Enabled = true;
        }

        private void sizegr()
        {


            this.gridView1.Columns[0].Width = 100;
            this.gridView1.Columns[1].Width = 100;
            this.gridView1.Columns[2].Width = 183;
            this.gridView1.Columns[3].Width = 111;
            this.gridView1.Columns[4].Width = 109;
            this.gridView1.Columns[5].Width = 135;
            this.gridView1.Columns[6].Width = 105;
            //this.gridView1.Columns[7].Width = 156;

        }
        private void calculatAmount()
        {
            if (textQty.Text != string.Empty && textPr.Text != string.Empty)
            {
                double amount = Convert.ToDouble(textPr.Text) * Convert.ToDouble(textQty.Text);
                textSa.Text = amount.ToString();
            }

        }
        private void totalamount()
        {
            if (textDi.Text != string.Empty && textSa.Text != string.Empty)
            {
                float dis = float.Parse(textDi.Text); // تحويل النص إلى float
                float amoun = float.Parse(textSa.Text); // تحويل النص إلى float

                float tamont = amoun - (amoun * (dis / 100));
                textTo.Text = tamont.ToString();
            }


        }
        private void invo_Load(object sender, EventArgs e)
        {
            //conn.Open();
            //SqlCommand Sqlcmd = new SqlCommand("select * from Orders_Details");
            //conn.Close();


            text_Des.Properties.AutoHeight = true;
            text_Des.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            text_Des.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            text_Des.Properties.Appearance.Options.UseTextOptions = true;

            text_Des.Properties.AutoHeight = true;
            text_Des.Width = 200;
            text_Des.Height = 100;
            text_Des.Properties.NullText = "أدخل الوصف هنا...";
            //text_inNu.Properties.ReadOnly = true;
            Text_InfCus.Properties.ReadOnly = true;
            Text_Name.Properties.ReadOnly = true;
            Text_LName.Properties.ReadOnly = true;
            Text_Phone.Properties.ReadOnly = true;
            Text_Email.Properties.ReadOnly = true;
            pictureEdit1.Properties.ReadOnly = true;
            Text_Total.Properties.ReadOnly = true;
            Text_CuName.Properties.ReadOnly = true;
            text_inNu.Properties.BorderStyle.GetType();
            pictureEdit1.Image = null;



        }

        private void text_Des_TextChanged(object sender, EventArgs e)
        {


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            text_inNu.Text = Order.GET_LAT_ORDId().Rows[0][0].ToString();
            But_new_inv.Enabled = false;
            btn_Print_inv.Enabled = true;

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
       
                int idordd = Convert.ToInt32(Order.GET_LAT_ORDIdfp().Rows[0][0]);
                ReportL.rpt_Orders ord = new ReportL.rpt_Orders();
                ReportL.Report_Pro re = new ReportL.Report_Pro();

            ord.SetParameterValue("@ID_ORDd", idordd);
            //ord.SetDataSource(Order.GLO(idordd));
            re.crystalReportViewer1.ReportSource = ord;
                re.ShowDialog();
            //TextObject textname = (TextObject)ord.ReportDefinition.Sections["Section2"].ReportObjects["Text2"];
            //textname.Text = "اسم المورد : ";
            //if (conn.State != ConnectionState.Open)
            //{
            //    conn.Open();
            //}
            //SqlCommand Sqlcmd = new SqlCommand("select * from Orders_Details",conn);
            //SqlDataAdapter ad = new SqlDataAdapter(Sqlcmd);
            //DataSet ds = new DataSet();
            //ad.Fill(ds, "Orders_Details");
            //ord.SetDataSource(ds);




        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            PL.cus_List list = new cus_List();
            list.ShowDialog();
            if (list.gridView1 != null)
            {


                this.Text_InfCus.Text = list.gridView1.GetRowCellValue(list.gridView1.FocusedRowHandle, "ID_CUS").ToString();
                this.Text_Name.Text = list.gridView1.GetRowCellValue(list.gridView1.FocusedRowHandle, "First_Name").ToString();
                this.Text_LName.Text = list.gridView1.GetRowCellValue(list.gridView1.FocusedRowHandle, "Last_Name").ToString();
                this.Text_Phone.Text = list.gridView1.GetRowCellValue(list.gridView1.FocusedRowHandle, "Phone").ToString();
                this.Text_Email.Text = list.gridView1.GetRowCellValue(list.gridView1.FocusedRowHandle, "Email").ToString();
                byte[] picE = (byte[])list.gridView1.GetRowCellValue(list.gridView1.FocusedRowHandle, "Image");
                MemoryStream ms = new MemoryStream(picE);
                pictureEdit1.Image = Image.FromStream(ms);
            }
        }



        private void simpleButton3_Click_1(object sender, EventArgs e)
        {

            clear();

            Product_List pl = new Product_List();
            pl.ShowDialog();
            if (pl.gridView1 != null)
            {


                this.textId.Text = pl.gridView1.GetRowCellValue(pl.gridView1.FocusedRowHandle, "تصنيف المنتج").ToString();
                this.textNa.Text = pl.gridView1.GetRowCellValue(pl.gridView1.FocusedRowHandle, "وصف المنتج").ToString();
                this.textPr.Text = pl.gridView1.GetRowCellValue(pl.gridView1.FocusedRowHandle, "ثمن المنتج").ToString();

            }
        }

        private void textQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void textPr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void textDi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void textQty_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textPr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && textQty.Text != string.Empty)
            {
                textPr.Focus();
            }
        }

        private void textPr_KeyUp(object sender, KeyEventArgs e)
        {
            calculatAmount();
            totalamount();
        }

        private void textQty_KeyUp(object sender, KeyEventArgs e)
        {
            calculatAmount();
            totalamount();
        }

        private void textDi_KeyUp(object sender, KeyEventArgs e)
        {

            totalamount();
        }

        private void textDi_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                if (Order.Ve_Qty(textId.Text, Convert.ToInt32(textQty.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("لا توجد كمية كافية", "تنبيه!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    object value = gridView1.GetRowCellValue(i, "تصنيف المنتج"); // قم بتغيير "اسم_العمود" إلى اسم العمود الذي ترغب في استخدامه
                    if (value != null && value.ToString() == textId.Text)
                    {
                        MessageBox.Show("هذا الطلب موجود بالفعل", "تنبيه!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                   
                }
            


                DataRow r = dt.NewRow();
                r[0] = textId.Text;
                r[1] = textNa.Text;
                r[2] = textQty.Text;
                r[3] = textPr.Text;
                r[4] = textSa.Text;
                r[5] = textDi.Text;
                r[6] = textTo.Text;
                dt.Rows.Add(r);
                gridControl1.DataSource = dt;
                clear();
                try
                {
                    double total = 0;
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        object value = gridView1.GetRowCellValue(i, "إجمالي المنتج");
                        if (value != null && value != DBNull.Value)
                        {
                            total += Convert.ToDouble(value);
                        }
                    }

                    Text_Total.Text = total.ToString();


                }
                catch
                {
                    MessageBox.Show("من فضلك أكمل الطلب", "تنبيه!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.textId.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "تصنيف المنتج").ToString();
                this.textNa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "إسم المنتج").ToString();
                this.textQty.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "كمية المنتج").ToString();

                this.textPr.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ثمن المنتج").ToString();
               
                this.textDi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "نسبة الخصم %").ToString();
                this.textSa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "مبلغ البيع").ToString();
                this.textTo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "إجمالي المنتج").ToString();
                gridView1.DeleteRow(gridView1.FocusedRowHandle);

                //int columnIndex = 0; // تستبدل 0 بالفهرس العددي الخاص بالعمود الذي تريد الوصول إليه
                //string columnName = gridView1.Columns[columnIndex].FieldName;
                //this.textId.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, columnName).ToString();

            }
            catch
            {
                return;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            double total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                object value = gridView1.GetRowCellValue(i, "إجمالي المنتج");
                if (value != null && value != DBNull.Value)
                {
                    total += Convert.ToDouble(value);
                }
            }

            Text_Total.Text = total.ToString();

        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridView1_DoubleClick(sender, e);
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    for (int i = 0; i < gridView1.RowCount; i++)
            //    {

            //    gridView1.DeleteRow(i);
            //}
            dt.Clear();
            gridView1.RefreshData();
            double total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                object value = gridView1.GetRowCellValue(i, "إجمالي المنتج");
                if (value != null && value != DBNull.Value)
                {
                    total += Convert.ToDouble(value);
                }
            }

            Text_Total.Text = total.ToString();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dt.Clear();
            gridView1.RefreshData();
            double total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                object value = gridView1.GetRowCellValue(i, "إجمالي المنتج");
                if (value != null && value != DBNull.Value)
                {
                    total += Convert.ToDouble(value);
                }
            }

            Text_Total.Text = total.ToString();

        }

        private void btn_Print_inv_Click(object sender, EventArgs e)
        {
            //check values
            if (text_inNu.Text == string.Empty || Text_InfCus.Text == string.Empty || gridView1.RowCount < 1 || text_Des.Text == string.Empty)
            {
                MessageBox.Show("تفقد المعلومات الأساسية", "تنبيه!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //إضافة بيانات الفاتورة
            Order.Add_ord(Convert.ToInt32(text_inNu.Text), textDate.DateTime, Convert.ToInt32(Text_InfCus.Text), text_Des.Text, Text_CuName.Text);
            //إضافة المنتجات
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                Order.Add_ord_D(gridView1.GetRowCellValue(i, "تصنيف المنتج").ToString(),
                        Convert.ToInt32(text_inNu.Text),
                     //Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "إسم المنتج").ToString()),
                     Convert.ToInt32(gridView1.GetRowCellValue(i, "كمية المنتج").ToString()),
                     gridView1.GetRowCellValue(i, "ثمن المنتج").ToString(),
                     Convert.ToInt32(gridView1.GetRowCellValue(i, "مبلغ البيع").ToString()),
                     gridView1.GetRowCellValue(i, "نسبة الخصم %").ToString(),
                     gridView1.GetRowCellValue(i, "إجمالي المنتج").ToString());
            }
            MessageBox.Show("تم الحفظ بنجاح", "تنبيه!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearD();
            
            //List<BL.ClS_Order> ordersList = new List<BL.ClS_Order>();

            //for (int i = 0; i < gridView1.RowCount - 1; i++)
            //{
            //    // إنشاء كائن Order جديد
            //Order.ID_PRO = gridView1.GetRowCellValue(i, "تصنيف المنتج").ToString();
            //    Order.Quantity = Convert.ToInt32(gridView1.GetRowCellValue(i, "كمية المنتج").ToString());
            //    Order.Price = gridView1.GetRowCellValue(i, "ثمن المنتج").ToString();
            //    Order.Amount = Convert.ToInt32(gridView1.GetRowCellValue(i, "مبلغ البيع").ToString());
            //    Order.Discount = gridView1.GetRowCellValue(i, "نسبة الخصم %").ToString();
            //    Order.TotalAmount = gridView1.GetRowCellValue(i, "إجمالي المنتج").ToString();
            //    ordersList.Add(Order);
            //}
            //MessageBox.Show("تم الحفظ بنجاح", "تنبيه!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }
    }
    }
    

//PL.cus_List list = new cus_List();
//list.ShowDialog();
//            if (list.dataGridView1 != null)
//            {


//                this.Text_InfCus.Text = list.dataGridView1.CurrentRow.Cells[0].Value.ToString();
//                this.Text_Name.Text = list.dataGridView1.CurrentRow.Cells[1].Value.ToString();
//                this.Text_LName.Text = list.dataGridView1.CurrentRow.Cells[2].Value.ToString();
//                this.Text_Phone.Text = list.dataGridView1.CurrentRow.Cells[3].Value.ToString();
//                this.Text_Email.Text = list.dataGridView1.CurrentRow.Cells[4].Value.ToString();
//                byte[] picE = (byte[])list.dataGridView1.CurrentRow.Cells[5].Value;
//                MemoryStream ms = new MemoryStream(picE);
//                pictureEdit1.Image = Image.FromStream(ms);
//            }

////////////////////////////////////////
//PL.cus_List list = new cus_List();
//list.Show();

//int selectedRowHandle = gridView1.FocusedRowHandle;

//if (selectedRowHandle >= 0)
//{
//    Text_InfCus.Text = gridView1.GetRowCellValue(selectedRowHandle, "ID_CUS").ToString();
//    Text_Name.Text = gridView1.GetRowCellValue(selectedRowHandle, "First_Name").ToString();
//    Text_LName.Text = gridView1.GetRowCellValue(selectedRowHandle, "Last_Name").ToString();
//    Text_Phone.Text = gridView1.GetRowCellValue(selectedRowHandle, "Phone").ToString();
//    Text_Email.Text = gridView1.GetRowCellValue(selectedRowHandle, "Email").ToString();

//    byte[] picE = (byte[])gridView1.GetRowCellValue(selectedRowHandle, "Image");
//    MemoryStream ms = new MemoryStream(picE);
//    pictureEdit1.Image = Image.FromStream(ms);
//}