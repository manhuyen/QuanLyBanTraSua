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
    public partial class PhieuNhap : UserControl
    {
        public PhieuNhap()
        {
            InitializeComponent();
        }
        My_QLBTSClient b = new My_QLBTSClient();
        Phieunhap pn = new Phieunhap();
        void Clear()
        {
            txtMaPN.Clear();
            txtMaNV.Clear();
            txtngaynhap.Clear();
        }
        void Clear1()
        {

            txtMaNV.Clear();
            txttennvk.Clear();
            txtsdt.Clear();
        }
        void Clear2()
        {
            txtmanl.Clear();
            txttennl.Clear();
            txtdonvitinh.Clear();
        }
        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = b.Xem_Phieunhap();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = b.Xem_NhanvienKho();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = b.Xem_Nguyenlieu();

        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text == "")
            {
                MessageBox.Show("Mời bạn nhập giá trị vào!");
                return;
            }
            else
            {

                MessageBox.Show("Thêm Thành Công!");
                pn._manhap = txtMaPN.Text;
                pn._manv = txtMaNV.Text;
                pn._ngaynhap = Convert.ToDateTime(txtngaynhap.Text);

                b.Them_Phieunhap(pn._manhap, pn._manv, pn._ngaynhap);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = b.Xem_Phieunhap();
                Clear();
            }
        }

        private void ToolStripButton10_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mời bạn nhập giá trị vào!");
                return;
            }
            else
            {

                MessageBox.Show("Thêm Thành Công!");

                pn._manv = txtMaNV.Text;
                pn._tennv = txttennl.Text;
                pn._soDT = txtsdt.Text;

                b.Them_NhanvienKho(pn._manv, pn._tennv, pn._soDT);

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = b.Xem_NhanvienKho();
                Clear1();
            }
        }

        private void ToolStripButton12_Click(object sender, EventArgs e)
        {
            if (txtmanl.Text == "")
            {
                MessageBox.Show("Mời bạn nhập giá trị vào!");
                return;
            }
            else
            {

                MessageBox.Show("Thêm Thành Công!");

                pn._manl = txtmanl.Text;
                pn._tennl = txttennl.Text;
                pn._donvitinh = txtdonvitinh.Text;

                b.Them_Nguyenlieu(pn._manv, pn._tennv, pn._soDT);

                dataGridView3.DataSource = null;
                dataGridView3.DataSource = b.Xem_Nguyenlieu();
                Clear2();
            }
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Phiếu Nhập  Này?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //int mapn = Convert.ToInt16(dataGridView1.CurrentRow.Cells["STT"].Value.ToString());
                string mapn = dataGridView1.CurrentRow.Cells["STT"].Value.ToString();
                b.Xoa_Phieunhap(mapn);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = b.Xem_Phieunhap();
            }
            else
            {
                return;
            }
        }

        private void ToolStripButton9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Nhân Viên Này?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //int mapn = Convert.ToInt16(dataGridView1.CurrentRow.Cells["STT"].Value.ToString());
                string manv = dataGridView2.CurrentRow.Cells["STT"].Value.ToString();
                b.Xoa_NhanvienKho(manv);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = b.Xem_NhanvienKho();
            }
            else
            {
                return;
            }
        }

        private void ToolStripButton11_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Nguyên Liệu Này?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //int mapn = Convert.ToInt16(dataGridView1.CurrentRow.Cells["STT"].Value.ToString());
                string manl = dataGridView3.CurrentRow.Cells["STT"].Value.ToString();
                b.Xoa_Nguyenlieu(manl);
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = b.Xem_Nguyenlieu();
            }
            else
            {
                return;
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            txtMaPN.Text = dataGridView1.CurrentRow.Cells["STT"].Value.ToString();
            txtMaNV.Text = dataGridView1.CurrentRow.Cells["Mã Nhân Viên"].Value.ToString();
            txtngaynhap.Text = dataGridView1.CurrentRow.Cells["Ngày Nhập"].Value.ToString();

        }

        private void ToolStripButton8_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = dataGridView2.CurrentRow.Cells["STT"].Value.ToString();
            txttennvk.Text = dataGridView2.CurrentRow.Cells["Tên Nhân Viên Kho"].Value.ToString();
            txtsdt.Text = dataGridView2.CurrentRow.Cells["Số Điện Thoại"].Value.ToString();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            txtmanl.Text = dataGridView3.CurrentRow.Cells["STT"].Value.ToString();
            txttennl.Text = dataGridView3.CurrentRow.Cells["Tên Nguyên Liệu"].Value.ToString();
            txtdonvitinh.Text = dataGridView3.CurrentRow.Cells["Đơn Vị Tính"].Value.ToString();
        }

        

        private void PhieuNhap_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = b.Xem_Phieunhap();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = b.Xem_NhanvienKho();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = b.Xem_Nguyenlieu();

        }
        List<string> l = new List<string>();
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text == "")
            {
                return;
            }
            else
            {
                MessageBox.Show("Lưu thành công!");


                pn._manhap = txtMaPN.Text;
                pn._manv = txtMaNV.Text;
                pn._ngaynhap = Convert.ToDateTime(txtngaynhap.Text);
                b.Sua_Phieunhap(pn._manhap, pn._manv, pn._ngaynhap);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = b.Xem_Phieunhap();
                Clear();
            }
        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                return;
            }
            else
            {
                MessageBox.Show("Lưu thành công!");


                pn._manv = txtMaNV.Text;
                pn._tennv = txttennvk.Text;
                pn._soDT = txtsdt.Text;
                b.Sua_NhanvienKho(pn._manv, pn._tennl, pn._soDT);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = b.Xem_NhanvienKho();
                Clear1();
            }
        }
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (txtmanl.Text == "")
            {
                return;
            }
            else
            {
                MessageBox.Show("Lưu thành công!");


                pn._manl = txtmanl.Text;
                pn._tennl = txttennl.Text;
                pn._donvitinh = txtdonvitinh.Text;
                b.Sua_Nguyenlieu(pn._manl, pn._tennl, pn._donvitinh);
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = b.Xem_Nguyenlieu();
                Clear2();
            }
        }
    }
}
