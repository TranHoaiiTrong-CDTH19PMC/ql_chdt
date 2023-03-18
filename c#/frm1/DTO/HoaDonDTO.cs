using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HoaDonDTO
    {
       
       private string _mahd;
       private DateTime _ngaylaphoadon;
       private string _manv;
       private string _makh;
       private string _sdt;
       private int _id;
       private double _tongtien;
       public double TongTien
       {
           get { return _tongtien; }
           set { _tongtien = value; }
       }
       public int ID
       {
           get { return _id; }
           set { _id = value; }
       }

       public string MaHD
       {
           get { return _mahd; }
           set { _mahd = value; }
       }
       public string sdtKH
       {
           get { return _sdt; }
           set { _sdt = value; }
       }
       public string MaNV
       {
           get { return _manv; }
           set { _manv = value; }
       }
      public DateTime NgayLapHD
       {
           get { return _ngaylaphoadon;}
           set { _ngaylaphoadon = value; }
       }
      public string MaKH
      {
          get { return _makh; }
          set { _makh = value; }
      }
    }
}
