using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PointOfSale.DAL
{
    
    class DATAACCESSLAYER
    {

        public static SqlConnection conn = null;

        //This Constructor Inisialize The Connection Object
        //يقوم بإستنساخ الكائن المشيد وهوا سكيل كونكشين
        public DATAACCESSLAYER()
        {
            conn  = new SqlConnection(@"Data Source=DESKTOP-1BB8SQP\SQLEXPRESS; Initial Catalog=POS; Integrated Security=true");
            conn.Open();
        }
        //method to open the connection
        public void Open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }
        //method to close the connection
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
              conn.Close();
            }
        }
        //method to read Data from DataBase
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.CommandText = stored_procedure;
            Sqlcmd.Connection = conn;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    Sqlcmd.Parameters.Add(param[i]);// they do same object  هم يفعلون نفس الغرض
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(Sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //method to Insert , Update , Delete Data From DataBase
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.CommandText = stored_procedure;
            Sqlcmd.Connection = conn;
            if (param != null)
            {
                Sqlcmd.Parameters.AddRange(param);
            }// they do same object  هم يفعلون نفس الغرض

            try
            {
                Sqlcmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("تفقد عملية الإدخال ", "تنبيه!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
