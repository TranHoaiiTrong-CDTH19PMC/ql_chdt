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
    public partial class frmDangNhap : Form
    {
        NhanVienBUS _nhavienBUS = new NhanVienBUS();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMatKhau.Text)||string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show(Contrants.NhapChuaDu,Contrants.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string s = txtMatKhau.Text.MaHoaMK();
               if( _nhavienBUS.kiemtrataikhoan(txtTaiKhoan.Text, s)==Contrants.QuanLy)
               {
                   frmCha f = new frmCha();
                   f.Show();
                   this.Hide();
               }
               else
               {
                  if( _nhavienBUS.kiemtrataikhoan(txtTaiKhoan.Text,s)==Contrants.nhanvien)
                   {
                       frmcuaNhanVien fr=new frmcuaNhanVien();
                       fr.Show();
                       this.Hide();
                   }
                   else{
                   MessageBox.Show(Contrants.dangnhapkhongthanhcong,Contrants.ThongBao, MessageBoxButtons.OK);
                   return;

                   }
               }
            }
        }

        private void btnquaylai_Click_1(object sender, EventArgs e)
        {
            frmTrangChu fr = new frmTrangChu();
            fr.Show();
            this.Close();
        }

     
    }
}
