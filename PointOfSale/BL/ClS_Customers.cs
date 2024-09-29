using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PointOfSale.BL
{
    class ClS_Customers
    {
        public DataTable GET_ALL_CSU()
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CSU", null);
            DAL.Close();
            return Dt;
        }
        public void Add_Customers(string pFirst_Name, string pLast_Name, string pPhone, string pEmail, byte[] pImage)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("First_Name", SqlDbType.NVarChar, -1);
            param[0].Value = pFirst_Name;
            param[1] = new SqlParameter("Last_Name", SqlDbType.NVarChar, -1);
            param[1].Value = pLast_Name;
            param[2] = new SqlParameter("Phone", SqlDbType.NChar, 15);
            param[2].Value = pPhone;
            param[3] = new SqlParameter("Email", SqlDbType.NVarChar, -1);
            param[3].Value = pEmail;
            param[4] = new SqlParameter("Image", SqlDbType.Image);
            param[4].Value = pImage;
            
            DAL.ExecuteCommand("ADD_CUS", param);
            DAL.Close();
        }
        public void Edit_Customers(string pFirst_Name, string pLast_Name, string pPhone, string pEmail, byte[] pImage,int id)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("First_Name", SqlDbType.NVarChar, -1);
            param[0].Value = pFirst_Name;
            param[1] = new SqlParameter("Last_Name", SqlDbType.NVarChar, -1);
            param[1].Value = pLast_Name;
            param[2] = new SqlParameter("Phone", SqlDbType.NChar, 15);
            param[2].Value = pPhone;
            param[3] = new SqlParameter("Email", SqlDbType.NVarChar, -1);
            param[3].Value = pEmail;
            param[4] = new SqlParameter("Image", SqlDbType.Image);
            param[4].Value = pImage;
            param[5] = new SqlParameter("ID", SqlDbType.Int);
            param[5].Value = id;

            DAL.ExecuteCommand("EDIT_CUS", param);
            DAL.Close();
        }
        public void Delete_Customers( int id)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("ID", SqlDbType.Int);
            param[0].Value = id;

            DAL.ExecuteCommand("Delete_CUS", param);
            DAL.Close();
        }

        public DataTable Search_CUS(string Criterion)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();

            DataTable Dt = new DataTable();
            //SqlParameter param = new SqlParameter("@criterion", SqlDbType.NVarChar, 50);// راجع السطر ده الهيفهمك الإجراء المخزن
            //param.Value = Criterion;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("criterion", SqlDbType.NVarChar, -1);
            param[0].Value = Criterion;
            Dt = DAL.SelectData("Search_CUS", param);
            DAL.Close();
            return Dt;
        }
    }
}
