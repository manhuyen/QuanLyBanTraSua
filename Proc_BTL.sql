create proc Xem_Topping
as
begin
 select * from Topping
end
go
execute Xem_Topping
go
create proc Xem_DoUong
as
begin
 select MaDU as STT, tendu as N'Tên Đồ Uống',LoaiDU.Maloai as N'Mã Loại',tenloai as N'Tên Loại',size,dongia as 'Gía Bán',HinhAnh as N'Image' from Douong,LoaiDU where Douong.Maloai=LoaiDU.Maloai
end
go
execute Xem_DoUong
go
create proc Update_Loaithanhvien
as
begin
update Thanhvien set loaithanhvien=N'Đồng' where 0<diemtichluy and diemtichluy<50
update Thanhvien set loaithanhvien=N'Bạc' where 50<=diemtichluy and diemtichluy <100 
update Thanhvien set loaithanhvien=N'Vàng' where 100<=diemtichluy and diemtichluy <500 
update Thanhvien set loaithanhvien=N'Kim Cương' where 500<=diemtichluy
end

go
execute Update_Loaithanhvien
go
Create proc Them_Thanhvien(@matv char(10),@STT int,@hoten nvarchar(50),@loaithanhvien nvarchar(50),@soDT nvarchar(50),@email nvarchar(50),@diachi nvarchar(50),@diemtichluy int)
as
begin
Insert into Thanhvien(MaTV,STT,hoten,loaithanhvien,soDT,email,diachi,diemtichluy) values(@matv,@STT,@hoten,@loaithanhvien,@soDT,@email,@diachi,@diemtichluy)
end
go
execute Them_Thanhvien N'TV100',100,N'MM',null,null,null,null,100
go
Create proc Xoa_Thanhvien(@matv char(10))
as
begin
delete Thanhvien where MaTV=@matv
end
go
execute Xoa_Thanhvien N'TV100'
go
Create proc Sua_Thanhvien(@matv char(10),@STT int,@hoten nvarchar(50),@loaithanhvien nvarchar(50),@soDT nvarchar(50),@email nvarchar(50),@diachi nvarchar(50),@diemtichluy int)
as
begin
update Thanhvien
set hoten=@hoten,STT=@STT,loaithanhvien=@loaithanhvien,soDT=@soDT,email=@email,diachi=@diachi,diemtichluy=@diemtichluy
where MaTV=@matv
end
go
execute Sua_Thanhvien N'TV11',1,N'ManhLe',N'Kim Cuong',N'm@','123456789',N'Ha Noi',100
go
alter proc Them_DoUong(@tendu nvarchar(50),@size nvarchar(50),@dongia float,@hinhanh nvarchar(100),@maloai int)
as
begin
insert into Douong(tendu,size,dongia,MaLoai,HinhAnh) values(@tendu,@size,@dongia,@maloai,@hinhanh)
end
go
execute Them_DoUong N'',N'',1,N'',1
go
create proc Xoa_DoUong(@madu int)
as
begin
delete Douong where MaDU=@madu
end
go
execute Xoa_DoUong 1
go
create proc Sua_DoUong(@madu int,@tendu nvarchar(50),@size nvarchar(50),@dongia float,@hinhanh nvarchar(100),@maloai int,@tenloai nvarchar(50))
as
begin
update Douong
set tenDU=@tendu,size=@size,dongia=@dongia,HinhAnh=@hinhanh,Maloai=@maloai
where MaDU=@madu
 update LoaiDU set tenloai=@tenloai where MaLoai=@maloai
end
go
execute Sua_DoUong 1,N'',N'',1,N'',1,N''
go
create proc Them_Topping(@matopping char(10),@tentopping nvarchar(50),@hinhanh nvarchar(100),@giatopping float)
as
begin
Insert into Topping(Matopping,tentopping,HinhAnh,giatopping) values(@matopping,@tentopping,@hinhanh,@giatopping)
end
go
execute Them_Topping N'',N'',N'',1
go
create proc Xoa_Topping(@matopping char(10))
as
begin
delete Topping where Matopping=@matopping
end
go
execute Xoa_Topping N''
go
create proc Sua_Topping(@matopping char(10),@tentopping nvarchar(50),@hinhanh nvarchar(100),@giatopping float)
as
begin
update Topping
set tentopping=@tentopping,HinhAnh=@hinhanh,giatopping=@giatopping
where Matopping=@matopping
end
go
execute Sua_Topping N'',N'',N'',1
