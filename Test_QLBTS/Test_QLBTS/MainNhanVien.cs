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
    public partial class Main : Form
    {
        private int id;
        private string pass;
        
        public Main()
        {
            InitializeComponent();  
        }
        
        public string Name_NguoiDung
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _pass
        {
            get { return pass; }
            set { pass = value; }
        }


        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
            textBox1.Clear();
           
        }

        private void btmenu_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Menu m = new Menu();
            panel3.Controls.Add(m);
            
        }

        private void btthanhvien_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            ThanhVien t = new ThanhVien();
            panel3.Controls.Add(t);

        }

        private void bttinhtien_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            TinhTien t = new TinhTien();
            panel3.Controls.Add(t);
        }

        private void btdiscount_Click(object sender, EventArgs e)
        {

            Order_ThanhToan order_ThanhToan = new Order_ThanhToan();
            order_ThanhToan.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Change_Pass c = new Change_Pass();
            c._id = _id;
            c._pass = _pass;
            c.Show();
        }
    }
}
