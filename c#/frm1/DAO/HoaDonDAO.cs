using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
   public class HoaDonDAO
    {
       SqlConnection _con = new SqlConnection(Contrants.con);
      
        public bool kiemtraHoaDon(string s)
        {
            try
            {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.ktraHD;
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.Add(new SqlParameter(Contrants.mahd, s));
                var n = Convert.ToInt32(cmd.ExecuteScalar());
                _con.Close();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
       public string laymanhanvien(string s)
        {
            try {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.layMANV;
            List<SqlParameter> ls = new List<SqlParameter>();
            ls.Add(new SqlParameter(Contrants.tennv, s));
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddRange(ls.ToArray());
            string n =Convert.ToString( cmd.ExecuteScalar());
           _con.Close();
            return n;
            }
            catch (Exception)
            {
                return null;
            }
        }
       public List<HoaDonDTO> danhsachhoadon()
        {
            try {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
            List<HoaDonDTO> ls = new List<HoaDonDTO>();
            String sql = Contrants.laydanhsachHD;
            SqlCommand cmd = new SqlCommand(sql,_con);
          SqlDataReader q=  cmd.ExecuteReader();
           if(q.HasRows)
           {
               while(q.Read())
               {
                   HoaDonDTO hd = new HoaDonDTO
                   {
                       MaHD=q.GetString(0),
                       NgayLapHD=q.GetDateTime(1),
                       MaNV=q.GetString(2),
                       MaKH=q.GetString(3),
                       TongTien=q.GetDouble(6)
                   };
                   ls.Add(hd);
               }
           }
            _con.Close();
            return ls;
            }
            catch (Exception)
            {
                return null;
            }
        }
       
       public List<HoaDonDTO> TimKiemHoaDon(string s)
       {
           try { 
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
           List<HoaDonDTO> ls = new List<HoaDonDTO>();
           String sql = "select * from HOADON where TrangThai=1 and(MaHD like '%" + s + "%')";
           SqlCommand cmd = new SqlCommand(sql, _con);
           SqlDataReader q = cmd.ExecuteReader();
           if (q.HasRows)
           {
               while (q.Read())
               {
                   HoaDonDTO hd = new HoaDonDTO
                   {
                       MaHD = q.GetString(0),
                       NgayLapHD = q.GetDateTime(1),
                       MaNV = q.GetString(2),
                       MaKH = q.GetString(3),
                       TongTien = q.GetDouble(6)
                   };
                   ls.Add(hd);
               }
           }
           _con.Close();
           return ls;
           }
           catch (Exception)
           {
               return null;
           }
       }
       public int layIDSHoaDon()
       {
           try
           {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.hoadonIDcaonhat;
               SqlCommand cmd = new SqlCommand(sql, _con);
               int n = Convert.ToInt32(cmd.ExecuteScalar());
               _con.Close();
               return n;
           }
           catch (Exception)
           {
               return -1;
           }

       }
       public HoaDonDTO danhsachhoadoncoIdcaonhat()
       {
           try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
           HoaDonDTO hoadon = new HoaDonDTO();
           String sql = Contrants.danhsachhoadonID_caonhat;
           SqlCommand cmd = new SqlCommand(sql, _con);
           SqlDataReader q = cmd.ExecuteReader();
           if (q.HasRows)
           {
               while (q.Read())
               {
                   HoaDonDTO hd = new HoaDonDTO
                   {
                       MaHD = q.GetString(0),
                       NgayLapHD = q.GetDateTime(1),
                       MaNV = q.GetString(2),
                       MaKH = q.GetString(3)
                   };
                   hoadon = hd;
               }
           }
           _con.Close();
           return hoadon;
           }
           catch (Exception)
           {
               return null;
           }
       }
       public string laymakhachhang(string s)
       {
           try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.layMAKH;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.SDT_KH,s));
           SqlCommand cmd = new SqlCommand(sql, _con);
           cmd.Parameters.AddRange(ls.ToArray());
           string n = Convert.ToString(cmd.ExecuteScalar());
          _con.Close();
           return n;
           }
           catch (Exception)
           {
               return null;
           }
       }
       public int themHoaDon(HoaDonDTO hd)
       {
           try { 
           string m = laymakhachhang(hd.sdtKH);
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String sql = Contrants.themHD;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.mahd, hd.MaHD));
           ls.Add(new SqlParameter(Contrants.makh, m));
           ls.Add(new SqlParameter(Contrants.manv, hd.MaNV));
           ls.Add(new SqlParameter(Contrants.ngaylap, hd.NgayLapHD));
           SqlCommand cmd = new SqlCommand(sql,_con);
           cmd.Parameters.AddRange(ls.ToArray());
           int n = cmd.ExecuteNonQuery();
           _con.Close();
           return n;
           }
           catch (Exception)
           {
               return -1;
           }
       }
       public int capNhatTongTien(string mahd,float tongtien)
       {
           try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               List<SqlParameter> ls = new List<SqlParameter>();
               String sql = Contrants.capnhattongtien;
           SqlCommand cmd = new SqlCommand(sql, _con);
           ls.Add(new SqlParameter(Contrants.mahd, mahd));
           ls.Add(new SqlParameter(Contrants.tongtien, tongtien));
           cmd.Parameters.AddRange(ls.ToArray());
           int n = cmd.ExecuteNonQuery();
           _con.Close();
           return n;
           }
           catch (Exception)
           {
               return -1;
           }
       }
       public int capNhatHoaDon(HoaDonDTO hd)
       {
           try { 
           string m = laymakhachhang(hd.sdtKH);
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String sql = Contrants.suaHD;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.mahd, hd.MaHD));
           ls.Add(new SqlParameter(Contrants.makh, m));
           ls.Add(new SqlParameter(Contrants.manv, hd.MaNV));
           ls.Add(new SqlParameter(Contrants.ngaylap, hd.NgayLapHD));
           SqlCommand cmd = new SqlCommand(sql, _con);
           cmd.Parameters.AddRange(ls.ToArray());
           int n = cmd.ExecuteNonQuery();
           _con.Close();
           return n;
           }
           catch (Exception)
           {
               return -1;
           }

       }
       public int xoaHoaDon(HoaDonDTO hd)
       {
           try { 
           string m = laymakhachhang(hd.sdtKH);
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String sql = Contrants.XoaHD;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.mahd, hd.MaHD));
           SqlCommand cmd = new SqlCommand(sql, _con);
           cmd.Parameters.AddRange(ls.ToArray());
           int n = cmd.ExecuteNonQuery();
           _con.Close();
           return n;
           }
           catch (Exception)
           {
               return -1;
           }
       }
       public List<HoaDonDTO> DanhSachHoaDonTheoNgay(DateTime NgayLapHD)
       {
           try
           {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               List<HoaDonDTO> ls = new List<HoaDonDTO>();
               String sql = "select * from HOADON where TrangThai=1 and NgayLapHD=@ngaylaphd ";
               SqlCommand cmd = new SqlCommand(sql, _con);
               cmd.Parameters.Add(new SqlParameter("@ngaylapHD", NgayLapHD));
               SqlDataReader q = cmd.ExecuteReader();
               if (q.HasRows)
               {
                   while (q.Read())
                   {
                       HoaDonDTO hd = new HoaDonDTO
                       {
                           MaHD = q.GetString(0),
                           NgayLapHD = q.GetDateTime(1),
                           MaNV = q.GetString(2),
                           MaKH = q.GetString(3),
                           TongTien = q.GetDouble(6)
                       };
                       ls.Add(hd);
                   }
               }
               _con.Close();
               return ls;
           }
           catch (Exception)
           {
               return null;
           }
       }
    }
}
