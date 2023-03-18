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
    public partial class frmQlNhanVien : Form
    {
        NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        
        public frmQlNhanVien()
        {
            InitializeComponent();

        }

        private void QLNV_Load(object sender, EventArgs e)
        {
           // ChuVu.DataSource
            dtgnhanvien.AutoGenerateColumns = false;
            dtgnhanvien.DataSource = _nhanvienBUS.laydanhsachnhanvien();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnThemmanv.Enabled = true;
            txtPassWord.Enabled = true;
            txtDiaChi.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtPassWord.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtmail.Text = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtPassWord.Text)
                || string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text)
                || string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtPassWord.Text) || string.IsNullOrEmpty(txtmail.Text)
               || string.IsNullOrWhiteSpace(txtmail.Text)
               )
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtPassWord.Text.Length<8)
            {
                MessageBox.Show("Mật khẩu của bạn quá ngắn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                 if(txtSDT.Text.Length!=10)
                 {
                     MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                     return;
                 }
                 if (_nhanvienBUS.IsNumber(txtSDT.Text) == false)
                 {
                     MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                     return;
                 }
                 if (_nhanvienBUS.isEmail(txtmail.Text) == false)
                 {
                     MessageBox.Show(Contrants.Email, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        NhanVienDTO nv = new NhanVienDTO
                        {
                            ChucVu = cbbChucvu.Text,
                            MaNV = txtMaNV.Text,
                            TenNV = txtTenNV.Text,
                            DiaChi = txtDiaChi.Text,
                            MatKhau = txtPassWord.Text,
                            SDT = txtSDT.Text,
                            GioiTinh = gioitinh,
                            Email = txtmail.Text

                        };
                        if (_nhanvienBUS.kiemtramssv(txtMaNV.Text))
                        {
                            MessageBox.Show(Contrants.MaDaTonTai,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            int n = _nhanvienBUS.themnhanvien(nv);
                            if (n > 0)
                            {
                                MessageBox.Show(Contrants.ThemThanhCong,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dtgnhanvien.DataSource = _nhanvienBUS.laydanhsachnhanvien();
                                txtDiaChi.Text = string.Empty;
                                txtMaNV.Text = string.Empty;
                                txtPassWord.Text = string.Empty;
                                txtSDT.Text = string.Empty;
                                txtTenNV.Text = string.Empty;
                                txtmail.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show(Contrants.ThemThatbai,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    
            }
        }

        private void dtgnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtMaNV.Enabled = false;
            btnThem.Enabled = false;
            txtPassWord.Enabled = false;
            btnThemmanv.Enabled = false;
            txtMaNV.Text = dtgnhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNV.Text = dtgnhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSDT.Text = dtgnhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
          //  txtPassWord.Text = dtgnhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDiaChi.Text = dtgnhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmail.Text = dtgnhanvien.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (dtgnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString()==Contrants.nam)
            {
                rdNam.Checked = true;
            }
            else
            {
                if (dtgnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString() == Contrants.nu)
                    rdNu.Checked = true;
                else
                    rdKhac.Checked = true;
            }
            cbbChucvu.Text = dtgnhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtDiaChi.Text)
                || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text)
                || string.IsNullOrWhiteSpace(txtTenNV.Text)|| string.IsNullOrEmpty(txtmail.Text)
               || string.IsNullOrWhiteSpace(txtmail.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            if (_nhanvienBUS.IsNumber(txtSDT.Text) == false)
            {
                MessageBox.Show(Contrants.SDT, Contrants.ThongBao, MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (_nhanvienBUS.isEmail(txtmail.Text) == false)
                {
                    MessageBox.Show(Contrants.Email,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {

                
                int m;
                try
                {
                    m = int.Parse(txtSDT.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show(Contrants.SDT,Contrants.ThongBao, MessageBoxButtons.OK);
                    return;
                }
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
                
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = txtMaNV.Text,
                    TenNV = txtTenNV.Text,
                    DiaChi = txtDiaChi.Text,
                    //MatKhau = txtPassWord.Text,
                    SDT = txtSDT.Text,
                    GioiTinh=gioitinh,
                    ChucVu= cbbChucvu.Text,
                    Email = txtmail.Text
                };
               
                    int n = _nhanvienBUS.capnhatnhanvien(nv);
                    if (n > 0)
                    {
                        MessageBox.Show(Contrants.CapnhatThanhCong,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgnhanvien.DataSource = _nhanvienBUS.laydanhsachnhanvien();
                        txtDiaChi.Text = string.Empty;
                        txtMaNV.Text = string.Empty;
                        txtPassWord.Text = string.Empty;
                        txtSDT.Text = string.Empty;
                        txtTenNV.Text = string.Empty;
                        txtmail.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show(Contrants.CapNhatThatBai,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDiaChi.Text = string.Empty;
                        txtMaNV.Text = string.Empty;
                        txtPassWord.Text = string.Empty;
                        txtSDT.Text = string.Empty;
                        txtTenNV.Text = string.Empty;
                        txtmail.Text = string.Empty;
                        return;
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtDiaChi.Text)
                || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtTenNV.Text) )
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                if(_nhanvienBUS.kiemtramMANVtheoHD(txtMaNV.Text))
                {
                    MessageBox.Show(Contrants.nhanviencontontai,Contrants.ThongBao, MessageBoxButtons.OK);
                    return;
                }
               
            else
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = txtMaNV.Text,
                    TenNV = txtTenNV.Text,
                    DiaChi = txtDiaChi.Text,
                    MatKhau = txtPassWord.Text,
                    SDT = txtSDT.Text,
                };
                DialogResult resut = MessageBox.Show(Contrants.Bancochachanmuonxoa, Contrants.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resut == DialogResult.Yes)
                {
                    int n = _nhanvienBUS.xoanhanvien(nv);
                    if (n > 0)
                    {
                        MessageBox.Show(Contrants.XoaThanhCong, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgnhanvien.DataSource = _nhanvienBUS.laydanhsachnhanvien();
                        txtDiaChi.Text = string.Empty;
                        txtMaNV.Text = string.Empty;
                        txtPassWord.Text = string.Empty;
                        txtSDT.Text = string.Empty;
                        txtTenNV.Text = string.Empty;
                        txtmail.Text = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show(Contrants.XoaThatBai, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDiaChi.Text = string.Empty;
                        txtMaNV.Text = string.Empty;
                        txtPassWord.Text = string.Empty;
                        txtSDT.Text = string.Empty;
                        txtTenNV.Text = string.Empty;
                        txtmail.Text = string.Empty;
                        return;
                    }
                }
                else
                {
                    txtDiaChi.Text = string.Empty;
                    txtMaNV.Text = string.Empty;
                    txtPassWord.Text = string.Empty;
                    txtSDT.Text = string.Empty;
                    txtTenNV.Text = string.Empty;
                    txtmail.Text = string.Empty;
                    return;
                }
                   
                
            }
        }

        private void btnThemmanv_Click(object sender, EventArgs e)
        {
            int k = _nhanvienBUS.layIdnhanvien()+1;
            if(k<1)
            {
                txtMaNV.Text = Contrants.NV + 1 + Contrants.cach;
            }
            else
            {
                txtMaNV.Text = Contrants.NV + k + Contrants.cach;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtgnhanvien.DataSource = _nhanvienBUS.timkiemNhanVien(txtTimKiem.Text);
        }

       

 
        private void button1_Click(object sender, EventArgs e)
        {
            frmCha fr = new frmCha();
            fr.Show();
            this.Hide();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

     

     
    }
}
