use master
create database CHDTDD
go
--
use CHDTDD
go

create table SANPHAM
(
MaSP	nvarchar(10) primary key,
TenSP	nvarchar(100)	,
MoTa	nvarchar(200),	
SoLuong int,	
DonGia	 float ,
TrangThai bit check(TrangThai=0 or TrangThai=1),
ID int IDENTITY (1,1),
MaNCC nvarchar(10),
GiaBan float
)
create TABLE NHACUNGCAP
(
ID int IDENTITY (1,1),
MaNCC nvarchar(10) primary key,
TenNCC nvarchar(50),
SDT nvarchar(10),
TrangThai bit check(TrangThai=0 or TrangThai=1)
)
go

create table HOADON
(
MaHD	nvarchar(10)	primary key,
NgayLapHD	DateTime,
MaNV nvarchar(10),
MaKH	Nvarchar(10),
TrangThai bit check(TrangThai=0 or TrangThai=1),
ID int IDENTITY (1,1),
TongTien float  DEFAULT 0
)

create table CT_HOADON
(
[ID] [int] IDENTITY(1,1) NOT NULL,
MaHD	nvarchar(10)	not null,
MaSP nvarchar(10)	not null,
SoLuong	Int	,
DonGia	int,	
ThanhTien int,
TrangThai bit check(TrangThai=0 or TrangThai=1),

)

create table KHACHHANG
(
MaKH	Nvarchar(10)primary key	,
TenKH	Nvarchar(100)	,
DiaChi	Nvarchar(100),	
Phone	varchar(10),	
TrangThai bit check(TrangThai=0 or TrangThai=1),
ID int IDENTITY (1,1),
GioiTinh nvarchar(50)
)

create table NHANVIEN
(
MaNV	nvarChar(10)primary key	,
TenNV	Nvarchar(100)	,
DiaChi	Nvarchar(100),	
Phone	varchar(10),	
TrangThai bit check(TrangThai=0 or TrangThai=1),
matkhau nvarchar(50),	
ID int IDENTITY (1,1),
GioiTinh nvarchar(50),
ChucVu nvarchar(50),
Email nvarchar(50)
)

alter table sanpham
add foreign key(MaNCC) references nhacungcap(MaNCC)


alter table hoadon
add foreign key(makh) references khachhang(makh)

alter table hoadon
add foreign key(manv)references nhanvien(manv)

alter table CT_HoaDon
add constraint pk_cthd primary key(MaHD,MaSp)

alter table ct_hoadon
add foreign key(mahd) references hoadon(mahd)

alter table ct_hoadon
add foreign key(masp) references sanpham(masp)


create proc themNV(@manv nvarchar(50),@tennv nvarchar(50),@diachi nvarchar(50),@sdt nvarchar(50),@pass nvarchar(50),@gioitinh nvarchar(50),@chucvu nvarchar(50),@email nvarchar(50))
as
begin
insert into NHANVIEN(MaNV,TenNV,DiaChi,Phone,matkhau,TrangThai,GioiTinh,ChucVu,Email) values(@manv,@tennv,@diachi,@sdt,@pass,1,@gioitinh,@chucvu,@email)
end;

exec themNV @manv,@tennv,@diachi,@sdt,@pass,@gioitinh,@chucvu,@email


create proc suaNV(@manv nvarchar(50),@tennv nvarchar(50),@diachi nvarchar(50),@sdt nvarchar(50),@pass nvarchar(50),@gioitinh nvarchar(50),@chucvu nvarchar(50),@email nvarchar(50))
as
begin
update NHANVIEN set TenNV=@tennv,DiaChi=@diachi,Phone=@sdt,matkhau=@pass,GioiTinh=@gioitinh,ChucVu=@chucvu,Email=@email where MaNV=@manv
end;

exec suaNV @manv,@tennv,@diachi,@sdt,@pass,@gioitinh,@chucvu,@email

create proc xoaNV(@manv nvarchar(50))
as
begin
update NHANVIEN set TrangThai=0 where MaNV=@manv
end;

exec xoaNV @manv

create proc laydanhsachNV
as
begin
select * from NHANVIEN where TrangThai=1 order by id 
end;

exec laydanhsachNV

create proc xoaSP(@masp nvarchar(50))
as 
begin
update SANPHAM set TrangThai=0 where MaSP=@masp
end;

exec xoaSP @masp

create proc captNhaSP(@masp nvarchar(50),@tensp nvarchar(50),@soluong int,@dongia float,@mota nvarchar(50),@mancc nvarchar(50),@giaban float)
as 
begin
update SANPHAM set TenSP=@tensp,SoLuong=@soluong,DonGia=@dongia,MoTa=@mota,TrangThai=1,
                MaNCC=@mancc,GiaBan=@giaban  where MaSP=@masp
end;

exec canhaSP  @masp,@tensp,@soluong,@dongia,@mota,@mancc

create proc ThemSP (@masp nvarchar(50),@tensp nvarchar(50),@soluong int,@dongia int,@mota nvarchar(50),@mancc nvarchar(50),@giaban float)
as 
begin
 insert into SANPHAM(MaSP,TenSP,SoLuong,DonGia,MoTa,TrangThai,MaNCC,GiaBan) values
                    (@masp,@tensp,@soluong,@dongia,@mota,1,@mancc,@giaban)
end;
exec ThemSP  @masp,@tensp,@soluong,@dongia,@mota,@mancc
