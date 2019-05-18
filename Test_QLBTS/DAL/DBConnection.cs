using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnection
    {
        protected SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-I0HUN56\\MSSQLSERVER1;Initial Catalog=ThucTapNhom_QLBTS;Integrated Security=True");
    }
}
