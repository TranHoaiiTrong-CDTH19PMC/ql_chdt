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
    public partial class frmbaocao : Form
    {
        private SanPhamBUS _spBUS = new SanPhamBUS();
        private NhaCungCapBUS _nccBUS = new NhaCungCapBUS();
        private HoaDonBUS _hdBUS = new HoaDonBUS();
        public frmbaocao()
        {
            InitializeComponent();
        }

     

        private void frmbaocao_Load(object sender, EventArgs e)
        {
            cbbTheoNCC.DataSource = _nccBUS.LayDSNhaCungCap();
            cbbTheoNCC.DisplayMember = "TenNCC";
            cbbTheoNCC.ValueMember = "MaNCC";
            cbbHoaDonTN.DataSource = _hdBUS.danhsachhoadon();
            cbbHoaDonTN.DisplayMember = "NgayLapHD";
            cbbHoaDonTN.ValueMember = "NgayLapHD";
        }

        private void btnxembaocao_Click(object sender, EventArgs e)
        {
            if (rbtTatCaSP.Checked == true)
            {
                frmXembaocao f = new frmXembaocao();
                f.LayTattCaSP();
                f.ShowDialog();
            }
            if (rbtSanPhamTNCC.Checked == true)
            {
                frmXembaocao f = new frmXembaocao();
                f.LayTatCaSanPhamTheoNCC((NhaCungCapDTO)cbbTheoNCC.SelectedItem);
                f.ShowDialog();
            }
            if (rbtXemTatCaHD.Checked == true)
            {
                frmXembaocao f = new frmXembaocao();
                f.LayTattCaHD();
                f.ShowDialog();
            }
            if (rbtSanPhamNhomNCC.Checked == true)
            {
                frmXembaocao f = new frmXembaocao();
                f.XemSanPhamTheoNhomNCC();
                f.ShowDialog();
            }
            if (rbtHoaDonNgay.Checked == true)
            {
                frmXembaocao f = new frmXembaocao();
                f.LayTatCaCTHoaDonTheoNgay((HoaDonDTO)cbbHoaDonTN.SelectedItem);
                f.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCha fr = new frmCha();
            fr.Show();
            this.Hide();
        }
    }
}

       


        