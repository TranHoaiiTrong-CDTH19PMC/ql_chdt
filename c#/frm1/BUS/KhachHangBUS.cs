using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace BUS
{
   public class KhachHangBUS
    {
      
       KhachHangDAO _khachhangDAO = new KhachHangDAO();
         public List<KhachHangDTO> laydanhsachkhachhang()
       {
           return _khachhangDAO.laydanhsachkhachhang();
       }       
        public bool kiemtraSDTKH(string s)
         { 
            return _khachhangDAO.kiemtraSDTKH(s);
        }
        public bool kiemtraKhachHang(string s)
         {
             return _khachhangDAO.kiemtraKhachHang(s);
         }
        public int layIdkhachhang()
         {
             return _khachhangDAO.layIdkhachhang();
         }
        public int themkhachhang(KhachHangDTO kh)
         {
             return _khachhangDAO.themkhachhang(kh);
         }
        public List<KhachHangDTO> TimKiem(string s)
        {
            return _khachhangDAO.TimKiem(s);
        }
          public int capnhatkhachhang(KhachHangDTO kh)
        {
            return _khachhangDAO.capnhatkhachhang(kh);

        }
         public int xoakhachhang(KhachHangDTO kh)
          {
              return _khachhangDAO.xoakhachhang(kh);
          }
         public List<KhachHangDTO> laydanhsachTatCakhachhang()
         {
             return _khachhangDAO.laydanhsachTatCakhachhang(); 
         }
         public bool kiemtraKhachHangtheoHD(string s)
         {
             return _khachhangDAO.kiemtraKhachHangtheoHD(s);
         }
    }
}
