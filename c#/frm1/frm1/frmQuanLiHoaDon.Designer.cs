namespace frm1
{
    partial class frmQuanLiHoaDon
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
            this.dtgHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenNVLap = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayLapHoaDonHD = new System.Windows.Forms.DateTimePicker();
            this.cbbkhachhangHD = new System.Windows.Forms.ComboBox();
            this.txtMahoadonHD = new System.Windows.Forms.TextBox();
            this.btnthemkhang = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbTenNVHD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHoaDon
            // 
            this.dtgHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.sdtKH,
            this.TenNVLap,
            this.NgayLapHD,
            this.TongTien});
            this.dtgHoaDon.Location = new System.Drawing.Point(-1, 188);
            this.dtgHoaDon.Name = "dtgHoaDon";
            this.dtgHoaDon.Size = new System.Drawing.Size(895, 320);
            this.dtgHoaDon.TabIndex = 10;
            this.dtgHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHoaDon_CellContentClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.Name = "MaHD";
            // 
            // sdtKH
            // 
            this.sdtKH.HeaderText = "Số Điện Thoại Khách hàng";
            this.sdtKH.Name = "sdtKH";
            this.sdtKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sdtKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TenNVLap
            // 
            this.TenNVLap.HeaderText = "Nhân Viên Lập";
            this.TenNVLap.Name = "TenNVLap";
            this.TenNVLap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenNVLap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày Lập";
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SĐT Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân Viên Lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(342, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(342, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Lập ";
            // 
            // dtpNgayLapHoaDonHD
            // 
            this.dtpNgayLapHoaDonHD.Location = new System.Drawing.Point(427, 98);
            this.dtpNgayLapHoaDonHD.Name = "dtpNgayLapHoaDonHD";
            this.dtpNgayLapHoaDonHD.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayLapHoaDonHD.TabIndex = 4;
            // 
            // cbbkhachhangHD
            // 
            this.cbbkhachhangHD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbkhachhangHD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbkhachhangHD.FormattingEnabled = true;
            this.cbbkhachhangHD.Items.AddRange(new object[] {
            "1234",
            "5678"});
            this.cbbkhachhangHD.Location = new System.Drawing.Point(126, 57);
            this.cbbkhachhangHD.Name = "cbbkhachhangHD";
            this.cbbkhachhangHD.Size = new System.Drawing.Size(129, 21);
            this.cbbkhachhangHD.TabIndex = 1;
            this.cbbkhachhangHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbkhachhangHD_KeyPress);
            // 
            // txtMahoadonHD
            // 
            this.txtMahoadonHD.Enabled = false;
            this.txtMahoadonHD.Location = new System.Drawing.Point(427, 57);
            this.txtMahoadonHD.Name = "txtMahoadonHD";
            this.txtMahoadonHD.Size = new System.Drawing.Size(121, 20);
            this.txtMahoadonHD.TabIndex = 3;
            // 
            // btnthemkhang
            // 
            this.btnthemkhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemkhang.Location = new System.Drawing.Point(271, 57);
            this.btnthemkhang.Name = "btnthemkhang";
            this.btnthemkhang.Size = new System.Drawing.Size(50, 23);
            this.btnthemkhang.TabIndex = 12;
            this.btnthemkhang.Text = "Thêm";
            this.btnthemkhang.UseVisualStyleBackColor = true;
            this.btnthemkhang.Click += new System.EventHandler(this.btnthemkhang_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::frm1.Properties.Resources.refesh;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(733, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 66);
            this.btnClear.TabIndex = 8;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::frm1.Properties.Resources.sua1;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(653, 44);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 66);
            this.btnSua.TabIndex = 5;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::frm1.Properties.Resources.xoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(653, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 66);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::frm1.Properties.Resources.them;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(733, 44);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 66);
            this.btnThem.TabIndex = 6;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbTenNVHD
            // 
            this.cbbTenNVHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNVHD.FormattingEnabled = true;
            this.cbbTenNVHD.Location = new System.Drawing.Point(126, 101);
            this.cbbTenNVHD.Name = "cbbTenNVHD";
            this.cbbTenNVHD.Size = new System.Drawing.Size(129, 21);
            this.cbbTenNVHD.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(217, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tìm Kiếm";
            this.label6.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(321, 157);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(264, 25);
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(292, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::frm1.Properties.Resources.BTNBACK2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 39);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmQuanLiHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::frm1.Properties.Resources.nen5;
            this.ClientSize = new System.Drawing.Size(894, 503);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cbbTenNVHD);
            this.Controls.Add(this.btnthemkhang);
            this.Controls.Add(this.txtMahoadonHD);
            this.Controls.Add(this.cbbkhachhangHD);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayLapHoaDonHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgHoaDon);
            this.Name = "frmQuanLiHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.frmQuanLiHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHoaDonHD;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbkhachhangHD;
        private System.Windows.Forms.TextBox txtMahoadonHD;
        private System.Windows.Forms.ComboBox cbbTenNVHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn sdtKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenNVLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnthemkhang;
    }
}