using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace Test_QLBTS
{
    public partial class Order_ThanhToan : Form
    {
        public Order_ThanhToan()
        {
            InitializeComponent();
        }
        public void Tinhtien()
        {
            int totalprice = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                if (dataGridView3.Rows[i].Cells[1].Value != null)
                {
                    dataGridView3.Rows[i].Cells[1].Value = Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value) * Convert.ToInt32(dataGridView3.Rows[i].Cells[8].Value);
                }
                totalprice += Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value) + Convert.ToInt32(dataGridView3.Rows[i].Cells[3].Value);
            }

            textBox1.Text = totalprice.ToString();
        }
        private void Order_ThanhToan_Load(object sender, EventArgs e)
        {
            string query = "select madu,tenDU,dongia from Douong";
            Connect connect = new Connect();
            DataTable dt = new DataTable();
            connect.Get_Table(query, dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = false;
                dataGridView1.Rows[n].Cells[1].Value = item["tenDU"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["dongia"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["madu"].ToString();

            }
            string query2 = "select matopping,tentopping, giatopping from Topping";
            DataTable dt1 = new DataTable();
            connect.Get_Table(query2, dt1);
            foreach (DataRow item in dt1.Rows)
            {
                int n1 = dataGridView2.Rows.Add();
                dataGridView2.Rows[n1].Cells[0].Value = false;
                dataGridView2.Rows[n1].Cells[1].Value = item["tentopping"].ToString();
                dataGridView2.Rows[n1].Cells[2].Value = item["giatopping"].ToString();
                dataGridView2.Rows[n1].Cells[3].Value = item["matopping"].ToString();
            }

            // Dòng code chuyển dữ liệu từ sql vào textbox sử dụng Databindings
            //txtsoHD.DataBindings.Add("Text", dt2, "column1", true);
        }

        private void btnchondo_Click(object sender, EventArgs e)
        {

            int kiemtra = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {

                if ((bool)item.Cells[0].Value == true)
                {
                    kiemtra = kiemtra + 1;
                }
            }
            if (kiemtra == 0)
            {
                MessageBox.Show("Bạn phải chọn đồ uống trước sau đó mới được order topping ^^");

            }
            else if(kiemtra!=0)
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {

                    if ((bool)item.Cells[0].Value == true)
                    {
                        int n = dataGridView3.Rows.Add();
                        dataGridView3.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                        dataGridView3.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                        dataGridView3.Rows[n].Cells[9].Value = item.Cells[6].Value.ToString();

                        if (item.Cells[3].Value == null)
                        {
                            dataGridView3.Rows[n].Cells[4].Value = "";
                        }
                        else
                        {
                            dataGridView3.Rows[n].Cells[4].Value = item.Cells[3].Value.ToString();

                        }
                        if (item.Cells[4].Value == null)
                        {
                            dataGridView3.Rows[n].Cells[5].Value = "";

                        }
                        else
                        {
                            dataGridView3.Rows[n].Cells[5].Value = item.Cells[4].Value.ToString();

                        }
                        if (item.Cells[5].Value == null)
                        {
                            dataGridView3.Rows[n].Cells[8].Value = "1";
                        }
                        else
                        {
                            dataGridView3.Rows[n].Cells[8].Value = item.Cells[5].Value.ToString();

                        }
                    }


                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = false;
                }
                foreach (DataGridViewRow item in dataGridView2.Rows)
                {

                    if ((bool)item.Cells[0].Value == true)
                    {
                        int n = dataGridView3.Rows.Add();
                        if (dataGridView3.Rows[n - 1].Cells[2].Value == null)
                        {
                            dataGridView3.Rows[n - 1].Cells[2].Value = item.Cells[1].Value.ToString();
                            dataGridView3.Rows[n - 1].Cells[3].Value = item.Cells[2].Value.ToString();
                            dataGridView3.Rows[n - 1].Cells[10].Value = item.Cells[3].Value.ToString();
                        }

                    }

                }
                // Reset lại các ô select
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    dataGridView2.Rows[i].Cells[0].Value = false;
                }
                // Tính tiền
                Tinhtien();
                // xóa dòng thừa
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    if (dataGridView3.Rows[i].Cells[0].Value == null && dataGridView3.Rows[i].Cells[2].Value == null)
                    {
                        dataGridView3.Rows.RemoveAt(i);
                    }

                }
            }
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            //int totalprice = 0;
            //for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            //{

            //    totalprice += Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value) + Convert.ToInt32(dataGridView3.Rows[i].Cells[3].Value);
            //}

            //textBox1.Text = totalprice.ToString();
            textBox1.Text = 0.ToString();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Tinhtien();
            double a = double.Parse(textBox1.Text) - (double.Parse(textBox1.Text) * 0.2);
            textBox1.Text = a.ToString();
            txtdiscount.Text = 0.2.ToString();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            Tinhtien();
            double a = double.Parse(textBox1.Text) - (double.Parse(textBox1.Text) * 0.5);
            textBox1.Text = a.ToString();
            txtdiscount.Text = 0.5.ToString();
        }

        private void btn75_Click(object sender, EventArgs e)
        {
            Tinhtien();
            double a = double.Parse(textBox1.Text) - (double.Parse(textBox1.Text) * 0.75);
            textBox1.Text = a.ToString();
            txtdiscount.Text = 0.75.ToString();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            Tinhtien();
            double a = double.Parse(textBox1.Text) - (double.Parse(textBox1.Text) * 1);
            textBox1.Text = a.ToString();
            txtdiscount.Text = 1.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int totalprice = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                if (dataGridView3.Rows[i].Cells[6].Selected == true && dataGridView3.Rows[i].Cells[1].Value != null)
                {
                    dataGridView3.Rows[i].Cells[1].Value = Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value) + 9000;

                }
            }
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                if (dataGridView3.Rows[i].Cells[7].Selected == true && dataGridView3.Rows[i].Cells[1].Value != null)
                {
                    dataGridView3.Rows[i].Cells[1].Value = Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value) - 9000;

                }
            }
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                totalprice += Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value) + Convert.ToInt32(dataGridView3.Rows[i].Cells[3].Value);
            }
            textBox1.Text = totalprice.ToString();
        }

        private void dataGridView3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow data in dataGridView3.SelectedRows)
                {
                    dataGridView3.Rows.Remove(data);
                }
                int totalprice = 0;
                for (int i = 0; i < dataGridView3.Rows.Count; ++i)
                {

                    totalprice += Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value) + Convert.ToInt32(dataGridView3.Rows[i].Cells[3].Value);
                }

                textBox1.Text = totalprice.ToString();
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
           
            Connect connect = new Connect();
            string query3 = "SELECT sohd FROM dbo.HoaDon";
            DataTable dt2 = new DataTable();
            connect.Get_Table(query3, dt2);
            foreach (DataRow row in dt2.Rows)
            {
                int n = dataGridView4.Rows.Add();
                dataGridView4.Rows[n].Cells[0].Value = row["sohd"].ToString();
            }
            // Lấy số hóa đơn tự động
            int a = dataGridView4.Rows.Count;

            ////txtsoHD.Text = (a + 1).ToString();

            txtsoHD.Text = (Convert.ToInt32(dataGridView4.Rows[a - 2].Cells[0].Value) + 1).ToString();

            if (txtsotienKhdua.Text == "")
            {
                MessageBox.Show("Nhập số tiền khách hàng đưa !");
            }
            else if (txtsotienKhdua.Text != null)
            {
                txtsotienthua.Text = (Convert.ToInt32(txtsotienKhdua.Text) - Convert.ToInt32(textBox1.Text)).ToString();

                if (Convert.ToInt32(textBox1.Text) > 200000)
                {
                    txtdiemcong.Text = 17.ToString();
                }
                else if (Convert.ToInt32(textBox1.Text) >= 200000)
                {
                    txtdiemcong.Text = 15.ToString();
                }
                else if (Convert.ToInt32(textBox1.Text) >= 100000)
                {
                    txtdiemcong.Text = 10.ToString();
                }
                else if (Convert.ToInt32(textBox1.Text) >= 50000)
                {
                    txtdiemcong.Text = 5.ToString();
                }
                else if (Convert.ToInt32(textBox1.Text) < 50000)
                {
                    txtdiemcong.Text = 0.ToString();
                }
                txtngaymua.Text = DateTime.Today.ToString();

                txtgiomua.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

                string query = "INSERT INTO Hoadon(soHD,discount,tongtienKHtra,sotienKHdua,sotienthua,ngaymua,sogiomua,diemcong) VALUES('" + txtsoHD.Text + "','" + txtdiscount.Text + "','" + textBox1.Text + "','" + txtsotienKhdua.Text + "','" + txtsotienthua.Text + "','" + txtngaymua.Text + "','" + txtgiomua.Text + "','" + txtdiemcong.Text + "')";
                connect.ExcuteNonQuery(query);
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    if (dataGridView3.Rows[i].Cells[0].Value != null)
                    {

                        string query1 = "insert into DongHD(sohd,soluong,madu,matopping) values ('" + txtsoHD.Text + "','" + dataGridView3.Rows[i].Cells[8].Value + "','" + dataGridView3.Rows[i].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "')";
                        connect.ExcuteNonQuery(query1);
                    }
                    else
                    {
                        string query2 = "insert into DongHD(sohd,soluong,madu,matopping) values ('" + txtsoHD.Text + "','" + dataGridView3.Rows[i - 1].Cells[8].Value + "','" + dataGridView3.Rows[i - 1].Cells[9].Value + "','" + dataGridView3.Rows[i].Cells[10].Value + "')";
                        connect.ExcuteNonQuery(query2);
                    }


                }
            }
            dataGridView4.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
