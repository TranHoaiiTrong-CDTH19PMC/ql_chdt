using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
   public class CT_HoaDonDTO
    {
       private int _ID;
        private string _masp;
        private int _soluong;
        private double _dongia;
        private double _thanhtien;
        private string _mahd;
        private double _tongtien;
        public double TongTien
        {
            get { return _tongtien; }
            set { _tongtien = value; }
        }
       public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string MaHD
        {
            get { return _mahd; }
            set { _mahd = value; }
        }
        public string MaSP
        {
            get { return _masp; }
            set { _masp = value; }
        }
        public double DonGia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }
        public int SoLuong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public double ThanhTien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }
        }
      
    }
}
