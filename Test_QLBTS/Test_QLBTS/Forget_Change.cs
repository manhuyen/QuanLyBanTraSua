using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Test_QLBTS
{
    public partial class Forget_Change : Form
    {
        public Forget_Change()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhap d = new DangNhap();
            this.Close();
            d.Show();
            Clear();
        }
        Bus b = new Bus();
        void Clear()
        {
            txbmatkhaumoi.Clear();
            txbsodt.Clear();
            txbtaikhoan.Clear();
            txbxacnhan.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txbmatkhaumoi.Text != txbxacnhan.Text)
            {
                MessageBox.Show("Xác nhận không khớp!");
            }
            else
            {
                if (b.Quen_Pass(txbtaikhoan.Text, txbsodt.Text, txbmatkhaumoi.Text))
                {
                    MessageBox.Show("thay đổi mật khẩu thành công");
                    b.Quen_Pass(txbtaikhoan.Text, txbsodt.Text, txbmatkhaumoi.Text);
                    Clear();

                }
                else
                {
                    MessageBox.Show("số điện thoại hoặc tên tài khoản không đúng!");
                    
                }

            }
        }
    }
}
