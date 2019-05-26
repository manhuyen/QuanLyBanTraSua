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
using Microsoft.Reporting.WinForms;
using Test_QLBTS.ServiceReference1;

namespace Test_QLBTS
{
    public partial class MainQuanLy : Form
    {
        My_QLBTSClient db = new My_QLBTSClient();
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

        private void rpView_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(db.DoanhThu_DateToDate(dpicker_from.Value.ToString(), dpicker_to.Value.ToString()));

            ReportDataSource rpSource = new ReportDataSource("DataSet", ds.Tables[0]);
            this.rpView.LocalReport.DataSources.Clear();
            this.rpView.LocalReport.DataSources.Add(rpSource);
            this.rpView.LocalReport.Refresh();

            rpView.RefreshReport();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            string From = dpicker_from.Value.ToString();
            string To = dpicker_to.Value.ToString();

            DataSet ds = new DataSet();
            ds.Tables.Add(db.DoanhThu_DateToDate(From, To));

            ReportDataSource rpSource = new ReportDataSource("DataSet", ds.Tables[0]);
            this.rpView.LocalReport.DataSources.Clear();
            this.rpView.LocalReport.DataSources.Add(rpSource);
            this.rpView.LocalReport.Refresh();

            rpView.RefreshReport();
        }
    }
}
