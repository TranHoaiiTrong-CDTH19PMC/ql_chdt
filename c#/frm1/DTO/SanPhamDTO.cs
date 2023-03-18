using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class SanPhamDTO
    {
       private string _masp;
       private string _tensp;
       private string _mota;
       private int _soluong;
       private double _dongia;

       public string MaSP{
           get {return _masp;}
           set{_masp=value;}
       }

       public string TenSP
       {
            get {return _tensp;}
           set{_tensp=value;}
       }
       public string MoTa
       {
            get {return _mota;}
           set{_mota=value;}
       }
       public int SoLuong
       {
            get {return _soluong;}
           set{_soluong=value;}
       }
       public double DonGia
       {
           get { return _dongia; }
           set { _dongia = value; }
       }
       public string MaNCC { get; set; }
       public double GiaBan { get; set; }
    }
}
