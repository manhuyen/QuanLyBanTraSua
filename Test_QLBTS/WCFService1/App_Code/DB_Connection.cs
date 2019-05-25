using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DB_Connection
/// </summary>
public class DB_Connection
{ 
    protected SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-I0HUN56\\MSSQLSERVER1;Initial Catalog=N5_T3_QLBanTraSua;Integrated Security=True");
}