using DTO;
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

namespace frm1
{
    public partial class frmtaikhoan : Form
    {
        NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        public frmtaikhoan()
        {
            InitializeComponent();
        }

        private void btnthaydoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmatkhaucu.Text) || string.IsNullOrEmpty(labek.Text) || string.IsNullOrEmpty(txtmatkhuamoi2.Text)
                || string.IsNullOrWhiteSpace(txtmatkhuamoi2.Text) || string.IsNullOrWhiteSpace(labek.Text)
                || string.IsNullOrWhiteSpace(txtmatkhaucu.Text) || string.IsNullOrEmpty(txtmanv.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu, Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                 string mkcu=txtmatkhaucu.Text.MaHoaMK();
                if (_nhanvienBUS.kiemtrataikhoan(txtmanv.Text, mkcu) == Contrants.nhanvien
                    || _nhanvienBUS.kiemtrataikhoan(txtmanv.Text, mkcu) == Contrants.QuanLy)
                {
                    if (txtmatkhaumoi1.Text != txtmatkhuamoi2.Text)
                    {
                        MessageBox.Show("Mật khẩu bạn đặt không trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        if (txtmatkhuamoi2.Text.Length < 8 || txtmatkhaumoi1.Text.Length < 8)
                        {
                            MessageBox.Show("Mật khẩu của bạn quá ngắn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                        else
                        {
                            string s = txtmatkhaumoi1.Text.MaHoaMK();
                            int n = _nhanvienBUS.Datlaimatkhau(s, txtmanv.Text);
                            if (n > 0)
                            {
                                MessageBox.Show("Đặt lại mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                                txtmanv.Text = string.Empty;
                                txtmatkhaucu.Text = string.Empty;
                                txtmatkhaumoi1.Text = string.Empty;
                                txtmatkhuamoi2.Text = string.Empty;
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Đặt lại mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK);
                                txtmanv.Text = string.Empty;
                                txtmatkhaucu.Text = string.Empty;
                                txtmatkhaumoi1.Text = string.Empty;
                                txtmatkhuamoi2.Text = string.Empty;
                                return;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên hoặc mật khẩu của bạn sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCha fr = new frmCha();
            fr.Show();
            this.Hide();
        }
    }
}
