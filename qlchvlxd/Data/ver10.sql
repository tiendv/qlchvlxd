USE [QLCHVLXD]
GO
/****** Object:  Table [dbo].[loaisanpham]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaisanpham](
	[maloaisp] [int] NOT NULL,
	[tenloaisp] [nvarchar](50) NULL,
 CONSTRAINT [PK_loaisanpham] PRIMARY KEY CLUSTERED 
(
	[maloaisp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[loaisanpham] ([maloaisp], [tenloaisp]) VALUES (1, N'Vật Liệu Thô')
INSERT [dbo].[loaisanpham] ([maloaisp], [tenloaisp]) VALUES (2, N'Nguyên Vật Liệu Hoàn Thiện')
INSERT [dbo].[loaisanpham] ([maloaisp], [tenloaisp]) VALUES (3, N'Nguyên Vật Liệu Trang Trí')
/****** Object:  Table [dbo].[loaidonvitinh]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaidonvitinh](
	[maloaidonvitinh] [int] NOT NULL,
	[tendonvitinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_loaidonvitinh] PRIMARY KEY CLUSTERED 
(
	[maloaidonvitinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[loaidonvitinh] ([maloaidonvitinh], [tendonvitinh]) VALUES (1, N'Kg')
INSERT [dbo].[loaidonvitinh] ([maloaidonvitinh], [tendonvitinh]) VALUES (2, N'Tấn')
INSERT [dbo].[loaidonvitinh] ([maloaidonvitinh], [tendonvitinh]) VALUES (3, N'Tạ')
INSERT [dbo].[loaidonvitinh] ([maloaidonvitinh], [tendonvitinh]) VALUES (4, N'Yến')
INSERT [dbo].[loaidonvitinh] ([maloaidonvitinh], [tendonvitinh]) VALUES (5, N'Chiếc')
INSERT [dbo].[loaidonvitinh] ([maloaidonvitinh], [tendonvitinh]) VALUES (6, N'Cái')
INSERT [dbo].[loaidonvitinh] ([maloaidonvitinh], [tendonvitinh]) VALUES (7, N'Viên')
INSERT [dbo].[loaidonvitinh] ([maloaidonvitinh], [tendonvitinh]) VALUES (8, N'Gói')
/****** Object:  Table [dbo].[khachhang]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khachhang](
	[makh] [char](10) NOT NULL,
	[tenkh] [nvarchar](50) NULL,
	[cmnd] [char](9) NULL,
	[diachi] [nvarchar](50) NULL,
	[sodienthoai] [nvarchar](15) NULL,
	[gioitinh] [nvarchar](3) NULL,
	[loaikhachhang] [int] NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[khachhang] ([makh], [tenkh], [cmnd], [diachi], [sodienthoai], [gioitinh], [loaikhachhang]) VALUES (N'KH0001    ', N'Triệu Hoàng', N'298643279', N'2 Nguyễn Văn Trỗi, Quan 3', N'01267895232', N'Nam', 1)
INSERT [dbo].[khachhang] ([makh], [tenkh], [cmnd], [diachi], [sodienthoai], [gioitinh], [loaikhachhang]) VALUES (N'KH0002    ', N'Phạm Thi Lan', N'256895431', N'1 Phạm Ngọc Thạch, Quận 1', N'0989647653', N'NỮ', 1)
INSERT [dbo].[khachhang] ([makh], [tenkh], [cmnd], [diachi], [sodienthoai], [gioitinh], [loaikhachhang]) VALUES (N'KH0003    ', N'Nguyễn Văn Tâm', N'274689324', N'15 Bạch Đằng, Quận Bình Thạnh', N'0902546789', N'Nam', 1)
INSERT [dbo].[khachhang] ([makh], [tenkh], [cmnd], [diachi], [sodienthoai], [gioitinh], [loaikhachhang]) VALUES (N'KH0004    ', N'Lê Thanh Thành', N'263549214', N'25 Lý Thường Kiệt, Quận 10', N'01223546879', N'NỮ', 1)
/****** Object:  Table [dbo].[bangluong]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bangluong](
	[mabl] [int] NOT NULL,
	[manv] [int] NOT NULL,
	[songaydilam] [int] NULL,
	[thang] [int] NULL,
	[luongcoban] [float] NULL,
	[ungtruoc] [float] NULL,
	[luongconlai] [float] NULL,
 CONSTRAINT [PK_bangluong] PRIMARY KEY CLUSTERED 
(
	[mabl] ASC,
	[manv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[bangluong] ([mabl], [manv], [songaydilam], [thang], [luongcoban], [ungtruoc], [luongconlai]) VALUES (12010, 1, 26, 1, 20000000, 0, 20000000)
INSERT [dbo].[bangluong] ([mabl], [manv], [songaydilam], [thang], [luongcoban], [ungtruoc], [luongconlai]) VALUES (12010, 2, 26, 1, 20000000, 0, 20000000)
INSERT [dbo].[bangluong] ([mabl], [manv], [songaydilam], [thang], [luongcoban], [ungtruoc], [luongconlai]) VALUES (12010, 3, 26, 1, 20000000, 0, 20000000)
INSERT [dbo].[bangluong] ([mabl], [manv], [songaydilam], [thang], [luongcoban], [ungtruoc], [luongconlai]) VALUES (12010, 4, 26, 1, 20000000, 0, 20000000)
/****** Object:  Table [dbo].[phieunhapkho]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phieunhapkho](
	[mank] [char](10) NOT NULL,
	[ngaynhap] [datetime] NULL,
	[tongtien] [float] NULL,
 CONSTRAINT [PK_phieunhapkho] PRIMARY KEY CLUSTERED 
(
	[mank] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT INTO [QLCHVLXD].[dbo].[phieunhapkho]([mank],[ngaynhap],[tongtien])VALUES('NK0001','2010-01-1',20000000)
INSERT INTO [QLCHVLXD].[dbo].[phieunhapkho]([mank],[ngaynhap],[tongtien])VALUES('NK0002','2010-01-2',5600000)
INSERT INTO [QLCHVLXD].[dbo].[phieunhapkho]([mank],[ngaynhap],[tongtien])VALUES('NK0003','2010-01-3',5000000)
INSERT INTO [QLCHVLXD].[dbo].[phieunhapkho]([mank],[ngaynhap],[tongtien])VALUES('NK0004','2010-01-4',15000000)
INSERT INTO [QLCHVLXD].[dbo].[phieunhapkho]([mank],[ngaynhap],[tongtien])VALUES('NK0005','2010-01-5',19500000)
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[mancc] [char](10) NOT NULL,
	[tenncc] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_nhacungcap] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [dienthoai]) VALUES (N'C00001       ', N'Hà Tiên', N'Km 8, Duong Ha Noi, Q. Thu Duc, TP. HCM', N'08-8966608')
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [dienthoai]) VALUES (N'C00002       ', N'Taicera', N'Khu CN Go Dau, Xa Phuoc Thai, Long Thanh, Dong Nai', N'061 - 3841 594')
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [dienthoai]) VALUES (N'C00003       ', N'Thái Nguyên', N'So 51, duong B1, Phuong 13, Quan Tan Binh, TP HCM', N'08 8106177')
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [dienthoai]) VALUES (N'C00004       ', N'NIPPON', N'So 14, Duong 3A, Khu CN Bien Hoa II, Dong Nai', N'(061)836579')
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [dienthoai]) VALUES (N'C00005       ', N'Hoa Sen', N'09, Thong Nhat, KCN Song Than II, Binh Duong', N'0650. 379 0790')
/****** Object:  Table [dbo].[thongsotinhluong]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thongsotinhluong](
	[maloainv] [int] NOT NULL,
	[tenloainv] [nvarchar](50) NULL,
	[luongcoban] [float] NULL,
 CONSTRAINT [PK_thongsotinhluong] PRIMARY KEY CLUSTERED 
(
	[maloainv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[thongsotinhluong] ([maloainv], [tenloainv], [luongcoban]) VALUES (1, N'THỦ KHO', 20000000)
INSERT [dbo].[thongsotinhluong] ([maloainv], [tenloainv], [luongcoban]) VALUES (2, N'BÁN HÀNG', 1000000)
INSERT [dbo].[thongsotinhluong] ([maloainv], [tenloainv], [luongcoban]) VALUES (3, N'GIAO HÀNG', 5000000)
/****** Object:  Table [dbo].[thamsophivanchuyen]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thamsophivanchuyen](
	[sokm] [int] NULL,
	[phivanchuyen] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thamsochietkhau]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thamsochietkhau](
	[tenchietkhau] [nvarchar](50) NULL,
	[tilechietkhau] [float] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[thamsochietkhau] ([tenchietkhau], [tilechietkhau]) VALUES (N'Mức chiết khấu 1', 10)
INSERT [dbo].[thamsochietkhau] ([tenchietkhau], [tilechietkhau]) VALUES (N'Mức chiết khấu 2', 11)
INSERT [dbo].[thamsochietkhau] ([tenchietkhau], [tilechietkhau]) VALUES (N'Mức chiết khấu 3', 22)
INSERT [dbo].[thamsochietkhau] ([tenchietkhau], [tilechietkhau]) VALUES (N'Mức chiết khấu 4', 33)
INSERT [dbo].[thamsochietkhau] ([tenchietkhau], [tilechietkhau]) VALUES (N'Mức chiết khấu 5', 50)
/****** Object:  Trigger [T_thang]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[T_thang]
on [dbo].[bangluong]
for insert, update
as
begin
	if exists (select * from bangluong where thang > 12 or thang < 0)
	begin 
		rollback;
		print 'nhap khong dung voi dinh dang';
	end
end
GO
/****** Object:  Trigger [songaydilam]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[songaydilam]
on [dbo].[bangluong]
for insert, update
as
begin
	if exists (select * from bangluong where songaydilam > 26 or songaydilam < 0)
	begin 
		rollback;
		print 'nhap khong dung voi dinh dang';
	end
end
GO
/****** Object:  Table [dbo].[sanpham]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sanpham](
	[msp] [int] NOT NULL,
	[tensp] [nvarchar](50) NULL,
	[gianhap] [float] NULL,
	[giaban] [float] NULL,
	[soluong] [int] NULL,
	[soluongtoithieu] [int] NULL,
	[mancc] [char](10) NULL,
	[thongtin] [nvarchar](50) NULL,
	[donvitinh] [int] NULL,
	[maloaisp] [int] NULL,
 CONSTRAINT [PK_sanpham] PRIMARY KEY CLUSTERED 
(
	[msp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[sanpham] ([msp], [tensp], [gianhap], [giaban], [soluong], [soluongtoithieu], [mancc], [thongtin], [donvitinh], [maloaisp]) VALUES (1, N'Gạch xây dựng', 5000, 5500, 2000, 100, N'C00002       ', N'Gạch thô xây dựng ', 7, 1)
INSERT [dbo].[sanpham] ([msp], [tensp], [gianhap], [giaban], [soluong], [soluongtoithieu], [mancc], [thongtin], [donvitinh], [maloaisp]) VALUES (2, N'Xi Măng Hà Tiên', 150000, 160000, 200, 10, N'C00001       ', N'Xi măng Hà Tiên  ', 8, 1)
INSERT [dbo].[sanpham] ([msp], [tensp], [gianhap], [giaban], [soluong], [soluongtoithieu], [mancc], [thongtin], [donvitinh], [maloaisp]) VALUES (3, N'Gạch Hoa', 3000, 4500, 200, 10, N'C00002       ', N'Gạch trang trí  ', 7, 2)
INSERT [dbo].[sanpham] ([msp], [tensp], [gianhap], [giaban], [soluong], [soluongtoithieu], [mancc], [thongtin], [donvitinh], [maloaisp]) VALUES (4, N'Vòi tắm hoa sen', 500000, 550000, 10, 2, N'C00005       ', N'Vòi tắm xoa sen trong phòng tắm kiểu dáng đẹp  ', 5, 3)
INSERT [dbo].[sanpham] ([msp], [tensp], [gianhap], [giaban], [soluong], [soluongtoithieu], [mancc], [thongtin], [donvitinh], [maloaisp]) VALUES (5, N'Xi măng Cẩm Phả', 130000, 140000, 150, 10, N'C00003       ', N'Xi măng Cẩm Phả', 8, 1)
/****** Object:  Table [dbo].[nhanvien]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manv] [int] NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[matkhau] [nvarchar](10) NULL,
	[ngaysinh] [datetime] NULL,
	[sodienthoai] [nvarchar](15) NULL,
	[ngaybatdau] [datetime] NULL,
	[quequan] [nvarchar](50) NULL,
	[maloainv] [int] NULL,
	[gioitinh] [nvarchar](10) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[nhanvien] ([manv], [hoten], [matkhau], [ngaysinh], [sodienthoai], [ngaybatdau], [quequan], [maloainv], [gioitinh]) VALUES (1, N'NGUYỄN PHƯỚC CƯỜNG', N'JDFHKDJHFH', CAST(0x00007E4A00000000 AS DateTime), N'0122345676', CAST(0x00009C0100000000 AS DateTime), N'ĐẮC LẮC', 1, NULL)
INSERT [dbo].[nhanvien] ([manv], [hoten], [matkhau], [ngaysinh], [sodienthoai], [ngaybatdau], [quequan], [maloainv], [gioitinh]) VALUES (2, N'HUỲNH MINH ĐỨC', N'JDFHKDJHFH', CAST(0x00007E4A00000000 AS DateTime), N'0122345676', CAST(0x00009C0100000000 AS DateTime), N'ĐẮC LẮC', 1, NULL)
INSERT [dbo].[nhanvien] ([manv], [hoten], [matkhau], [ngaysinh], [sodienthoai], [ngaybatdau], [quequan], [maloainv], [gioitinh]) VALUES (3, N'ĐỖ VĂN TIẾN', N'JDFHKDJHFH', CAST(0x00007E4A00000000 AS DateTime), N'0122345676', CAST(0x00009C0100000000 AS DateTime), N'ĐẮC LẮC', 1, NULL)
INSERT [dbo].[nhanvien] ([manv], [hoten], [matkhau], [ngaysinh], [sodienthoai], [ngaybatdau], [quequan], [maloainv], [gioitinh]) VALUES (4, N'NGUYỄN NGỌC KHÁNH LINH', N'JDFHKDJHFH', CAST(0x00007E4A00000000 AS DateTime), N'0122345676', CAST(0x00009C0100000000 AS DateTime), N'ĐẮC LẮC', 1, NULL)
/****** Object:  Table [dbo].[ctphieunhapkho]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ctphieunhapkho](
	[mactnk] [char](10) NOT NULL,
	[mank] [char](10) NULL,
	[masp] [int] NULL,
	[soluong] [int] NULL,
	[giaban] [float] NULL,
	[giamua] [float] NULL,
 CONSTRAINT [PK_ctphieunhapkho] PRIMARY KEY CLUSTERED 
(
	[mactnk] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO [QLCHVLXD].[dbo].[ctphieunhapkho]([mactnk],[mank],[masp],[soluong],[giaban],[giamua]) VALUES ('CT0001','NK0001', 1, 1000, 5500, 5000)
INSERT INTO [QLCHVLXD].[dbo].[ctphieunhapkho]([mactnk],[mank],[masp],[soluong],[giaban],[giamua]) VALUES ('CT0002','NK0001', 2, 100, 160000, 150000)
INSERT INTO [QLCHVLXD].[dbo].[ctphieunhapkho]([mactnk],[mank],[masp],[soluong],[giaban],[giamua]) VALUES ('CT0003','NK0002', 3, 200, 4500, 3000)
INSERT INTO [QLCHVLXD].[dbo].[ctphieunhapkho]([mactnk],[mank],[masp],[soluong],[giaban],[giamua]) VALUES ('CT0004','NK0002', 4, 10, 550000, 500000)
INSERT INTO [QLCHVLXD].[dbo].[ctphieunhapkho]([mactnk],[mank],[masp],[soluong],[giaban],[giamua]) VALUES ('CT0005','NK0003', 1, 1000, 5500, 5000)
INSERT INTO [QLCHVLXD].[dbo].[ctphieunhapkho]([mactnk],[mank],[masp],[soluong],[giaban],[giamua]) VALUES ('CT0006','NK0004', 2, 100, 160000, 150000)
INSERT INTO [QLCHVLXD].[dbo].[ctphieunhapkho]([mactnk],[mank],[masp],[soluong],[giaban],[giamua]) VALUES ('CT0007','NK0005', 5, 150, 140000, 130000)
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahd] [char](10) NOT NULL,
	[manv] [int] NULL,
	[makh] [char](10) NULL,
	[tongtien] [float] NULL,
	[chietkhau] [float] NULL,
	[tientra] [float] NULL,
	[tienno] [float] NULL,
	[ngaylaphd] [datetime] NULL,
	[giaohang] [int] NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Trigger [TRIG_loainhanvien]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[TRIG_loainhanvien]
on [dbo].[nhanvien]
for insert, update
as
BEGIN
	if exists (select maloainv from nhanvien where maloainv > 3)
	begin
		Print 'Nhap khong dung';
		rollback;
	end 
	
END
GO
/****** Object:  Trigger [ngaysinh_ngaybatdau]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[ngaysinh_ngaybatdau]
   ON  [dbo].[nhanvien]
   for INSERT,UPDATE
AS 
BEGIN
	if exists (select * from nhanvien where ngaysinh > ngaybatdau)
	begin
		Print 'Nhap khong dung';
		rollback;
	end 
	
END
GO
/****** Object:  Table [dbo].[phieugiaohang]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phieugiaohang](
	[magh] [char](10) NOT NULL,
	[mahd] [char](10) NULL,
	[ngaygiao] [datetime] NULL,
	[chiphi] [float] NULL,
 CONSTRAINT [PK_phieugiaohang_1] PRIMARY KEY CLUSTERED 
(
	[magh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phieutragop]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phieutragop](
	[matragop] [char](10) NOT NULL,
	[sotientra] [float] NULL,
	[ngaytra] [datetime] NULL,
	[mahd] [char](10) NULL,
 CONSTRAINT [PK_phieutragop] PRIMARY KEY CLUSTERED 
(
	[matragop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cthoadon]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cthoadon](
	[macthd] [char](10) NOT NULL,
	[mahd] [char](10) NOT NULL,
	[masp] [int] NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
	[maloaisp] [int] NULL,
 CONSTRAINT [PK_cthoadon] PRIMARY KEY CLUSTERED 
(
	[macthd] ASC,
	[mahd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ctphieugiaohang]    Script Date: 01/10/2010 21:51:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ctphieugiaohang](
	[magh] [char](10) NULL,
	[masp] [int] NULL,
	[soluong] [int] NULL,
	[manv] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_ctphieugiaohang_phieugiaohang]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[ctphieugiaohang]  WITH CHECK ADD  CONSTRAINT [FK_ctphieugiaohang_phieugiaohang] FOREIGN KEY([magh])
REFERENCES [dbo].[phieugiaohang] ([magh])
GO
ALTER TABLE [dbo].[ctphieugiaohang] CHECK CONSTRAINT [FK_ctphieugiaohang_phieugiaohang]
GO
/****** Object:  ForeignKey [FK_ctphieugiaohang_sanpham]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[ctphieugiaohang]  WITH CHECK ADD  CONSTRAINT [FK_ctphieugiaohang_sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[sanpham] ([msp])
GO
ALTER TABLE [dbo].[ctphieugiaohang] CHECK CONSTRAINT [FK_ctphieugiaohang_sanpham]
GO
/****** Object:  ForeignKey [FK_ctphieunhapkho_phieunhapkho]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[ctphieunhapkho]  WITH CHECK ADD  CONSTRAINT [FK_ctphieunhapkho_phieunhapkho] FOREIGN KEY([mank])
REFERENCES [dbo].[phieunhapkho] ([mank])
GO
ALTER TABLE [dbo].[ctphieunhapkho] CHECK CONSTRAINT [FK_ctphieunhapkho_phieunhapkho]
GO
/****** Object:  ForeignKey [FK_ctphieunhapkho_sanpham]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[ctphieunhapkho]  WITH CHECK ADD  CONSTRAINT [FK_ctphieunhapkho_sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[sanpham] ([msp])
GO
ALTER TABLE [dbo].[ctphieunhapkho] CHECK CONSTRAINT [FK_ctphieunhapkho_sanpham]
GO
/****** Object:  ForeignKey [FK_cthoadon_hoadon]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD  CONSTRAINT [FK_cthoadon_hoadon] FOREIGN KEY([mahd])
REFERENCES [dbo].[hoadon] ([mahd])
GO
ALTER TABLE [dbo].[cthoadon] CHECK CONSTRAINT [FK_cthoadon_hoadon]
GO
/****** Object:  ForeignKey [FK_cthoadon_loaisanpham]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD  CONSTRAINT [FK_cthoadon_loaisanpham] FOREIGN KEY([maloaisp])
REFERENCES [dbo].[loaisanpham] ([maloaisp])
GO
ALTER TABLE [dbo].[cthoadon] CHECK CONSTRAINT [FK_cthoadon_loaisanpham]
GO
/****** Object:  ForeignKey [FK_cthoadon_sanpham]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD  CONSTRAINT [FK_cthoadon_sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[sanpham] ([msp])
GO
ALTER TABLE [dbo].[cthoadon] CHECK CONSTRAINT [FK_cthoadon_sanpham]
GO
/****** Object:  ForeignKey [FK_hoadon_nhanvien]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_nhanvien]
GO
/****** Object:  ForeignKey [FK_nhanvien_thongsotinhluong]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_thongsotinhluong] FOREIGN KEY([maloainv])
REFERENCES [dbo].[thongsotinhluong] ([maloainv])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_thongsotinhluong]
GO
/****** Object:  ForeignKey [FK_phieugiaohang_hoadon]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[phieugiaohang]  WITH CHECK ADD  CONSTRAINT [FK_phieugiaohang_hoadon] FOREIGN KEY([mahd])
REFERENCES [dbo].[hoadon] ([mahd])
GO
ALTER TABLE [dbo].[phieugiaohang] CHECK CONSTRAINT [FK_phieugiaohang_hoadon]
GO
/****** Object:  ForeignKey [FK_phieutragop_hoadon]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[phieutragop]  WITH CHECK ADD  CONSTRAINT [FK_phieutragop_hoadon] FOREIGN KEY([mahd])
REFERENCES [dbo].[hoadon] ([mahd])
GO
ALTER TABLE [dbo].[phieutragop] CHECK CONSTRAINT [FK_phieutragop_hoadon]
GO
/****** Object:  ForeignKey [FK_sanpham_loaidonvitinh]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_loaidonvitinh] FOREIGN KEY([donvitinh])
REFERENCES [dbo].[loaidonvitinh] ([maloaidonvitinh])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_loaidonvitinh]
GO
/****** Object:  ForeignKey [FK_sanpham_loaisanpham]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_loaisanpham] FOREIGN KEY([maloaisp])
REFERENCES [dbo].[loaisanpham] ([maloaisp])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_loaisanpham]
GO
/****** Object:  ForeignKey [FK_sanpham_nhacungcap]    Script Date: 01/10/2010 21:51:40 ******/
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_nhacungcap] FOREIGN KEY([mancc])
REFERENCES [dbo].[nhacungcap] ([mancc])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_nhacungcap]
GO
