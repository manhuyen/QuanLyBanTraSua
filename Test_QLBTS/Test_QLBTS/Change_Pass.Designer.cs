namespace Test_QLBTS
{
    partial class Change_Pass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbmkcu = new System.Windows.Forms.TextBox();
            this.txbmkmoi = new System.Windows.Forms.TextBox();
            this.txbXacnhanmk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu Cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác Nhận Mật Khẩu";
            // 
            // txbmkcu
            // 
            this.txbmkcu.Location = new System.Drawing.Point(163, 40);
            this.txbmkcu.Name = "txbmkcu";
            this.txbmkcu.PasswordChar = '*';
            this.txbmkcu.Size = new System.Drawing.Size(238, 22);
            this.txbmkcu.TabIndex = 3;
            // 
            // txbmkmoi
            // 
            this.txbmkmoi.Location = new System.Drawing.Point(163, 83);
            this.txbmkmoi.Name = "txbmkmoi";
            this.txbmkmoi.PasswordChar = '*';
            this.txbmkmoi.Size = new System.Drawing.Size(238, 22);
            this.txbmkmoi.TabIndex = 4;
            // 
            // txbXacnhanmk
            // 
            this.txbXacnhanmk.Location = new System.Drawing.Point(163, 126);
            this.txbXacnhanmk.Name = "txbXacnhanmk";
            this.txbXacnhanmk.PasswordChar = '*';
            this.txbXacnhanmk.Size = new System.Drawing.Size(238, 22);
            this.txbXacnhanmk.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Change_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(494, 259);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbXacnhanmk);
            this.Controls.Add(this.txbmkmoi);
            this.Controls.Add(this.txbmkcu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Change_Pass";
            this.Text = "Change_Pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbmkcu;
        private System.Windows.Forms.TextBox txbmkmoi;
        private System.Windows.Forms.TextBox txbXacnhanmk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}