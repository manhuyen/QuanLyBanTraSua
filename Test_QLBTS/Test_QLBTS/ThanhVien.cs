using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Test_QLBTS.ServiceReference1;
namespace Test_QLBTS
{
    public partial class ThanhVien : UserControl
    {
        public ThanhVien()
        {
            InitializeComponent();
        }
        
       // Bus bus = new Bus();
        thanhvien tv = new thanhvien();
        My_QLBTSClient bus = new My_QLBTSClient();
        void Clear_Textbox()
        {
            txbdiachi.Clear();
            txbloattv.Clear();
            txbemail.Clear();
            txbhoten.Clear();
            txtSTT.Clear();
            txbsdt.Clear();
            txbmatv.Clear();
            txbdiemTl.Clear();

        }
        private void ThanhVien_Load(object sender, EventArgs e)
        {
            bus.Xem_ThanhVien().Clear();
            dataGridView1.DataSource = bus.Xem_ThanhVien();


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {                
            if (txbmatv.Text == "")
            {
                MessageBox.Show("Mời bạn nhập giá trị vào!");
                return;
            }
            else
            {
                if (bus.Check_Thanhvien(txbmatv.Text) == false)
                {
                    MessageBox.Show("Ma TV da ton tai!");
                }
                else
                {

                    //MessageBox.Show("Thêm Thành Công!");
                    //tv._diachi = txbdiachi.Text;
                    //tv._diemTl = Convert.ToInt32(txbdiemTl.Text);
                    //tv._email = txbemail.Text;
                    //tv._hoten = txbhoten.Text;
                    //tv._matv = txbmatv.Text;
                    //tv._stt = Convert.ToInt32(txtSTT.Text);
                    //tv._loaitv = txbloattv.Text;
                    //tv._sodt = txbsdt.Text;
                    //Clear_Textbox();
                    //bus.Them_NV(tv);
                    //bus.Xem_ThanhVien().Clear();
                    //dataGridView1.DataSource = bus.Xem_ThanhVien();
                    MessageBox.Show("Thêm Thành Công!");
                    tv._diachi = txbdiachi.Text;
                    tv._diemTl = Convert.ToInt16(txbdiemTl.Text);
                    tv._email = txbemail.Text;
                    tv._hoten = txbhoten.Text;
                    tv._matv = txbmatv.Text;
                    tv._stt = Convert.ToInt16(txtSTT.Text);
                    tv._loaitv = txbloattv.Text;
                    tv._sodt = txbsdt.Text;

                    bus.Them_ThanhVien(tv._matv, tv._stt, tv._hoten, tv._loaitv, tv._sodt, tv._email, tv._diachi, tv._diemTl);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bus.Xem_ThanhVien();
                    Clear_Textbox();
                }





            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string matv = dataGridView1.CurrentRow.Cells["MaTV"].Value.ToString();
           
                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Thành Viên Này?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    bus.Xoa_ThanhVien(matv);
                // bus.Xem_ThanhVien().Clear();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bus.Xem_ThanhVien();
                }
                else
                {
                    return;
                }
            
         
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
            txbdiachi.Text= dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
            txbdiemTl.Text= dataGridView1.CurrentRow.Cells["diemtichluy"].Value.ToString();
            txbemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            txbhoten.Text = dataGridView1.CurrentRow.Cells["hoten"].Value.ToString();
            txbmatv.Text = dataGridView1.CurrentRow.Cells["Matv"].Value.ToString();
            txtSTT.Text = dataGridView1.CurrentRow.Cells["STT"].Value.ToString();
            txbloattv.Text = dataGridView1.CurrentRow.Cells["loaithanhvien"].Value.ToString();
           txbsdt.Text = dataGridView1.CurrentRow.Cells["soDT"].Value.ToString();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (txbmatv.Text == "")
            {
                return;
            }
            else
            {
                tv._diachi = txbdiachi.Text;
                tv._diemTl = Convert.ToInt32(txbdiemTl.Text);
                tv._email = txbemail.Text;
                tv._hoten = txbhoten.Text;
                tv._matv = txbmatv.Text;
                tv._stt = Convert.ToInt32(txtSTT.Text);
                tv._loaitv = txbloattv.Text;
                tv._sodt = txbsdt.Text;
                if (bus.Sua_ThanhVien(tv._matv, tv._stt, tv._hoten, tv._loaitv, tv._sodt, tv._email, tv._diachi, tv._diemTl) ==true)
                {
                    MessageBox.Show("Sua Thanh Cong!");
                    bus.Sua_ThanhVien(tv._matv, tv._stt, tv._hoten, tv._loaitv, tv._sodt, tv._email, tv._diachi, tv._diemTl);
                    Clear_Textbox();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bus.Xem_ThanhVien();

                }
                else
                {
                    MessageBox.Show("Sua That Bai!");
                }
               
            }
        }

        private void Txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Thanhvien where hoten like N'%" + txbtimkiem.Text + "%'";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bus.Xem_TuyTron(query);

        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            bus.Update_LoaiTV();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bus.Xem_ThanhVien();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReportThanhvien f = new frmReportThanhvien();
            f.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmDiemCong f = new FrmDiemCong();
            f.Show();
        }
    }
}
