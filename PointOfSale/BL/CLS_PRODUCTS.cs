using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PointOfSale.BL
{
    class CLS_PRODUCTS
    {
        public DataTable GET_ALL_GATEGORIES()
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
        
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_GATEGORIES", null);
            DAL.Close();
            return Dt;
        }

        public void Add_Product(string Name, string Des, int Qty, string Price, byte [] Image, int ID_Cat)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("ID_PRO", SqlDbType.NVarChar, 30);
            param[0].Value = Name;
            param[1] = new SqlParameter("Name", SqlDbType.NVarChar, -1);
            param[1].Value = Des;
            param[2] = new SqlParameter("Quantity", SqlDbType.Int);
            param[2].Value = Qty;
            param[3] = new SqlParameter("Price", SqlDbType.NVarChar, -1);
            param[3].Value = Price;
            param[4] = new SqlParameter("Image", SqlDbType.Image);
            param[4].Value = Image;
            param[5] = new SqlParameter("ID_CAT", SqlDbType.Int);
            param[5].Value = ID_Cat;
            DAL.ExecuteCommand("ADD_PRO", param);
            DAL.Close();
        }
        public DataTable VP_ID(string vName)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("ID", SqlDbType.NVarChar, 30);
            param[0].Value = vName;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("VP_ID", param);
            DAL.Close();
            return Dt;
        }
        public DataTable GET_ALL_Pro()
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_Pro", null);
            DAL.Close();
            return Dt;
        }
        public DataTable Search_Pro(string vName)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("ID", SqlDbType.NVarChar, 30);
            param[0].Value = vName;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Search_Pro", param);
            DAL.Close();
            return Dt;
        }

        public void Delete_Pro(string ID_D)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar,30);
            param[0].Value = ID_D;
         
            DAL.ExecuteCommand("Delete_Pro", param);
            DAL.Close();
        }
       

            public DataTable Get_Image_Pro(string vName)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("ID", SqlDbType.NVarChar, 30);
            param[0].Value = vName;
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_Image_Pro", param);
            DAL.Close();
            return Dt;
        }
        public void Edit_pro(string Name, string Des, int Qty, string Price, byte[] Image, int ID_Cat)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("ID_PRO", SqlDbType.NVarChar, 30);
            param[0].Value = Name;
            param[1] = new SqlParameter("Name", SqlDbType.NVarChar, -1);
            param[1].Value = Des;
            param[2] = new SqlParameter("Quantity", SqlDbType.Int);
            param[2].Value = Qty;
            param[3] = new SqlParameter("Price", SqlDbType.NVarChar, -1);
            param[3].Value = Price;
            param[4] = new SqlParameter("Image", SqlDbType.Image);
            param[4].Value = Image;
            param[5] = new SqlParameter("ID_CAT", SqlDbType.Int);
            param[5].Value = ID_Cat;
            DAL.ExecuteCommand("Edit_pro", param);
            DAL.Close();
        }
    }
}
