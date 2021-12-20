USE [master]
GO
/****** Object:  Database [QLLuongSP]    Script Date: 17/11/2021 8:13:55 CH ******/
CREATE DATABASE [QLLuongSP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLLuongSP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLLuongSP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLLuongSP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLLuongSP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLLuongSP] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLLuongSP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLLuongSP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLLuongSP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLLuongSP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLLuongSP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLLuongSP] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLLuongSP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLLuongSP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLLuongSP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLLuongSP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLLuongSP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLLuongSP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLLuongSP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLLuongSP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLLuongSP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLLuongSP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLLuongSP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLLuongSP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLLuongSP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLLuongSP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLLuongSP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLLuongSP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLLuongSP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLLuongSP] SET RECOVERY FULL 
GO
ALTER DATABASE [QLLuongSP] SET  MULTI_USER 
GO
ALTER DATABASE [QLLuongSP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLLuongSP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLLuongSP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLLuongSP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLLuongSP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLLuongSP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLLuongSP', N'ON'
GO
ALTER DATABASE [QLLuongSP] SET QUERY_STORE = OFF
GO
USE [QLLuongSP]
GO
/****** Object:  Table [dbo].[BangCongHC]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangCongHC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayCham] [date] NULL,
	[IDNhanVien] [int] NULL,
	[TrangThai] [bit] NULL,
	[IDLoaiPhep] [int] NULL,
 CONSTRAINT [PK_BangCongHC] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangCongSP]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangCongSP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDCongDoan] [int] NULL,
	[IDCaLam] [int] NULL,
	[NgayDiLam] [date] NULL,
	[ID_NhanVien] [int] NULL,
	[SoLuongSP] [int] NULL,
 CONSTRAINT [PK_BangCongSP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangLuong]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangLuong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [date] NULL,
	[TienLuong] [decimal](18, 0) NOT NULL,
	[IDNhanVien] [int] NOT NULL,
	[SoBuoiLamThem] [int] NULL,
 CONSTRAINT [PK_BangLuong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CaLam]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaLam](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenCa] [nvarchar](120) NULL,
	[ThoiGianLam] [nvarchar](150) NULL,
 CONSTRAINT [PK_CaLam] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHopDong]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHopDong](
	[IDSanPham] [int] NOT NULL,
	[IDHopDong] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietHopDong] PRIMARY KEY CLUSTERED 
(
	[IDSanPham] ASC,
	[IDHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](120) NULL,
	[PhuCap] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongDoan]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongDoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenCongDoan] [nvarchar](120) NULL,
	[DonGia] [decimal](18, 0) NULL,
	[IDSanPham] [int] NULL,
 CONSTRAINT [PK_CongDoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenHopDong] [nvarchar](120) NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[TenKhachHang] [nvarchar](120) NULL,
	[DieuKhoan] [ntext] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_HopDong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhep]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhep](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhep] [nvarchar](150) NULL,
	[PhuCap] [decimal](18, 0) NULL,
 CONSTRAINT [PK_LoaiPhep] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](120) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](120) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[CMND] [varchar](12) NOT NULL,
	[IDPhongBan] [int] NULL,
	[ChiSoLuong] [float] NULL,
	[LuongCanBan] [decimal](18, 0) NULL,
	[TrinhDoNgoaiNgu] [float] NULL,
	[ThamNienCongTac] [int] NULL,
	[IDChucVu] [int] NULL,
	[IDTrinhDoHocVan] [int] NULL,
	[Anh] [varchar](120) NULL,
	[GioiTinh] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhongBan] [nvarchar](120) NULL,
	[NgayThanhLap] [date] NULL,
	[TenQuanLy] [nvarchar](120) NULL,
	[SoLuongNhanVien] [int] NOT NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](120) NULL,
	[DonViTinh] [nvarchar](20) NULL,
	[DonGia] [decimal](18, 0) NULL,
	[AnhSP] [varchar](120) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [varchar](120) NOT NULL,
	[Password] [varchar](50) NULL,
	[IDNhanVien] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrinhDoHocVan]    Script Date: 17/11/2021 8:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDoHocVan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenTrinhDo] [nvarchar](120) NULL,
	[ChiSoLuongCongThem] [float] NULL,
 CONSTRAINT [PK_TrinhDoHocVan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BangCongHC] ON 

INSERT [dbo].[BangCongHC] ([ID], [NgayCham], [IDNhanVien], [TrangThai], [IDLoaiPhep]) VALUES (113, CAST(N'2021-12-07' AS Date), 7, NULL, NULL)
INSERT [dbo].[BangCongHC] ([ID], [NgayCham], [IDNhanVien], [TrangThai], [IDLoaiPhep]) VALUES (114, CAST(N'2021-12-08' AS Date), 7, NULL, NULL)
INSERT [dbo].[BangCongHC] ([ID], [NgayCham], [IDNhanVien], [TrangThai], [IDLoaiPhep]) VALUES (150, CAST(N'2021-12-09' AS Date), 7, NULL, NULL)
INSERT [dbo].[BangCongHC] ([ID], [NgayCham], [IDNhanVien], [TrangThai], [IDLoaiPhep]) VALUES (151, CAST(N'2021-12-10' AS Date), 7, NULL, NULL)
INSERT [dbo].[BangCongHC] ([ID], [NgayCham], [IDNhanVien], [TrangThai], [IDLoaiPhep]) VALUES (152, CAST(N'2021-12-11' AS Date), 7, NULL, NULL)
INSERT [dbo].[BangCongHC] ([ID], [NgayCham], [IDNhanVien], [TrangThai], [IDLoaiPhep]) VALUES (168, CAST(N'2021-12-01' AS Date), 23, 0, NULL)
INSERT [dbo].[BangCongHC] ([ID], [NgayCham], [IDNhanVien], [TrangThai], [IDLoaiPhep]) VALUES (169, CAST(N'2021-12-02' AS Date), 23, 0, NULL)
INSERT [dbo].[BangCongHC] ([ID], [NgayCham], [IDNhanVien], [TrangThai], [IDLoaiPhep]) VALUES (170, CAST(N'2021-12-03' AS Date), 23, NULL, NULL)
INSERT [dbo].[BangCongHC] ([ID], [NgayCham], [IDNhanVien], [TrangThai], [IDLoaiPhep]) VALUES (171, CAST(N'2021-12-04' AS Date), 23, NULL, NULL)
SET IDENTITY_INSERT [dbo].[BangCongHC] OFF
GO
SET IDENTITY_INSERT [dbo].[BangCongSP] ON 

INSERT [dbo].[BangCongSP] ([ID], [IDCongDoan], [IDCaLam], [NgayDiLam], [ID_NhanVien], [SoLuongSP]) VALUES (20, 21, 2, CAST(N'2021-11-14' AS Date), 18, 0)
INSERT [dbo].[BangCongSP] ([ID], [IDCongDoan], [IDCaLam], [NgayDiLam], [ID_NhanVien], [SoLuongSP]) VALUES (22, 21, 2, CAST(N'2021-11-14' AS Date), 20, 0)
SET IDENTITY_INSERT [dbo].[BangCongSP] OFF
GO
SET IDENTITY_INSERT [dbo].[BangLuong] ON 

INSERT [dbo].[BangLuong] ([ID], [NgayLap], [TienLuong], [IDNhanVien], [SoBuoiLamThem]) VALUES (1, CAST(N'2021-11-12' AS Date), CAST(9000000 AS Decimal(18, 0)), 2, 5)
INSERT [dbo].[BangLuong] ([ID], [NgayLap], [TienLuong], [IDNhanVien], [SoBuoiLamThem]) VALUES (2, CAST(N'2021-11-14' AS Date), CAST(7800000 AS Decimal(18, 0)), 24, 3)
INSERT [dbo].[BangLuong] ([ID], [NgayLap], [TienLuong], [IDNhanVien], [SoBuoiLamThem]) VALUES (3, CAST(N'2021-11-14' AS Date), CAST(450000 AS Decimal(18, 0)), 23, 2)
INSERT [dbo].[BangLuong] ([ID], [NgayLap], [TienLuong], [IDNhanVien], [SoBuoiLamThem]) VALUES (4, CAST(N'2021-11-17' AS Date), CAST(0 AS Decimal(18, 0)), 10, 0)
INSERT [dbo].[BangLuong] ([ID], [NgayLap], [TienLuong], [IDNhanVien], [SoBuoiLamThem]) VALUES (5, CAST(N'2021-11-17' AS Date), CAST(0 AS Decimal(18, 0)), 9, 0)
INSERT [dbo].[BangLuong] ([ID], [NgayLap], [TienLuong], [IDNhanVien], [SoBuoiLamThem]) VALUES (6, CAST(N'2021-11-17' AS Date), CAST(100000 AS Decimal(18, 0)), 19, 0)
INSERT [dbo].[BangLuong] ([ID], [NgayLap], [TienLuong], [IDNhanVien], [SoBuoiLamThem]) VALUES (7, CAST(N'2021-11-17' AS Date), CAST(0 AS Decimal(18, 0)), 8, 0)
INSERT [dbo].[BangLuong] ([ID], [NgayLap], [TienLuong], [IDNhanVien], [SoBuoiLamThem]) VALUES (8, CAST(N'2021-11-17' AS Date), CAST(22000000 AS Decimal(18, 0)), 24, 3)
SET IDENTITY_INSERT [dbo].[BangLuong] OFF
GO
SET IDENTITY_INSERT [dbo].[CaLam] ON 

INSERT [dbo].[CaLam] ([ID], [TenCa], [ThoiGianLam]) VALUES (1, N'Sáng', N'7h đến 11h30')
INSERT [dbo].[CaLam] ([ID], [TenCa], [ThoiGianLam]) VALUES (2, N'Chiều', N'12h30 đến 5h')
INSERT [dbo].[CaLam] ([ID], [TenCa], [ThoiGianLam]) VALUES (3, N'Tối', N'6h đến 9h30')
SET IDENTITY_INSERT [dbo].[CaLam] OFF
GO
INSERT [dbo].[ChiTietHopDong] ([IDSanPham], [IDHopDong], [SoLuong]) VALUES (1, 2, 1000)
INSERT [dbo].[ChiTietHopDong] ([IDSanPham], [IDHopDong], [SoLuong]) VALUES (5, 6, 2)
INSERT [dbo].[ChiTietHopDong] ([IDSanPham], [IDHopDong], [SoLuong]) VALUES (6, 7, 10)
INSERT [dbo].[ChiTietHopDong] ([IDSanPham], [IDHopDong], [SoLuong]) VALUES (8, 7, 10)
INSERT [dbo].[ChiTietHopDong] ([IDSanPham], [IDHopDong], [SoLuong]) VALUES (9, 7, 15)
INSERT [dbo].[ChiTietHopDong] ([IDSanPham], [IDHopDong], [SoLuong]) VALUES (11, 6, 4)
INSERT [dbo].[ChiTietHopDong] ([IDSanPham], [IDHopDong], [SoLuong]) VALUES (12, 6, 6)
GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([ID], [TenChucVu], [PhuCap]) VALUES (4, N'Quản lý', CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[ChucVu] ([ID], [TenChucVu], [PhuCap]) VALUES (5, N'Trưởng phòng ban', CAST(3000000 AS Decimal(18, 0)))
INSERT [dbo].[ChucVu] ([ID], [TenChucVu], [PhuCap]) VALUES (6, N'Nhân viên', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[ChucVu] ([ID], [TenChucVu], [PhuCap]) VALUES (7, N'Công nhân', CAST(0 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[CongDoan] ON 

INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (1, N'May thân trước', CAST(20000 AS Decimal(18, 0)), 1)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (2, N'May thân sau', CAST(20000 AS Decimal(18, 0)), 1)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (3, N'May cổ áo', CAST(20000 AS Decimal(18, 0)), 1)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (4, N'May tay áo', CAST(20000 AS Decimal(18, 0)), 1)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (5, N'Đươm cút áo', CAST(20000 AS Decimal(18, 0)), 1)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (20, N'May lưng quần', CAST(15000 AS Decimal(18, 0)), 4)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (21, N'May ống quần', CAST(15000 AS Decimal(18, 0)), 4)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (22, N'May túi quần', CAST(15000 AS Decimal(18, 0)), 4)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (23, N'May túi áo', CAST(15000 AS Decimal(18, 0)), 5)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (24, N'May tay áo', CAST(17000 AS Decimal(18, 0)), 5)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (25, N'May cút áo', CAST(15000 AS Decimal(18, 0)), 5)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (26, N'May cổ áo', CAST(15000 AS Decimal(18, 0)), 5)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (27, N'Gắn dây kéo', CAST(15000 AS Decimal(18, 0)), 5)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (28, N'May tay áo', CAST(15000 AS Decimal(18, 0)), 6)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (29, N'May túi áo', CAST(15000 AS Decimal(18, 0)), 6)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (30, N'May lưng áo', CAST(20000 AS Decimal(18, 0)), 6)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (31, N'Cắt chỉ áo', CAST(15000 AS Decimal(18, 0)), 6)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (33, N'May lưng quần', CAST(15000 AS Decimal(18, 0)), 7)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (34, N'May túi quần', CAST(15000 AS Decimal(18, 0)), 7)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (35, N'In màu', CAST(20000 AS Decimal(18, 0)), 7)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (36, N'May thân trước', CAST(15000 AS Decimal(18, 0)), 8)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (37, N'In kiểu trước áo', CAST(15000 AS Decimal(18, 0)), 8)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (38, N'May lưng áo', CAST(15000 AS Decimal(18, 0)), 9)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (39, N'May túi áo', CAST(15000 AS Decimal(18, 0)), 9)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (40, N'In kiểu áo', CAST(15000 AS Decimal(18, 0)), 9)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (41, N'May ống quần', CAST(15000 AS Decimal(18, 0)), 10)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (42, N'May cổ áo', CAST(15000 AS Decimal(18, 0)), 11)
INSERT [dbo].[CongDoan] ([ID], [TenCongDoan], [DonGia], [IDSanPham]) VALUES (43, N'May tay áo', CAST(15000 AS Decimal(18, 0)), 12)
SET IDENTITY_INSERT [dbo].[CongDoan] OFF
GO
SET IDENTITY_INSERT [dbo].[HopDong] ON 

INSERT [dbo].[HopDong] ([ID], [TenHopDong], [NgayBatDau], [NgayKetThuc], [TenKhachHang], [DieuKhoan], [TrangThai]) VALUES (2, N'Hợp đồng mua bán quần áo', CAST(N'2021-04-15' AS Date), CAST(N'2021-05-30' AS Date), N'Trần Văn Nhân', N'- Đảm bảo lợi ích giữa 2 bên...', 0)
INSERT [dbo].[HopDong] ([ID], [TenHopDong], [NgayBatDau], [NgayKetThuc], [TenKhachHang], [DieuKhoan], [TrangThai]) VALUES (6, N'Hợp đồng mua bán áo khoát', CAST(N'2021-10-18' AS Date), CAST(N'2022-01-27' AS Date), N'Lê Văn Lợi', N'- Điều 1
- Điều 2
- Điều 3', 1)
INSERT [dbo].[HopDong] ([ID], [TenHopDong], [NgayBatDau], [NgayKetThuc], [TenKhachHang], [DieuKhoan], [TrangThai]) VALUES (7, N'Hợp đồng mua bán áo thun', CAST(N'2021-11-12' AS Date), CAST(N'2021-12-31' AS Date), N'Hoàng Minh Luân', N'- Điều 1
- Điều 2
- Điều 3', 1)
SET IDENTITY_INSERT [dbo].[HopDong] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiPhep] ON 

INSERT [dbo].[LoaiPhep] ([ID], [TenPhep], [PhuCap]) VALUES (1, N'Tiêm vacxin covid-19', CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhep] ([ID], [TenPhep], [PhuCap]) VALUES (2, N'Nghỉ bệnh', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhep] ([ID], [TenPhep], [PhuCap]) VALUES (3, N'Nghỉ sinh con', CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[LoaiPhep] ([ID], [TenPhep], [PhuCap]) VALUES (4, N'Khác', CAST(100000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[LoaiPhep] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (2, N'Hồ Hoàng Hà', CAST(N'1993-04-07' AS Date), N'Tân Trụ Long An', N'0398452112', N'321439727', 4, 1.32, CAST(10000000 AS Decimal(18, 0)), 6, 5, 5, 8, N'D:\Study\PTUD\QLLSP\Avatar\Nam.jpg', 1)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (3, N'Lê Thị Hà Nhân', CAST(N'1994-07-09' AS Date), N'Quận 1 TP Hồ Chí Minh', N'0378342122', N'329382727', 3, 1.32, CAST(8000000 AS Decimal(18, 0)), 5, 4, 4, 6, N'D:\Study\PTUD\QLLSP\Avatar\Nu.jpg', 0)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (5, N'Trịnh Trọng Nhân', CAST(N'1991-05-12' AS Date), N'Thủ Đức TP Hồ Chí Minh', N'0383522118', N'338497271', 2, 1.32, CAST(12000000 AS Decimal(18, 0)), 5.5, 5, 4, 6, N'D:\Study\PTUD\QLLSP\Avatar\Nam.jpg', 1)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (7, N'Nguyễn Văn Bình', CAST(N'1992-12-03' AS Date), N'Mỏ Cày Nam Bến Tre', N'0391052198', N'383929727', 1, 1.32, CAST(9000000 AS Decimal(18, 0)), 6.2, 6, 5, 8, N'D:\Study\PTUD\QLLSP\Avatar\Nam.jpg', 1)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (8, N'Võ Ngọc Hòa', CAST(N'1996-09-12' AS Date), N'Châu Thành Tiền Giang', N'0398459382', N'320492227', 1, 1.32, CAST(6000000 AS Decimal(18, 0)), 4, 2, 6, 7, N'D:\Study\PTUD\QLLSP\Avatar\Nu.jpg', 0)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (9, N'Hồ Thị Thúy', CAST(N'1997-09-09' AS Date), N'Hải Châu Đà Nẵng', N'0398473920', N'321493027', 2, 1.32, CAST(6500000 AS Decimal(18, 0)), 4.5, 2, 7, 8, N'D:\Study\PTUD\QLLSP\Avatar\Nu.jpg', 0)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (10, N'Lê Công Tiến', CAST(N'1999-08-01' AS Date), N'Bến Cầu Tây Ninh', N'0398473892', N'321438291', 3, 1.32, CAST(7000000 AS Decimal(18, 0)), 4.3, 3, 7, 7, N'D:\Study\PTUD\QLLSP\Avatar\Nam.jpg', 1)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (17, N'Hoàng Văn Minh', CAST(N'1995-12-29' AS Date), N'Đà Nẵng', N'0384726312', N'374892637', 2, 1.32, CAST(5000000 AS Decimal(18, 0)), 4.4, 2, 6, 7, NULL, 1)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (18, N'Lê Minh Hải', CAST(N'1994-06-14' AS Date), N'Cầu Giấy Hà Nội', N'0482637412', N'384726349', 2, 0, CAST(0 AS Decimal(18, 0)), 0, 0, 7, 7, NULL, 1)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (19, N'Nguyễn Thị Mỹ Hạ', CAST(N'1995-09-04' AS Date), N'Quận 2 TP Hồ Chí Minh', N'0374835125', N'283947621', 3, 0, CAST(0 AS Decimal(18, 0)), 0, 0, 7, 8, NULL, 0)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (20, N'Võ Hoàng Tấn Trọng', CAST(N'1997-11-05' AS Date), N'Châu Thành Tiền Giang', N'0384715243', N'374626348', 2, 0, CAST(0 AS Decimal(18, 0)), 0, 0, 7, 6, NULL, 1)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (21, N'Lê Hoàng Ngọc Nữ', CAST(N'1996-03-05' AS Date), N'Tây Ninh', N'03847253', N'3849736452', 3, 0, CAST(0 AS Decimal(18, 0)), 0, 0, 7, 8, NULL, 0)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (22, N'Hoàng Thị Ngọc Châu', CAST(N'1999-12-04' AS Date), N'Đồng Nai', N'0384756212', N'3648394756', 2, 0, CAST(0 AS Decimal(18, 0)), 0, 0, 7, 6, NULL, 0)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (23, N'Trần Minh Chánh', CAST(N'1993-12-04' AS Date), N'Lào Cai', N'0347827363', N'938472635478', 1, 1.32, CAST(600000 AS Decimal(18, 0)), 3.8, 2, 6, 7, NULL, 1)
INSERT [dbo].[NhanVien] ([ID], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [IDPhongBan], [ChiSoLuong], [LuongCanBan], [TrinhDoNgoaiNgu], [ThamNienCongTac], [IDChucVu], [IDTrinhDoHocVan], [Anh], [GioiTinh]) VALUES (24, N'Ngô Thị Ngọc Minh', CAST(N'1994-09-06' AS Date), N'Quận 8 TP HCM', N'0473846521', N'389457364723', 4, 1.32, CAST(7000000 AS Decimal(18, 0)), 4.5, 3, 6, 6, NULL, 0)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[PhongBan] ON 

INSERT [dbo].[PhongBan] ([ID], [TenPhongBan], [NgayThanhLap], [TenQuanLy], [SoLuongNhanVien]) VALUES (1, N'Kiểm toán', CAST(N'2009-12-05' AS Date), N'Nguyễn Văn Bình', 0)
INSERT [dbo].[PhongBan] ([ID], [TenPhongBan], [NgayThanhLap], [TenQuanLy], [SoLuongNhanVien]) VALUES (2, N'Sản xuất', CAST(N'2009-12-05' AS Date), N'Trịnh Trọng Nhân', 0)
INSERT [dbo].[PhongBan] ([ID], [TenPhongBan], [NgayThanhLap], [TenQuanLy], [SoLuongNhanVien]) VALUES (3, N'Nhân sự', CAST(N'2009-12-05' AS Date), N'Lê Thị Hà Nhân', 0)
INSERT [dbo].[PhongBan] ([ID], [TenPhongBan], [NgayThanhLap], [TenQuanLy], [SoLuongNhanVien]) VALUES (4, N'Tài vụ', CAST(N'2009-12-05' AS Date), N'Hồ Hoàng Hà', 0)
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([ID], [TenSP], [DonViTinh], [DonGia], [AnhSP]) VALUES (1, N'Áo sơ mi nam', N'VNĐ', CAST(150000 AS Decimal(18, 0)), N'https://cavino.vn/wp-content/uploads/2019/04/lam-sao-de-co-mot-ao-so-mi-nam-dep-va-thie-ke-tam-trung.jpg')
INSERT [dbo].[SanPham] ([ID], [TenSP], [DonViTinh], [DonGia], [AnhSP]) VALUES (4, N'Quần tây nam', N'VNĐ', CAST(300000 AS Decimal(18, 0)), N'https://cf.shopee.vn/file/eb8e7ce77a1ea7b8e54a5382be3b9828')
INSERT [dbo].[SanPham] ([ID], [TenSP], [DonViTinh], [DonGia], [AnhSP]) VALUES (5, N'Áo khoát kaki nữ', N'VNĐ', CAST(150000 AS Decimal(18, 0)), N'https://thoitrangteenthienphuc.vn/upload/sanpham/ao-khoac-kaki-nu-tui-hop-phoi-3-mau-bao-dep-gia-re-5-6186.jpg')
INSERT [dbo].[SanPham] ([ID], [TenSP], [DonViTinh], [DonGia], [AnhSP]) VALUES (6, N'Áo thun nam Hàn Quốc', N'VNĐ', CAST(150000 AS Decimal(18, 0)), N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSfGWqSgAcp7VXsB49tBrci5Qj4tGCQpP3hOA&usqp=CAU')
INSERT [dbo].[SanPham] ([ID], [TenSP], [DonViTinh], [DonGia], [AnhSP]) VALUES (7, N'Quần sort nam', N'VNĐ', CAST(200000 AS Decimal(18, 0)), N'https://quanaoxuongmay.com/wp-content/uploads/10100-1045044364-685ff88c8ffb69a530ea-3.png')
INSERT [dbo].[SanPham] ([ID], [TenSP], [DonViTinh], [DonGia], [AnhSP]) VALUES (8, N'Áo thun nữ Nhật Bản', N'VNĐ', CAST(130000 AS Decimal(18, 0)), N'https://media3.scdn.vn/img4/2020/03_27/ycJjICdBUOTBFzk8GSZ4_simg_de2fe0_500x500_maxb.jpg')
INSERT [dbo].[SanPham] ([ID], [TenSP], [DonViTinh], [DonGia], [AnhSP]) VALUES (9, N'Áo thun nam kiểu cách', N'VNĐ', CAST(170000 AS Decimal(18, 0)), N'https://tmluxury.vn/wp-content/uploads/ao-thun-nam-co-co-dep-tm-luxury.jpg')
INSERT [dbo].[SanPham] ([ID], [TenSP], [DonViTinh], [DonGia], [AnhSP]) VALUES (10, N'Quần jean nam', N'VNĐ', CAST(240000 AS Decimal(18, 0)), N'https://annshop.vn/wp-content/uploads/12605-z1963131976320-c7a924493ac0038c43327cf680ebc855-result.jpg')
INSERT [dbo].[SanPham] ([ID], [TenSP], [DonViTinh], [DonGia], [AnhSP]) VALUES (11, N'Áo khoát Jean nữ', N'VNĐ', CAST(290000 AS Decimal(18, 0)), N'https://media3.scdn.vn/img3/2019/5_21/MYIzaV_simg_de2fe0_500x500_maxb.jpg')
INSERT [dbo].[SanPham] ([ID], [TenSP], [DonViTinh], [DonGia], [AnhSP]) VALUES (12, N'Áo khoát Jean nam', N'VNĐ', CAST(3200000 AS Decimal(18, 0)), N'https://cf.shopee.vn/file/9aab4e8abe14c744e5eb6fd3b935d54a')
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
INSERT [dbo].[TaiKhoan] ([Username], [Password], [IDNhanVien]) VALUES (N'CN_001', N'123', 9)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [IDNhanVien]) VALUES (N'CN_002', N'123', 10)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [IDNhanVien]) VALUES (N'NV_001', N'123', 8)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [IDNhanVien]) VALUES (N'NV_002', N'123', 2)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [IDNhanVien]) VALUES (N'NV_003', N'123', 24)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [IDNhanVien]) VALUES (N'QL_001', N'123', 3)
INSERT [dbo].[TaiKhoan] ([Username], [Password], [IDNhanVien]) VALUES (N'QL_002', N'123', 5)
GO
SET IDENTITY_INSERT [dbo].[TrinhDoHocVan] ON 

INSERT [dbo].[TrinhDoHocVan] ([ID], [TenTrinhDo], [ChiSoLuongCongThem]) VALUES (6, N'Đại học', 0.7)
INSERT [dbo].[TrinhDoHocVan] ([ID], [TenTrinhDo], [ChiSoLuongCongThem]) VALUES (7, N'Trung cấp', 0.3)
INSERT [dbo].[TrinhDoHocVan] ([ID], [TenTrinhDo], [ChiSoLuongCongThem]) VALUES (8, N'Cao đẳng', 0.5)
SET IDENTITY_INSERT [dbo].[TrinhDoHocVan] OFF
GO
ALTER TABLE [dbo].[BangCongHC] ADD  CONSTRAINT [DF_BangCongHC_Status]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[PhongBan] ADD  CONSTRAINT [DF_PhongBan_SoLuongNhanVien]  DEFAULT ((0)) FOR [SoLuongNhanVien]
GO
ALTER TABLE [dbo].[BangCongHC]  WITH CHECK ADD  CONSTRAINT [FK_BangCongHC_LoaiPhep] FOREIGN KEY([IDLoaiPhep])
REFERENCES [dbo].[LoaiPhep] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[BangCongHC] CHECK CONSTRAINT [FK_BangCongHC_LoaiPhep]
GO
ALTER TABLE [dbo].[BangCongHC]  WITH CHECK ADD  CONSTRAINT [FK_BangCongHC_NhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BangCongHC] CHECK CONSTRAINT [FK_BangCongHC_NhanVien]
GO
ALTER TABLE [dbo].[BangCongSP]  WITH CHECK ADD  CONSTRAINT [FK_BangCongSP_CaLam] FOREIGN KEY([IDCaLam])
REFERENCES [dbo].[CaLam] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[BangCongSP] CHECK CONSTRAINT [FK_BangCongSP_CaLam]
GO
ALTER TABLE [dbo].[BangCongSP]  WITH CHECK ADD  CONSTRAINT [FK_BangCongSP_CongDoan] FOREIGN KEY([IDCongDoan])
REFERENCES [dbo].[CongDoan] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[BangCongSP] CHECK CONSTRAINT [FK_BangCongSP_CongDoan]
GO
ALTER TABLE [dbo].[BangCongSP]  WITH CHECK ADD  CONSTRAINT [FK_BangCongSP_NhanVien] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BangCongSP] CHECK CONSTRAINT [FK_BangCongSP_NhanVien]
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD  CONSTRAINT [FK_BangLuong_NhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BangLuong] CHECK CONSTRAINT [FK_BangLuong_NhanVien]
GO
ALTER TABLE [dbo].[ChiTietHopDong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHopDong_HopDong] FOREIGN KEY([IDHopDong])
REFERENCES [dbo].[HopDong] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHopDong] CHECK CONSTRAINT [FK_ChiTietHopDong_HopDong]
GO
ALTER TABLE [dbo].[ChiTietHopDong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHopDong_SanPham] FOREIGN KEY([IDSanPham])
REFERENCES [dbo].[SanPham] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHopDong] CHECK CONSTRAINT [FK_ChiTietHopDong_SanPham]
GO
ALTER TABLE [dbo].[CongDoan]  WITH CHECK ADD  CONSTRAINT [FK_CongDoan_SanPham] FOREIGN KEY([IDSanPham])
REFERENCES [dbo].[SanPham] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CongDoan] CHECK CONSTRAINT [FK_CongDoan_SanPham]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([IDChucVu])
REFERENCES [dbo].[ChucVu] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([IDPhongBan])
REFERENCES [dbo].[PhongBan] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TrinhDoHocVan] FOREIGN KEY([IDTrinhDoHocVan])
REFERENCES [dbo].[TrinhDoHocVan] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TrinhDoHocVan]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QLLuongSP] SET  READ_WRITE 
GO
