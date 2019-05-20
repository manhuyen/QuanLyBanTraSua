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
    public partial class MainQuanLy : Form
    {
        User u = new User();
        public MainQuanLy()
        {
            
            InitializeComponent();
          
        }
        public string Name_Nguoidung
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
            textBox1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPhieunhap_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            PhieuNhap m = new PhieuNhap();
            panel4.Controls.Add(m);
        }
    }
}
