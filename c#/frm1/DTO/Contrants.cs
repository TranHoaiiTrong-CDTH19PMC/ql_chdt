using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public static class Contrants
    {
       public static String con = @"Data Source=DESKTOP-7VR81LB\SQLEXPRESS;Initial Catalog=CUAHANGDTDD;Integrated Security=True";
       public static string ThemThanhCong = "Thêm thành công! ";
       public static string ThemThatbai = "Thêm thất bại!,Bạn hãy kiểm tra lại thông tin nhập chính sác chưa?";
       public static string CapnhatThanhCong = "Cập nhật thành công!";
       public static string CapNhatThatBai = "Cập nhật thất bại!,Bạn hãy kiểm tra lại thông tin nhập chính sác chưa?";
       public static string XoaThanhCong = "Xóa thành công!";
       public static string XoaThatBai = "Xóa thất bại!,Bạn hãy kiểm tra lại thông tin nhập chính sác chưa?";
       public static string ThongBao = "Thông báo";
       public static string NhapChuaDu = "Bạn hãy điền đầy đủ thông tin";
       public static string MaDaTonTai = "Mã này đã tồn tại,bạn hãy kiểm tra lại";
       public static string SDT = "Bạn chưa nhập đúng định dạng số điện thoại";
       public static string So = "Bạn chưa nhập đúng định dạng là số";
       public static string Email = "Bạn chưa nhập đúng định dạng Email";
       public static string ktSDT = "Số điện thoại khách hàng đã sai mời bạn nhập lại";
       public static string Bancochachanmuonxoa = "Bạn có chắc chắn muốn xóa?";
        public static string QuanLy="Quản Lí";
    public static string nhanvien="Nhân Viên";
    public static string dangnhapkhongthanhcong = "Tài khoản hoặc mật khẩu của bạn đã sai";
       //SanphamDAO
       public static string laydanhsachCTHD= "select id from CT_HOADON where MaHD=@manhd and MaSP=@masp";
       //CTHoaDon
       public static string themCTHD="insert into CT_HOADON(MaHD,MaSP,DonGia,SoLuong,ThanhTien,TrangThai) values(@mahd,@masp,@dongia,@soluong,@thanhtien,1)";
       public static string SuaCTHD = "update CT_HOADON set SoLuong=@soluong,DonGia=@dongia,ThanhTien=@thanhtien where TrangThai=1 and MaHD=@mahd and MaSP=@masp";
      public static string XoaCTHD= "update CT_HOADON set TrangThai=0 where MaHD=@mahd";
      public static string laydanhsachCT_HD= "select * from CT_HOADON where TrangThai=1 and MaHD=@mahd order by id ";
      public static string layMASPCT_HD = "select MaSP from SANPHAM where TrangThai=1 and TenSP=@tensp";
      public static string dongia = "@dongia";
      public static string soluong="@soluong";
      public static string thanhtien = "@thanhtien";
      public static string tongtien = "@tongtien";
      public static string mahd = "@mahd";
       //HoaDonDAO
        public static string laydanhsachHD="select * from HOADON where TrangThai=1 order by id ";
      public static string themHD ="insert into HOADON(MaHD,NgayLapHD,MaKH,MaNV,TrangThai) values (@mahd,@ngaylap,@makh,@manv,1)";
        public static string suaHD= "update HOADON set MaKH=@makh,MaNV=@manv,NgayLapHD=@ngaylap where MaHD=@mahd";
        public static string XoaHD = "update HOADON set TrangThai=0 where MaHD=@mahd";
       public static string capnhattongtien= "update HOADON set TongTien=@tongtien where MaHD=@mahd";
       public static string layMAKH = "select MaKH from KHACHHANG where  Phone=@sdt";
    public static string danhsachhoadonID_caonhat= "select top 1 * from HOADON where TrangThai=1 order by id DESC";
    public static string hoadonIDcaonhat="select max(id) from HOADON";
    public static string s = "s";
    public static string timkiemHD = "select * from HOADON where TrangThai=1 and(MaHD like '%" + Contrants.s + "%' or MaNV like'%" + Contrants.s + "%' or MaKH like '%" + Contrants.s + "%')";
    public static string layMANV = "select MaNV from NHANVIEN where TenNV=@tennv";
    public static string ktraHD = "select ID from CT_HOADON where MaHD=@mahd and TrangThai=1";
    public static string ngaylap = "@ngaylap";
       //khachangDAO
        public static string laydanhsacchKH="select * from khachhang where Trangthai=1 order by id ";
        public static string themKh= "insert into KHACHHANG(MaKH,TenKH,DiaChi,Phone,TrangThai,GioiTinh) values(@makh,@tenkh,@diachi,@sdt,1,@gioitinh)";
        public static string SuaKH="update KHACHHANG set TenKH=@tenkh,DiaChi=@diachi,Phone=@sdt,GioiTinh=@gioitinh where MaKH=@makh";
       public static string xoaKH="update KHACHHANG set TrangThai=0 where MaKH=@makh";
       public static string timkiemKH = "select * from KHACHHANG where TrangThai=1 and(MaKH like '%" + s + "%'or TenKH like '%" + s + "%' or DiaChi like '%" + s + "%' or Phone like '%" + s + "%' or GioiTinh like '%" + s + "%')";
        public static string ktrSDTKH= "select id from KHACHHANG where Phone=@sdt";
        public static string ktraKhachhang = "select id from KHACHHANG where MaKH=@mankh";
        public static string ktraKhachhangtheo_HD = "select id from HOADON where MaKH=@mankh and TrangThai=1";
      public static string layDStatcaKhachhang=  "select * from khachhang order by id ";
        public static string makh = "@makh";
        public static string SDT_KH = "@sdt";
        public static string tenkh = "@tenkh";
     public static string diachi_KH="@diachi";
        public static string gioitinhKH="@gioitinh";
        public static string layID_KH = "select max(id) from khachhang";
       //NhacungcapDAO
        public static string laydanhsachNhacungcap ="select * from NHACUNGCAP where TrangThai=1 order by id ";
        public static string themNhacungcap="insert into NHACUNGCAP(MaNCC,TenNCC,SDT,TrangThai) values(@mancc,@tenncc,@sdt,1)";
         public static string suanhacungcaop="update NHACUNGCAP set TenNCC=@tenncc,SDT=@sdt where MaNCC=@mancc ";
        public static string xoanhacungcap="update NHACUNGCAP set TrangThai=0 where MaNCC=@mancc ";
        public static string tim = "tim";
        public static string timkiemnhacungcap = "select * from NHACUNGCAP where TrangThai=1 and(TenNCC like '%" + Contrants.tim + "%' or MaNCC like '%" + Contrants.tim + "%'  or SDT like '%" + Contrants.tim + "%')";
        public static string mancc = "@mancc";
        public static string tenncc = "@tenncc";
        public static string layIDnhacungcap = "select max(id) from NHACUNGCAP ";
        public static string laymancc = "select MaNCC from NHACUNGCAP where TrangThai=1 and TenNCC=@tenncc";
      public static string ktranhacungcap=  "select id from NHACUNGCAP where MaNCC=@mancc";
      public static string ktranhacungcaptheo_SP = "select id from SANPHAM where MaNCC=@mancc and TrangThai=1";
       //nhanvienDAO
        public static string them_NV="exec themNV @manv,@tennv,@diachi,@sdt,@pass,@gioitinh,@chucvu,@email";
        public static string Sua_NV= "exec suaNVN @manv,@tennv,@diachi,@sdt,@gioitinh,@chucvu,@email";
        public static string Xoa_NV= "exec xoaNV @manv";
        public static string laydanhsach_NV="exec laydanhsachNV";
        public static string timkiem_NV = "select * from NHANVIEN where TrangThai=1 and(MaNV like '%" + Contrants.s + "%' or TenNV like '%" + Contrants.s + "%' or DiaChi like '%" + Contrants.s + "%' or Phone like '%" + Contrants.s + "%' or GioiTinh like '%" + Contrants.s + "%' or ChucVu like '%" + Contrants.s + "%' or Email like '%" + Contrants.s + "%' )";
        public static string KiemtrataiKhoan = "select ChucVu from NHANVIEN where MaNV=@manv and matkhau=@pass and TrangThai=1";
        public static string laydanhsachtatca_NV = "	select * from NHANVIEN  order by id ";
        public static string kiemtra_MANV="select id from NHANVIEN where MaNV=@manv";
        public static string kiemtra_MANVtheo_HD = "select id from HOADON where MaNV=@manv and TrangThai=1";
             public static string layID_NV= "select max(id) from NHANVIEN";
             public static string Ham_KT_Email = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
             public static string tennv = "tennv";
             public static string manv = "@manv";
             public static string matkhau = "@pass";
       public static string chucvu="@chucvu";
       public static string EmailNV = "@email";
       //sanphamDAO
         public static string themSP= "exec ThemSP  @masp,@tensp,@soluong,@dongia,@mota,@mancc,@giaban";
         public static string SuaSP = "exec captNhaSP @masp,@tensp,@soluong,@dongia,@mota,@mancc,@giaban ";
        public static string XoaSP= " exec xoaSP @masp";
        public static string timkiemSP = "	select * from SANPHAM where TrangThai=1 and(MaSP like '%" + Contrants.s + "%' or TenSP like '%" + Contrants.s + "%'or MoTa like '%" + Contrants.s + "%' or MaNCC like '%" + Contrants.s + "%') ";
       public static string kiemtraSP="select id from SANPHAM where MaSP=@masp";
           public static string kiemtraSoluongSP= "select id from SANPHAM where MaSP=@masp and SoLuong>=@soluong";
           public static string truSoluongSP = "update SANPHAM set SoLuong=(SoLuong-@soluong) where MaSP=@masp";
      public static string layidSP="select max(id) from SANPHAM";
       public static string laydanhsachSP= "select * from SANPHAM where TrangThai=1 order by id ";
       public static string  laydanhsachtatcaSP= "select * from SANPHAM  order by id ";
     public static string soluongcaonhat2SP= "select top 2 * from SANPHAM where TrangThai=1 order by SoLuong DESC ";
     public static string masp = "@masp";
     public static string tensp = "@tensp";
     public static string mota = "@mota";
     public static string giaban = "@giaban";
     public static string nam = "Nam";
     public static string nu = "Nữ";
     public static string khac = "Khác";
     public static string NV = "NV_";
     public static string SP = "SP_";
     public static string HD = "HD_";
     public static string KH = "KH_";
     public static string NCC = "NCC_";
     public static string cach = "";
     public static string nhanviencontontai="Nhân viên còn tồn tại không xóa được";
     public static string khachhangcontontai = "Khách hàng này còn tồn tại";
     public static string solongkhongdu = "Số lượng không đủ ";
     public static string SDTHOA = "SDT";
      public static string hoadoncontontai= "Hóa đơn còn tồn tại không xóa được";
      public static string nhacungcapcontontai = "Nhà cung cấp còn tồn tại không được xóa";
      public static string MaKH = "MaKH";
      public static string TenKH = "TenKH";
      public static string MaSP = "MaSP";
      public static string TenSP = "TenSP";
      public static string MaNV = "MaNV";
      public static string TenNV = "TenNV";
      public static string MaNCC = "MaNCC";
      public static string TenNCC = "TenNCC";
        }
}
