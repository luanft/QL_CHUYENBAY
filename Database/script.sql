USE [master]
GO
/****** Object:  Database [QUANLYCHUYENBAY]    Script Date: 6/20/2015 10:35:32 PM ******/
CREATE DATABASE [QUANLYCHUYENBAY]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYCHUYENBAY', FILENAME = N'E:\SOLUTION\SQL\QuanLiChuyenBay\MainForm\QUANLYCHUYENBAY.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANLYCHUYENBAY_log', FILENAME = N'E:\SOLUTION\SQL\QuanLiChuyenBay\MainForm\QUANLYCHUYENBAY_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYCHUYENBAY].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QUANLYCHUYENBAY]
GO
/****** Object:  Table [dbo].[CHUCNANG]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUCNANG](
	[MaChucNang] [char](50) NOT NULL,
	[MoTaChucNang] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUYENBAY]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUYENBAY](
	[MaChuyenBay] [char](5) NOT NULL,
	[MaTuyenBay] [char](5) NULL,
	[ThoiGianBay] [int] NULL,
	[DonGia] [float] NULL,
	[NgayKhoiHanh] [date] NULL,
	[GioKhoiHanh] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOANHTHUCHUYENBAY]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOANHTHUCHUYENBAY](
	[MaBaoCao] [nchar](10) NOT NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
	[MaChuyenBay] [char](5) NOT NULL,
	[DoanhThu] [float] NULL,
	[Tile] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOANHTHUNAM]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANHTHUNAM](
	[Nam] [int] NOT NULL,
	[DoanhThuNam] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DOANHTHUTHANG]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANHTHUTHANG](
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[SoChuyenBay] [int] NULL,
	[DoanhThu] [float] NULL,
	[TiLe] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Thang] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANGVE]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGVE](
	[MaHangVe] [char](5) NOT NULL,
	[TenHangVe] [nvarchar](50) NULL,
	[TiLeDonGia] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIGHE]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIGHE](
	[MaChuyenBay] [char](5) NOT NULL,
	[MaHangVe] [char](5) NOT NULL,
	[SoGhe] [int] NULL,
	[SoGheDat] [int] NULL,
	[SoGheTrong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC,
	[MaHangVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMCHUCNANG]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMCHUCNANG](
	[MaNhomNguoiDung] [char](3) NOT NULL,
	[MaChucNang] [char](50) NOT NULL,
 CONSTRAINT [pk_NHOMCHUCNANG] PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC,
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMNGUOIDUNG]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMNGUOIDUNG](
	[MaNhomNguoiDung] [char](3) NOT NULL,
	[TenNhomNguoiDung] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUDATCHO]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUDATCHO](
	[MaPhieuDat] [char](5) NOT NULL,
	[NgayDat] [date] NULL,
	[NguoiDat] [nvarchar](50) NULL,
	[CMND] [varchar](10) NULL,
	[DienThoai] [varchar](11) NULL,
	[Huy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUYENHAN]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QUYENHAN](
	[MaNhomNguoiDung] [char](3) NOT NULL,
	[MaNhanVien] [char](10) NOT NULL,
 CONSTRAINT [pk_QUYENHAN] PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC,
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANBAY]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANBAY](
	[MaSanBay] [char](5) NOT NULL,
	[TenSanBay] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANBAYTRUNGGIAN]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANBAYTRUNGGIAN](
	[MaChuyenBay] [char](5) NOT NULL,
	[MaSanBay] [char](5) NOT NULL,
	[ThoiGianDung] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC,
	[MaSanBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[SoSanBayTrungGianToiDa] [int] NOT NULL,
	[ThoiGianDungToiThieu] [int] NOT NULL,
	[ThoiGianDungToiDa] [int] NOT NULL,
	[ThoiGianBayToiThieu] [int] NOT NULL,
	[HangChotDatVe] [int] NOT NULL,
	[STT] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TUYENBAY]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TUYENBAY](
	[MaTuyenBay] [char](5) NOT NULL,
	[MaSanBayDi] [char](5) NULL,
	[MaSanBayDen] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VE]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VE](
	[MaVe] [char](5) NOT NULL,
	[MaChuyenBay] [char](5) NOT NULL,
	[HanhKhach] [nvarchar](50) NULL,
	[CMND] [varchar](10) NULL,
	[DienThoai] [varchar](11) NULL,
	[HangVe] [char](5) NOT NULL,
	[DaLayVe] [int] NULL,
	[GiaTien] [int] NOT NULL,
	[MaPhieuDat] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC,
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[CHUCNANG_G01]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[CHUCNANG_G01]
as 
select MaChucNang from NHOMCHUCNANG where MaNhomNguoiDung = 'G01'
GO
/****** Object:  View [dbo].[CHUCNANG_G02]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[CHUCNANG_G02]
as 
select MaChucNang from NHOMCHUCNANG where MaNhomNguoiDung = 'G02'
GO
/****** Object:  View [dbo].[CHUCNANG_G03]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[CHUCNANG_G03]
as 
select MaChucNang from NHOMCHUCNANG where MaNhomNguoiDung = 'G03'
GO
/****** Object:  View [dbo].[CHUCNANG_G04]    Script Date: 6/20/2015 10:35:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[CHUCNANG_G04]
as 
select MaChucNang from NHOMCHUCNANG where MaNhomNguoiDung = 'G04'
GO
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'baocao_Nam                                        ', N'Báo cáo theo năm')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'baocao_Thang                                      ', N'Báo cáo theo thang')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'kinhdoanh_BanVe                                   ', N'Bán vé')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'kinhdoanh_Datcho                                  ', N'Đặt chỗ')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'kinhDoanh_traVe                                   ', N'Trả lại vé')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'main_menu                                         ', N'Menu chính')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'menu_Baocao                                       ', N'Báo cáo')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'menu_Dangnhap                                     ', N'menu đăng nhập')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'menu_Dangxuat                                     ', N'Chức năng đang xuất')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'menu_Hethong                                      ', N'menu hệ thống')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'menu_Kinhdoanh                                    ', N'Menu kinh doanh')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'menu_Phanquyen                                    ', N'Phân quyền cho nhóm người dùng')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'menu_Quydinh                                      ', N'Menu quy định')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'menu_Them                                         ', N'Them mune')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'menu_Themnguoidung                                ', N'Menu thêm người dùng')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'menu_Tracuu                                       ', N'Tra cứu thông tin')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'quydinh_Danhsach                                  ', N'Danh sách các quy định')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'them_Hangve                                       ', N'Thêm hạng vé')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'them_Lichbay                                      ', N'Thêm lịch bay')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'them_Lichchuyenbay                                ', N'Them lich chuyen bay')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'them_Sanbay                                       ', N'Thêm sân bay')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'them_Tuyenbay                                     ', N'Thêm tuyến bay')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'tracuu_Dulieu                                     ', N'Tra cứu dữ liệu')
INSERT [dbo].[CHUCNANG] ([MaChucNang], [MoTaChucNang]) VALUES (N'tracuu_Lichbay                                    ', N'Tra cứu lịch bay')
INSERT [dbo].[HANGVE] ([MaHangVe], [TenHangVe], [TiLeDonGia]) VALUES (N'HV001', N'Sang', 2)
INSERT [dbo].[HANGVE] ([MaHangVe], [TenHangVe], [TiLeDonGia]) VALUES (N'HV002', N'Thường Dân', 1)
INSERT [dbo].[HANGVE] ([MaHangVe], [TenHangVe], [TiLeDonGia]) VALUES (N'HV003', N'Cùi Bắp', 0.5)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [Email], [MatKhau]) VALUES (N'NV0001    ', N'Trần Minh Luận', N'luanft', N'luanft')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'baocao_Nam                                        ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'baocao_Thang                                      ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'kinhdoanh_BanVe                                   ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'kinhdoanh_Datcho                                  ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'kinhDoanh_traVe                                   ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'main_menu                                         ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'menu_Baocao                                       ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'menu_Dangnhap                                     ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'menu_Dangxuat                                     ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'menu_Hethong                                      ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'menu_Kinhdoanh                                    ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'menu_Phanquyen                                    ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'menu_Quydinh                                      ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'menu_Them                                         ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'menu_Themnguoidung                                ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'menu_Tracuu                                       ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'quydinh_Danhsach                                  ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'them_Hangve                                       ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'them_Lichbay                                      ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'them_Lichchuyenbay                                ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'them_Sanbay                                       ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'them_Tuyenbay                                     ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'tracuu_Dulieu                                     ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G01', N'tracuu_Lichbay                                    ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G02', N'baocao_Nam                                        ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G02', N'baocao_Thang                                      ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G02', N'main_menu                                         ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G02', N'menu_Baocao                                       ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G02', N'menu_Dangxuat                                     ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G02', N'menu_Hethong                                      ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G02', N'menu_Tracuu                                       ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G02', N'quydinh_Danhsach                                  ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G02', N'tracuu_Dulieu                                     ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G02', N'tracuu_Lichbay                                    ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'baocao_Thang                                      ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'kinhdoanh_BanVe                                   ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'kinhdoanh_Datcho                                  ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'main_menu                                         ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'menu_Dangxuat                                     ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'menu_Hethong                                      ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'menu_Them                                         ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'menu_Tracuu                                       ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'them_Hangve                                       ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'them_Lichchuyenbay                                ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'them_Sanbay                                       ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'them_Tuyenbay                                     ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G03', N'tracuu_Lichbay                                    ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G04', N'main_menu                                         ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G04', N'menu_Dangxuat                                     ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G04', N'menu_Hethong                                      ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G04', N'menu_Tracuu                                       ')
INSERT [dbo].[NHOMCHUCNANG] ([MaNhomNguoiDung], [MaChucNang]) VALUES (N'G04', N'tracuu_Lichbay                                    ')
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (N'G01', N'Admin')
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (N'G02', N'Quản Lý')
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (N'G03', N'Nhân Viên')
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (N'G04', N'Khác')
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (N'G05', N'Trùm')
INSERT [dbo].[QUYENHAN] ([MaNhomNguoiDung], [MaNhanVien]) VALUES (N'G01', N'NV0001    ')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay], [DiaChi]) VALUES (N'SB001', N'Lương Sơn Bạc', N'Lương sơn bạc')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay], [DiaChi]) VALUES (N'SB002', N'Tân Sơn Nhất', N'Tân sơn nhất')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay], [DiaChi]) VALUES (N'SB003', N'Tân Sơn Nhì', N'Tân sơn nhì')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay], [DiaChi]) VALUES (N'SB004', N'Nội Bài', N'Hà Nồi')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'TB001', N'SB001', N'SB002')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'TB002', N'SB001', N'SB003')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'TB003', N'SB001', N'SB004')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'TB004', N'SB002', N'SB001')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'TB005', N'SB002', N'SB003')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'TB006', N'SB002', N'SB004')
ALTER TABLE [dbo].[CHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENBAY_TUYENBAY] FOREIGN KEY([MaTuyenBay])
REFERENCES [dbo].[TUYENBAY] ([MaTuyenBay])
GO
ALTER TABLE [dbo].[CHUYENBAY] CHECK CONSTRAINT [FK_CHUYENBAY_TUYENBAY]
GO
ALTER TABLE [dbo].[DOANHTHUCHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_DOANHTHUCHUYENBAY_CHUYENBAY] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[CHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[DOANHTHUCHUYENBAY] CHECK CONSTRAINT [FK_DOANHTHUCHUYENBAY_CHUYENBAY]
GO
ALTER TABLE [dbo].[LOAIGHE]  WITH CHECK ADD  CONSTRAINT [FK_LOAIGHE_CHUYENBAY] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[CHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[LOAIGHE] CHECK CONSTRAINT [FK_LOAIGHE_CHUYENBAY]
GO
ALTER TABLE [dbo].[LOAIGHE]  WITH CHECK ADD  CONSTRAINT [FK_LOAIGHE_HANGVE] FOREIGN KEY([MaHangVe])
REFERENCES [dbo].[HANGVE] ([MaHangVe])
GO
ALTER TABLE [dbo].[LOAIGHE] CHECK CONSTRAINT [FK_LOAIGHE_HANGVE]
GO
ALTER TABLE [dbo].[NHOMCHUCNANG]  WITH CHECK ADD  CONSTRAINT [fk_NHOMCHUCNANG1] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([MaNhomNguoiDung])
GO
ALTER TABLE [dbo].[NHOMCHUCNANG] CHECK CONSTRAINT [fk_NHOMCHUCNANG1]
GO
ALTER TABLE [dbo].[NHOMCHUCNANG]  WITH CHECK ADD  CONSTRAINT [fk_NHOMCHUCNANG2] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[CHUCNANG] ([MaChucNang])
GO
ALTER TABLE [dbo].[NHOMCHUCNANG] CHECK CONSTRAINT [fk_NHOMCHUCNANG2]
GO
ALTER TABLE [dbo].[QUYENHAN]  WITH CHECK ADD  CONSTRAINT [fk_QUYENHAN1] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([MaNhomNguoiDung])
GO
ALTER TABLE [dbo].[QUYENHAN] CHECK CONSTRAINT [fk_QUYENHAN1]
GO
ALTER TABLE [dbo].[QUYENHAN]  WITH CHECK ADD  CONSTRAINT [fk_QUYENHAN2] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[QUYENHAN] CHECK CONSTRAINT [fk_QUYENHAN2]
GO
ALTER TABLE [dbo].[SANBAYTRUNGGIAN]  WITH CHECK ADD  CONSTRAINT [FK_SANBAYTRUNGGIAN_CHUYENBAY] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[CHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[SANBAYTRUNGGIAN] CHECK CONSTRAINT [FK_SANBAYTRUNGGIAN_CHUYENBAY]
GO
ALTER TABLE [dbo].[SANBAYTRUNGGIAN]  WITH CHECK ADD  CONSTRAINT [FK_SANBAYTRUNGGIAN_SANBAY] FOREIGN KEY([MaSanBay])
REFERENCES [dbo].[SANBAY] ([MaSanBay])
GO
ALTER TABLE [dbo].[SANBAYTRUNGGIAN] CHECK CONSTRAINT [FK_SANBAYTRUNGGIAN_SANBAY]
GO
ALTER TABLE [dbo].[TUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_TUYENBAY_SANBAY] FOREIGN KEY([MaSanBayDi])
REFERENCES [dbo].[SANBAY] ([MaSanBay])
GO
ALTER TABLE [dbo].[TUYENBAY] CHECK CONSTRAINT [FK_TUYENBAY_SANBAY]
GO
ALTER TABLE [dbo].[TUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_TUYENBAY_SANBAY1] FOREIGN KEY([MaSanBayDen])
REFERENCES [dbo].[SANBAY] ([MaSanBay])
GO
ALTER TABLE [dbo].[TUYENBAY] CHECK CONSTRAINT [FK_TUYENBAY_SANBAY1]
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD  CONSTRAINT [FK_VE_CHUYENBAY] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[CHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[VE] CHECK CONSTRAINT [FK_VE_CHUYENBAY]
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD  CONSTRAINT [FK_VE_HANGVE] FOREIGN KEY([HangVe])
REFERENCES [dbo].[HANGVE] ([MaHangVe])
GO
ALTER TABLE [dbo].[VE] CHECK CONSTRAINT [FK_VE_HANGVE]
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD  CONSTRAINT [FK_VE_PHIEUDATCHO] FOREIGN KEY([MaPhieuDat])
REFERENCES [dbo].[PHIEUDATCHO] ([MaPhieuDat])
GO
ALTER TABLE [dbo].[VE] CHECK CONSTRAINT [FK_VE_PHIEUDATCHO]
GO
USE [master]
GO
ALTER DATABASE [QUANLYCHUYENBAY] SET  READ_WRITE 
GO
