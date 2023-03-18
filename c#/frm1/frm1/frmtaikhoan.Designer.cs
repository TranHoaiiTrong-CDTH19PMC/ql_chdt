namespace frm1
{
    partial class frmtaikhoan
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
            this.txtmatkhaucu = new System.Windows.Forms.TextBox();
            this.txtmatkhuamoi2 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtmatkhaumoi1 = new System.Windows.Forms.TextBox();
            this.labek = new System.Windows.Forms.Label();
            this.btnthaydoi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txtmatkhaucu
            // 
            this.txtmatkhaucu.Location = new System.Drawing.Point(104, 68);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.PasswordChar = '*';
            this.txtmatkhaucu.Size = new System.Drawing.Size(100, 20);
            this.txtmatkhaucu.TabIndex = 2;
            // 
            // txtmatkhuamoi2
            // 
            this.txtmatkhuamoi2.Location = new System.Drawing.Point(104, 159);
            this.txtmatkhuamoi2.Name = "txtmatkhuamoi2";
            this.txtmatkhuamoi2.PasswordChar = '*';
            this.txtmatkhuamoi2.Size = new System.Drawing.Size(100, 20);
            this.txtmatkhuamoi2.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(5, 162);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Nhập lại mật khẩu";
            // 
            // txtmatkhaumoi1
            // 
            this.txtmatkhaumoi1.Location = new System.Drawing.Point(104, 111);
            this.txtmatkhaumoi1.Name = "txtmatkhaumoi1";
            this.txtmatkhaumoi1.PasswordChar = '*';
            this.txtmatkhaumoi1.Size = new System.Drawing.Size(100, 20);
            this.txtmatkhaumoi1.TabIndex = 3;
            // 
            // labek
            // 
            this.labek.AutoSize = true;
            this.labek.Location = new System.Drawing.Point(12, 114);
            this.labek.Name = "labek";
            this.labek.Size = new System.Drawing.Size(71, 13);
            this.labek.TabIndex = 4;
            this.labek.Text = "Mật khẩu mới";
            // 
            // btnthaydoi
            // 
            this.btnthaydoi.Location = new System.Drawing.Point(23, 212);
            this.btnthaydoi.Name = "btnthaydoi";
            this.btnthaydoi.Size = new System.Drawing.Size(75, 23);
            this.btnthaydoi.TabIndex = 5;
            this.btnthaydoi.Text = "Thay đổi";
            this.btnthaydoi.UseVisualStyleBackColor = true;
            this.btnthaydoi.Click += new System.EventHandler(this.btnthaydoi_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::frm1.Properties.Resources.BTNBACK2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(144, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 34);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(104, 24);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 20);
            this.txtmanv.TabIndex = 1;
            // 
            // frmtaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnthaydoi);
            this.Controls.Add(this.txtmatkhaumoi1);
            this.Controls.Add(this.labek);
            this.Controls.Add(this.txtmatkhuamoi2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmatkhaucu);
            this.Controls.Add(this.label1);
            this.Name = "frmtaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatkhaucu;
        private System.Windows.Forms.TextBox txtmatkhuamoi2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtmatkhaumoi1;
        private System.Windows.Forms.Label labek;
        private System.Windows.Forms.Button btnthaydoi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmanv;
    }
}