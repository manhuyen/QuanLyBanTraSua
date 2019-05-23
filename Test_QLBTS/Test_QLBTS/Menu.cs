using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
using Test_QLBTS.ServiceReference1;
namespace Test_QLBTS
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        My_QLBTSClient b = new My_QLBTSClient();
        void Clear()
        {
            txbgia.Clear();
            txbhinhanh.Clear();
            txbtendu.Clear();
            combSize.Text = "";
            combLoaidu.Text = "";
        }
        void Clear2()
        {
            txbgiatopping.Clear();
            txbimage.Clear();
            txbMaTopping.Clear();
            txbTenTopping.Clear();
        }
        private void Menu_Load(object sender, EventArgs e)
        {      
                 dataGridView1.DataSource = null;
                dataGridView1.DataSource = b.Xem_DoUong();
             dataGridView2.DataSource = null;
            dataGridView2.DataSource = b.Xem_Topping();

        }
      //  Bus b = new Bus();


        private void btopen_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {

                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = img;


            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox2.Image = img;
                // Gán ảnh

            }

        }
        Menu_DU m = new Menu_DU();
        List<string> l = new List<string>();
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            
            if (combLoaidu.Text=="")
            {
                MessageBox.Show("Mời Bạn Nhập Dữ Liệu");
                return;
            }
            else
            {
                pictureBox1.Image = null;
                MessageBox.Show("Thêm Thành Công!");
                l.Add("1.Milk tea");
                l.Add("2.Fresh Fruit Tea");
                l.Add("3.Macchiato");
                l.Add("4.Handmade Freeze");
                l.Add("5.Special Drink");
                l.Add("6.Chè");
                l.Add("7.Fresh Fruit");
                l.Add("8.Macchi");
                l.Add("9.Handmade");
                l.Add("10.Drink");
                for (int i = 0; i < 10; i++)
                {
                    if (combLoaidu.Text == l[i])
                    {
                        m._maloai = i + 1;
                    }
                }
                m._image = txbhinhanh.Text;
                m._tendu = txbtendu.Text;
                m._size = combSize.Text;
                m._dongia =Convert.ToDouble( txbgia.Text);
                b.Them_DoUong(m._tendu,m._size,m._dongia,m._maloai,m._image);
                Clear();
                 dataGridView1.DataSource = null;
                dataGridView1.DataSource = b.Xem_DoUong();

            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Đồ Uống  Này?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pictureBox1.Image = null;
                int madu = Convert.ToInt16(dataGridView1.CurrentRow.Cells["STT"].Value.ToString());
                b.Xoa_DoUong(madu);
                 dataGridView1.DataSource = null;
                dataGridView1.DataSource = b.Xem_DoUong();
            }
            else
            {
                return;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txbgia.Text = dataGridView1.CurrentRow.Cells["Gía Bán"].Value.ToString();
            txbhinhanh.Text = dataGridView1.CurrentRow.Cells["Image"].Value.ToString();
            txbtendu.Text = dataGridView1.CurrentRow.Cells["Tên Đồ Uống"].Value.ToString();
            combLoaidu.Text = dataGridView1.CurrentRow.Cells["Tên Loại"].Value.ToString();
            combSize.Text = dataGridView1.CurrentRow.Cells["size"].Value.ToString();
            m._madu =Convert.ToInt16(dataGridView1.CurrentRow.Cells["STT"].Value.ToString());

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (combLoaidu.Text == "")
            {
                return;
            }
            else
            {
                MessageBox.Show("Lưu thành công!");
                l.Add("1.Milk tea");
                l.Add("2.Fresh Fruit Tea");
                l.Add("3.Macchiato");
                l.Add("4.Handmade Freeze");
                l.Add("5.Special Drink");
                l.Add("6.Chè");
                l.Add("7.Fresh Fruit");
                l.Add("8.Macchi");
                l.Add("9.Handmade");
                l.Add("10.Drink");
                for (int i = 0; i < 10; i++)
                {
                    if (combLoaidu.Text == l[i])
                    {
                        m._maloai = i + 1;
                    }
                }
                m._loaidu = combLoaidu.Text;
                m._tendu = txbtendu.Text;
                m._size = combSize.Text;
                m._dongia =Convert.ToDouble( txbgia.Text);
                m._image = txbhinhanh.Text;
                b.Sua_DoUong(m._madu,m._loaidu,m._tendu, m._size, m._dongia, m._maloai, m._image);  
                 dataGridView1.DataSource = null;
                dataGridView1.DataSource = b.Xem_DoUong();
                Clear();

            }

        }

        private void btImage_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                string check = dataGridView1.CurrentRow.Cells["Image"].Value.ToString();
                pictureBox1.Image = new Bitmap(@"C:\Users\ADMIN\source\repos\Test_QLBTS\Test_QLBTS\Resources\" + check);
            }
            catch
            {
                MessageBox.Show("Not Image!");
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Topping  Này?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pictureBox2.Image = null;
                m._matopping = dataGridView2.CurrentRow.Cells["MaTopping"].Value.ToString();
                b.Xoa_Topping(m._matopping);
                 dataGridView2.DataSource = null;
                dataGridView2.DataSource = b.Xem_Topping();
            }
            else
            {
                return;
            }

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (txbMaTopping.Text == "")
            {
                MessageBox.Show("Mời bạn nhập dữ liệu!");
                return;
            }
            else
            {
                if (b.Check_Topping(txbMaTopping.Text) == false)
                {
                    MessageBox.Show("Ma da ton tai!");
                }
                else
                {
                    MessageBox.Show("Thêm Thành Công!");
                    pictureBox2.Image = null;
                    m._matopping = txbMaTopping.Text;
                    m._tentopping = txbTenTopping.Text;
                    m._gia = Convert.ToDouble(txbgiatopping.Text);
                    m._image = txbimage.Text;
                    b.Them_Topping(m._matopping, m._tentopping, m._gia, m._image);
                    Clear2();
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = b.Xem_Topping();
                }
            }

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            txbMaTopping.Text = dataGridView2.CurrentRow.Cells["MaTopping"].Value.ToString();
            txbTenTopping.Text= dataGridView2.CurrentRow.Cells["tentopping"].Value.ToString();
            txbgiatopping.Text= dataGridView2.CurrentRow.Cells["giatopping"].Value.ToString();
            txbimage.Text = dataGridView2.CurrentRow.Cells["HinhAnh"].Value.ToString();
        }

        private void toolStrip7_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (txbMaTopping.Text == "")
            {
                return;
            }
            else
            {
                MessageBox.Show("lưu Thành Công!");
                pictureBox2.Image = null;
                m._matopping = txbMaTopping.Text;
                m._tentopping = txbTenTopping.Text;
                m._gia = Convert.ToDouble(txbgiatopping.Text);
                m._image = txbimage.Text;
                 
                b.Sua_Topping(m._matopping, m._tentopping, m._gia, m._image);
                Clear2();
                 dataGridView2.DataSource = null;
                dataGridView2.DataSource = b.Xem_Topping();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Image = null;
                string check = dataGridView2.CurrentRow.Cells["HinhAnh"].Value.ToString();
                pictureBox2.Image = new Bitmap(@"C:\Users\ADMIN\source\repos\Test_QLBTS\Test_QLBTS\Resources\" + check);
            }
            catch
            {
                MessageBox.Show("Not Image!");
            }
        }

        private void Txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            string query = " select MaDU as STT, tendu as N'Tên Đồ Uống',LoaiDU.Maloai as N'Mã Loại',tenloai as N'Tên Loại',size,dongia as 'Gía Bán',HinhAnh as N'Image' from Douong,LoaiDU where Douong.Maloai=LoaiDU.Maloai and tenDU like N'%" + txbtimkiem.Text + "%'";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = b.Xem_TuyTron(query);
        }

        private void Txbtimkiemtopping_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Topping where tentopping like N'%" + txbtimkiemtopping.Text+ "%'";

            dataGridView2.DataSource = null;

            dataGridView2.DataSource = b.Xem_TuyTron(query);
            
           
        }
    }
}
