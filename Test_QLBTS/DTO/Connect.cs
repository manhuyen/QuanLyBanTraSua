﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Connect
    {
        public SqlConnection sqlconnection;
<<<<<<< HEAD
        public string connnect = "Data Source=DESKTOP-0GB6OIM\\SQLEXPRESS;Initial Catalog=ThucTapNhom_QLBTS;Integrated Security=True";
=======
        public string connnect = "Data Source=DESKTOP-I0HUN56\\MSSQLSERVER1;Initial Catalog=N5_T3_QLBanTraSua;Integrated Security=True";
>>>>>>> 0c83102fb98aeae84cd240e4f395ee33f7769504
        public Connect()
        {
            if (sqlconnection != null && sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
            else if (sqlconnection == null)
            {
                sqlconnection = new SqlConnection(connnect);
                sqlconnection.Open();
            }
        }
        public void Get_Table(string query, DataTable dataTable)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlconnection);
            dataAdapter.Fill(dataTable);

        }
        public DataTable Get_Table1(string query, DataTable dataTable)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlconnection);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void ExcuteNonQuery(string query)
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            sqlconnection.Close();
        }

}
}
