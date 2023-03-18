using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace frm1
{
    public partial class qlKhachhang : Form
    {
        KhachHangBUS _khahangBUS = new KhachHangBUS();
        NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        public qlKhachhang()
        {
            InitializeComponent();
        }
        private void qlKhachhang_Load(object sender, EventArgs e)
        {
            dtgkhachhang.DataSource = _khahangBUS.laydanhsachkhachhang();
        }

        private void dtgkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtMakhachhang.Enabled = false;
            btnthem.Enabled = false;
            btnTaoMAKH.Enabled = false;
            txtMakhachhang.Text = dtgkhachhang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenKhachang.Text = dtgkhachhang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdiachikh.Text = dtgkhachhang.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsdtkh.Text = dtgkhachhang.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dtgkhachhang.Rows[e.RowIndex].Cells[1].Value.ToString() == Contrants.nam)
            {
                rdNam.Checked = true;
            }
            else
            {
                if (dtgkhachhang.Rows[e.RowIndex].Cells[1].Value.ToString() == Contrants.nu)
                    rdNu.Checked = true;
                else
                    rdKhac.Checked = true;
            }
        }

        private void btnTaoMAKH_Click(object sender, EventArgs e)
        {
            int k=_khahangBUS.layIdkhachhang()+1;
            if (k < 1)
            {
                txtMakhachhang.Text = Contrants.KH + 1 +Contrants.cach;
            }
            else
            {
                txtMakhachhang.Text = Contrants.KH + k +Contrants.cach;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtgkhachhang.DataSource = _khahangBUS.TimKiem(txtTimKiem.Text);
        }

     
        private void button1_Click_1(object sender, EventArgs e)
        {

            frmQuanLiHoaDon fr = new frmQuanLiHoaDon();
            fr.Show();
            this.Hide();
        }

        private void btnThemkh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtsdtkh.Text)
                || string.IsNullOrEmpty(txtTenKhachang.Text) || string.IsNullOrEmpty(txtMakhachhang.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (txtsdtkh.Text.Length != 10)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            if (_nhanvienBUS.IsNumber(txtsdtkh.Text) == false)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (_khahangBUS.kiemtraKhachHang(txtMakhachhang.Text))
                {
                    MessageBox.Show(Contrants.MaDaTonTai, Contrants.ThongBao, MessageBoxButtons.OK);
                    return;
                }
                else
                {

                    string gioitinh;
                    if (rdNam.Checked)
                    {
                        gioitinh = Contrants.nam;
                    }
                    else
                    {
                        if (rdNu.Checked)
                            gioitinh = Contrants.nu;
                        else
                            gioitinh = Contrants.khac;
                    }
                    KhachHangDTO kh = new KhachHangDTO
                    {
                        GioiTinh = gioitinh,
                        MaKH = txtMakhachhang.Text,
                        TenKH = txtTenKhachang.Text,
                        DiaChi = txtdiachikh.Text,
                        SDT = txtsdtkh.Text
                    };
                    int n = _khahangBUS.themkhachhang(kh);
                    if (n > 0)
                    {
                        MessageBox.Show(Contrants.ThemThanhCong, Contrants.ThongBao, MessageBoxButtons.OK);
                        dtgkhachhang.DataSource = _khahangBUS.laydanhsachkhachhang();
                        txtMakhachhang.Enabled = true;
                        txtMakhachhang.Text = string.Empty;
                        txtdiachikh.Text = string.Empty;
                        txtsdtkh.Text = string.Empty;
                        txtTenKhachang.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show(Contrants.ThemThatbai, Contrants.ThongBao, MessageBoxButtons.OK);
                        txtMakhachhang.Enabled = true;
                        txtMakhachhang.Text = string.Empty;
                        txtdiachikh.Text = string.Empty;
                        txtsdtkh.Text = string.Empty;
                        txtTenKhachang.Text = string.Empty;
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtsdtkh.Text)
               || string.IsNullOrEmpty(txtTenKhachang.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (txtsdtkh.Text.Length != 10)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            if (_nhanvienBUS.IsNumber(txtsdtkh.Text) == false)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            else
            {
                string gioitinh;
                if (rdNam.Checked)
                {
                    gioitinh = Contrants.nam;
                }
                else
                {
                    if (rdNu.Checked)
                        gioitinh = Contrants.nu;
                    else
                        gioitinh = Contrants.khac;
                }
                KhachHangDTO kh = new KhachHangDTO
                {
                    GioiTinh = gioitinh,
                    MaKH = txtMakhachhang.Text,
                    TenKH = txtTenKhachang.Text,
                    DiaChi = txtdiachikh.Text,
                    SDT = txtsdtkh.Text
                };
                int n = _khahangBUS.capnhatkhachhang(kh);
                if (n > 0)
                {
                    MessageBox.Show(Contrants.CapnhatThanhCong, Contrants.ThongBao, MessageBoxButtons.OK);
                    dtgkhachhang.DataSource = _khahangBUS.laydanhsachkhachhang();
                    txtMakhachhang.Enabled = true;
                    txtMakhachhang.Text = string.Empty;
                    txtdiachikh.Text = string.Empty;
                    txtsdtkh.Text = string.Empty;
                    txtTenKhachang.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(Contrants.CapNhatThatBai, Contrants.ThongBao, MessageBoxButtons.OK);
                    txtMakhachhang.Enabled = true;
                    txtMakhachhang.Text = string.Empty;
                    txtdiachikh.Text = string.Empty;
                    txtsdtkh.Text = string.Empty;
                    txtTenKhachang.Text = string.Empty;
                }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMakhachhang.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (_khahangBUS.kiemtraKhachHangtheoHD(txtMakhachhang.Text))
            {
                MessageBox.Show(Contrants.khachhangcontontai, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            else
            {
               
                KhachHangDTO kh = new KhachHangDTO
                {
                    MaKH = txtMakhachhang.Text,
                    TenKH = txtTenKhachang.Text,
                    DiaChi = txtdiachikh.Text,
                    SDT = txtsdtkh.Text
                };
                DialogResult resut = MessageBox.Show(Contrants.Bancochachanmuonxoa, Contrants.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resut == DialogResult.Yes)
                {
                    int n = _khahangBUS.xoakhachhang(kh);
                    if (n > 0)
                    {
                        MessageBox.Show(Contrants.XoaThanhCong, Contrants.ThongBao, MessageBoxButtons.OK);
                        txtMakhachhang.Enabled = true;
                        txtMakhachhang.Text = string.Empty;
                        txtdiachikh.Text = string.Empty;
                        txtsdtkh.Text = string.Empty;
                        txtTenKhachang.Text = string.Empty;
                        dtgkhachhang.DataSource = _khahangBUS.laydanhsachkhachhang();
                    }
                    else
                    {
                        MessageBox.Show(Contrants.XoaThatBai, Contrants.ThongBao, MessageBoxButtons.OK);
                        txtMakhachhang.Enabled = true;
                        txtMakhachhang.Text = string.Empty;
                        txtdiachikh.Text = string.Empty;
                        txtsdtkh.Text = string.Empty;
                        txtTenKhachang.Text = string.Empty;
                    }
                }
                else
                {
                    txtMakhachhang.Enabled = true;
                    txtMakhachhang.Text = string.Empty;
                    txtdiachikh.Text = string.Empty;
                    txtsdtkh.Text = string.Empty;
                    txtTenKhachang.Text = string.Empty;
                    return;
                }
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
            txtMakhachhang.Enabled = true;
            btnTaoMAKH.Enabled = true;
            txtMakhachhang.Text = string.Empty;
            txtdiachikh.Text = string.Empty;
            txtsdtkh.Text = string.Empty;
            txtTenKhachang.Text = string.Empty;
        }

        private void txtsdtkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
