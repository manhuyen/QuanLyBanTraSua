namespace Test_QLBTS
{
    partial class rpDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dpicker_from = new System.Windows.Forms.DateTimePicker();
            this.dpicker_to = new System.Windows.Forms.DateTimePicker();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.rpView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThucTapNhom_QLBTSDataSet1 = new Test_QLBTS.ThucTapNhom_QLBTSDataSet1();
            this.rpHoaDon_DateToDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpHoaDon_DateToDateTableAdapter = new Test_QLBTS.ThucTapNhom_QLBTSDataSet1TableAdapters.rpHoaDon_DateToDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapNhom_QLBTSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpHoaDon_DateToDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dpicker_from
            // 
            this.dpicker_from.Location = new System.Drawing.Point(12, 12);
            this.dpicker_from.Name = "dpicker_from";
            this.dpicker_from.Size = new System.Drawing.Size(200, 20);
            this.dpicker_from.TabIndex = 0;
            // 
            // dpicker_to
            // 
            this.dpicker_to.Location = new System.Drawing.Point(621, 12);
            this.dpicker_to.Name = "dpicker_to";
            this.dpicker_to.Size = new System.Drawing.Size(200, 20);
            this.dpicker_to.TabIndex = 1;
            // 
            // btn_thongke
            // 
            this.btn_thongke.Location = new System.Drawing.Point(379, 9);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(75, 23);
            this.btn_thongke.TabIndex = 2;
            this.btn_thongke.Text = "Thống Kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // rpView
            // 
            reportDataSource2.Name = "DataSet";
            reportDataSource2.Value = this.rpHoaDon_DateToDateBindingSource;
            this.rpView.LocalReport.DataSources.Add(reportDataSource2);
            this.rpView.LocalReport.ReportEmbeddedResource = "Test_QLBTS.rpDoanhThu.rdlc";
            this.rpView.Location = new System.Drawing.Point(12, 38);
            this.rpView.Name = "rpView";
            this.rpView.ServerReport.BearerToken = null;
            this.rpView.Size = new System.Drawing.Size(810, 411);
            this.rpView.TabIndex = 3;
            // 
            // ThucTapNhom_QLBTSDataSet1
            // 
            this.ThucTapNhom_QLBTSDataSet1.DataSetName = "ThucTapNhom_QLBTSDataSet1";
            this.ThucTapNhom_QLBTSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpHoaDon_DateToDateBindingSource
            // 
            this.rpHoaDon_DateToDateBindingSource.DataMember = "rpHoaDon_DateToDate";
            this.rpHoaDon_DateToDateBindingSource.DataSource = this.ThucTapNhom_QLBTSDataSet1;
            // 
            // rpHoaDon_DateToDateTableAdapter
            // 
            this.rpHoaDon_DateToDateTableAdapter.ClearBeforeFill = true;
            // 
            // rpDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.rpView);
            this.Controls.Add(this.btn_thongke);
            this.Controls.Add(this.dpicker_to);
            this.Controls.Add(this.dpicker_from);
            this.Name = "rpDoanhThu";
            this.Text = "rpDoanhThu";
            this.Load += new System.EventHandler(this.rpDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapNhom_QLBTSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpHoaDon_DateToDateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpicker_from;
        private System.Windows.Forms.DateTimePicker dpicker_to;
        private System.Windows.Forms.Button btn_thongke;
        private Microsoft.Reporting.WinForms.ReportViewer rpView;
        private System.Windows.Forms.BindingSource rpHoaDon_DateToDateBindingSource;
        private ThucTapNhom_QLBTSDataSet1 ThucTapNhom_QLBTSDataSet1;
        private ThucTapNhom_QLBTSDataSet1TableAdapters.rpHoaDon_DateToDateTableAdapter rpHoaDon_DateToDateTableAdapter;
    }
}