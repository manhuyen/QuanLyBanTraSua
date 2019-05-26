namespace Test_QLBTS
{
    partial class MainQuanLy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPhieunhap = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bttinhtien = new System.Windows.Forms.Button();
            this.btdiscount = new System.Windows.Forms.Button();
            this.btthanhvien = new System.Windows.Forms.Button();
            this.btmenu = new System.Windows.Forms.Button();
            this.rpHoaDon_DateToDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThucTapNhom_QLBTSDataSet1 = new Test_QLBTS.ThucTapNhom_QLBTSDataSet1();
            this.rpView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.dpicker_to = new System.Windows.Forms.DateTimePicker();
            this.dpicker_from = new System.Windows.Forms.DateTimePicker();
            this.rpHoaDon_DateToDateTableAdapter = new Test_QLBTS.ThucTapNhom_QLBTSDataSet1TableAdapters.rpHoaDon_DateToDateTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpHoaDon_DateToDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapNhom_QLBTSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 84);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(853, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đăng Xuất";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(698, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đổi Mật Khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chào Bạn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(333, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hệ Thống Quản Lý Cửa Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(10, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 528);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(926, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kho";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(195, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 604);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnPhieunhap);
            this.panel3.Location = new System.Drawing.Point(5, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 484);
            this.panel3.TabIndex = 0;
            // 
            // btnPhieunhap
            // 
            this.btnPhieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieunhap.Location = new System.Drawing.Point(-26, 13);
            this.btnPhieunhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPhieunhap.Name = "btnPhieunhap";
            this.btnPhieunhap.Size = new System.Drawing.Size(218, 26);
            this.btnPhieunhap.TabIndex = 11;
            this.btnPhieunhap.Text = ">>KHO<<";
            this.btnPhieunhap.UseVisualStyleBackColor = true;
            this.btnPhieunhap.Click += new System.EventHandler(this.BtnPhieunhap_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(926, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doanh Thu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.rpView);
            this.panel6.Controls.Add(this.btn_thongke);
            this.panel6.Controls.Add(this.dpicker_to);
            this.panel6.Controls.Add(this.dpicker_from);
            this.panel6.Location = new System.Drawing.Point(228, 6);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(695, 482);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.bttinhtien);
            this.panel5.Controls.Add(this.btdiscount);
            this.panel5.Controls.Add(this.btthanhvien);
            this.panel5.Controls.Add(this.btmenu);
            this.panel5.Location = new System.Drawing.Point(5, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 482);
            this.panel5.TabIndex = 0;
            // 
            // bttinhtien
            // 
            this.bttinhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttinhtien.Location = new System.Drawing.Point(2, 95);
            this.bttinhtien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttinhtien.Name = "bttinhtien";
            this.bttinhtien.Size = new System.Drawing.Size(218, 26);
            this.bttinhtien.TabIndex = 7;
            this.bttinhtien.Text = ">> Tính Tiền<<";
            this.bttinhtien.UseVisualStyleBackColor = true;
            // 
            // btdiscount
            // 
            this.btdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdiscount.Location = new System.Drawing.Point(2, 64);
            this.btdiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btdiscount.Name = "btdiscount";
            this.btdiscount.Size = new System.Drawing.Size(218, 26);
            this.btdiscount.TabIndex = 6;
            this.btdiscount.Text = ">>Discount<<";
            this.btdiscount.UseVisualStyleBackColor = true;
            // 
            // btthanhvien
            // 
            this.btthanhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthanhvien.Location = new System.Drawing.Point(0, 33);
            this.btthanhvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btthanhvien.Name = "btthanhvien";
            this.btthanhvien.Size = new System.Drawing.Size(218, 26);
            this.btthanhvien.TabIndex = 5;
            this.btthanhvien.Text = ">> Thành Viên<<";
            this.btthanhvien.UseVisualStyleBackColor = true;
            // 
            // btmenu
            // 
            this.btmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenu.Location = new System.Drawing.Point(0, 2);
            this.btmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmenu.Name = "btmenu";
            this.btmenu.Size = new System.Drawing.Size(218, 26);
            this.btmenu.TabIndex = 4;
            this.btmenu.Text = ">> Menu<<";
            this.btmenu.UseVisualStyleBackColor = true;
            // 
            // rpHoaDon_DateToDateBindingSource
            // 
            this.rpHoaDon_DateToDateBindingSource.DataMember = "rpHoaDon_DateToDate";
            this.rpHoaDon_DateToDateBindingSource.DataSource = this.ThucTapNhom_QLBTSDataSet1;
            // 
            // ThucTapNhom_QLBTSDataSet1
            // 
            this.ThucTapNhom_QLBTSDataSet1.DataSetName = "ThucTapNhom_QLBTSDataSet1";
            this.ThucTapNhom_QLBTSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpView
            // 
            reportDataSource2.Name = "DataSet";
            reportDataSource2.Value = this.rpHoaDon_DateToDateBindingSource;
            this.rpView.LocalReport.DataSources.Add(reportDataSource2);
            this.rpView.LocalReport.ReportEmbeddedResource = "Test_QLBTS.rpDoanhThu.rdlc";
            this.rpView.Location = new System.Drawing.Point(3, 35);
            this.rpView.Name = "rpView";
            this.rpView.ServerReport.BearerToken = null;
            this.rpView.Size = new System.Drawing.Size(689, 425);
            this.rpView.TabIndex = 7;
            this.rpView.Load += new System.EventHandler(this.rpView_Load);
            // 
            // btn_thongke
            // 
            this.btn_thongke.Location = new System.Drawing.Point(279, 3);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(146, 26);
            this.btn_thongke.TabIndex = 6;
            this.btn_thongke.Text = "Thống Kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // dpicker_to
            // 
            this.dpicker_to.Location = new System.Drawing.Point(492, 3);
            this.dpicker_to.Name = "dpicker_to";
            this.dpicker_to.Size = new System.Drawing.Size(200, 26);
            this.dpicker_to.TabIndex = 5;
            // 
            // dpicker_from
            // 
            this.dpicker_from.Location = new System.Drawing.Point(3, 3);
            this.dpicker_from.Name = "dpicker_from";
            this.dpicker_from.Size = new System.Drawing.Size(200, 26);
            this.dpicker_from.TabIndex = 4;
            // 
            // rpHoaDon_DateToDateTableAdapter
            // 
            this.rpHoaDon_DateToDateTableAdapter.ClearBeforeFill = true;
            // 
            // MainQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainQuanLy";
            this.Text = "MainQuanLy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpHoaDon_DateToDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapNhom_QLBTSDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bttinhtien;
        private System.Windows.Forms.Button btdiscount;
        private System.Windows.Forms.Button btthanhvien;
        private System.Windows.Forms.Button btmenu;
        private System.Windows.Forms.Button btnPhieunhap;
        private Microsoft.Reporting.WinForms.ReportViewer rpView;
        private System.Windows.Forms.BindingSource rpHoaDon_DateToDateBindingSource;
        private ThucTapNhom_QLBTSDataSet1 ThucTapNhom_QLBTSDataSet1;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.DateTimePicker dpicker_to;
        private System.Windows.Forms.DateTimePicker dpicker_from;
        private ThucTapNhom_QLBTSDataSet1TableAdapters.rpHoaDon_DateToDateTableAdapter rpHoaDon_DateToDateTableAdapter;
    }
}