using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
   public class CT_HoaDonBUS
    {
       CT_HoaDonDAO _cthoadonDAO = new CT_HoaDonDAO();
       public List<CT_HoaDonDTO> laydanhsachCTHoaDon(string s)
       {
           return _cthoadonDAO.laydanhsachCTHoaDon(s);
       }
        public bool kiemtraCT_HoaDon(string s,string masp)
        {
            return _cthoadonDAO.kiemtraCT_HoaDon(s, masp);
        }
        //public double TinhTongTien(string mahd)
        //{
        //    return _cthoadonDAO.TinhTongTien(mahd);
        //}
        public int themCThoadon(CT_HoaDonDTO hd)
        {
            return _cthoadonDAO.themCThoadon(hd);
        }
       public int suaCTHoaDon(CT_HoaDonDTO hd)
        {
            return _cthoadonDAO.suaCThoadon(hd);
        }
       public int xoaCTHoaDon(CT_HoaDonDTO hd)
       {
           return _cthoadonDAO.xoaCThoadon(hd);
       }
    }
}
