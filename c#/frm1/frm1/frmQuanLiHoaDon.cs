using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace frm1
{
    
    public partial class frmQuanLiHoaDon : Form
    {
        KhachHangBUS _khahangBUS = new KhachHangBUS();
        NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        SanPhamBUS _sanphamBUS = new SanPhamBUS();
        CT_HoaDonBUS _cthoadonBUS = new CT_HoaDonBUS();
        HoaDonBUS _hoadonBUS = new HoaDonBUS();
        public frmQuanLiHoaDon()
        {
            InitializeComponent();
            dtgHoaDon.AutoGenerateColumns = false;
        }
        private void frmQuanLiHoaDon_Load(object sender, EventArgs e)
        {
            cbbTenNVHD.DataSource = _nhanvienBUS.laydanhsachnhanvien();
            cbbTenNVHD.DisplayMember =Contrants.TenNV;
            cbbTenNVHD.ValueMember =Contrants.MaNV;
            cbbkhachhangHD.DataSource = _khahangBUS.laydanhsachkhachhang();
            cbbkhachhangHD.DisplayMember = Contrants.SDTHOA;
            cbbkhachhangHD.ValueMember = Contrants.MaKH;
            TenNVLap.DataSource = _nhanvienBUS.laydsTatCaNV();
            TenNVLap.DisplayMember = Contrants.TenNV;
            TenNVLap.ValueMember = Contrants.MaNV;
            TenNVLap.DataPropertyName = Contrants.MaNV;
            sdtKH.DataSource = _khahangBUS.laydanhsachTatCakhachhang();
            sdtKH.DisplayMember = Contrants.SDTHOA;
            sdtKH.ValueMember = Contrants.MaKH;
            sdtKH.DataPropertyName = Contrants.MaKH;
            dtgHoaDon.DataSource = _hoadonBUS.danhsachhoadon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           // double tongtien = 0;

            if (string.IsNullOrEmpty(cbbkhachhangHD.Text)
                ||string.IsNullOrEmpty(cbbTenNVHD.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            if (_nhanvienBUS.IsNumber(cbbkhachhangHD.Text) == false)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }

            else
            {
                if(_khahangBUS.kiemtraSDTKH(cbbkhachhangHD.Text)==false)
                {
                    MessageBox.Show(Contrants.ktSDT, Contrants.ThongBao, MessageBoxButtons.OK);
                    return;
                }
                int m = 1 + _hoadonBUS.layIDSHoaDon();
                if(m>=1)
                {
                    txtMahoadonHD.Text = Contrants.HD + m + Contrants.cach;
                }
                else
                {
                    txtMahoadonHD.Text = Contrants.HD + 1 +Contrants.cach;  
                }
                    HoaDonDTO hd = new HoaDonDTO
                    {
                        MaHD = txtMahoadonHD.Text,
                        MaNV = _hoadonBUS.laymanhanvien(cbbTenNVHD.Text),
                        sdtKH = cbbkhachhangHD.Text,
                        NgayLapHD = dtpNgayLapHoaDonHD.Value
                    };
                    int n = _hoadonBUS.themHoaDon(hd);
                    if (n > 0)
                    {
                        MessageBox.Show(Contrants.ThemThanhCong,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                         dtgHoaDon.DataSource = _hoadonBUS.danhsachhoadon();
                        txtMahoadonHD.Text = string.Empty;
                        txtTimKiem.Text = string.Empty;
                        dtpNgayLapHoaDonHD.Value = DateTime.Now;
                        cbbkhachhangHD.Text = string.Empty;
                        cbbTenNVHD.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show(Contrants.ThemThatbai,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMahoadonHD.Text = string.Empty;
                        txtTimKiem.Text = string.Empty;
                        dtpNgayLapHoaDonHD.Value = DateTime.Now;
                        cbbkhachhangHD.Text = string.Empty;
                        cbbTenNVHD.Text = string.Empty;
                        return;
                    }
                    frmthemhoadon fr = new frmthemhoadon();
                    fr.Show();
                    this.Hide();
                }
            
     }
        private void btnthemkhang_Click(object sender, EventArgs e)
        {
            qlKhachhang frm = new qlKhachhang();
            frm.Show();
            this.Hide();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_nhanvienBUS.IsNumber(cbbkhachhangHD.Text) == false)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            if (_khahangBUS.kiemtraSDTKH(cbbkhachhangHD.Text) == false)
            {
                MessageBox.Show(Contrants.ktSDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(txtMahoadonHD.Text) || string.IsNullOrEmpty(cbbkhachhangHD.SelectedItem.ToString())
               || string.IsNullOrEmpty(cbbTenNVHD.SelectedItem.ToString()))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
          
            else
            {
                HoaDonDTO hd = new HoaDonDTO
                {
                    MaHD = txtMahoadonHD.Text,
                    MaNV = _hoadonBUS.laymanhanvien(cbbTenNVHD.Text),
                    sdtKH = cbbkhachhangHD.Text,
                    NgayLapHD = dtpNgayLapHoaDonHD.Value
                };
                int n = _hoadonBUS.capNhatHoaDon(hd);
                if (n > 0)
                {
                    MessageBox.Show(Contrants.CapnhatThanhCong, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgHoaDon.DataSource = _hoadonBUS.danhsachhoadon();
                    txtMahoadonHD.Text = string.Empty;
                    txtTimKiem.Text = string.Empty;
                    dtpNgayLapHoaDonHD.Value = DateTime.Now;
                    cbbkhachhangHD.Text = string.Empty;
                    cbbTenNVHD.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(Contrants.CapNhatThatBai, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMahoadonHD.Text = string.Empty;
                    txtTimKiem.Text = string.Empty;
                    dtpNgayLapHoaDonHD.Value = DateTime.Now;
                    cbbkhachhangHD.Text = string.Empty;
                    cbbTenNVHD.Text = string.Empty;
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMahoadonHD.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            if(_hoadonBUS.kiemtraHoaDon(txtMahoadonHD.Text))
            {
                MessageBox.Show(Contrants.hoadoncontontai,Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            HoaDonDTO hd = new HoaDonDTO
            {
                MaHD = txtMahoadonHD.Text,
                MaNV = _hoadonBUS.laymanhanvien(cbbTenNVHD.Text),
                sdtKH = cbbkhachhangHD.Text,
                NgayLapHD = dtpNgayLapHoaDonHD.Value
            };
            DialogResult resut = MessageBox.Show(Contrants.Bancochachanmuonxoa, Contrants.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resut == DialogResult.Yes)
            {
                int n = _hoadonBUS.xoaHoaDon(hd);
                if (n > 0)
                {
                    MessageBox.Show(Contrants.XoaThanhCong, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgHoaDon.DataSource = _hoadonBUS.danhsachhoadon();
                    txtMahoadonHD.Text = string.Empty;
                    txtTimKiem.Text = string.Empty;
                    dtpNgayLapHoaDonHD.Value = DateTime.Now;
                    cbbkhachhangHD.Text = string.Empty;
                    cbbTenNVHD.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(Contrants.XoaThatBai, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMahoadonHD.Text = string.Empty;
                    txtTimKiem.Text = string.Empty;
                    dtpNgayLapHoaDonHD.Value = DateTime.Now;
                    cbbkhachhangHD.Text = string.Empty;
                    cbbTenNVHD.Text = string.Empty;
                }
            }
            else
            {
                txtMahoadonHD.Text = string.Empty;
                txtTimKiem.Text = string.Empty;
                dtpNgayLapHoaDonHD.Value = DateTime.Now;
                cbbkhachhangHD.Text = string.Empty;
                cbbTenNVHD.Text = string.Empty;
                return;
            }
           
        }
        private void dtgHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMahoadonHD.Enabled = false;
            btnThem.Enabled = false;
            txtMahoadonHD.Text = dtgHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbbkhachhangHD.SelectedValue = dtgHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbbTenNVHD.SelectedValue = dtgHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbbTenNVHD.DisplayMember = dtgHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
           dtgHoaDon.DataSource= _hoadonBUS.TimKiemHoaDon(txtTimKiem.Text);

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtMahoadonHD.Text = string.Empty;
            txtTimKiem.Text = string.Empty;
            dtpNgayLapHoaDonHD.Value = DateTime.Now;
            cbbkhachhangHD.Text = string.Empty;
            cbbTenNVHD.Text = string.Empty;
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            frmCha fr = new frmCha();
            fr.Show();
            this.Hide();
        }

        private void cbbkhachhangHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

    }
}
