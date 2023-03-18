namespace frm1
{
    partial class qlKhachhang
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKhachang = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.Label();
            this.txtdiachikh = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.Label();
            this.txtsdtkh = new System.Windows.Forms.TextBox();
            this.dtgkhachhang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMakhachhang = new System.Windows.Forms.TextBox();
            this.btnTaoMAKH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdKhac = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtTenKhachang
            // 
            this.txtTenKhachang.Location = new System.Drawing.Point(139, 94);
            this.txtTenKhachang.Name = "txtTenKhachang";
            this.txtTenKhachang.Size = new System.Drawing.Size(161, 20);
            this.txtTenKhachang.TabIndex = 2;
            // 
            // txtDiachi
            // 
            this.txtDiachi.AutoSize = true;
            this.txtDiachi.BackColor = System.Drawing.Color.Transparent;
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.ForeColor = System.Drawing.Color.Red;
            this.txtDiachi.Location = new System.Drawing.Point(24, 149);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(47, 13);
            this.txtDiachi.TabIndex = 0;
            this.txtDiachi.Text = "Địa chỉ";
            // 
            // txtdiachikh
            // 
            this.txtdiachikh.Location = new System.Drawing.Point(139, 146);
            this.txtdiachikh.Name = "txtdiachikh";
            this.txtdiachikh.Size = new System.Drawing.Size(161, 20);
            this.txtdiachikh.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.BackColor = System.Drawing.Color.Transparent;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Red;
            this.txtSDT.Location = new System.Drawing.Point(24, 123);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(83, 13);
            this.txtSDT.TabIndex = 0;
            this.txtSDT.Text = "Số điện thoại";
            // 
            // txtsdtkh
            // 
            this.txtsdtkh.Location = new System.Drawing.Point(139, 120);
            this.txtsdtkh.Name = "txtsdtkh";
            this.txtsdtkh.Size = new System.Drawing.Size(161, 20);
            this.txtsdtkh.TabIndex = 3;
            this.txtsdtkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdtkh_KeyPress);
            // 
            // dtgkhachhang
            // 
            this.dtgkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgkhachhang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChi,
            this.SDT,
            this.GioiTinh});
            this.dtgkhachhang.Location = new System.Drawing.Point(12, 254);
            this.dtgkhachhang.Name = "dtgkhachhang";
            this.dtgkhachhang.Size = new System.Drawing.Size(628, 150);
            this.dtgkhachhang.TabIndex = 14;
            this.dtgkhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgkhachhang_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtMakhachhang
            // 
            this.txtMakhachhang.Enabled = false;
            this.txtMakhachhang.Location = new System.Drawing.Point(139, 68);
            this.txtMakhachhang.Name = "txtMakhachhang";
            this.txtMakhachhang.Size = new System.Drawing.Size(162, 20);
            this.txtMakhachhang.TabIndex = 1;
            // 
            // btnTaoMAKH
            // 
            this.btnTaoMAKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMAKH.Location = new System.Drawing.Point(339, 66);
            this.btnTaoMAKH.Name = "btnTaoMAKH";
            this.btnTaoMAKH.Size = new System.Drawing.Size(64, 22);
            this.btnTaoMAKH.TabIndex = 2;
            this.btnTaoMAKH.Text = "Tạo";
            this.btnTaoMAKH.UseVisualStyleBackColor = true;
            this.btnTaoMAKH.Click += new System.EventHandler(this.btnTaoMAKH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(83, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(187, 221);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(337, 27);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rdKhac
            // 
            this.rdKhac.AutoSize = true;
            this.rdKhac.BackColor = System.Drawing.Color.Transparent;
            this.rdKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKhac.ForeColor = System.Drawing.Color.Red;
            this.rdKhac.Location = new System.Drawing.Point(251, 176);
            this.rdKhac.Name = "rdKhac";
            this.rdKhac.Size = new System.Drawing.Size(54, 17);
            this.rdKhac.TabIndex = 7;
            this.rdKhac.Text = "Khác";
            this.rdKhac.UseVisualStyleBackColor = false;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.BackColor = System.Drawing.Color.Transparent;
            this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.ForeColor = System.Drawing.Color.Red;
            this.rdNu.Location = new System.Drawing.Point(197, 176);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(41, 17);
            this.rdNu.TabIndex = 6;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = false;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.BackColor = System.Drawing.Color.Transparent;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.ForeColor = System.Drawing.Color.Red;
            this.rdNam.Location = new System.Drawing.Point(139, 176);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(50, 17);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(24, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Giới tính";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::frm1.Properties.Resources.BTNBACK2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 42);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(150, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackgroundImage = global::frm1.Properties.Resources.refesh;
            this.btnquaylai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnquaylai.Location = new System.Drawing.Point(552, 139);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(76, 60);
            this.btnquaylai.TabIndex = 11;
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImage = global::frm1.Properties.Resources.sua1;
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsua.Location = new System.Drawing.Point(442, 138);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 60);
            this.btnsua.TabIndex = 10;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Transparent;
            this.btnxoa.BackgroundImage = global::frm1.Properties.Resources.xoa;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxoa.Location = new System.Drawing.Point(552, 66);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(76, 56);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::frm1.Properties.Resources.them;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Location = new System.Drawing.Point(442, 66);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 56);
            this.btnthem.TabIndex = 8;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnThemkh_Click);
            // 
            // qlKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::frm1.Properties.Resources.nen21;
            this.ClientSize = new System.Drawing.Size(652, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdKhac);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTaoMAKH);
            this.Controls.Add(this.dtgkhachhang);
            this.Controls.Add(this.txtsdtkh);
            this.Controls.Add(this.txtdiachikh);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenKhachang);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMakhachhang);
            this.Controls.Add(this.label1);
            this.Name = "qlKhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách hàng";
            this.Load += new System.EventHandler(this.qlKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKhachang;
        private System.Windows.Forms.Label txtDiachi;
        private System.Windows.Forms.TextBox txtdiachikh;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.TextBox txtsdtkh;
        private System.Windows.Forms.DataGridView dtgkhachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMakhachhang;
        private System.Windows.Forms.Button btnTaoMAKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdKhac;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
    }
}