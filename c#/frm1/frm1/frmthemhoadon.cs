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
    public partial class frmthemhoadon : Form
    {
        SanPhamBUS _sanphamBUS = new SanPhamBUS();
        HoaDonBUS _hoadon = new HoaDonBUS();
        CT_HoaDonBUS _cthoadon = new CT_HoaDonBUS();
        public frmthemhoadon()
        {
            InitializeComponent();
            dtCTHOADON.AutoGenerateColumns = false;
        }    
        private void frmthemhoadon_Load(object sender, EventArgs e)
        {
            cbbSanPham.DataSource = _sanphamBUS.laydssapham();
            cbbSanPham.DisplayMember = Contrants.TenSP;
            cbbSanPham.ValueMember = Contrants.MaSP;
            HoaDonDTO hd = _hoadon.danhsachhoadoncoIdcaonhat();
            txtMaHD.Text = hd.MaHD;
            txtMaNV.Text = hd.MaNV;
            txtMaKH.Text = hd.MaKH;
            dtNgayLapHD.Value = hd.NgayLapHD;
            string l = cbbSanPham.SelectedItem.ToString();
            TenSP.DataSource = _sanphamBUS.laydstatcasapham();
            TenSP.DisplayMember = Contrants.TenSP;
            TenSP.ValueMember = Contrants.MaSP;
            TenSP.DataPropertyName = Contrants.MaSP;
          dtCTHOADON.DataSource = _cthoadon.laydanhsachCTHoaDon(txtMaHD.Text);
        }

        private void btnThemhoadon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDonGiaCTHD.Text)
                || string.IsNullOrEmpty(txtThanhTien.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                    CT_HoaDonDTO hd = new CT_HoaDonDTO
                    {
                        MaHD = txtMaHD.Text,
                        MaSP = cbbSanPham.Text,
                        SoLuong =Convert.ToInt32( nudSoluong.Value),
                        ThanhTien = Convert.ToDouble(txtThanhTien.Text),
                        DonGia = Convert.ToDouble(txtDonGiaCTHD.Text),
                    };
                if(_sanphamBUS.kiemtraSOluongSanPham(Convert.ToString( cbbSanPham.SelectedValue),Convert.ToInt32(nudSoluong.Value))==false)
                {
                     MessageBox.Show(Contrants.solongkhongdu,Contrants.ThongBao, MessageBoxButtons.OK);
                    return;
                }
                    int n = _cthoadon.themCThoadon(hd);
                    if (n > 0)
                    {
                        MessageBox.Show(Contrants.ThemThanhCong,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtCTHOADON.DataSource = _cthoadon.laydanhsachCTHoaDon(txtMaHD.Text);
                        txtThanhTien.Text = string.Empty;
                        txtDonGiaCTHD.Text = string.Empty;
                        
                        int nl = _hoadon.capNhatTongTien(txtMaHD.Text,float.Parse(txttongtien.Text));
                        if (nl > 0)
                        {
                            int trusoluong = _sanphamBUS.TRUSOluongSanPham(Convert.ToString(cbbSanPham.SelectedValue), Convert.ToInt32(nudSoluong.Value));
                            nudSoluong.Value = 0;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Contrants.ThemThatbai,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaKH.Text = string.Empty;
                        txtMaNV.Text = string.Empty;
                        txtThanhTien.Text = string.Empty;
                        txtDonGiaCTHD.Text = string.Empty;
                        nudSoluong.Value = 0;
                    }
                }
      }
        private void dtCTHOADON_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
                return;
            txtMaHD.Enabled = false;
            btnThemhoadon.Enabled = false;
            cbbSanPham.SelectedValue = dtCTHOADON.Rows[e.RowIndex].Cells[1].Value;
            txtMaHD.Text = dtCTHOADON.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDonGiaCTHD.Text = dtCTHOADON.Rows[e.RowIndex].Cells[2].Value.ToString();
            nudSoluong.Value=Convert.ToInt32( dtCTHOADON.Rows[e.RowIndex].Cells[3].Value);
            txtThanhTien.Text = dtCTHOADON.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtCTHOADON.Rows[e.RowIndex].Cells[4].Value= 0;
            txtMaKH.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            dtNgayLapHD.Value = DateTime.Now;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            btnThemhoadon.Enabled = true;
            txtMaKH.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtThanhTien.Text = string.Empty;
            txtDonGiaCTHD.Text = string.Empty;
            nudSoluong.Value = 0;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDonGiaCTHD.Text) 
               || string.IsNullOrEmpty(txtThanhTien.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                CT_HoaDonDTO hd = new CT_HoaDonDTO
                {
                    MaHD = txtMaHD.Text,
                    MaSP = cbbSanPham.Text,
                    SoLuong = Convert.ToInt32(nudSoluong.Value),
                    ThanhTien = Convert.ToDouble(txtThanhTien.Text),
                    DonGia = Convert.ToDouble(txtDonGiaCTHD.Text),
                };

                int n = _cthoadon.suaCTHoaDon(hd);
                if (n > 0)
                {
                    MessageBox.Show(Contrants.CapnhatThanhCong,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtCTHOADON.DataSource = _cthoadon.laydanhsachCTHoaDon(txtMaHD.Text);
                    txtThanhTien.Text = string.Empty;
                    txtDonGiaCTHD.Text = string.Empty;
                    nudSoluong.Value = 0;
                }
                else
                {
                    MessageBox.Show(Contrants.CapNhatThatBai,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKH.Text = string.Empty;
                    txtMaNV.Text = string.Empty;
                    txtThanhTien.Text = string.Empty;
                    txtDonGiaCTHD.Text = string.Empty;
                    nudSoluong.Value = 0;
                }
                  int nl = _hoadon.capNhatTongTien(txtMaHD.Text,float.Parse(txttongtien.Text));
                
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDonGiaCTHD.Text)
               || string.IsNullOrEmpty(txtThanhTien.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                CT_HoaDonDTO hd = new CT_HoaDonDTO
                {
                    MaHD = txtMaHD.Text,
                    MaSP = cbbSanPham.Text,
                    SoLuong =Convert.ToInt32( nudSoluong.Value),
                    ThanhTien = Convert.ToInt32(txtThanhTien.Text),
                    DonGia = Convert.ToInt32(txtDonGiaCTHD.Text),
                };
                DialogResult resut = MessageBox.Show(Contrants.Bancochachanmuonxoa, Contrants.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resut == DialogResult.Yes)
                {
                    int n = _cthoadon.xoaCTHoaDon(hd);
                    if (n > 0)
                    {
                        MessageBox.Show(Contrants.XoaThanhCong, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtCTHOADON.DataSource = _cthoadon.laydanhsachCTHoaDon(txtMaHD.Text);
                        txtThanhTien.Text = string.Empty;
                        txtDonGiaCTHD.Text = string.Empty;
                        nudSoluong.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show(Contrants.XoaThatBai, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaKH.Text = string.Empty;
                        txtMaNV.Text = string.Empty;
                        txtThanhTien.Text = string.Empty;
                        txtDonGiaCTHD.Text = string.Empty;
                        nudSoluong.Value = 0;
                    }
                    int nl = _hoadon.capNhatTongTien(txtMaHD.Text, float.Parse(txttongtien.Text));
                }
                else
                {
                    txtThanhTien.Text = string.Empty;
                    txtDonGiaCTHD.Text = string.Empty;
                    nudSoluong.Value = 0;
                    return;
                }
               
            }
        }
       
        private void nudSoluong_ValueChanged(object sender, EventArgs e)
        {
            double m;
            try
            {
                m = double.Parse(txtDonGiaCTHD.Text);
                Double l = Convert.ToInt32(nudSoluong.Value) * Convert.ToDouble(txtDonGiaCTHD.Text);
                txtThanhTien.Text = Convert.ToString(l);
                int ml = dtCTHOADON.Rows.Count;
                float tongtien = 0;
                for (int i = 0; i < ml; i++)
                {
                    tongtien = tongtien + float.Parse(dtCTHOADON.Rows[i].Cells[4].Value.ToString());
                }
                txttongtien.Text = Convert.ToString(tongtien+l);
            }
            catch (Exception)
            {
                txtDonGiaCTHD.Text = string.Empty;
                nudSoluong.Value = 0;
            }
        }

        private void cbbSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            txtDonGiaCTHD.Text = _sanphamBUS.laydongiasanpham(Convert.ToString(cbbSanPham.SelectedValue));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQuanLiHoaDon fr = new frmQuanLiHoaDon();
            fr.Show();
            this.Hide();
        }
    }
}
