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
    public partial class frmCha : Form
    {
        public frmCha()
        {
            InitializeComponent();
        }

        private void frmCha_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void QL_LHD_Click(object sender, EventArgs e)
        {
          //  frmLHD f = new frmLHD();
          //  f.Show();
        }

        private void QL_QLNV_Click(object sender, EventArgs e)
        {
            frmQlNhanVien g = new frmQlNhanVien();
            g.Show();
            this.Hide();
        }
       
        private void QL_QLSP_Click(object sender, EventArgs e)
        {
            frmQLSP h = new frmQLSP();
            h.Show();
            this.Hide();
        }

        private void NV_LHD_Click(object sender, EventArgs e)
        {
          //  frmLHD f = new frmLHD();
           // f.Show();
        }
       
        private void NV_QLSP_Click(object sender, EventArgs e)
        {
            frmQLSP h = new frmQLSP();
            h.Show();
            this.Hide();

        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiHoaDon fr = new frmQuanLiHoaDon();
            fr.Show();
            this.Hide();

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbaocao rf = new frmbaocao();
            rf.Show();
            this.Hide();

        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhaCungCap fr = new frmQLNhaCungCap();
            fr.Show();
            this.Hide();

        }

        private void frmCha_KeyDown(object sender, KeyEventArgs e)
        {
            
           // if (e.Control && e.KeyCode == Keys.T)
            //{
              //  frmQlNhanVien g = new frmQlNhanVien();
                //g.Show();
            //}
        
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlKhachhang fr = new qlKhachhang();
            fr.Show();
            this.Hide();

        }

        private void menuStrip1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                frmQlNhanVien fr = new frmQlNhanVien();
                fr.Show();
                this.Hide();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDangNhap fr = new frmDangNhap();
            fr.Show();
            this.Hide();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtaikhoan fr = new frmtaikhoan();
            fr.Show();
            this.Hide();
        }
    }
}
