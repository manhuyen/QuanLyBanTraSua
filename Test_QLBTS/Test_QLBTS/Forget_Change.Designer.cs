namespace Test_QLBTS
{
    partial class Forget_Change
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbmatkhaumoi = new System.Windows.Forms.TextBox();
            this.txbsodt = new System.Windows.Forms.TextBox();
            this.txbtaikhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxacnhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbmatkhaumoi
            // 
            this.txbmatkhaumoi.Location = new System.Drawing.Point(198, 124);
            this.txbmatkhaumoi.Name = "txbmatkhaumoi";
            this.txbmatkhaumoi.PasswordChar = '*';
            this.txbmatkhaumoi.Size = new System.Drawing.Size(238, 22);
            this.txbmatkhaumoi.TabIndex = 13;
            // 
            // txbsodt
            // 
            this.txbsodt.Location = new System.Drawing.Point(198, 81);
            this.txbsodt.Name = "txbsodt";
            this.txbsodt.Size = new System.Drawing.Size(238, 22);
            this.txbsodt.TabIndex = 12;
            // 
            // txbtaikhoan
            // 
            this.txbtaikhoan.Location = new System.Drawing.Point(198, 38);
            this.txbtaikhoan.Name = "txbtaikhoan";
            this.txbtaikhoan.Size = new System.Drawing.Size(238, 22);
            this.txbtaikhoan.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số Điện Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tài Khoản";
            // 
            // txbxacnhan
            // 
            this.txbxacnhan.Location = new System.Drawing.Point(198, 167);
            this.txbxacnhan.Name = "txbxacnhan";
            this.txbxacnhan.PasswordChar = '*';
            this.txbxacnhan.Size = new System.Drawing.Size(238, 22);
            this.txbxacnhan.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Xác Nhận";
            // 
            // Forget_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(555, 300);
            this.Controls.Add(this.txbxacnhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbmatkhaumoi);
            this.Controls.Add(this.txbsodt);
            this.Controls.Add(this.txbtaikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forget_Change";
            this.Text = "Forget_Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbmatkhaumoi;
        private System.Windows.Forms.TextBox txbsodt;
        private System.Windows.Forms.TextBox txbtaikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxacnhan;
        private System.Windows.Forms.Label label4;
    }
}