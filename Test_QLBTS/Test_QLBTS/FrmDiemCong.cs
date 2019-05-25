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

namespace Test_QLBTS
{
    public partial class FrmDiemCong : Form
    {
        public FrmDiemCong()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double a,b,c,d,f;
            
            b = Convert.ToDouble(txbsotienKhdua.Text);
            c = Convert.ToDouble(txbtongtienhoadon.Text);
            d=    Convert.ToDouble(txbdiscount.Text);
            a = b - c * d;
            f = c * d;
            if(f <50000)
            {
                txbdiemcong.Text = "10";
            }
            else
            {
                if(f>=50000 && f<=100000) txbdiemcong.Text = "100";
                if(f>=100000) txbdiemcong.Text = "150";

            }
            txbsotienthua.Text = Convert.ToString(a);
            txbthanhtien.Text = Convert.ToString(f);
             SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-I0HUN56\\MSSQLSERVER1;Initial Catalog=N5_T3_QLBanTraSua;Integrated Security=True");
            //DataTable dt = new DataTable();
            //string query = "INSERT INTO Hoadon(soHD,discount,tongtienKHtra,sotienKHdua,sotienthua,ngaymua,sogiomua,diemcong,MaKM,MaTV) VALUES(" + txbsoHD.Text + "," + txbdiscount.Text + "," + txbthanhtien + "," + txbsotienKhdua.Text + "," + txbsotienthua.Text + ",'" + txbngaymua.Text + "','" + txbgiomua.Text + "'," + txbdiemcong.Text + ",null,'" + txbmatv.Text + "')";

            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //sqlDataAdapter.Fill(dt);
            DataTable dt1 = new DataTable();
            string query1 = $"update Thanhvien set diemtichluy=diemtichluy+{txbdiemcong.Text} where MaTV=N'{txbmatv.Text}' ";

            SqlCommand sqlCommand1 = new SqlCommand(query1, sqlConnection);
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
            sqlDataAdapter1.Fill(dt1);




        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
