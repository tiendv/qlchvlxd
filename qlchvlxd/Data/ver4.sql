--use master
--drop database qlchvlxd
--USE [QLCHVLXD]
--GO
create database QLCHVLXD
/****** Object:  Table [dbo].[thamso]    Script Date: 01/08/2010 02:52:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thamso](
	[chietkhau1] [float] NULL,
	[chieukhau2] [float] NULL,
	[chietkhau3] [float] NULL,
	[phivanchuyen] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 01/08/2010 02:52:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[mancc] [char](3) NOT NULL,
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
/****** Object:  Table [dbo].[loaisanpham]    Script Date: 01/08/2010 02:52:26 ******/
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
/****** Object:  Table [dbo].[loaidonvitinh]    Script Date: 01/08/2010 02:52:26 ******/
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
/****** Object:  Table [dbo].[khachhang]    Script Date: 01/08/2010 02:52:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khachhang](
	[makh] [char](5) NOT NULL,
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
/****** Object:  Table [dbo].[nhanvien]    Script Date: 01/08/2010 02:52:26 ******/
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
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phieunhapkho]    Script Date: 01/08/2010 02:52:26 ******/
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
/****** Object:  Table [dbo].[sanpham]    Script Date: 01/08/2010 02:52:26 ******/
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
	[mancc] [char](3) NULL,
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
/****** Object:  Table [dbo].[hoadon]    Script Date: 01/08/2010 02:52:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahd] [char](10) NOT NULL,
	[ngaylaphd] [datetime] NULL,
	[tongtien] [float] NULL,
	[giaohang] [int] NULL,
	[chietkhau] [int] NULL,
	[manv] [int] NULL,
	[makh] [char](5) NULL,
	[tienno] [float] NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cthoadon]    Script Date: 01/08/2010 02:52:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cthoadon](
	[macthd] [char](10) NOT NULL,
	[masp] [int] NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
	[mahd] [char](10) NULL,
	[maloaisp] [int] NULL,
 CONSTRAINT [PK_cthoadon] PRIMARY KEY CLUSTERED 
(
	[macthd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phieugiaohang]    Script Date: 01/08/2010 02:52:26 ******/
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
/****** Object:  Table [dbo].[phieutragop]    Script Date: 01/08/2010 02:52:26 ******/
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
/****** Object:  Table [dbo].[ctphieugiaohang]    Script Date: 01/08/2010 02:52:26 ******/
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
/****** Object:  Table [dbo].[ctphieunhapkho]    Script Date: 01/08/2010 02:52:26 ******/
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bangluong]    Script Date: 01/08/2010 02:52:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bangluong](
	[mabl] [int] NOT NULL,
	[manv] [int] NULL,
	[songaydilam] [int] NULL,
	[thang] [int] NULL,
	[luongcoban] [float] NULL,
	[ungtruoc] [float] NULL,
	[luongconlai] [float] NULL,
 CONSTRAINT [PK_bangluong] PRIMARY KEY CLUSTERED 
(
	[mabl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_bangluong_nhanvien]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[bangluong]  WITH CHECK ADD  CONSTRAINT [FK_bangluong_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
GO
ALTER TABLE [dbo].[bangluong] CHECK CONSTRAINT [FK_bangluong_nhanvien]
GO
/****** Object:  ForeignKey [FK_cthoadon_hoadon]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD  CONSTRAINT [FK_cthoadon_hoadon] FOREIGN KEY([mahd])
REFERENCES [dbo].[hoadon] ([mahd])
GO
ALTER TABLE [dbo].[cthoadon] CHECK CONSTRAINT [FK_cthoadon_hoadon]
GO
/****** Object:  ForeignKey [FK_cthoadon_loaisanpham]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD  CONSTRAINT [FK_cthoadon_loaisanpham] FOREIGN KEY([maloaisp])
REFERENCES [dbo].[loaisanpham] ([maloaisp])
GO
ALTER TABLE [dbo].[cthoadon] CHECK CONSTRAINT [FK_cthoadon_loaisanpham]
GO
/****** Object:  ForeignKey [FK_cthoadon_sanpham]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[cthoadon]  WITH CHECK ADD  CONSTRAINT [FK_cthoadon_sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[sanpham] ([msp])
GO
ALTER TABLE [dbo].[cthoadon] CHECK CONSTRAINT [FK_cthoadon_sanpham]
GO
/****** Object:  ForeignKey [FK_ctphieugiaohang_phieugiaohang]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[ctphieugiaohang]  WITH CHECK ADD  CONSTRAINT [FK_ctphieugiaohang_phieugiaohang] FOREIGN KEY([magh])
REFERENCES [dbo].[phieugiaohang] ([magh])
GO
ALTER TABLE [dbo].[ctphieugiaohang] CHECK CONSTRAINT [FK_ctphieugiaohang_phieugiaohang]
GO
/****** Object:  ForeignKey [FK_ctphieugiaohang_sanpham]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[ctphieugiaohang]  WITH CHECK ADD  CONSTRAINT [FK_ctphieugiaohang_sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[sanpham] ([msp])
GO
ALTER TABLE [dbo].[ctphieugiaohang] CHECK CONSTRAINT [FK_ctphieugiaohang_sanpham]
GO
/****** Object:  ForeignKey [FK_ctphieunhapkho_phieunhapkho]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[ctphieunhapkho]  WITH CHECK ADD  CONSTRAINT [FK_ctphieunhapkho_phieunhapkho] FOREIGN KEY([mank])
REFERENCES [dbo].[phieunhapkho] ([mank])
GO
ALTER TABLE [dbo].[ctphieunhapkho] CHECK CONSTRAINT [FK_ctphieunhapkho_phieunhapkho]
GO
/****** Object:  ForeignKey [FK_ctphieunhapkho_sanpham]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[ctphieunhapkho]  WITH CHECK ADD  CONSTRAINT [FK_ctphieunhapkho_sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[sanpham] ([msp])
GO
ALTER TABLE [dbo].[ctphieunhapkho] CHECK CONSTRAINT [FK_ctphieunhapkho_sanpham]
GO
/****** Object:  ForeignKey [FK_hoadon_khachhang]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khachhang] FOREIGN KEY([makh])
REFERENCES [dbo].[khachhang] ([makh])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khachhang]
GO
/****** Object:  ForeignKey [FK_hoadon_nhanvien]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_nhanvien]
GO
/****** Object:  ForeignKey [FK_phieugiaohang_hoadon]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[phieugiaohang]  WITH CHECK ADD  CONSTRAINT [FK_phieugiaohang_hoadon] FOREIGN KEY([mahd])
REFERENCES [dbo].[hoadon] ([mahd])
GO
ALTER TABLE [dbo].[phieugiaohang] CHECK CONSTRAINT [FK_phieugiaohang_hoadon]
GO
/****** Object:  ForeignKey [FK_phieutragop_hoadon]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[phieutragop]  WITH CHECK ADD  CONSTRAINT [FK_phieutragop_hoadon] FOREIGN KEY([mahd])
REFERENCES [dbo].[hoadon] ([mahd])
GO
ALTER TABLE [dbo].[phieutragop] CHECK CONSTRAINT [FK_phieutragop_hoadon]
GO
/****** Object:  ForeignKey [FK_sanpham_loaidonvitinh]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_loaidonvitinh] FOREIGN KEY([donvitinh])
REFERENCES [dbo].[loaidonvitinh] ([maloaidonvitinh])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_loaidonvitinh]
GO
/****** Object:  ForeignKey [FK_sanpham_loaisanpham]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_loaisanpham] FOREIGN KEY([maloaisp])
REFERENCES [dbo].[loaisanpham] ([maloaisp])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_loaisanpham]
GO
/****** Object:  ForeignKey [FK_sanpham_nhacungcap]    Script Date: 01/08/2010 02:52:26 ******/
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_nhacungcap] FOREIGN KEY([mancc])
REFERENCES [dbo].[nhacungcap] ([mancc])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_nhacungcap]
GO
