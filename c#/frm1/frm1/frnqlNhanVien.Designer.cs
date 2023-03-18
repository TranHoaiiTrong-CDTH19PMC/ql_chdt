namespace frm1
{
    partial class frmQlNhanVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbChucvu = new System.Windows.Forms.ComboBox();
            this.rdKhac = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThemmanv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgnhanvien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grThongTinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(320, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(10, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(10, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Loại Nhân Viên";
            // 
            // grThongTinNhanVien
            // 
            this.grThongTinNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.grThongTinNhanVien.Controls.Add(this.txtmail);
            this.grThongTinNhanVien.Controls.Add(this.label10);
            this.grThongTinNhanVien.Controls.Add(this.cbbChucvu);
            this.grThongTinNhanVien.Controls.Add(this.rdKhac);
            this.grThongTinNhanVien.Controls.Add(this.rdNu);
            this.grThongTinNhanVien.Controls.Add(this.rdNam);
            this.grThongTinNhanVien.Controls.Add(this.label9);
            this.grThongTinNhanVien.Controls.Add(this.label8);
            this.grThongTinNhanVien.Controls.Add(this.txtTimKiem);
            this.grThongTinNhanVien.Controls.Add(this.btnThemmanv);
            this.grThongTinNhanVien.Controls.Add(this.btnClear);
            this.grThongTinNhanVien.Controls.Add(this.btnSua);
            this.grThongTinNhanVien.Controls.Add(this.btnXoa);
            this.grThongTinNhanVien.Controls.Add(this.btnThem);
            this.grThongTinNhanVien.Controls.Add(this.txtPassWord);
            this.grThongTinNhanVien.Controls.Add(this.txtSDT);
            this.grThongTinNhanVien.Controls.Add(this.txtDiaChi);
            this.grThongTinNhanVien.Controls.Add(this.txtTenNV);
            this.grThongTinNhanVien.Controls.Add(this.txtMaNV);
            this.grThongTinNhanVien.Controls.Add(this.label3);
            this.grThongTinNhanVien.Controls.Add(this.label7);
            this.grThongTinNhanVien.Controls.Add(this.label1);
            this.grThongTinNhanVien.Controls.Add(this.label6);
            this.grThongTinNhanVien.Controls.Add(this.label2);
            this.grThongTinNhanVien.Controls.Add(this.label5);
            this.grThongTinNhanVien.Controls.Add(this.label4);
            this.grThongTinNhanVien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinNhanVien.ForeColor = System.Drawing.Color.Yellow;
            this.grThongTinNhanVien.Location = new System.Drawing.Point(9, 39);
            this.grThongTinNhanVien.Name = "grThongTinNhanVien";
            this.grThongTinNhanVien.Size = new System.Drawing.Size(811, 209);
            this.grThongTinNhanVien.TabIndex = 3;
            this.grThongTinNhanVien.TabStop = false;
            this.grThongTinNhanVien.Text = "Thông Tin Nhân Viên";
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.White;
            this.txtmail.ForeColor = System.Drawing.Color.Red;
            this.txtmail.Location = new System.Drawing.Point(382, 56);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(182, 22);
            this.txtmail.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(320, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Email";
            // 
            // cbbChucvu
            // 
            this.cbbChucvu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbChucvu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucvu.FormattingEnabled = true;
            this.cbbChucvu.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lí"});
            this.cbbChucvu.Location = new System.Drawing.Point(116, 162);
            this.cbbChucvu.Name = "cbbChucvu";
            this.cbbChucvu.Size = new System.Drawing.Size(168, 23);
            this.cbbChucvu.TabIndex = 5;
            // 
            // rdKhac
            // 
            this.rdKhac.AutoSize = true;
            this.rdKhac.ForeColor = System.Drawing.Color.Yellow;
            this.rdKhac.Location = new System.Drawing.Point(511, 127);
            this.rdKhac.Name = "rdKhac";
            this.rdKhac.Size = new System.Drawing.Size(53, 19);
            this.rdKhac.TabIndex = 10;
            this.rdKhac.Text = "Khác";
            this.rdKhac.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.ForeColor = System.Drawing.Color.Yellow;
            this.rdNu.Location = new System.Drawing.Point(451, 128);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(42, 19);
            this.rdNu.TabIndex = 9;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.ForeColor = System.Drawing.Color.Yellow;
            this.rdNam.Location = new System.Drawing.Point(382, 128);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(50, 19);
            this.rdNam.TabIndex = 8;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(320, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giới tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(318, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(428, 173);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(367, 25);
            this.txtTimKiem.TabIndex = 15;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThemmanv
            // 
            this.btnThemmanv.ForeColor = System.Drawing.Color.Black;
            this.btnThemmanv.Location = new System.Drawing.Point(307, 21);
            this.btnThemmanv.Name = "btnThemmanv";
            this.btnThemmanv.Size = new System.Drawing.Size(51, 23);
            this.btnThemmanv.TabIndex = 2;
            this.btnThemmanv.Text = "Tạo";
            this.btnThemmanv.UseVisualStyleBackColor = true;
            this.btnThemmanv.Click += new System.EventHandler(this.btnThemmanv_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::frm1.Properties.Resources.refesh;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(721, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 66);
            this.btnClear.TabIndex = 12;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::frm1.Properties.Resources.sua1;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(634, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 66);
            this.btnSua.TabIndex = 11;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::frm1.Properties.Resources.xoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(721, 95);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 66);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::frm1.Properties.Resources.them;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(634, 95);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 66);
            this.btnThem.TabIndex = 13;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.White;
            this.txtPassWord.ForeColor = System.Drawing.Color.Red;
            this.txtPassWord.Location = new System.Drawing.Point(116, 92);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(168, 22);
            this.txtPassWord.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.ForeColor = System.Drawing.Color.Red;
            this.txtSDT.Location = new System.Drawing.Point(116, 127);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(168, 22);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.ForeColor = System.Drawing.Color.Red;
            this.txtDiaChi.Location = new System.Drawing.Point(382, 92);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(182, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.White;
            this.txtTenNV.ForeColor = System.Drawing.Color.Red;
            this.txtTenNV.Location = new System.Drawing.Point(116, 56);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(168, 22);
            this.txtTenNV.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.White;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.ForeColor = System.Drawing.Color.Red;
            this.txtMaNV.Location = new System.Drawing.Point(116, 22);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(168, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(10, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu";
            // 
            // dtgnhanvien
            // 
            this.dtgnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.DiaChi,
            this.SDT,
            this.MatKhau,
            this.GioiTinh,
            this.ChucVu,
            this.Email});
            this.dtgnhanvien.Location = new System.Drawing.Point(9, 247);
            this.dtgnhanvien.Name = "dtgnhanvien";
            this.dtgnhanvien.Size = new System.Drawing.Size(811, 200);
            this.dtgnhanvien.TabIndex = 17;
            this.dtgnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgnhanvien_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LawnGreen;
            this.label11.Location = new System.Drawing.Point(262, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::frm1.Properties.Resources.BTNBACK2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-1, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 35);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmQlNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::frm1.Properties.Resources.nen31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtgnhanvien);
            this.Controls.Add(this.grThongTinNhanVien);
            this.DoubleBuffered = true;
            this.Name = "frmQlNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.QLNV_Load);
            this.grThongTinNhanVien.ResumeLayout(false);
            this.grThongTinNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grThongTinNhanVien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dtgnhanvien;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemmanv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdKhac;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.ComboBox cbbChucvu;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}