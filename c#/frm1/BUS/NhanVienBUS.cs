using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Text.RegularExpressions;
namespace BUS
{
   public class NhanVienBUS
    {
       NhanVienDAO _nhanvienDAO = new NhanVienDAO();
       public string kiemtrataikhoan(string s, string v)
       {
           return _nhanvienDAO.kiemtrataikhoan(s, v);
       }
       public bool isEmail(string inputEmail)
           {
               return _nhanvienDAO.isEmail(inputEmail);
           }
         public bool IsNumber(string pText)
       {
           return _nhanvienDAO.IsNumber(pText);
       }
       public bool kiemtramMANVtheoHD(string s)
         {
             return _nhanvienDAO.kiemtramMANVtheoHD(s);
         }
       public int layIdnhanvien()
           {
               return _nhanvienDAO.layIdnhanvien();
           }
           public List<NhanVienDTO> timkiemNhanVien(string s)
       {
           return _nhanvienDAO.timKiemNhanVien(s);
       }
       public bool kiemtramssv(string s)
       {
           return _nhanvienDAO.kiemtramssv(s);
       }
         public List<NhanVienDTO> laydanhsachnhanvien()
       {
          return _nhanvienDAO.laydssapham();
       }
        public int themnhanvien(NhanVienDTO nv)
         {
             return _nhanvienDAO.themnhanvien(nv);
         }
        public int capnhatnhanvien(NhanVienDTO nv)
        {
            return _nhanvienDAO.capnhatnhanvien(nv);
        }
        public int xoanhanvien(NhanVienDTO nv)
        {
            return _nhanvienDAO.xoanhanvien(nv);
        }
     public List<NhanVienDTO> laydsTatCaNV()
        {
            return _nhanvienDAO.laydsTatCaNV();
        }
         public int Datlaimatkhau(string mk,string manv)
         {
             return _nhanvienDAO.Datlaimatkhau(mk, manv);
         }
    }
}
