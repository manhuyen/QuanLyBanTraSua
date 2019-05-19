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
        protected SqlConnection sqlConnection = new SqlConnection("Data Source=DINHDAN-PC;Initial Catalog=ThucTapNhom_QLBTS;Integrated Security=True");
    }
}
