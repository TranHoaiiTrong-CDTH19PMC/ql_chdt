using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class KhachHangDTO
    {
       private string _makh;
       private string _tenkh;
       private string _diachi;
       private string _sdt;
       private string _gioitinh;
       public string MaKH
       {
           get { return _makh; }
           set { _makh = value; }
       }
       public string GioiTinh
       {
           get { return _gioitinh; }
           set { _gioitinh = value; }
       }
       public string TenKH
       {
           get { return _tenkh; }
           set { _tenkh = value; }
       }
       public string SDT
       {
           get { return _sdt; }
           set { _sdt = value; }
       }
       public string DiaChi
       {
           get { return _diachi; }
           set { _diachi = value; }
       }
    }
}
