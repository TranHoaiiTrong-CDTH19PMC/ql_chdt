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
   public class CT_HoaDonDAO
    {

       SqlConnection _con = new SqlConnection(Contrants.con);
       public List<CT_HoaDonDTO> laydanhsachCTHoaDon(string s)
       {
           try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
           List<CT_HoaDonDTO> ls = new List<CT_HoaDonDTO>();
           String Sql = Contrants.laydanhsachCT_HD;
           SqlCommand cmd = new SqlCommand(Sql, _con);
           cmd.Parameters.Add(new SqlParameter(Contrants.mahd, s));
           SqlDataReader q = cmd.ExecuteReader();
           if(q.HasRows)
           {
               while(q.Read())
               {
                   CT_HoaDonDTO hd = new CT_HoaDonDTO
                   {
                       ID = q.GetInt32(0),
                       MaHD=q.GetString(1),
                       MaSP=q.GetString(2),
                       SoLuong=q.GetInt32(3),
                       DonGia=q.GetInt32(4),
                       ThanhTien=q.GetInt32(5)
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
       public string laymasanpham(string s)
       {
           try
           {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.layMASPCT_HD;
               List<SqlParameter> ls = new List<SqlParameter>();
               ls.Add(new SqlParameter(Contrants.tensp, s));
               SqlCommand cmd = new SqlCommand(sql, _con);
               cmd.Parameters.AddRange(ls.ToArray());
               string masp = Convert.ToString(cmd.ExecuteScalar());
               _con.Close();
               return masp;
           }
           catch (Exception)
           {
               return null;
           }
       }
      
       public bool kiemtraCT_HoaDon(string tensp,string s)
       {
           
           string masp = laymasanpham(tensp);
           try
           {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.laydanhsachCTHD;
               SqlCommand cmd = new SqlCommand(sql, _con);
               cmd.Parameters.Add(new SqlParameter(Contrants.mahd, s));
               cmd.Parameters.Add(new SqlParameter(Contrants.masp, masp));
               var n = cmd.ExecuteNonQuery();
               _con.Close();
               return n > 0;
           }
           catch (Exception)
           {
               return false;
           }
       }
      
       public int themCThoadon(CT_HoaDonDTO hd)
       {
          try { 
           string masp = laymasanpham(hd.MaSP);
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String sql=Contrants.themCTHD;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.mahd, hd.MaHD));
           ls.Add(new SqlParameter(Contrants.masp, masp));
           ls.Add(new SqlParameter(Contrants.dongia, hd.DonGia));
           ls.Add(new SqlParameter(Contrants.soluong, hd.SoLuong));
           ls.Add(new SqlParameter(Contrants.thanhtien, hd.ThanhTien));
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
       public int suaCThoadon(CT_HoaDonDTO hd)
       {
           //try { 
           string masp = laymasanpham(hd.MaSP);
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String sql = Contrants.SuaCTHD;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.mahd, hd.MaHD));
           ls.Add(new SqlParameter(Contrants.masp, masp));
           ls.Add(new SqlParameter(Contrants.dongia, hd.DonGia));
           ls.Add(new SqlParameter(Contrants.soluong, hd.SoLuong));
           ls.Add(new SqlParameter(Contrants.thanhtien, hd.ThanhTien));
           SqlCommand cmd = new SqlCommand(sql, _con);
           cmd.Parameters.AddRange(ls.ToArray());
           int n = cmd.ExecuteNonQuery();
           _con.Close();
           return n;
           //}
           //catch (Exception)
           //{
           //    return -1;
           //}
       }
       public int xoaCThoadon(CT_HoaDonDTO hd)
       {
           try { 
           string masp = laymasanpham(hd.MaSP);
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String sql = Contrants.XoaCTHD;
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
    }


}
