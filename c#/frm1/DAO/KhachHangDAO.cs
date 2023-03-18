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
   public class KhachHangDAO
    {

       SqlConnection _con = new SqlConnection(Contrants.con);
       public List<KhachHangDTO> laydanhsachkhachhang()
       {
           try { 
           List<KhachHangDTO> ls= new List<KhachHangDTO>();
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String slq = Contrants.laydanhsacchKH;
           SqlCommand cmd = new SqlCommand(slq, _con);
         SqlDataReader q=  cmd.ExecuteReader();
           if(q.HasRows)
           {
               while(q.Read())
               {
                   KhachHangDTO kh = new KhachHangDTO
                   {
                       MaKH=q.GetString(0),
                       TenKH=q.GetString(1),
                       DiaChi=q.GetString(2),
                       SDT=q.GetString(3),
                       GioiTinh=q.GetString(6)
                   };
                   ls.Add(kh);
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
       public List<KhachHangDTO> laydanhsachTatCakhachhang()
       {
           try
           {
               List<KhachHangDTO> ls = new List<KhachHangDTO>();
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String slq = Contrants.layDStatcaKhachhang;
               SqlCommand cmd = new SqlCommand(slq, _con);
               SqlDataReader q = cmd.ExecuteReader();
               if (q.HasRows)
               {
                   while (q.Read())
                   {
                       KhachHangDTO kh = new KhachHangDTO
                       {
                           MaKH = q.GetString(0),
                           TenKH = q.GetString(1),
                           DiaChi = q.GetString(2),
                           SDT = q.GetString(3),
                           GioiTinh = q.GetString(6)
                       };
                       ls.Add(kh);
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
       public bool kiemtraKhachHang(string s)
       {
           try
           {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.ktraKhachhang;
               SqlCommand cmd = new SqlCommand(sql, _con);
               cmd.Parameters.Add(new SqlParameter(Contrants.makh, s));
               var n = Convert.ToInt32(cmd.ExecuteScalar());
               _con.Close();
               return n > 0;
           }
           catch (Exception)
           {
               return false;
           }
       }
       public bool kiemtraKhachHangtheoHD(string s)
       {
           try
           {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.ktraKhachhangtheo_HD;
               SqlCommand cmd = new SqlCommand(sql, _con);
               cmd.Parameters.Add(new SqlParameter(Contrants.makh, s));
               var n = Convert.ToInt32(cmd.ExecuteScalar());
               _con.Close();
               return n > 0;
           }
           catch (Exception)
           {
               return false;
           }
       }
       public bool kiemtraSDTKH(string s)
       {
           try
           {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.ktrSDTKH;
               SqlCommand cmd = new SqlCommand(sql, _con);
               cmd.Parameters.Add(new SqlParameter(Contrants.SDT_KH, s));
               var n = Convert.ToInt32(cmd.ExecuteScalar());
               _con.Close();
               return n > 0;
           }
           catch (Exception)
           {
               return false;
           }
       }
        public List<KhachHangDTO> TimKiem(string s)
       {
           try { 
           List<KhachHangDTO> ls= new List<KhachHangDTO>();
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String slq = "select * from KHACHHANG where TrangThai=1 and(MaKH like '%" + s + "%'or TenKH like '%" + s + "%' or DiaChi like '%" + s + "%' or Phone like '%" + s + "%' or GioiTinh like '%" + s + "%')";
           SqlCommand cmd = new SqlCommand(slq, _con);
         SqlDataReader q=  cmd.ExecuteReader();
           if(q.HasRows)
           {
               while(q.Read())
               {
                   KhachHangDTO kh = new KhachHangDTO
                   {
                       MaKH=q.GetString(0),
                       TenKH=q.GetString(1),
                       DiaChi=q.GetString(2),
                       SDT=q.GetString(3),
                       GioiTinh=q.GetString(6)
                   };
                   ls.Add(kh);
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
    

       public int layIdkhachhang()
       {
           try { 
           _con.Open();
           String sql = Contrants.layID_KH;
           SqlCommand cmd = new SqlCommand(sql,_con);
           int l =Convert.ToInt32( cmd.ExecuteScalar());
           _con.Close();
           return l;
           }
           catch (Exception)
           {
               return -1;
           }
       }
       public int themkhachhang(KhachHangDTO kh)
       {
          try { 
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String sql = Contrants.themKh;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.makh,kh.MaKH));
            ls.Add(new SqlParameter(Contrants.tenkh,kh.TenKH));
            ls.Add(new SqlParameter(Contrants.diachi_KH,kh.DiaChi));
            ls.Add(new SqlParameter(Contrants.SDT_KH,kh.SDT));
            ls.Add(new SqlParameter(Contrants.gioitinhKH, kh.GioiTinh));
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
       public int capnhatkhachhang(KhachHangDTO kh)
       {
           try {
            if (_con.State == ConnectionState.Closed)
            { _con.Open(); }
            String sql = Contrants.SuaKH;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.makh, kh.MaKH));
           ls.Add(new SqlParameter(Contrants.tenkh, kh.TenKH));
           ls.Add(new SqlParameter(Contrants.diachi_KH, kh.DiaChi));
           ls.Add(new SqlParameter(Contrants.SDT_KH, kh.SDT));
           ls.Add(new SqlParameter(Contrants.gioitinhKH, kh.GioiTinh));
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
       public int xoakhachhang(KhachHangDTO kh)
       {
           try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.xoaKH;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.makh, kh.MaKH));
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
       
    }
}
