using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO _sanphamDAO = new SanPhamDAO();
        public bool kiemtrasanpham(string s)
        {
            return _sanphamDAO.kiemtramsanpham(s);
        }
       public string laydongiasanpham(string s)
        {
            return _sanphamDAO.laydongiasanpham(s);
        }
       public List<SanPhamDTO> LayDanhSachSanPhamTNCC(string MaNCC)
       {
           return _sanphamDAO.LayDanhSachSanPhamTNCC(MaNCC);
       }
         public List<SanPhamDTO> laydssapham()
        {
           return _sanphamDAO.laydssapham();
        }
        public int themsanpham(SanPhamDTO sp)
        {
            return _sanphamDAO.themsanpham(sp);
        }
        public int capnhatsanpham(SanPhamDTO sp)
        {
            return _sanphamDAO.capnhatsanpham(sp);
        }
         public int xoasanpham(SanPhamDTO sp)
        {
            return _sanphamDAO.xoasanpham(sp);
        }
          public int layIDSanpham()
         {
             return _sanphamDAO.layIDSanpham();
         }
          public List<SanPhamDTO> TimKiemSanPham(string s)
          {
              return _sanphamDAO.TimKiemSanPham(s);
          }
          //public int layMaSP(string s)
          //{
          //    return _sanphamDAO.layGiaBan(s);
          //}
         public List<SanPhamDTO> laydstatcasapham()
          {
              return _sanphamDAO.laydstatcasapham();
          }
         public bool kiemtraSOluongSanPham(string masp,int soluong)
         {
             return _sanphamDAO.kiemtraSOluongSanPham(masp, soluong);
         }
         public int TRUSOluongSanPham(string tensp,int soluong)
         {
             return _sanphamDAO.TRUSOluongSanPham(tensp, soluong);
         }
         public bool kiemtramsanphamncc(string s)
         {
             return _sanphamDAO.kiemtramsanphamtheoncc(s);
         }
    }
}
