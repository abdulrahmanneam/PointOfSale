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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace PointOfSale.PL
{
    public partial class Pro : Form
    {
        public static Pro re;
        static void frmClosed(object sender, FormClosedEventArgs e)
        {
            re = null;
        }
        public static Pro getNewPro
        {
            get
            {
                if (re == null)
                {
                    re = new Pro();
                    re.FormClosed += new FormClosedEventHandler(frmClosed);
                }
                return re;
            }
        }
            BL.CLS_PRODUCTS pro = new BL.CLS_PRODUCTS();
      
        public Pro()
        {
            InitializeComponent();
            if (re == null)
                re = this;
            this.dataGridView1.DataSource = pro.GET_ALL_Pro();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pro.Search_Pro(Text_Search.Text);
            this.dataGridView1.DataSource =dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Pro add = new Add_Pro();
            add.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("هل أنت متأكد من حذف المنتج", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if ( r == DialogResult.Yes)
            {
              
           
                pro.Delete_Pro(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحذف","عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       this.dataGridView1.DataSource = pro.GET_ALL_Pro();  
            }
            else
            { MessageBox.Show("تم إلغاء الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = pro.GET_ALL_Pro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Add_Pro edit = new Add_Pro();
            edit.Text_Name.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            edit.Text_Des.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            edit.Text_Qty.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            edit.Text_Price.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            edit.combCAT.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            edit.Text = "تعديل المنتج =>" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            edit.Save_Pro.Text = "تعديل";
            edit.state = "UpDate";
            edit.Text_Name.ReadOnly = true;
            byte[] image = (byte[])pro.Get_Image_Pro(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream im = new MemoryStream(image);
            edit.pictureBox1.Image = Image.FromStream(im);

            edit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Image_Viwe viwe = new Image_Viwe();
            byte[] image = (byte[])pro.Get_Image_Pro(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream im = new MemoryStream(image);
            viwe.pictureBox1.Image = Image.FromStream(im);
            viwe.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            ReportL.rpy_Pro rp = new ReportL.rpy_Pro();
            rp.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
          
            ReportL.Report_Pro r_p = new ReportL.Report_Pro();
            r_p.crystalReportViewer1.ReportSource = rp;
            r_p.ShowDialog();
            //((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            
            //if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            { 
                Add_Pro print = new Add_Pro();
                float margin = 40;// ده البيظبتلك الهيدر والفوتر بتاع التقرير

                Font f = new Font("Arial", 18, FontStyle.Bold);// ده الفونت أو حجم الخط ونوعه

                // احتسب ارتفاع كل خلية من الخلايا
                SizeF fsNo = e.Graphics.MeasureString("إسم المنتج", f);
                SizeF fsDes = e.Graphics.MeasureString("وصف المنتج", f);
                SizeF fsQty = e.Graphics.MeasureString("كمية المنتج", f);
                SizeF fsPrice = e.Graphics.MeasureString("سعر المنتج", f);
                SizeF fsCombCAT = e.Graphics.MeasureString("صنف", f);

                string strNo = (print.Text_Name.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string strDate = "التاريخ : " + Text_Date.Text;
                string strDes = (print.Text_Des.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                string strQty = (print.Text_Qty.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
                string strPrice = (print.Text_Price.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                string strCombCAT = (print.combCAT.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString());

                SizeF fsNO = e.Graphics.MeasureString(strNo, f);
                SizeF fsDate = e.Graphics.MeasureString(strDate, f);

                e.Graphics.DrawImage(Properties.Resources.STM_1000LID, 5, 5, 200, 200);// هذا لوضع مكان الصورة
                e.Graphics.DrawString(strNo, f, Brushes.Black, (e.PageBounds.Width - fsNO.Width) / 2, margin);// هذا للإسم 
                e.Graphics.DrawString(strDate, f, Brushes.Black, e.PageBounds.Width - fsDate.Width - margin, margin + fsNO.Height);// هذا للتاريخ

                float preHeights = margin + fsNO.Height + fsDate.Height + 110;// هذا لإبعاد الجدول عن العناصر العلوية وأضفتهم حتى ينقص مسافتهم لا يزيدها
                float rectangleHeight = e.PageBounds.Height - margin - preHeights; // هذا لتضيق حجم الجدول

                e.Graphics.DrawRectangle(Pens.Black, margin, preHeights, e.PageBounds.Width - margin * 2, rectangleHeight);// هذا هوا محيط  من خلاله جعلنا العناصر السابقة في مستطيل لوحدها مستقلة هذه البداية وهوا مستطيل وحددنا الون الخط وعرضه وطوله

                float colHei = 50; // دهالإرتفاع ومنه بتظبت أغلب التقرير الجدول ميطلعش عند الصورة والبيانات الرئيسية وبرده بتظبت العناصر حسب المكان الهتستخدمه

                float colwi = 150;// وده إسم الصنف
                float colwi2 = 300 + colwi;// ده الوصف وركز فيه
                float colwi3 = 80 + colwi2;// ده الكمية
                float colwi4 = 120 + colwi3;// ده السعر 
                float colwi5 = 100 + colwi4;// ركز على الأربع عناصر دولت هي البتظبتلك صفوف وعماويد العناصر ومنها هتعرف عملت إي وده التصنيف

                e.Graphics.DrawLine(Pens.DimGray, margin, preHeights + colHei, e.PageBounds.Width - margin, preHeights + colHei);
                e.Graphics.DrawString("إسم المنتج", f, Brushes.Black, e.PageBounds.Width - margin * 2 - colwi, preHeights);
                e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - colwi, preHeights, e.PageBounds.Width - margin * 2 - colwi, e.PageBounds.Height - margin);

                // احتسب ارتفاع العمود الأعلى (الذي يحتوي على أطول نص) من بين النصوص
                float maxTextHeight = Math.Max(fsNo.Height, Math.Max(fsDes.Height, Math.Max(fsQty.Height, Math.Max(fsPrice.Height, fsCombCAT.Height))));

                // احتسب ارتفاع الخلية الكلي
                float cellHeight = colHei + maxTextHeight;

                e.Graphics.DrawString("وصف المنتج", f, Brushes.Black, e.PageBounds.Width - colwi2, preHeights);
                e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - colwi2, preHeights, e.PageBounds.Width - margin * 2 - colwi2, e.PageBounds.Height - margin);

                e.Graphics.DrawString("كمية", f, Brushes.Black, e.PageBounds.Width - margin * 2 - colwi3, preHeights);
                e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - colwi3, preHeights, e.PageBounds.Width - margin * 2 - colwi3, e.PageBounds.Height - margin);

                e.Graphics.DrawString("سعر", f, Brushes.Black, e.PageBounds.Width - margin * 2 - colwi4, preHeights);
                e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - colwi4, preHeights, e.PageBounds.Width - margin * 2 - colwi4, e.PageBounds.Height - margin);

                e.Graphics.DrawString("   صنف ", f, Brushes.Black, e.PageBounds.Width - margin * 2 - colwi5, preHeights);

                // الخطوات السابقة كانت لرسم هيكل تقرير الأصن الخطو التالية وضع البيانات بداخله
                float RowHei = 50;//هذا يستخدم لتحديد إرتفاع العناصر ويجب أن يكون مطابقاً مع  colHei
                float currentHeight = preHeights + RowHei;
                int maxCharCount = 27;//هذه هي المعادلة التي تساعد على حل كتابة النصوص الكثيرة في الوصف والنسافة التي يجب عليه النزول اليها
                int maxCharCount2 = 35;// فلتها مع إسم الصنف لكن لم تنجح مثل الصنف ولكن حلت مشكلة أن الصنف لا ينزل معه وأيضاً أعطتني مسافة


                string shortenedDescription = strDes.Length > maxCharCount ? strDes.Substring(0, maxCharCount) : strDes;
                e.Graphics.DrawString(shortenedDescription, f, Brushes.Navy, e.PageBounds.Width - margin * 2 - colwi2, currentHeight);
                string shortenedDescription1 = strNo.Length > maxCharCount2 ? strNo.Substring(0, maxCharCount2) : strNo;
                e.Graphics.DrawString(shortenedDescription1, f, Brushes.Navy, e.PageBounds.Width - margin * 2 - colwi, currentHeight);
                if (strDes.Length > maxCharCount)
                {
                    string remainingDescription = strDes.Substring(maxCharCount);
                    currentHeight += RowHei;
                    e.Graphics.DrawString(remainingDescription, f, Brushes.Navy, (e.PageBounds.Width -10)- /*margin * 2*/ - colwi2, currentHeight);
                }
              
                else if (strNo.Length > maxCharCount2)
                {
                    string remainingDescription = strNo.Substring(maxCharCount2);
                    currentHeight += RowHei;
                    e.Graphics.DrawString(remainingDescription, f, Brushes.Navy, (e.PageBounds.Width - 10) - margin * 2 - colwi, currentHeight);
                }
                //e.Graphics.DrawString(strNo, f, Brushes.Navy, e.PageBounds.Width - margin * 2 - colwi, preHeights + RowHei);
                e.Graphics.DrawString(strQty, f, Brushes.Navy, e.PageBounds.Width - margin * 2 - colwi3, preHeights + RowHei);//هؤلاء الأوت بوت
                e.Graphics.DrawString(strPrice, f, Brushes.Navy, e.PageBounds.Width - margin * 2 - colwi4, preHeights + RowHei);
                e.Graphics.DrawString(strCombCAT, f, Brushes.Navy, e.PageBounds.Width - margin  - colwi5, preHeights + RowHei);
                 RowHei += 50;
                //e.Graphics.DrawLine(Pens.Black, margin, preHeights + RowHei + colHei, e.PageBounds.Width - margin, preHeights + RowHei + colHei);// هذا خط نهاية التقرير ولكن لم أستخدمه لأنه سيحدث مشكلة إذا طال نص الوصف سوف يعبره فا الأفضل إلغائه
            }
        }

        private void Pro_Load(object sender, EventArgs e)
        {
            Text_Date.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportL.Cachedrp_ProList rpl = new ReportL.Cachedrp_ProList();
            ReportL.Report_Pro r_p = new ReportL.Report_Pro();
            r_p.crystalReportViewer1.ReportSource = rpl;
            r_p.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReportL.rp_ProList rpl = new ReportL.rp_ProList();
            //create export options
            ExportOptions ex = new ExportOptions();// هذا الكائن سيجعلنا نحول ونخزن هذا التقرير بإمتدادات أخرى
            ExcelFormatOptions efo = new ExcelFormatOptions();
           
             //create object for DestinationOptions 
            DiskFileDestinationOptions ddo = new DiskFileDestinationOptions();// هذا سيجعلنا نحدد مسار التخزين

            //set the path DestinationOptions 
            ddo.DiskFileName = @"D:\Product.xls";

            // do export options
            ex = rpl.ExportOptions;
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportFormatType = ExportFormatType.Excel;
            ex.ExportFormatOptions = efo;
            // now i would to set this file into DestinationOptions 
            ex.ExportDestinationOptions = ddo;
            //the last move will save ex with rpl
            rpl.Export();
            MessageBox.Show("Done","Export",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReportL.rp_ProList rpl = new ReportL.rp_ProList();
            //create export options
            ExportOptions ex = new ExportOptions();// هذا الكائن سيجعلنا نحول ونخزن هذا التقرير بإمتدادات أخرى
            PdfRtfWordFormatOptions efo = new PdfRtfWordFormatOptions();

            //create object for DestinationOptions 
            DiskFileDestinationOptions ddo = new DiskFileDestinationOptions();// هذا سيجعلنا نحدد مسار التخزين

            //set the path DestinationOptions 
            ddo.DiskFileName = @"D:\Product.rtf";

            // do export options
            ex = rpl.ExportOptions;
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportFormatType = ExportFormatType.WordForWindows;
            ex.ExportFormatOptions = efo;
            // now i would to set this file into DestinationOptions 
            ex.ExportDestinationOptions = ddo;
            //the last move will save ex with rpl
            rpl.Export();
            MessageBox.Show("Done", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button11_Click(object sender, EventArgs e)
        {

            ReportL.rp_ProList rpl = new ReportL.rp_ProList();
            //create export options
            ExportOptions ex = new ExportOptions();// هذا الكائن سيجعلنا نحول ونخزن هذا التقرير بإمتدادات أخرى
            PdfRtfWordFormatOptions efo = new PdfRtfWordFormatOptions();

            //create object for DestinationOptions 
            DiskFileDestinationOptions ddo = new DiskFileDestinationOptions();// هذا سيجعلنا نحدد مسار التخزين

            //set the path DestinationOptions 
            ddo.DiskFileName = @"D:\Product.pdf";

            // do export options
            ex = rpl.ExportOptions;
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportFormatType = ExportFormatType.PortableDocFormat;
            ex.ExportFormatOptions = efo;
            // now i would to set this file into DestinationOptions 
            ex.ExportDestinationOptions = ddo;
            //the last move will save ex with rpl
            rpl.Export();
            MessageBox.Show("Done", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Text_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
