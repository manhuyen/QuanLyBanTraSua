﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Test_QLBTS
{
    public partial class TinhTien : UserControl
    {
        public TinhTien()
        {
            InitializeComponent();
        }

        private void TinhTien_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //SqlConnection sqlConnection = new SqlConnection(";Initial Catalog=N5_T3_QLBanTraSua;Integrated Security=True");
            //sqlConnection.Open();

            //string query = "select * from HoaDon";
            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //sqlDataAdapter.Fill(dt);
            //dataGridView1.DataSource = dt;
            //sqlConnection.Close();
        }
    }
}
