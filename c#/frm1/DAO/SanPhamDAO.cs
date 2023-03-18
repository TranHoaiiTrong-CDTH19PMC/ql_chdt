using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
   public  class SanPhamDAO
    {
       SqlConnection _con = new SqlConnection(Contrants.con);
         public bool kiemtramsanpham(string s)
        {
            try {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.kiemtraSP;
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.Add(new SqlParameter(Contrants.masp, s));
                var n = Convert.ToInt32(cmd.ExecuteScalar());
                _con.Close();
                return n > 0;
            }catch(Exception )
            {
                return false;
            }
        }
         public bool kiemtramsanphamtheoncc(string s)
         {
             try
             {
                 if (_con.State == ConnectionState.Closed)
                 { _con.Open(); }
                 String sql = "select id from ct_hoadon where MaSP=@masp";
                 SqlCommand cmd = new SqlCommand(sql, _con);
                 cmd.Parameters.Add(new SqlParameter(Contrants.masp, s));
                 var n = Convert.ToInt32(cmd.ExecuteScalar());
                 _con.Close();
                 return n > 0;
             }
             catch (Exception)
             {
                 return false;
             }
         }
       public string laydongiasanpham(string s)
         {
             _con.Open();
             String sql = "select GiaBan from SANPHAM where TrangThai=1 and MaSP=@masp";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.Add(new SqlParameter(Contrants.masp, s));
                var n = Convert.ToString(cmd.ExecuteScalar());
             _con.Close();
           return n;
         }
       public bool kiemtraSOluongSanPham(string masp,int soluong)
         {
             _con.Open();
             String sql = Contrants.kiemtraSoluongSP;
             List<SqlParameter> ls = new List<SqlParameter>();
             ls.Add(new SqlParameter(Contrants.masp,masp));
             ls.Add(new SqlParameter(Contrants.soluong, soluong));
             SqlCommand cmd = new SqlCommand(sql, _con);
             cmd.Parameters.AddRange(ls.ToArray());
             var n = Convert.ToInt32(cmd.ExecuteScalar());
             _con.Close();
             return n > 0;
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
        public int TRUSOluongSanPham(string tensp,int soluong)
       {
           string masp = laymasanpham(tensp);
           if (_con.State == ConnectionState.Closed)
           { _con.Open(); }
           String sql = Contrants.truSoluongSP;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.masp, tensp));
           ls.Add(new SqlParameter(Contrants.soluong, soluong));
           SqlCommand cmd = new SqlCommand(sql, _con);
           cmd.Parameters.AddRange(ls.ToArray());
           var n = cmd.ExecuteNonQuery();
           _con.Close();
           return n ;
       }
         public int layIDSanpham()
         {
             try
             {
                 if (_con.State == ConnectionState.Closed)
                 { _con.Open(); }
                 String sql = Contrants.layidSP;
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
        public List<SanPhamDTO> laydssapham()
         {
             try
             {
             List<SanPhamDTO> ls=new List<SanPhamDTO>();
             if (_con.State == ConnectionState.Closed)
             { _con.Open(); }
             String sql = Contrants.laydanhsachSP;
           SqlCommand cmd = new SqlCommand(sql,_con);
           SqlDataReader q = cmd.ExecuteReader();
            if(q.HasRows)
            {
                while(q.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO
                    {
                        MaSP = q.GetString(0),
                        TenSP = q.GetString(1),
                        MoTa = q.GetString(2),
                        SoLuong = q.GetInt32(3),
                        DonGia = q.GetDouble(4),
                        MaNCC = q.GetString(7),
                        GiaBan = q.GetDouble(8),
                    };
                    ls.Add(sp);
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
        public List<SanPhamDTO> laydstatcasapham()
        {
            try
            {
                List<SanPhamDTO> ls = new List<SanPhamDTO>();
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.laydanhsachtatcaSP;
                SqlCommand cmd = new SqlCommand(sql, _con);
                SqlDataReader q = cmd.ExecuteReader();
                if (q.HasRows)
                {
                    while (q.Read())
                    {
                        SanPhamDTO sp = new SanPhamDTO
                        {
                            MaSP = q.GetString(0),
                            TenSP = q.GetString(1),
                            MoTa = q.GetString(2),
                            SoLuong = q.GetInt32(3),
                            DonGia = q.GetDouble(4),
                            MaNCC = q.GetString(7),
                            GiaBan = q.GetDouble(8),

                        };
                        ls.Add(sp);
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
        public List<SanPhamDTO> TimKiemSanPham(string s)
        {
            try
            {
                List<SanPhamDTO> ls = new List<SanPhamDTO>();
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = "	select * from SANPHAM where TrangThai=1 and(MaSP like '%" + s + "%' or TenSP like '%" + s + "%'or MoTa like '%" + s + "%' or MaNCC like '%" + s + "%') ";
                SqlCommand cmd = new SqlCommand(sql, _con);
                SqlDataReader q = cmd.ExecuteReader();
                if (q.HasRows)
                {
                    while (q.Read())
                    {
                        SanPhamDTO sp = new SanPhamDTO
                        {
                            MaSP = q.GetString(0),
                            TenSP = q.GetString(1),
                            MoTa = q.GetString(2),
                            SoLuong = q.GetInt32(3),
                            DonGia =q.GetDouble(4),
                            MaNCC = q.GetString(7),
                            GiaBan = q.GetDouble(8)
                        };
                        ls.Add(sp);
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
        public int themsanpham(SanPhamDTO sp)
        {
            try
            {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.themSP;
                List<SqlParameter> pa = new List<SqlParameter>();
                pa.Add(new SqlParameter(Contrants.masp, sp.MaSP));
                pa.Add(new SqlParameter(Contrants.tensp, sp.TenSP));
                pa.Add(new SqlParameter(Contrants.soluong, sp.SoLuong));
                pa.Add(new SqlParameter(Contrants.mota, sp.MoTa));
                pa.Add(new SqlParameter(Contrants.dongia, sp.DonGia));
                pa.Add(new SqlParameter(Contrants.mancc, sp.MaNCC));
                pa.Add(new SqlParameter(Contrants.giaban, sp.GiaBan));
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddRange(pa.ToArray());
                int n = cmd.ExecuteNonQuery();
                _con.Close();
                return n;
            }
            catch (Exception)
            {
                return -1;
            }       
        }
        public int capnhatsanpham(SanPhamDTO sp)
        {
            try
            {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.SuaSP;
                List<SqlParameter> pa = new List<SqlParameter>();
                pa.Add(new SqlParameter(Contrants.masp, sp.MaSP));
                pa.Add(new SqlParameter(Contrants.tensp, sp.TenSP));
                pa.Add(new SqlParameter(Contrants.soluong, sp.SoLuong));
                pa.Add(new SqlParameter(Contrants.mota, sp.MoTa));
                pa.Add(new SqlParameter(Contrants.dongia, sp.DonGia));
                pa.Add(new SqlParameter(Contrants.mancc, sp.MaNCC));
                pa.Add(new SqlParameter(Contrants.giaban, sp.GiaBan));
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddRange(pa.ToArray());
                int n = cmd.ExecuteNonQuery();
                _con.Close();
                return n;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int xoasanpham(SanPhamDTO sp)
        {
            try
            {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.XoaSP;
                List<SqlParameter> pa = new List<SqlParameter>();
                pa.Add(new SqlParameter(Contrants.masp, sp.MaSP));
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddRange(pa.ToArray());
                int n = cmd.ExecuteNonQuery();
                _con.Close();
                return n;
            }
            catch (Exception )
            {
                return -1;
            }
          
        }
        public List<SanPhamDTO> LayDanhSachSanPhamTNCC(string MaNCC)
        {
            try
            {
                List<SanPhamDTO> ls = new List<SanPhamDTO>();
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = "	select * from SANPHAM where TrangThai=1 and MaNCC=@mancc";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.Add(new SqlParameter("@mancc", MaNCC));
                SqlDataReader q = cmd.ExecuteReader();
                if (q.HasRows)
                {
                    while (q.Read())
                    {
                        SanPhamDTO sp = new SanPhamDTO
                        {
                            MaSP = q.GetString(0),
                            TenSP = q.GetString(1),
                            MoTa = q.GetString(2),
                            SoLuong = q.GetInt32(3),
                            DonGia = q.GetDouble(4),
                            MaNCC = q.GetString(7),
                            GiaBan = q.GetDouble(8),
                        };
                        ls.Add(sp);
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
