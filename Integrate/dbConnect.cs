using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrate
{
    class dbConnect
    {
        SqlDataAdapter sqlDataAdapter;


        //public string connString = ConfigurationManager.ConnectionStrings["DBConn"].ToString();

        public SqlConnection sqlConnect = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ToString());
        
        public SqlDataAdapter GridView(string sqlQry)
        {
            sqlDataAdapter = new SqlDataAdapter(sqlQry, sqlConnect);

            return sqlDataAdapter;
        }
    }
}
