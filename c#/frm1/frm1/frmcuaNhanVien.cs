using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm1
{
    public partial class frmcuaNhanVien : Form
    {
        public frmcuaNhanVien()
        {
            InitializeComponent();
        }

        private void QL_QLNV_Click(object sender, EventArgs e)
        {

        }

        private void QL_QLSP_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void quảnLýSảnPhầmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSP fr = new frmQLSP();
            fr.Show();
            this.Hide();

        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmQuanLiHoaDon fr = new frmQuanLiHoaDon();
            fr.Show();
            this.Hide();

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            qlKhachhang fr = new qlKhachhang();
            fr.Show();
            this.Hide();

        }

        private void quảnLýNhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLNhaCungCap fr = new frmQLNhaCungCap();
            fr.Show();
            this.Hide();

        }

       

        private void btndangxuat_Click_1(object sender, EventArgs e)
        {
            frmDangNhap fr = new frmDangNhap();
            fr.Show();
            this.Hide();
        }

        private void frmcuaNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtaikhoan fr = new frmtaikhoan();
            fr.Show();
            this.Hide();
        }
    }
}
