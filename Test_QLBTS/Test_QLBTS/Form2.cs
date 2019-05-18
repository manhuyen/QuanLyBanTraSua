using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace Test_QLBTS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-I0HUN56\\MSSQLSERVER1;Initial Catalog=ThucTapNhom_QLBTS;Integrated Security=True");
            
            DataTable dt = new DataTable("m");
            SqlCommand sqlCommand = new SqlCommand("Select * from Douong", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
