using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class NhanVienDTO
    {
       private string _manv;
       private string _tennv;
       private string _diachi;
       private string _sdt;
       private string _pass;
       private string _gioitinh;
       private string _chucvu;
      private string _mail;
       public string Email
       {
           get {return  _mail; }
           set { _mail = value; }
       }
       public string MaNV
       {
           get { return _manv; }
           set { _manv = value; }
       }      
       public string nhanviendangnhap { get; set; }

       public string GioiTinh
       {
           get {return _gioitinh ;}
           set {_gioitinh=value ;}
       }
       public string ChucVu
       {
           get { return _chucvu; }
           set { _chucvu = value; }
       }
       public string TenNV
       {
           get { return _tennv; }
           set { _tennv = value; }
       }
       public string DiaChi
       {
           get { return _diachi; }
           set { _diachi = value; }
       }
       public string SDT
       {
           get { return _sdt; }
           set { _sdt = value; }
       }
       public string MatKhau
       {
           get { return _pass; }
           set { _pass = value; }
       }
    }
}
