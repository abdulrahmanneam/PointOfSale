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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;


namespace PointOfSale.PL
{
    public partial class CAT_PRO : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-LCRKM5P\SQLEXPRESS; Initial Catalog=POS; Integrated Security=true");// SqlConnection هذا خاص بالإتصال ويكتب فيه المسار
        SqlDataAdapter sqlDa;// SqlDataAdapter دوره هوا جلب داتا من تيبل أوإرسال بيانات من تيبل هوا مثل وسيط بين قاعدة البيانات والطرف الأخر
        DataTable dt = new DataTable();//DataTable هي التيبلز أو الجدوال التي بداخلها الأتبريوت التي أستعملها ,ارسلها من هنا عن طريق البراميتر
        BindingManagerBase BmB; //BindingManagerBase الأن سنستخدم هذا الكلاس وهوا سيساعدنا في إدارة البيانات التي أحضرتها من حقول الداتا بيز سواء حفظ أو تعديل أو حذف وهوا أبستكرت كلاس لا يتم الوراثة منه
        SqlCommandBuilder cmdb;// يكننا من تفعيل الحفظ والتعديل والعحذف من خلال داتا ادبتر وداتا تيبل الذ سبق إستخدامهم
        public CAT_PRO()
        {
            InitializeComponent();
            sqlDa = new SqlDataAdapter("select ID_CAT as 'رقم الصنف', Descreption_CAT as 'إسم الصنف' from Category", sqlCon);// أنشئت كائن جديد ولكي أشير الي العناصر بداخل  تيبل كاتيجوري أو جدول الأصناف بإستخدام الكونستراكتر أجرمونت و:اني أكتب كويري داخل قاعدة البيانات ويمكنني التحكم بالأتربيوتس والإتصال دون الدخول للسيكوال , ووضعت أؤبجيكت الإتصال
            sqlDa.Fill(dt);// وضعت البيانات التي أحضرتها داخل الداتا تيبل
            dataGridView1.DataSource = dt; // وأشرت الى الأداة التي أستخدمها لعرض البيانات = داتا تيبل التي وضعت بداخلها البيانات
            Text_ID.DataBindings.Add("text", dt, "رقم الصنف");//DataBindings الأن سنستخدم هذا الإجراء مخصوص لربط البيانات من حقول في داتا بيز الى حقل في المشروع اي فورم
            Text_Des.DataBindings.Add("text", dt, "إسم الصنف");
            pCAT.DataBindings.Add("text", dt, "رقم الصنف");
            BmB = this.BindingContext[dt];
            pCAT.Text = (BmB.Position+1) + "  /  " + BmB.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BmB.EndCurrentEdit();//هذا الإجراء مهم وأساسي في جميع العمليات يقوم بإنهاء أي عملية حالية قبل تنفيض إجراء الحفظ
            cmdb = new SqlCommandBuilder(sqlDa);// ثم بعد ذالك أستخدم السكولكوموند بيلدر لأضع بداخله الداتا أدبتر ليعلم من هوا الخادم الذي  سيتم التعامل معه ومن هوا الذي سيتم التفعيل بداخله
            sqlDa.Update(dt);//ثم أقوم بالتحديث داخل الداتا تيبلز والداتا تيبلز مربوطة بالداتا بايندج فا أي إجراء سيتم التحديث عليه سيتم التحديث على البيانات الجاتيجوريز
            MessageBox.Show("تم الحفظ بنجاح", "عملية الإضافة والتعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BSave.Enabled = false;
            BNew.Enabled = true;
            pCAT.Text = (BmB.Position + 1) + "  /  " + BmB.Count;

            //this.dataGridView1.DataSource = dt;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CAT_Pro_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
         
            BmB.Position = 0;
            pCAT.Text = (BmB.Position + 1) + "  /  " + BmB.Count;

        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            BmB.Position = BmB.Count;
            pCAT.Text = (BmB.Position + 1) + "  /  " + BmB.Count;
        }

        private void BtnPrevi_Click(object sender, EventArgs e)
        {
            BmB.Position -= 1;
            pCAT.Text = (BmB.Position + 1) + "  /  " + BmB.Count;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            BmB.Position += 1;
            pCAT.Text = (BmB.Position + 1) + "  /  " + BmB.Count;
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            BmB.AddNew();
            BNew.Enabled = false;
            BSave.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0])+1;
            Text_ID.Text = id.ToString();
            Text_Des.Focus();
        }


        public DataTable Search_CAT(string vName)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("ID", SqlDbType.NVarChar,30);
            param[0].Value = vName;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Search_CAT", param);
            DAL.Close();
            return Dt;
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Search_CAT(Text_Search.Text);
            this.dataGridView1.DataSource = dt;
            pCAT.Text = (BmB.Position + 1) + "  /  " + BmB.Count;

            //if (Text_Search.Text != null)
            //{
            //    this.dataGridView1.CurrentRow.Cells[0].Value = Text_ID.Text;
            //    this.dataGridView1.CurrentRow.Cells[0].Value = Text_Des.Text;
            //}


        }

        private void BRef_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = dt;
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            BmB.RemoveAt(BmB.Position);
            BmB.EndCurrentEdit();//هذا الإجراء مهم وأساسي في جميع العمليات يقوم بإنهاء أي عملية حالية قبل تنفيض إجراء الحفظ
            cmdb = new SqlCommandBuilder(sqlDa);// ثم بعد ذالك أستخدم السكولكوموند بيلدر لأضع بداخله الداتا أدبتر ليعلم من هوا الخادم الذي  سيتم التعامل معه ومن هوا الذي سيتم التفعيل بداخله
            sqlDa.Update(dt);//ثم أقوم بالتحديث داخل الداتا تيبلز والداتا تيبلز مربوطة بالداتا بايندج فا أي إجراء سيتم التحديث عليه سيتم التحديث على البيانات الجاتيجوريز
            MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pCAT.Text = (BmB.Position + 1) + "  /  " + BmB.Count;


        }

        private void BPrintItem_Click(object sender, EventArgs e)
        {

            ReportL.Report_Pro C_pro = new ReportL.Report_Pro();
            ReportL.ry_GSG CP = new ReportL.ry_GSG();
            CP.SetParameterValue("@ID", Convert.ToInt32(Text_ID.Text));
            C_pro.crystalReportViewer1.ReportSource = CP;
            C_pro.ShowDialog();
           
        }

        private void BPrintAll_Click(object sender, EventArgs e)
        {
            //ReportL.ga C_pro = new ReportL.ga();
            //ReportL.CAT_Pro CP = new ReportL.CAT_Pro();
            //CP.Refresh();
            //C_pro.crystalReportViewer1.ReportSource  = CP;
            //C_pro.ShowDialog();
        }

        private void BExcel_Click(object sender, EventArgs e)
        {
            ReportL.CAT_Pro rpl = new ReportL.CAT_Pro();
   
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
            MessageBox.Show("Done", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BPDF_Click(object sender, EventArgs e)
        {
            ReportL.CAT_Pro rpl = new ReportL.CAT_Pro();
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

        private void BWord_Click(object sender, EventArgs e)
        {


            ReportL.ry_GSG rpl = new ReportL.ry_GSG();
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
            rpl.SetParameterValue("@ID", Convert.ToInt32(Text_ID.Text));
            rpl.Export();
            MessageBox.Show("Done", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ReportL.CAT_Pro rpl = new ReportL.CAT_Pro();
            ////create export options
            //ExportOptions ex = new ExportOptions();// هذا الكائن سيجعلنا نحول ونخزن هذا التقرير بإمتدادات أخرى
            //PdfRtfWordFormatOptions efo = new PdfRtfWordFormatOptions();

            ////create object for DestinationOptions 
            //DiskFileDestinationOptions ddo = new DiskFileDestinationOptions();// هذا سيجعلنا نحدد مسار التخزين

            ////set the path DestinationOptions 
            //ddo.DiskFileName = @"D:\Product.rtf";

            //// do export options
            //ex = rpl.ExportOptions;
            //ex.ExportDestinationType = ExportDestinationType.DiskFile;
            //ex.ExportFormatType = ExportFormatType.WordForWindows;
            //ex.ExportFormatOptions = efo;
            //// now i would to set this file into DestinationOptions 
            //ex.ExportDestinationOptions = ddo;
            ////the last move will save ex with rpl
            //rpl.Export();
            //MessageBox.Show("Done", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
