namespace Test_QLBTS
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttinhtien = new System.Windows.Forms.Button();
            this.btdiscount = new System.Windows.Forms.Button();
            this.btthanhvien = new System.Windows.Forms.Button();
            this.btmenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 107);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1181, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đăng Xuất";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(922, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đổi Mật Khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chào Bạn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(424, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ Thống Quản Lý Bán Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.Controls.Add(this.bttinhtien);
            this.panel2.Controls.Add(this.btdiscount);
            this.panel2.Controls.Add(this.btthanhvien);
            this.panel2.Controls.Add(this.btmenu);
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 682);
            this.panel2.TabIndex = 1;
            // 
            // bttinhtien
            // 
            this.bttinhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttinhtien.Location = new System.Drawing.Point(3, 114);
            this.bttinhtien.Name = "bttinhtien";
            this.bttinhtien.Size = new System.Drawing.Size(292, 32);
            this.bttinhtien.TabIndex = 3;
            this.bttinhtien.Text = ">> Tính Tiền<<";
            this.bttinhtien.UseVisualStyleBackColor = true;
            this.bttinhtien.Click += new System.EventHandler(this.bttinhtien_Click);
            // 
            // btdiscount
            // 
            this.btdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdiscount.Location = new System.Drawing.Point(3, 76);
            this.btdiscount.Name = "btdiscount";
            this.btdiscount.Size = new System.Drawing.Size(289, 32);
            this.btdiscount.TabIndex = 2;
            this.btdiscount.Text = ">>Discount<<";
            this.btdiscount.UseVisualStyleBackColor = true;
            this.btdiscount.Click += new System.EventHandler(this.btdiscount_Click);
            // 
            // btthanhvien
            // 
            this.btthanhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthanhvien.Location = new System.Drawing.Point(0, 38);
            this.btthanhvien.Name = "btthanhvien";
            this.btthanhvien.Size = new System.Drawing.Size(292, 32);
            this.btthanhvien.TabIndex = 1;
            this.btthanhvien.Text = ">> Thành Viên<<";
            this.btthanhvien.UseVisualStyleBackColor = true;
            this.btthanhvien.Click += new System.EventHandler(this.btthanhvien_Click);
            // 
            // btmenu
            // 
            this.btmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenu.Location = new System.Drawing.Point(0, 0);
            this.btmenu.Name = "btmenu";
            this.btmenu.Size = new System.Drawing.Size(292, 32);
            this.btmenu.TabIndex = 0;
            this.btmenu.Text = ">> Menu<<";
            this.btmenu.UseVisualStyleBackColor = true;
            this.btmenu.Click += new System.EventHandler(this.btmenu_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(301, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1046, 682);
            this.panel3.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 810);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttinhtien;
        private System.Windows.Forms.Button btdiscount;
        private System.Windows.Forms.Button btthanhvien;
        private System.Windows.Forms.Button btmenu;
        private System.Windows.Forms.Panel panel3;
    }
}