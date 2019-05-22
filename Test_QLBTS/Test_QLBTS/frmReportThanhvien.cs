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
using System.Data;
namespace Test_QLBTS
{
    public partial class frmReportThanhvien : Form
    {
        public frmReportThanhvien()
        {
            InitializeComponent();
        }

        private void FrmReportThanhvien_Load(object sender, EventArgs e)
        {
            My_QLBTSClient bus = new My_QLBTSClient();
            //  bus.Xem_ThanhVien().Clear();

       
            CrystalReport_Thanhvien c = new CrystalReport_Thanhvien();
            c.SetDataSource(bus.Xem_ThanhVien());
            crystalReportViewer1.ReportSource = c;

        }
    }
}
