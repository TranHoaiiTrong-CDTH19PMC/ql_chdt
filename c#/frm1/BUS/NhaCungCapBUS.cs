using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
   public  class NhaCungCapBUS
    {
       NhaCungCapDAO _nhacungcapDAO = new NhaCungCapDAO();
        public List<NhaCungCapDTO> LayDSNhaCungCap()
       {
           return _nhacungcapDAO.LayDSNhaCungCap();
       }
        public List<NhaCungCapDTO> LayDanhSachTatCaNCC()
        {
            return _nhacungcapDAO.LayDanhSachTatCaNCC();
        }
       public bool kiemtranhacungcap(string s)
        {
            return _nhacungcapDAO.kiemtranhacungcap(s);
        }
        public bool kiemtranhacungcaptheoSP(string s)
       {
           return _nhacungcapDAO.kiemtranhacungcaptheoSP(s);
       }
        public int layIDNhaCungCapCaoNhat()
        {
            return _nhacungcapDAO.layIDNhaCungCapCaoNhat();
        }
        public int ThemNhaCungCap(NhaCungCapDTO ncc)
        {
            return _nhacungcapDAO.ThemNhaCungCap(ncc);
        }
        public int CapNhatNhaCungCap(NhaCungCapDTO ncc)
        {
            return _nhacungcapDAO.CapnhatNhaCungCap(ncc);
        }
        public int XoaNhaCungCap(NhaCungCapDTO ncc)
        {
            return _nhacungcapDAO.XoaNhaCungCap(ncc);
        }
        public List<NhaCungCapDTO> TimKiemNhaCungCap(string s)
        {
            return _nhacungcapDAO.TimKiemNhaCungCap(s);
        }
         public string layMaNCC(string s)
        {
           return _nhacungcapDAO.layMaNCC(s);
        }
         
    }
}
