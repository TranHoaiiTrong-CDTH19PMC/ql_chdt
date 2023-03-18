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
    public partial class frmQLSP : Form
    {
        SanPhamBUS _sanphamBUS = new SanPhamBUS();
        NhaCungCapBUS _nhacungcapBUS = new NhaCungCapBUS();
        HoaDonBUS _hoadonBUS = new HoaDonBUS();
        public frmQLSP()
        {
            InitializeComponent();
            dtgSanPham.AutoGenerateColumns = false;
        }
        private void frmQLSP_Load(object sender, EventArgs e)
        {
            cbbnhacungcap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
            cbbnhacungcap.DisplayMember = Contrants.TenNCC;
            cbbnhacungcap.ValueMember =  Contrants.MaNCC;
            NCC.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
            NCC.DisplayMember = Contrants.TenNCC;
            NCC.ValueMember = Contrants.MaNCC;
            NCC.DataPropertyName = Contrants.MaNCC;
            dtgSanPham.DataSource = _sanphamBUS.laydssapham();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtGia.Text)
                || string.IsNullOrEmpty(txtMoTa.Text) || string.IsNullOrEmpty((txtSoLuong.Text))
                 || string.IsNullOrEmpty(cbbnhacungcap.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text)
                || string.IsNullOrWhiteSpace(txtGia.Text) || string.IsNullOrWhiteSpace(txtMoTa.Text) || string.IsNullOrWhiteSpace(txtGiaban.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            else
            {
                int m;
                float k, l;
                try
                {
                    m=int.Parse(txtSoLuong.Text);
                    k=float.Parse(txtGiaban.Text);
                    l=float.Parse(txtGia.Text);
                }catch(Exception)
                {
                    MessageBox.Show(Contrants.So, Contrants.ThongBao, MessageBoxButtons.OK);
                    return;
                }
                if (float.Parse(txtGiaban.Text) > 2000000000 || float.Parse(txtGia.Text) > 1000000000 || int.Parse(txtSoLuong.Text) > 1000
                   || float.Parse(txtGiaban.Text) < 0 || float.Parse(txtGia.Text) < 0 || int.Parse(txtSoLuong.Text) < 0)
                {
                    MessageBox.Show("Bạn hãy kiểm tra lại giá nhập,giá bán hoặc số lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (float.Parse(txtGiaban.Text) < float.Parse(txtGia.Text))
                {
                    DialogResult redut = MessageBox.Show("Giá bán đang nhỏ hơn đơn giá bạn có muốn tiếp tục cập nhật sản phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (redut == DialogResult.No)
                        return;
                }
                SanPhamDTO sp = new SanPhamDTO
                      {
                          MaSP = txtMaSP.Text,
                          TenSP = txtTenSP.Text,
                          SoLuong = Convert.ToInt32(txtSoLuong.Text),
                          DonGia = Convert.ToDouble(txtGia.Text),
                          MoTa = txtMoTa.Text,
                          MaNCC = Convert.ToString(cbbnhacungcap.SelectedValue),
                          GiaBan = Convert.ToDouble(txtGiaban.Text)
                      };

                int n = _sanphamBUS.capnhatsanpham(sp);
                if (n > 0)
                {
                    MessageBox.Show(Contrants.CapnhatThanhCong, Contrants.ThongBao, MessageBoxButtons.OK);
                    dtgSanPham.DataSource = _sanphamBUS.laydssapham();
                    txtGia.Text = string.Empty;
                    txtMaSP.Text = string.Empty;
                    txtMoTa.Text = string.Empty;
                    txtSoLuong.Text = string.Empty;
                    txtTenSP.Text = string.Empty;
                    txtGiaban.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(Contrants.CapNhatThatBai, Contrants.ThongBao, MessageBoxButtons.OK);
                    txtGia.Text = string.Empty;
                    txtMaSP.Text = string.Empty;
                    txtMoTa.Text = string.Empty;
                    txtSoLuong.Text = string.Empty;
                    txtTenSP.Text = string.Empty;
                    txtGiaban.Text = string.Empty;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text)||  string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtGia.Text)
                || string.IsNullOrEmpty(txtMoTa.Text) || string.IsNullOrEmpty((txtSoLuong.Text))
                ||string.IsNullOrEmpty(cbbnhacungcap.Text)||string.IsNullOrEmpty(txtGiaban.Text) ||string.IsNullOrWhiteSpace(txtTenSP.Text)
                || string.IsNullOrWhiteSpace(txtGia.Text) || string.IsNullOrWhiteSpace(txtMoTa.Text) || string.IsNullOrWhiteSpace(txtGiaban.Text)
                )
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_sanphamBUS.kiemtrasanpham(txtMaSP.Text))
            {
                MessageBox.Show(Contrants.MaDaTonTai,Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
           
            else
            {
                int m;
                float k, l;
                try
                {
                    m = int.Parse(txtSoLuong.Text);
                    k = float.Parse(txtGiaban.Text);
                    l = float.Parse(txtGia.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(Contrants.So,Contrants.ThongBao, MessageBoxButtons.OK);
                    return;
                }
                if (float.Parse(txtGiaban.Text) > 2000000000 || float.Parse(txtGia.Text) > 1000000000 || int.Parse(txtSoLuong.Text)>1000
                    || float.Parse(txtGiaban.Text) < 0 || float.Parse(txtGia.Text) < 0 || int.Parse(txtSoLuong.Text)<0)
                {
                    MessageBox.Show("Bạn hãy kiểm tra lại giá nhập,giá bán hoặc số lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(float.Parse(txtGiaban.Text)<float.Parse(txtGia.Text))
                {
                   DialogResult redut= MessageBox.Show("Giá bán đang nhỏ hơn đơn giá bạn có muốn tiếp tục thêm sản phẩm", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                   if (redut == DialogResult.No)
                       return;
                }
                SanPhamDTO sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text,
                    TenSP = txtTenSP.Text,
                    SoLuong = Convert.ToInt32(txtSoLuong.Text),
                    DonGia = Convert.ToDouble(txtGia.Text),
                    MoTa = txtMoTa.Text,
                    MaNCC = Convert.ToString(cbbnhacungcap.SelectedValue),
                    GiaBan = Convert.ToDouble(txtGiaban.Text)
                };
                    int n = _sanphamBUS.themsanpham(sp);
                    if (n > 0)
                    {
                        MessageBox.Show(Contrants.ThemThanhCong,Contrants.ThongBao, MessageBoxButtons.OK,MessageBoxIcon.Information);
                        dtgSanPham.DataSource = _sanphamBUS.laydssapham();
                        txtGia.Text = string.Empty;
                        txtMaSP.Text = string.Empty;
                        txtMoTa.Text = string.Empty;
                        txtSoLuong.Text = string.Empty;
                        txtTenSP.Text = string.Empty;
                        txtGiaban.Text = string.Empty;
                    }

                    else
                    {
                        MessageBox.Show(Contrants.ThemThatbai,Contrants.ThongBao, MessageBoxButtons.OK);
                        txtGia.Text = string.Empty;
                        txtMaSP.Text = string.Empty;
                        txtMoTa.Text = string.Empty;
                        txtSoLuong.Text = string.Empty;
                        txtTenSP.Text = string.Empty;
                        txtGiaban.Text = string.Empty;
                    }
                
            }
        }
        private void dtgSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtMaSP.Enabled = false;
            btnThem.Enabled = false;
            txtMaSP.Text = dtgSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenSP.Text = dtgSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMoTa.Text = dtgSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoLuong.Text = dtgSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGia.Text = dtgSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
          cbbnhacungcap.Text = dtgSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
          txtGiaban.Text = dtgSanPham.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtGia.Text)
                || string.IsNullOrEmpty(txtMoTa.Text) || string.IsNullOrEmpty((txtSoLuong.Text))
                 || string.IsNullOrEmpty(cbbnhacungcap.Text) )
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          
                if(_sanphamBUS.kiemtramsanphamncc(txtMaSP.Text))
                {
                    MessageBox.Show("Sản phẩm này còn tồn tại","Thông báo",MessageBoxButtons.OK);
                    return;
                }
            else
            {
                SanPhamDTO sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text,
                    TenSP = txtTenSP.Text,
                    SoLuong = Convert.ToInt32(txtSoLuong.Text),
                    DonGia = Convert.ToDouble(txtGia.Text),
                    MoTa = txtMoTa.Text,
                    MaNCC = _nhacungcapBUS.layMaNCC(cbbnhacungcap.Text),
                    GiaBan = Convert.ToDouble(txtGiaban.Text)
                };
                DialogResult resut = MessageBox.Show(Contrants.Bancochachanmuonxoa, Contrants.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                 if (resut == DialogResult.Yes)
                 {
                     int n = _sanphamBUS.xoasanpham(sp);
                     if (n > 0)
                     {
                         MessageBox.Show(Contrants.XoaThanhCong, Contrants.ThongBao, MessageBoxButtons.OK);

                         dtgSanPham.DataSource = _sanphamBUS.laydssapham();
                         txtGia.Text = string.Empty;
                         txtMaSP.Text = string.Empty;
                         txtMoTa.Text = string.Empty;
                         txtSoLuong.Text = string.Empty;
                         txtTenSP.Text = string.Empty;
                         txtGiaban.Text = string.Empty;
                         dtgSanPham.DataSource = _sanphamBUS.laydssapham();
                     }
                     else
                     {
                         MessageBox.Show(Contrants.XoaThatBai, Contrants.ThongBao, MessageBoxButtons.OK);
                         txtGia.Text = string.Empty;
                         txtMaSP.Text = string.Empty;
                         txtMoTa.Text = string.Empty;
                         txtSoLuong.Text = string.Empty;
                         txtTenSP.Text = string.Empty;
                         txtGiaban.Text = string.Empty;
                     }
                 }
                 else
                 {
                     txtGia.Text = string.Empty;
                     txtMaSP.Text = string.Empty;
                     txtMoTa.Text = string.Empty;
                     txtSoLuong.Text = string.Empty;
                     txtTenSP.Text = string.Empty;
                     txtGiaban.Text = string.Empty;
                     return;
                 }
               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtGia.Text = string.Empty;
            txtMaSP.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtGiaban.Text = string.Empty;
        }

    
        private void BtnTao_Click(object sender, EventArgs e)
        {
            int n = _sanphamBUS.layIDSanpham()+1;
            if (n >= 1)
            {
                txtMaSP.Text = Contrants.SP + n + Contrants.cach;
            }
            else
            {
                txtMaSP.Text =Contrants.SP + 1 + Contrants.cach;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtgSanPham.DataSource = _sanphamBUS.TimKiemSanPham(txtTimKiem.Text);
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void grThongTinSanPham_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCha fr = new frmCha();
            fr.Show();
            this.Hide();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
              if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
