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
using Test_QLBTS.ServiceReference1;
namespace Test_QLBTS
{
    public partial class Change_Pass : Form
    {
        public Change_Pass()
        {
            InitializeComponent();
        }
        private string pass;
        private int id;
        public string _pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        void clear()
        {
            txbmkcu.Clear();
            txbmkmoi.Clear();
            txbXacnhanmk.Clear();
        }
      //  Bus b = new Bus();
        My_QLBTSClient b = new My_QLBTSClient();
        private void button1_Click(object sender, EventArgs e)
        {

            if (txbmkcu.Text != _pass)
            {
                MessageBox.Show("mật khẩu cũ không đúng!");
            }
            else
            {
                if (txbmkmoi.Text != txbXacnhanmk.Text)
                {
                    MessageBox.Show("mật khẩu xác nhận không khớp!");
                }
                else
                {
                      MessageBox.Show("đã thay đổi mật khẩu!");
                    _pass = txbmkmoi.Text;
                    b.Change_Pass(_id, txbmkmoi.Text);
                    clear();
                    
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
