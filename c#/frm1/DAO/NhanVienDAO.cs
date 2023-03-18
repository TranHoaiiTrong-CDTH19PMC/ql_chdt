using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;
namespace DAO
{
   public class NhanVienDAO
    {
       SqlConnection _con = new SqlConnection(Contrants.con);
        public bool kiemtramssv(string s)
        {
            try{
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.kiemtra_MANV;
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.Add(new SqlParameter(Contrants.manv, s));
            var n = Convert.ToInt32(cmd.ExecuteScalar());
            _con.Close();
            return n > 0;
             }catch(Exception )
            {
                return false;
            }
        }
        public bool kiemtramMANVtheoHD(string s)
        {
            try
            {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.kiemtra_MANVtheo_HD ;
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.Add(new SqlParameter(Contrants.manv, s));
                var n = Convert.ToInt32(cmd.ExecuteScalar());
                _con.Close();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
       public bool IsNumber(string pText)
        {
            Regex regex = null;
            try
            {
                regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$"); return regex.IsMatch(pText);
            }
            catch (Exception )
            {
                return regex.IsMatch(pText);
            }
        }

        public int layIdnhanvien()
        {
            try {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.layID_NV;
            SqlCommand cmd = new SqlCommand(sql, _con);
            int l = Convert.ToInt32(cmd.ExecuteScalar());
            _con.Close();
            return l;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public string kiemtrataikhoan(string s,string v)
        {
            try {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.KiemtrataiKhoan;
            List<SqlParameter> lx = new List<SqlParameter>();
            lx.Add(new SqlParameter(Contrants.manv, s));
            lx.Add(new SqlParameter(Contrants.matkhau, v));
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddRange(lx.ToArray());
            var n = Convert.ToString(cmd.ExecuteScalar());
            _con.Close();
            return n;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<NhanVienDTO> laydssapham()
        {
            try { 
            List<NhanVienDTO> ls = new List<NhanVienDTO>();
            if (_con.State == ConnectionState.Closed)
            { _con.Open(); }
            String sql = Contrants.laydanhsach_NV;
            SqlCommand cmd = new SqlCommand(sql, _con);
            SqlDataReader q = cmd.ExecuteReader();
            if (q.HasRows)
            {
                while (q.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO
                    {
                        MaNV=q.GetString(0),
                        TenNV = q.GetString(1),
                        DiaChi = q.GetString(2),
                        SDT =q.GetString(3),
                        MatKhau = q.GetString(5),
                        GioiTinh=q.GetString(7),
                        ChucVu=q.GetString(8),
                        Email=q.GetString(9)
                    }; 
                    ls.Add(nv);
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
        public List<NhanVienDTO> laydsTatCaNV()
        {
            try
            {
                List<NhanVienDTO> ls = new List<NhanVienDTO>();
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.laydanhsachtatca_NV;
                SqlCommand cmd = new SqlCommand(sql, _con);
                SqlDataReader q = cmd.ExecuteReader();
                if (q.HasRows)
                {
                    while (q.Read())
                    {
                        NhanVienDTO nv = new NhanVienDTO
                        {
                            MaNV = q.GetString(0),
                            TenNV = q.GetString(1),
                            DiaChi = q.GetString(2),
                            SDT = q.GetString(3),
                            MatKhau = q.GetString(5),
                            GioiTinh = q.GetString(7),
                            ChucVu = q.GetString(8),
                            Email = q.GetString(9)
                        };
                        ls.Add(nv);
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
        public List<NhanVienDTO> timKiemNhanVien(string s)
        {
            try { 
            List<NhanVienDTO> ls = new List<NhanVienDTO>();
            if (_con.State == ConnectionState.Closed)
            { _con.Open(); }
            String sql = "select * from NHANVIEN where TrangThai=1 and(MaNV like '%" + s + "%' or TenNV like '%" + s + "%' or DiaChi like '%" + s + "%' or Phone like '%" + s + "%' or GioiTinh like '%" + s + "%' or ChucVu like '%" +s + "%' or Email like '%" + s + "%' )";
            SqlCommand cmd = new SqlCommand(sql, _con);
            SqlDataReader q = cmd.ExecuteReader();
            if (q.HasRows)
            {
                while (q.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO
                    {
                        MaNV = q.GetString(0),
                        TenNV = q.GetString(1),
                        DiaChi = q.GetString(2),
                        SDT = q.GetString(3),
                        MatKhau = q.GetString(5),
                        GioiTinh = q.GetString(7),
                        ChucVu=q.GetString(8),
                        Email=q.GetString(9),
                    };
                    ls.Add(nv);
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
       public int themnhanvien(NhanVienDTO nv)
        {
            try {
                if (_con.State == ConnectionState.Closed)
                { _con.Open(); }
                String sql = Contrants.them_NV;
                string s = nv.MatKhau.MaHoaMK();
            List<SqlParameter> ls = new List<SqlParameter>();
            ls.Add(new SqlParameter(Contrants.manv, nv.MaNV));
            ls.Add(new SqlParameter(Contrants.tennv, nv.TenNV));
            ls.Add(new SqlParameter(Contrants.diachi_KH, nv.DiaChi));
            ls.Add(new SqlParameter(Contrants.SDT_KH, nv.SDT));
            ls.Add(new SqlParameter(Contrants.matkhau, s));
            ls.Add(new SqlParameter(Contrants.gioitinhKH, nv.GioiTinh));
            ls.Add(new SqlParameter(Contrants.chucvu, nv.ChucVu));
            ls.Add(new SqlParameter(Contrants.EmailNV, nv.Email));
           SqlCommand cmd = new SqlCommand(sql, _con);
           cmd.Parameters.AddRange(ls.ToArray());
          int n= cmd.ExecuteNonQuery();           
            _con.Close();
            return n;
            }
            catch (Exception)
            {
                return -1;
            }
        }
       public int capnhatnhanvien(NhanVienDTO nv)
       {
           //try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); }
               String sql = Contrants.Sua_NV;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.manv, nv.MaNV));
           ls.Add(new SqlParameter(Contrants.tennv, nv.TenNV));
           ls.Add(new SqlParameter(Contrants.diachi_KH, nv.DiaChi));
           ls.Add(new SqlParameter(Contrants.SDT_KH, nv.SDT));
           ls.Add(new SqlParameter(Contrants.gioitinhKH, nv.GioiTinh));
           ls.Add(new SqlParameter(Contrants.chucvu, nv.ChucVu));
           ls.Add(new SqlParameter(Contrants.EmailNV, nv.Email));
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
       public bool isEmail(string inputEmail)
       {
           try { 
           inputEmail = inputEmail ?? string.Empty;
           string strRegex = Contrants.Ham_KT_Email;
           Regex re = new Regex(strRegex);
           if (re.IsMatch(inputEmail))
               return (true);
           else
               return (false);
           }
           catch (Exception)
           {
               return false;
           }
       }
       public int xoanhanvien(NhanVienDTO nv)
       {
           try {
               if (_con.State == ConnectionState.Closed)
               { _con.Open(); } String sql = Contrants.Xoa_NV;
           List<SqlParameter> ls = new List<SqlParameter>();
           ls.Add(new SqlParameter(Contrants.manv, nv.MaNV));
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
    public int Datlaimatkhau(string mk,string manv)
    {
        try {
            if (_con.State == ConnectionState.Closed)
            { _con.Open(); }
            String sql = "update NHANVIEN set matkhau=@matkhau where MaNV=@manv and TrangThai=1";
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.Add( new SqlParameter( "@matkhau", mk));
            cmd.Parameters.Add(new SqlParameter( "@manv", manv));
            int n = cmd.ExecuteNonQuery();
            return n;
        }
        catch (Exception)
        {
            return -1;
        }
           
       }
    }
}
