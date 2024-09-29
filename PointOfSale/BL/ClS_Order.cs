using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PointOfSale.BL
{
    class ClS_Order
    {
       
        public DataTable GET_LAT_ORDId()
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAT_ORDId", null);
            DAL.Close();
            return Dt;
        }
        public DataTable GET_LAT_ORDIdfp()
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAT_ORDIdforPr", null);
            DAL.Close();
            return Dt;
        }
        public void Add_ord(int idord, DateTime datetime, int cus, string dis, string salu)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("ID_ORD", SqlDbType.Int);
            param[0].Value = idord;
            param[1] = new SqlParameter("Date", SqlDbType.DateTime);
            param[1].Value = datetime;
            param[2] = new SqlParameter("ID_CUS", SqlDbType.Int);
            param[2].Value = cus;
            param[3] = new SqlParameter("Descrepion", SqlDbType.NVarChar, -1);
            param[3].Value = dis;
            param[4] = new SqlParameter("Sales_User", SqlDbType.NVarChar, -1);
            param[4].Value = salu;

            DAL.ExecuteCommand("ADD_ORDER", param);
            DAL.Close();
        }
        public void Add_ord_D(string idpro ,int idord, int Qty, string Price, float dis, string am,string Tam)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("ID_PRO", SqlDbType.NVarChar, -1);
            param[0].Value = idpro;
            param[1] = new SqlParameter("ID_ORD", SqlDbType.Int);
            param[1].Value = idord;
            param[2] = new SqlParameter("Quantity", SqlDbType.Int);
            param[2].Value = Qty;
            param[3] = new SqlParameter("Price", SqlDbType.NVarChar, -1);
            param[3].Value = Price;
            param[4] = new SqlParameter("Amount", SqlDbType.Float);
            param[4].Value = dis; 
             param[5] = new SqlParameter("Discount", SqlDbType.NVarChar, -1);
            param[5].Value = am;
            param[6] = new SqlParameter("TotalAmount", SqlDbType.NVarChar, -1);
            param[6].Value = Tam;

            DAL.ExecuteCommand("ADD_ORDER_D", param);
            DAL.Close();
        }
        public DataTable Ve_Qty(string idpro, int Qty )
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("Id_Pro", SqlDbType.NVarChar,-1);
            param[0].Value = idpro;
            param[1] = new SqlParameter("QTY", SqlDbType.Int);
            param[1].Value = Qty;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("veQTY", param);
            DAL.Close();
            return Dt;
        }
        public DataTable GLO(int idord)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            //DataTable Dt = new DataTable();

            //using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-LCRKM5P\SQLEXPRESS; Initial Catalog=POS; Integrated Security=true"))
            //{
            //    connection.Open();

            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.CommandText = "GET_ORDER_Deti";
            //        cmd.Connection = connection; // قم بتعيين الاتصال للأمر

            //        // إضافة المعاملة
            //        cmd.Parameters.Add(new SqlParameter("ID_ORDd", SqlDbType.Int)).Value = idord;

            //        Dt.Load(cmd.ExecuteReader());
            //    }

            //    connection.Close();
            //}

            //return Dt;
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("ID_ORDd", SqlDbType.Int);
            param[0].Value = idord;


            Dt = DAL.SelectData("GET_ORDER_Deti", param);
            DAL.Close();
            return Dt;
        }
        public DataTable reportOrder(string crt)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
          
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("crt", SqlDbType.VarChar,50);
            param[0].Value = crt;


            Dt = DAL.SelectData("reportOrder", param);
            DAL.Close();
            return Dt;
        }
    }

}
//public string ID_PRO { get; set; }
//public int Quantity { get; set; }
//public string Price { get; set; }
//public int Amount { get; set; }
//public string Discount { get; set; }
//public string TotalAmount { get; set; }