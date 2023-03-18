namespace frm1
{
    partial class frmQLSP
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
            this.grThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnTao = new System.Windows.Forms.Button();
            this.cbbnhacungcap = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.grThongTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongTinSanPham
            // 
            this.grThongTinSanPham.BackColor = System.Drawing.Color.Transparent;
            this.grThongTinSanPham.Controls.Add(this.txtTimKiem);
            this.grThongTinSanPham.Controls.Add(this.label9);
            this.grThongTinSanPham.Controls.Add(this.txtGiaban);
            this.grThongTinSanPham.Controls.Add(this.label8);
            this.grThongTinSanPham.Controls.Add(this.BtnTao);
            this.grThongTinSanPham.Controls.Add(this.cbbnhacungcap);
            this.grThongTinSanPham.Controls.Add(this.label7);
            this.grThongTinSanPham.Controls.Add(this.btnClear);
            this.grThongTinSanPham.Controls.Add(this.btnSua);
            this.grThongTinSanPham.Controls.Add(this.btnXoa);
            this.grThongTinSanPham.Controls.Add(this.btnThem);
            this.grThongTinSanPham.Controls.Add(this.txtMoTa);
            this.grThongTinSanPham.Controls.Add(this.txtSoLuong);
            this.grThongTinSanPham.Controls.Add(this.txtGia);
            this.grThongTinSanPham.Controls.Add(this.txtTenSP);
            this.grThongTinSanPham.Controls.Add(this.txtMaSP);
            this.grThongTinSanPham.Controls.Add(this.label3);
            this.grThongTinSanPham.Controls.Add(this.label6);
            this.grThongTinSanPham.Controls.Add(this.label2);
            this.grThongTinSanPham.Controls.Add(this.label5);
            this.grThongTinSanPham.Controls.Add(this.label4);
            this.grThongTinSanPham.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinSanPham.ForeColor = System.Drawing.Color.Red;
            this.grThongTinSanPham.Location = new System.Drawing.Point(12, 38);
            this.grThongTinSanPham.Name = "grThongTinSanPham";
            this.grThongTinSanPham.Size = new System.Drawing.Size(845, 193);
            this.grThongTinSanPham.TabIndex = 9;
            this.grThongTinSanPham.TabStop = false;
            this.grThongTinSanPham.Text = "Thông Tin Sản Phẩm";
            this.grThongTinSanPham.Enter += new System.EventHandler(this.grThongTinSanPham_Enter);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(306, 160);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(264, 22);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(211, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tìm Kiếm";
            // 
            // txtGiaban
            // 
            this.txtGiaban.BackColor = System.Drawing.Color.White;
            this.txtGiaban.ForeColor = System.Drawing.Color.Blue;
            this.txtGiaban.Location = new System.Drawing.Point(449, 25);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(168, 22);
            this.txtGiaban.TabIndex = 5;
            this.txtGiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaban_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(386, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Giá bán";
            // 
            // BtnTao
            // 
            this.BtnTao.Location = new System.Drawing.Point(306, 23);
            this.BtnTao.Name = "BtnTao";
            this.BtnTao.Size = new System.Drawing.Size(52, 23);
            this.BtnTao.TabIndex = 12;
            this.BtnTao.Text = "Tạo";
            this.BtnTao.UseVisualStyleBackColor = true;
            this.BtnTao.Click += new System.EventHandler(this.BtnTao_Click);
            // 
            // cbbnhacungcap
            // 
            this.cbbnhacungcap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbnhacungcap.FormattingEnabled = true;
            this.cbbnhacungcap.Location = new System.Drawing.Point(112, 125);
            this.cbbnhacungcap.Name = "cbbnhacungcap";
            this.cbbnhacungcap.Size = new System.Drawing.Size(188, 23);
            this.cbbnhacungcap.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(18, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nhà cung cấp";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::frm1.Properties.Resources.refesh;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(738, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 66);
            this.btnClear.TabIndex = 11;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::frm1.Properties.Resources.sua1;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(653, 30);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 66);
            this.btnSua.TabIndex = 8;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::frm1.Properties.Resources.xoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(653, 102);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 66);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::frm1.Properties.Resources.them;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(738, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 66);
            this.btnThem.TabIndex = 9;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.Color.White;
            this.txtMoTa.ForeColor = System.Drawing.Color.Blue;
            this.txtMoTa.Location = new System.Drawing.Point(449, 87);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(168, 61);
            this.txtMoTa.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.ForeColor = System.Drawing.Color.Blue;
            this.txtSoLuong.Location = new System.Drawing.Point(112, 89);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(188, 22);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.ForeColor = System.Drawing.Color.Blue;
            this.txtGia.Location = new System.Drawing.Point(449, 56);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(168, 22);
            this.txtGia.TabIndex = 6;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.White;
            this.txtTenSP.ForeColor = System.Drawing.Color.Blue;
            this.txtTenSP.Location = new System.Drawing.Point(112, 56);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(188, 22);
            this.txtTenSP.TabIndex = 2;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.White;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.ForeColor = System.Drawing.Color.Blue;
            this.txtMaSP.Location = new System.Drawing.Point(112, 24);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(188, 22);
            this.txtMaSP.TabIndex = 1;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(386, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mô Tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(18, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(386, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Sản Phẩm";
            // 
            // dtgSanPham
            // 
            this.dtgSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.MoTa,
            this.SoLuong,
            this.DonGia,
            this.NCC,
            this.GiaBan});
            this.dtgSanPham.Location = new System.Drawing.Point(12, 229);
            this.dtgSanPham.Name = "dtgSanPham";
            this.dtgSanPham.Size = new System.Drawing.Size(845, 218);
            this.dtgSanPham.TabIndex = 13;
            this.dtgSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSanPham_CellContentClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.Name = "MoTa";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Giá Nhập";
            this.DonGia.Name = "DonGia";
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "NCC";
            this.NCC.HeaderText = "Nhà Cung Cấp";
            this.NCC.Name = "NCC";
            this.NCC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NCC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::frm1.Properties.Resources.BTNBACK2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 36);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::frm1.Properties.Resources.nen41;
            this.ClientSize = new System.Drawing.Size(869, 454);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgSanPham);
            this.Controls.Add(this.grThongTinSanPham);
            this.Controls.Add(this.label1);
            this.Name = "frmQLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmQLSP_Load);
            this.grThongTinSanPham.ResumeLayout(false);
            this.grThongTinSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grThongTinSanPham;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.DataGridView dtgSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbnhacungcap;
        private System.Windows.Forms.Button BtnTao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}