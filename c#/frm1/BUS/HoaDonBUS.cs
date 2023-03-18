using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
   public class HoaDonBUS
    {
       HoaDonDAO _hoadonDAO = new HoaDonDAO();
       public List<HoaDonDTO> danhsachhoadon()
       {
          return _hoadonDAO.danhsachhoadon();
       }
       public List<HoaDonDTO> DanhSachHoaDonTheoNgay(DateTime NgayLapHD)
       {
           return _hoadonDAO.DanhSachHoaDonTheoNgay(NgayLapHD);
       }
         public bool kiemtraHoaDon(string s)
       {
           return _hoadonDAO.kiemtraHoaDon(s);
       }
        public int layIDSHoaDon()
         {
             return _hoadonDAO.layIDSHoaDon();
         }
        public int capNhatTongTien(string mahd,float tongtien)
       {
           return _hoadonDAO.capNhatTongTien(mahd, tongtien);
       }
       public string laymanhanvien(string s)
       {
           return _hoadonDAO.laymanhanvien(s);
       }
           public int themHoaDon(HoaDonDTO hd)
       {
           return _hoadonDAO.themHoaDon(hd);
       }
       
       public HoaDonDTO danhsachhoadoncoIdcaonhat()
           {
               return _hoadonDAO.danhsachhoadoncoIdcaonhat();
           }
        public int xoaHoaDon(HoaDonDTO hd)
       {
           return _hoadonDAO.xoaHoaDon(hd);
       }
        public int capNhatHoaDon(HoaDonDTO hd)
        {
            return _hoadonDAO.capNhatHoaDon(hd);
        }
        public List<HoaDonDTO> TimKiemHoaDon(string s)
        {
            return _hoadonDAO.TimKiemHoaDon(s);
        }
    }
}
