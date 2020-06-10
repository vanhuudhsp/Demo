using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLDATBAO
{
    class Modules
    {
        public static string cnnStr = "Data Source=.;Initial Catalog=QLDATBAO;Integrated Security=True";
        public SqlConnection getConnection
        {
            get
            {
                return new SqlConnection(cnnStr);
            }
        }
    }
}
