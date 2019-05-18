using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Test_QLBTS.ServiceReference1;

namespace Test_QLBTS
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget_Change f = new Forget_Change();
            this.Hide();
            f.Show();
        }
      //  Bus b = new Bus();
        My_QLBTSClient b = new My_QLBTSClient();
        
        private void button1_Click(object sender, EventArgs e)
        {
            int id = b.GetID(txbtaikhoan.Text, txbmatkhau.Text);
            if (id==2 || id==3)
            {
                this.Hide();
                Main m = new Main();
                m.Name_NguoiDung = b.GetName(txbtaikhoan.Text, txbmatkhau.Text);
                m._id = id;
                m._pass = b.GetPass(txbtaikhoan.Text, txbmatkhau.Text);
             
               
                m.Show();
               
                foreach (var item in this.Controls)
                {
                    var box = item as TextBox;
                    if (box != null)
                    {
                        box.Clear();
                    }
                }
               
              
            }
            else
            {
                if (id==1)
                {
                    this.Hide();
                    MainQuanLy m = new MainQuanLy();
                    m.Name_Nguoidung= b.GetName(txbtaikhoan.Text, txbmatkhau.Text);
                    m.Show();
                    foreach (var item in this.Controls)
                    {
                        var box = item as TextBox;
                        if (box != null)
                        {
                            box.Clear();
                        }
                    }
                  
               
                }
                else
                {
                    MessageBox.Show("tai khoan hoac mat khau sai!");
                }

            }

        }
    }
}
