using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PointOfSale.BL
{
    class CLS_activation
    {
        public DataTable Activ(string ID, string PAS)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("ID_AC", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            param[1] = new SqlParameter("PAS", SqlDbType.NVarChar, 50);
            param[1].Value = PAS;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SPr_LOGIN", param);
            DAL.Close();
            return dt;

        }

    }
}
