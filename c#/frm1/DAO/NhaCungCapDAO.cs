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
   public class NhaCungCapDAO
    {
       SqlConnection _con = new SqlConnection(Contrants.con);
       public List<NhaCungCapDTO> LayDSNhaCungCap()
        {
            try { 
           List<NhaCungCapDTO> NACC=new List<NhaCungCapDTO>();
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String sql = Contrants.laydanhsachNhacungcap;
           SqlCommand cmd = new SqlCommand(sql, _con);
           SqlDataReader p = cmd.ExecuteReader();
           if(p.HasRows)
           {
               while(p.Read())
               {
                   NhaCungCapDTO nc = new NhaCungCapDTO
                   {
                       MaNCC=p.GetString(1),
                       TenNCC = p.GetString(2),
                       SDT=p.GetString(3)
                   };
                   NACC.Add(nc);
               }
           }
           _con.Close();
           return NACC;
            }
            catch (Exception)
            {
                return null;
            }
        }
       public bool kiemtranhacungcap(string s)
       {
           try
           {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.ktranhacungcap;
               SqlCommand cmd = new SqlCommand(sql, _con);
               cmd.Parameters.Add(new SqlParameter(Contrants.mancc, s));
               var n = Convert.ToInt32(cmd.ExecuteScalar());
               _con.Close();
               return n > 0;
           }
           catch (Exception)
           {
               return false;
           }
       }
       public bool kiemtranhacungcaptheoSP(string s)
       {
           try
           {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.ktranhacungcaptheo_SP;
               SqlCommand cmd = new SqlCommand(sql, _con);
               cmd.Parameters.Add(new SqlParameter(Contrants.mancc, s));
               var n = Convert.ToInt32(cmd.ExecuteScalar());
               _con.Close();
               return n > 0;
           }
           catch (Exception)
           {
               return false;
           }
       }
       public string layMaNCC(string s)
       {
           try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
           List<SqlParameter> ls = new List<SqlParameter>();
           String sql = Contrants.laymancc;
           ls.Add(new SqlParameter(Contrants.tenncc, s));
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
       public int layIDNhaCungCapCaoNhat()
       {
           try
           {
            if (_con.State == ConnectionState.Closed)
            { _con.Open(); }
            String sql = Contrants.layIDnhacungcap;
           SqlCommand cmd = new SqlCommand(sql,_con);
           int n =Convert.ToInt32( cmd.ExecuteScalar());
           _con.Close();
           return n;
           }
           catch (Exception)
           {
               return -1;
           }
       }
       public int ThemNhaCungCap(NhaCungCapDTO ncc)
       {
           try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
           List<SqlParameter> ls = new List<SqlParameter>();
           String sql = Contrants.themNhacungcap;
           ls.Add(new SqlParameter(Contrants.mancc, ncc.MaNCC));
           ls.Add(new SqlParameter(Contrants.tenncc, ncc.TenNCC));
           ls.Add(new SqlParameter(Contrants.SDT_KH, ncc.SDT));
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
       public int CapnhatNhaCungCap(NhaCungCapDTO ncc)
       {
           try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); } List<SqlParameter> ls = new List<SqlParameter>();
               String sql = Contrants.suanhacungcaop;
           ls.Add(new SqlParameter(Contrants.mancc, ncc.MaNCC));
           ls.Add(new SqlParameter(Contrants.tenncc, ncc.TenNCC));
           ls.Add(new SqlParameter(Contrants.SDT_KH, ncc.SDT));
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
       public int XoaNhaCungCap(NhaCungCapDTO ncc)
       {
           try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); } List<SqlParameter> ls = new List<SqlParameter>();
               String sql = Contrants.xoanhacungcap;
           ls.Add(new SqlParameter(Contrants.mancc, ncc.MaNCC));
          
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
       public List<NhaCungCapDTO> TimKiemNhaCungCap(string tim)
       {
           try { 
           List<NhaCungCapDTO> NACC = new List<NhaCungCapDTO>();
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String sql = "select * from NHACUNGCAP where TrangThai=1 and(TenNCC like '%" + tim + "%' or MaNCC like '%" +tim + "%'  or SDT like '%" +tim + "%')";

           SqlCommand cmd = new SqlCommand(sql, _con);
           SqlDataReader p = cmd.ExecuteReader();
           if (p.HasRows)
           {
               while (p.Read())
               {
                   NhaCungCapDTO nc = new NhaCungCapDTO
                   {
                       MaNCC = p.GetString(1),
                       TenNCC = p.GetString(2),
                       SDT = p.GetString(3)
                   };
                   NACC.Add(nc);
               }
           }
           _con.Close();
           return NACC;
           }
           catch (Exception)
           {
               return null;
           }
       }


       public List<NhaCungCapDTO> LayDanhSachTatCaNCC()
       {
           try
           {
               List<NhaCungCapDTO> NACC = new List<NhaCungCapDTO>();
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = "select * from NHACUNGCAP order by id ";
               SqlCommand cmd = new SqlCommand(sql, _con);
               SqlDataReader p = cmd.ExecuteReader();
               if (p.HasRows)
               {
                   while (p.Read())
                   {
                       NhaCungCapDTO nc = new NhaCungCapDTO
                       {
                           MaNCC = p.GetString(1),
                           TenNCC = p.GetString(2),
                           SDT = p.GetString(3)
                       };
                       NACC.Add(nc);
                   }
               }
               _con.Close();
               return NACC;
           }
           catch (Exception)
           {
               return null;
           }
       }
    }
}
