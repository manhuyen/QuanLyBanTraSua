using Microsoft.Reporting.WinForms;
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
    public partial class rpDoanhThu : Form
    {
        My_QLBTSClient db = new My_QLBTSClient();

        public rpDoanhThu()
        {
            InitializeComponent();
        }

        private void rpDoanhThu_Load(object sender, EventArgs e)
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
