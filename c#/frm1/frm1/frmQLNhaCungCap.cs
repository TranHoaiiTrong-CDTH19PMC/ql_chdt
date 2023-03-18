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
    public partial class frmQLNhaCungCap : Form
    {
        NhaCungCapBUS _nhacungcapBUS = new NhaCungCapBUS();
        NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        public frmQLNhaCungCap()
        {
            InitializeComponent();
        }
        private void frmQLNhaCungCap_Load(object sender, EventArgs e)
        {
            dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int m = _nhacungcapBUS.layIDNhaCungCapCaoNhat() + 1;
            if(m>=1)
            {
                txtMaNCC.Text = Contrants.NCC + m + Contrants.cach;
            }
            else
            {
                txtMaNCC.Text = Contrants.NCC + 1 + Contrants.cach;
            }
           
            if (string.IsNullOrEmpty(txtMaNCC.Text) || string.IsNullOrEmpty(txtSDTNCC.Text) || string.IsNullOrEmpty(txtTenNCC.Text)
                || string.IsNullOrWhiteSpace(txtTenNCC.Text) || string.IsNullOrWhiteSpace(txtTenNCC.Text)
                || string.IsNullOrWhiteSpace(txtSDTNCC.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
                return;
            }
            if (txtSDTNCC.Text.Length != 10)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            if (_nhanvienBUS.IsNumber(txtSDTNCC.Text) == false)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (_nhacungcapBUS.kiemtranhacungcap(txtMaNCC.Text))
                {
                    MessageBox.Show(Contrants.MaDaTonTai,Contrants.ThongBao, MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    NhaCungCapDTO ncc = new NhaCungCapDTO
                    {
                        MaNCC = txtMaNCC.Text,
                        TenNCC = txtTenNCC.Text,
                        SDT = txtSDTNCC.Text
                    };
                    int n = _nhacungcapBUS.ThemNhaCungCap(ncc);
                    if (n > 0)
                    {
                        MessageBox.Show(Contrants.ThemThanhCong,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
                        txtMaNCC.Text = string.Empty;
                        txtSDTNCC.Text = string.Empty;
                        txtTenNCC.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show(Contrants.ThemThatbai, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
                        txtMaNCC.Text = string.Empty;
                        txtSDTNCC.Text = string.Empty;
                        txtTenNCC.Text = string.Empty;
                    }
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text) || string.IsNullOrEmpty(txtSDTNCC.Text) || string.IsNullOrEmpty(txtTenNCC.Text) || string.IsNullOrWhiteSpace(txtTenNCC.Text)
                || string.IsNullOrWhiteSpace(txtSDTNCC.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
                return;
            }
            if (txtSDTNCC.Text.Length != 10)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            if (_nhanvienBUS.IsNumber(txtSDTNCC.Text) == false)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            else
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO
                {
                    MaNCC = txtMaNCC.Text,
                    TenNCC = txtTenNCC.Text,
                    SDT = txtSDTNCC.Text
                };
                int n = _nhacungcapBUS.CapNhatNhaCungCap(ncc);
                if (n > 0)
                {
                    MessageBox.Show(Contrants.CapnhatThanhCong,Contrants.ThongBao,MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
                    txtMaNCC.Text = string.Empty;
                    txtSDTNCC.Text = string.Empty;
                    txtTenNCC.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(Contrants.CapNhatThatBai,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
                    txtMaNCC.Text = string.Empty;
                    txtSDTNCC.Text = string.Empty;
                    txtTenNCC.Text = string.Empty;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text) || string.IsNullOrEmpty(txtSDTNCC.Text) || string.IsNullOrEmpty(txtTenNCC.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
                return;
            }
                if(_nhacungcapBUS.kiemtranhacungcaptheoSP(txtMaNCC.Text))
                {
                    MessageBox.Show(Contrants.nhacungcapcontontai,Contrants.ThongBao, MessageBoxButtons.OK);
                    return;
                }
            else
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO
                {
                    MaNCC = txtMaNCC.Text,
                    TenNCC = txtTenNCC.Text,
                    SDT = txtSDTNCC.Text
                };
                DialogResult resut = MessageBox.Show(Contrants.Bancochachanmuonxoa,Contrants.ThongBao, MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (resut == DialogResult.Yes)
                {
                    int n = _nhacungcapBUS.XoaNhaCungCap(ncc);
                    if (n > 0)
                    {
                        MessageBox.Show(Contrants.XoaThanhCong, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
                        txtMaNCC.Text = string.Empty;
                        txtSDTNCC.Text = string.Empty;
                        txtTenNCC.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        MessageBox.Show(Contrants.XoaThatBai, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
                        txtMaNCC.Text = string.Empty;
                        txtSDTNCC.Text = string.Empty;
                        txtTenNCC.Text = string.Empty;
                        return;
                    }
                }
                else
                {
                    txtMaNCC.Text = string.Empty;
                    txtSDTNCC.Text = string.Empty;
                    txtTenNCC.Text = string.Empty;
                    return;

                }               
            }
        }
        private void dtgNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtMaNCC.Enabled = false;
            btnThem.Enabled = false;
            txtMaNCC.Text = dtgNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNCC.Text = dtgNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSDTNCC.Text = dtgNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtMaNCC.Text = string.Empty;
            txtSDTNCC.Text = string.Empty;
            txtTenNCC.Text = string.Empty;
            dtgNhaCungCap.DataSource = _nhacungcapBUS.LayDSNhaCungCap();
        }

   

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            dtgNhaCungCap.DataSource = _nhacungcapBUS.TimKiemNhaCungCap(txtTimKiem.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCha fr = new frmCha();
            fr.Show();
            this.Hide();
        }

        private void txtSDTNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
