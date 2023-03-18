namespace frm1
{
    partial class frmbaocao
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbHoaDonTN = new System.Windows.Forms.ComboBox();
            this.cbbTheoNCC = new System.Windows.Forms.ComboBox();
            this.rbtXemTatCaHD = new System.Windows.Forms.RadioButton();
            this.rbtSanPhamTNCC = new System.Windows.Forms.RadioButton();
            this.rbtHoaDonNgay = new System.Windows.Forms.RadioButton();
            this.rbtSanPhamNhomNCC = new System.Windows.Forms.RadioButton();
            this.rbtTatCaSP = new System.Windows.Forms.RadioButton();
            this.btnxembaocao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBack.BackgroundImage = global::frm1.Properties.Resources.BTNBACK2;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(317, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(72, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Báo cáo thống kê";
            // 
            // cbbHoaDonTN
            // 
            this.cbbHoaDonTN.ForeColor = System.Drawing.Color.Red;
            this.cbbHoaDonTN.FormattingEnabled = true;
            this.cbbHoaDonTN.Location = new System.Drawing.Point(187, 210);
            this.cbbHoaDonTN.Name = "cbbHoaDonTN";
            this.cbbHoaDonTN.Size = new System.Drawing.Size(126, 21);
            this.cbbHoaDonTN.TabIndex = 25;
            // 
            // cbbTheoNCC
            // 
            this.cbbTheoNCC.ForeColor = System.Drawing.Color.Red;
            this.cbbTheoNCC.FormattingEnabled = true;
            this.cbbTheoNCC.Location = new System.Drawing.Point(187, 176);
            this.cbbTheoNCC.Name = "cbbTheoNCC";
            this.cbbTheoNCC.Size = new System.Drawing.Size(126, 21);
            this.cbbTheoNCC.TabIndex = 26;
            // 
            // rbtXemTatCaHD
            // 
            this.rbtXemTatCaHD.AutoSize = true;
            this.rbtXemTatCaHD.BackColor = System.Drawing.Color.Transparent;
            this.rbtXemTatCaHD.ForeColor = System.Drawing.Color.Yellow;
            this.rbtXemTatCaHD.Location = new System.Drawing.Point(39, 111);
            this.rbtXemTatCaHD.Name = "rbtXemTatCaHD";
            this.rbtXemTatCaHD.Size = new System.Drawing.Size(99, 17);
            this.rbtXemTatCaHD.TabIndex = 19;
            this.rbtXemTatCaHD.TabStop = true;
            this.rbtXemTatCaHD.Text = "Tất cả hóa đơn";
            this.rbtXemTatCaHD.UseVisualStyleBackColor = false;
            // 
            // rbtSanPhamTNCC
            // 
            this.rbtSanPhamTNCC.AutoSize = true;
            this.rbtSanPhamTNCC.BackColor = System.Drawing.Color.Transparent;
            this.rbtSanPhamTNCC.ForeColor = System.Drawing.Color.Yellow;
            this.rbtSanPhamTNCC.Location = new System.Drawing.Point(39, 177);
            this.rbtSanPhamTNCC.Name = "rbtSanPhamTNCC";
            this.rbtSanPhamTNCC.Size = new System.Drawing.Size(142, 17);
            this.rbtSanPhamTNCC.TabIndex = 20;
            this.rbtSanPhamTNCC.TabStop = true;
            this.rbtSanPhamTNCC.Text = "Sản phẩm nhà cung cấp";
            this.rbtSanPhamTNCC.UseVisualStyleBackColor = false;
            // 
            // rbtHoaDonNgay
            // 
            this.rbtHoaDonNgay.AutoSize = true;
            this.rbtHoaDonNgay.BackColor = System.Drawing.Color.Transparent;
            this.rbtHoaDonNgay.ForeColor = System.Drawing.Color.Yellow;
            this.rbtHoaDonNgay.Location = new System.Drawing.Point(39, 211);
            this.rbtHoaDonNgay.Name = "rbtHoaDonNgay";
            this.rbtHoaDonNgay.Size = new System.Drawing.Size(117, 17);
            this.rbtHoaDonNgay.TabIndex = 21;
            this.rbtHoaDonNgay.TabStop = true;
            this.rbtHoaDonNgay.Text = "Hóa đơn theo ngày";
            this.rbtHoaDonNgay.UseVisualStyleBackColor = false;
            // 
            // rbtSanPhamNhomNCC
            // 
            this.rbtSanPhamNhomNCC.AutoSize = true;
            this.rbtSanPhamNhomNCC.BackColor = System.Drawing.Color.Transparent;
            this.rbtSanPhamNhomNCC.ForeColor = System.Drawing.Color.Yellow;
            this.rbtSanPhamNhomNCC.Location = new System.Drawing.Point(39, 144);
            this.rbtSanPhamNhomNCC.Name = "rbtSanPhamNhomNCC";
            this.rbtSanPhamNhomNCC.Size = new System.Drawing.Size(195, 17);
            this.rbtSanPhamNhomNCC.TabIndex = 22;
            this.rbtSanPhamNhomNCC.TabStop = true;
            this.rbtSanPhamNhomNCC.Text = "Sản phẩm theo nhóm nhà cung cấp";
            this.rbtSanPhamNhomNCC.UseVisualStyleBackColor = false;
            // 
            // rbtTatCaSP
            // 
            this.rbtTatCaSP.AutoSize = true;
            this.rbtTatCaSP.BackColor = System.Drawing.Color.Transparent;
            this.rbtTatCaSP.ForeColor = System.Drawing.Color.Yellow;
            this.rbtTatCaSP.Location = new System.Drawing.Point(39, 79);
            this.rbtTatCaSP.Name = "rbtTatCaSP";
            this.rbtTatCaSP.Size = new System.Drawing.Size(105, 17);
            this.rbtTatCaSP.TabIndex = 24;
            this.rbtTatCaSP.TabStop = true;
            this.rbtTatCaSP.Text = "Tất cả sản phẩm";
            this.rbtTatCaSP.UseVisualStyleBackColor = false;
            // 
            // btnxembaocao
            // 
            this.btnxembaocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnxembaocao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxembaocao.ForeColor = System.Drawing.Color.Red;
            this.btnxembaocao.Location = new System.Drawing.Point(132, 257);
            this.btnxembaocao.Name = "btnxembaocao";
            this.btnxembaocao.Size = new System.Drawing.Size(104, 23);
            this.btnxembaocao.TabIndex = 18;
            this.btnxembaocao.Text = "Xem báo cáo";
            this.btnxembaocao.UseVisualStyleBackColor = false;
            this.btnxembaocao.Click += new System.EventHandler(this.btnxembaocao_Click);
            // 
            // frmbaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::frm1.Properties.Resources.nen3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(377, 323);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbHoaDonTN);
            this.Controls.Add(this.cbbTheoNCC);
            this.Controls.Add(this.rbtXemTatCaHD);
            this.Controls.Add(this.rbtSanPhamTNCC);
            this.Controls.Add(this.rbtHoaDonNgay);
            this.Controls.Add(this.rbtSanPhamNhomNCC);
            this.Controls.Add(this.rbtTatCaSP);
            this.Controls.Add(this.btnxembaocao);
            this.Controls.Add(this.btnBack);
            this.Name = "frmbaocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.frmbaocao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbHoaDonTN;
        private System.Windows.Forms.ComboBox cbbTheoNCC;
        private System.Windows.Forms.RadioButton rbtXemTatCaHD;
        private System.Windows.Forms.RadioButton rbtSanPhamTNCC;
        private System.Windows.Forms.RadioButton rbtHoaDonNgay;
        private System.Windows.Forms.RadioButton rbtSanPhamNhomNCC;
        private System.Windows.Forms.RadioButton rbtTatCaSP;
        private System.Windows.Forms.Button btnxembaocao;

    }
}