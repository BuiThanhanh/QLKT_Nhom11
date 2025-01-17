USE [dbQLKTX]
GO
/****** Object:  Table [dbo].[tbCSVC]    Script Date: 11/9/2024 8:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCSVC](
	[TenCSVC] [nvarchar](20) NOT NULL,
	[LýDoPhatSinh] [nvarchar](20) NULL,
	[NgayPhatSinh] [date] NULL,
	[TienSua] [float] NULL,
 CONSTRAINT [PK_tbCSVC] PRIMARY KEY CLUSTERED 
(
	[TenCSVC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbDangNhap]    Script Date: 11/9/2024 8:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDangNhap](
	[TenTK] [nvarchar](30) NOT NULL,
	[MatKhau] [nvarchar](30) NULL,
	[TenTKMoi] [nvarchar](30) NULL,
	[MatKhauMoi] [nvarchar](30) NULL,
 CONSTRAINT [PK_tbDangNhap] PRIMARY KEY CLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbHoaDonTienDien]    Script Date: 11/9/2024 8:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbHoaDonTienDien](
	[MaHoaDon] [nvarchar](20) NULL,
	[NgayLapHoaDon] [date] NULL,
	[SoDien] [float] NULL,
	[GiaDien] [float] NULL,
	[SoNuoc] [float] NULL,
	[GiaNuoc] [float] NULL,
	[TongTien] [float] NULL,
	[TinhTrangDong] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbHopDong]    Script Date: 11/9/2024 8:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbHopDong](
	[MaHopDong] [nvarchar](20) NOT NULL,
	[MaSV] [nvarchar](20) NULL,
	[TenSV] [nvarchar](50) NULL,
	[MaPhong] [nvarchar](20) NULL,
	[NgayLap] [date] NULL,
	[NgayBD] [date] NULL,
	[NgayKT] [date] NULL,
	[TienCoc] [float] NULL,
 CONSTRAINT [PK_tbHopDong] PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbKyLuat]    Script Date: 11/9/2024 8:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbKyLuat](
	[MaKL] [nvarchar](20) NOT NULL,
	[MaSV] [nvarchar](20) NULL,
	[KyLuat] [nvarchar](10) NULL,
	[NgayKL] [date] NULL,
 CONSTRAINT [PK_tbKyLuat] PRIMARY KEY CLUSTERED 
(
	[MaKL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbNhanVien]    Script Date: 11/9/2024 8:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbNhanVien](
	[MaNV] [nvarchar](20) NOT NULL,
	[TenNV] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [nvarchar](10) NULL,
	[QueQuan] [nvarchar](30) NULL,
	[HeSoLuong] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPhong]    Script Date: 11/9/2024 8:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPhong](
	[MaPhong] [nvarchar](20) NOT NULL,
	[LoaiPhong] [nvarchar](10) NULL,
	[SVHienTai] [nvarchar](10) NULL,
	[SVToiDa] [nvarchar](10) NULL,
 CONSTRAINT [PK_tbPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbSinhVien]    Script Date: 11/9/2024 8:35:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSinhVien](
	[MaSV] [nvarchar](20) NOT NULL,
	[TenSV] [nvarchar](50) NULL,
	[Lop] [nvarchar](20) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](30) NULL,
	[SDT] [nvarchar](15) NULL,
	[MaPhong] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbSinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbCSVC] ([TenCSVC], [LýDoPhatSinh], [NgayPhatSinh], [TienSua]) VALUES (N'Bàn', N'Hỏng chân', CAST(N'2023-06-03' AS Date), 10000)
INSERT [dbo].[tbCSVC] ([TenCSVC], [LýDoPhatSinh], [NgayPhatSinh], [TienSua]) VALUES (N'Ghế ', N'bị hỏng ', CAST(N'2024-06-10' AS Date), 100000)
GO
INSERT [dbo].[tbDangNhap] ([TenTK], [MatKhau], [TenTKMoi], [MatKhauMoi]) VALUES (N'Thu', N'1234', N'Thuw', N'9876')
GO
INSERT [dbo].[tbHoaDonTienDien] ([MaHoaDon], [NgayLapHoaDon], [SoDien], [GiaDien], [SoNuoc], [GiaNuoc], [TongTien], [TinhTrangDong]) VALUES (N'TD01', CAST(N'2024-08-06' AS Date), 10, 50000, 12, 60000, 345231, N'đã đóng')
INSERT [dbo].[tbHoaDonTienDien] ([MaHoaDon], [NgayLapHoaDon], [SoDien], [GiaDien], [SoNuoc], [GiaNuoc], [TongTien], [TinhTrangDong]) VALUES (N'TD02', CAST(N'2024-09-09' AS Date), 25, 1300, 35, 2000, 12345, N'Chưa đóng ')
INSERT [dbo].[tbHoaDonTienDien] ([MaHoaDon], [NgayLapHoaDon], [SoDien], [GiaDien], [SoNuoc], [GiaNuoc], [TongTien], [TinhTrangDong]) VALUES (N'TD03', CAST(N'2024-08-06' AS Date), 12, 50000, 14, 60000, 46578, N'chưa đóng')
GO
INSERT [dbo].[tbHopDong] ([MaHopDong], [MaSV], [TenSV], [MaPhong], [NgayLap], [NgayBD], [NgayKT], [TienCoc]) VALUES (N'HD01', N'MT01', N'Nguyen Ba Minh THu', N'001', CAST(N'2023-06-02' AS Date), CAST(N'2023-07-01' AS Date), CAST(N'2024-01-03' AS Date), 100000)
INSERT [dbo].[tbHopDong] ([MaHopDong], [MaSV], [TenSV], [MaPhong], [NgayLap], [NgayBD], [NgayKT], [TienCoc]) VALUES (N'HD02', N'MT02', N'Hihi', N'002', CAST(N'2024-02-02' AS Date), CAST(N'2024-03-03' AS Date), CAST(N'2024-09-09' AS Date), 200000)
INSERT [dbo].[tbHopDong] ([MaHopDong], [MaSV], [TenSV], [MaPhong], [NgayLap], [NgayBD], [NgayKT], [TienCoc]) VALUES (N'HD03', N'MT04', N'aaa', N'002', CAST(N'2024-06-05' AS Date), CAST(N'2024-06-05' AS Date), CAST(N'2024-06-05' AS Date), 1234097)
GO
INSERT [dbo].[tbKyLuat] ([MaKL], [MaSV], [KyLuat], [NgayKL]) VALUES (N'KL01', N'MT01', N'Ngủ muộn', CAST(N'2024-06-12' AS Date))
INSERT [dbo].[tbKyLuat] ([MaKL], [MaSV], [KyLuat], [NgayKL]) VALUES (N'KL02', N'MT02', N'Đánh nhau', CAST(N'2024-03-08' AS Date))
GO
INSERT [dbo].[tbNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [SDT], [QueQuan], [HeSoLuong]) VALUES (N'NV01', N'Nguyễn M', N'Nữ', CAST(N'2003-06-08' AS Date), N'0321654789', N'HCM', N'6')
INSERT [dbo].[tbNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [SDT], [QueQuan], [HeSoLuong]) VALUES (N'NV02', N'Nguyễn C', N'Nam', CAST(N'2002-03-03' AS Date), N'0123415268', N'Hà Nội', N'2')
GO
INSERT [dbo].[tbPhong] ([MaPhong], [LoaiPhong], [SVHienTai], [SVToiDa]) VALUES (N'001', N'Đơn', N'8', N'10')
INSERT [dbo].[tbPhong] ([MaPhong], [LoaiPhong], [SVHienTai], [SVToiDa]) VALUES (N'002', N'Đôi', N'4', N'4')
INSERT [dbo].[tbPhong] ([MaPhong], [LoaiPhong], [SVHienTai], [SVToiDa]) VALUES (N'003', N'Đơn ', N'5', N'4')
GO
INSERT [dbo].[tbSinhVien] ([MaSV], [TenSV], [Lop], [GioiTinh], [NgaySinh], [QueQuan], [SDT], [MaPhong]) VALUES (N'MT01', N'Nguyen Ba Minh Thu', N'TinA22', N'Nu', CAST(N'2003-01-20' AS Date), N'Ha Noi', N'0969412669', N'001')
INSERT [dbo].[tbSinhVien] ([MaSV], [TenSV], [Lop], [GioiTinh], [NgaySinh], [QueQuan], [SDT], [MaPhong]) VALUES (N'MT02', N'Hihi', N'TinA21', N'Nam', CAST(N'2003-01-01' AS Date), N'HCM', N'0123456789', N'002')
INSERT [dbo].[tbSinhVien] ([MaSV], [TenSV], [Lop], [GioiTinh], [NgaySinh], [QueQuan], [SDT], [MaPhong]) VALUES (N'MT04', N'aaa', N'TinA24', N'Nữ', CAST(N'2024-06-04' AS Date), N'kjhg', N'23456', N'002')
INSERT [dbo].[tbSinhVien] ([MaSV], [TenSV], [Lop], [GioiTinh], [NgaySinh], [QueQuan], [SDT], [MaPhong]) VALUES (N'MT05', N'Nguyen Ba Minh Thư', N'TinA22', N'Nữ', CAST(N'2003-01-20' AS Date), N'Ha Noi', N'0969', N'001')
GO
ALTER TABLE [dbo].[tbHopDong]  WITH CHECK ADD  CONSTRAINT [FK_tbHopDong_tbSinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[tbSinhVien] ([MaSV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbHopDong] CHECK CONSTRAINT [FK_tbHopDong_tbSinhVien]
GO
ALTER TABLE [dbo].[tbKyLuat]  WITH CHECK ADD  CONSTRAINT [FK_tbKyLuat_tbSinhVien1] FOREIGN KEY([MaSV])
REFERENCES [dbo].[tbSinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[tbKyLuat] CHECK CONSTRAINT [FK_tbKyLuat_tbSinhVien1]
GO
