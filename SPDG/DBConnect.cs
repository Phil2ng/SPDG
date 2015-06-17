using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SPDG
{
    class DBConnect
    {
        public static SqlConnection con()
        {
            String ConStr = "Data Source=.;Initial Catalog=SPDG;Integrated Security=True";
            return new SqlConnection(ConStr);
        }
    }
}
