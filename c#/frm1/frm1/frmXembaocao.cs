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
using Microsoft.Reporting.WinForms;
namespace frm1
{
    public partial class frmXembaocao : Form
    {
        private NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        private SanPhamBUS _spBUS = new SanPhamBUS();
        private CT_HoaDonBUS _cthbBuS = new CT_HoaDonBUS();
        private HoaDonBUS _hdBUS = new HoaDonBUS();
        private NhaCungCapBUS _nccBUS = new NhaCungCapBUS();
        public frmXembaocao()
        {
            InitializeComponent();
        }

        private void frmXembaocao_Load(object sender, EventArgs e)
        {
            this.rbvxembaocaonhanvien.RefreshReport();
        }
        public void LayTattCaSP()
        {
            List<SanPhamDTO> _spDTO = new List<SanPhamDTO>();
            _spDTO = _spBUS.laydssapham();
            this.rbvxembaocaonhanvien.LocalReport.ReportEmbeddedResource = "frm1.rptXemTatCaSP.rdlc";
            this.rbvxembaocaonhanvien.LocalReport.DataSources.Add(new ReportDataSource("TCSP", _spDTO));
            this.rbvxembaocaonhanvien.RefreshReport();
        }
        
        public void LayTattCaHD()
        {
            List<HoaDonDTO> _hdDTO = new List<HoaDonDTO>();
            _hdDTO = _hdBUS.danhsachhoadon();
            this.rbvxembaocaonhanvien.LocalReport.ReportEmbeddedResource = "frm1.rptXemTatCaHD.rdlc";
            this.rbvxembaocaonhanvien.LocalReport.DataSources.Add(new ReportDataSource("DSHD", _hdDTO));
            this.rbvxembaocaonhanvien.RefreshReport();
        }
        public void LayTatCaSanPhamTheoNCC(NhaCungCapDTO nccDTO)
        {

            List<SanPhamDTO> _spDTO = new List<SanPhamDTO>();
            _spDTO = _spBUS.LayDanhSachSanPhamTNCC(nccDTO.MaNCC);
            this.rbvxembaocaonhanvien.LocalReport.ReportEmbeddedResource = "frm1.rptXemSanPhamTheoNCC.rdlc";
            this.rbvxembaocaonhanvien.LocalReport.DataSources.Add(new ReportDataSource("TNCC", _spDTO));
            this.rbvxembaocaonhanvien.LocalReport.SetParameters(new ReportParameter("rpNCC", nccDTO.TenNCC));
            this.rbvxembaocaonhanvien.RefreshReport();
        }
        public void LayTatCaCTHoaDonTheoNgay(HoaDonDTO NgayLapHoaDonDTO)
        {

            List<HoaDonDTO> _hdDTO = new List<HoaDonDTO>();
            _hdDTO = _hdBUS.DanhSachHoaDonTheoNgay(Convert.ToDateTime(NgayLapHoaDonDTO.NgayLapHD));
            this.rbvxembaocaonhanvien.LocalReport.ReportEmbeddedResource = "frm1.rptXemHoaDonTheoNgay.rdlc";
            this.rbvxembaocaonhanvien.LocalReport.DataSources.Add(new ReportDataSource("HDN", _hdDTO));
            this.rbvxembaocaonhanvien.LocalReport.SetParameters(new ReportParameter("rpNgay", Convert.ToDateTime(NgayLapHoaDonDTO.NgayLapHD).ToString()));
            this.rbvxembaocaonhanvien.RefreshReport();
        }
        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            string MaNCC = e.Parameters["paMaNCC"].Values[0];

            List<SanPhamDTO> _spDTO = new List<SanPhamDTO>();
            _spDTO = _spBUS.LayDanhSachSanPhamTNCC(MaNCC);

            e.DataSources.Add(new ReportDataSource("DSSP", _spDTO));
        }
        public void XemSanPhamTheoNhomNCC()
        {
            List<NhaCungCapDTO> _nccDTO = new List<NhaCungCapDTO>();
            _nccDTO = _nccBUS.LayDanhSachTatCaNCC();

            this.rbvxembaocaonhanvien.LocalReport.ReportEmbeddedResource = "frm1.rptXemDanhSachSanPhamTheoNhomNCC.rdlc";

            this.rbvxembaocaonhanvien.LocalReport.DataSources.Add(new ReportDataSource("tennnc", _nccDTO));
            this.rbvxembaocaonhanvien.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;

            this.rbvxembaocaonhanvien.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
