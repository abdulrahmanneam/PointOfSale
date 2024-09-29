using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PointOfSale.BL
{
    class ClS_LOGIN
    {
      
        public DataTable LOGIN(string ID , string PAS)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("UserName", SqlDbType.NVarChar, -1);
            param[0].Value = ID;
            param[1] = new SqlParameter("PAS", SqlDbType.NVarChar, 50);
            param[1].Value = PAS;

           
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_LOGIN", param);
            DAL.Close();
            return dt;

        }

        public void Add_User(string pFirst_Name, string pLast_Name, string idC, string Ad, string phone, string Pw, byte[] pImage , string Type)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID_USER", SqlDbType.NVarChar, 50);
            param[0].Value = pFirst_Name;
            param[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, -1);
            param[1].Value = pLast_Name;
            param[2] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[2].Value = idC;
            param[3] = new SqlParameter("@Addr", SqlDbType.NVarChar, 50);
            param[3].Value = Ad;
            param[4] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
            param[4].Value = phone;
            param[5] = new SqlParameter("@PAS", SqlDbType.NVarChar, 50);
            param[5].Value = Pw;
            param[6] = new SqlParameter("Image", SqlDbType.Image);
            param[6].Value = pImage;
            param[7] = new SqlParameter("@UserType", SqlDbType.NVarChar, -1);
            param[7].Value = Type;
            DAL.ExecuteCommand("Add_User", param);
            DAL.Close();
        }

        public void Edit_User(string pFirst_Name, string pLast_Name, string idC, string Ad, string phone, string Pw, byte[] pImage, string Type)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID_USER", SqlDbType.NVarChar, 50);
            param[0].Value = pFirst_Name;
            param[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, -1);
            param[1].Value = pLast_Name;
            param[2] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[2].Value = idC;
            param[3] = new SqlParameter("@Addr", SqlDbType.NVarChar, 50);
            param[3].Value = Ad;
            param[4] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
            param[4].Value = phone;
            param[5] = new SqlParameter("@PAS", SqlDbType.NVarChar, 50);
            param[5].Value = Pw;
            param[6] = new SqlParameter("Image", SqlDbType.Image);
            param[6].Value = pImage;
            param[7] = new SqlParameter("@UserType", SqlDbType.NVarChar, -1);
            param[7].Value = Type;
            DAL.ExecuteCommand("Edit_User", param);
            DAL.Close();
        }
        public DataTable SearchUsers(string cra)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("cra", SqlDbType.VarChar, 50);
            param[0].Value = cra;


            Dt = DAL.SelectData("SearchUsers", param);
            DAL.Close();
            return Dt;
        }
    }
}
