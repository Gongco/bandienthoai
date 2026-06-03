IF DB_ID(N'QLBanDienThoai') IS NULL
BEGIN
    CREATE DATABASE QLBanDienThoai
END
GO

USE QLBanDienThoai
GO

IF OBJECT_ID(N'ChiTietHoaDon', N'U') IS NOT NULL DROP TABLE ChiTietHoaDon
IF OBJECT_ID(N'HoaDon', N'U') IS NOT NULL DROP TABLE HoaDon
IF OBJECT_ID(N'DienThoai', N'U') IS NOT NULL DROP TABLE DienThoai
IF OBJECT_ID(N'HangDienThoai', N'U') IS NOT NULL DROP TABLE HangDienThoai
IF OBJECT_ID(N'TaiKhoan', N'U') IS NOT NULL DROP TABLE TaiKhoan
GO

CREATE TABLE HangDienThoai
(
    MaHang INT IDENTITY(1,1) PRIMARY KEY,
    TenHang NVARCHAR(50) NOT NULL UNIQUE
)
GO

CREATE TABLE DienThoai
(
    MaDT INT IDENTITY(1,1) PRIMARY KEY,
    TenDT NVARCHAR(100) NOT NULL,
    MaHang INT NOT NULL,
    DonGia DECIMAL(18, 0) NOT NULL,
    SoLuong INT NOT NULL,
    TinhTrang NVARCHAR(10) NOT NULL DEFAULT N'Moi',
    PhanTram INT NOT NULL DEFAULT 100,
    HinhAnh NVARCHAR(255) NOT NULL DEFAULT N'',
    CONSTRAINT FK_DienThoai_Hang FOREIGN KEY(MaHang) REFERENCES HangDienThoai(MaHang)
)
GO

CREATE TABLE HoaDon
(
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayBan DATETIME NOT NULL,
    KhachHang NVARCHAR(100) NOT NULL,
    TongTien DECIMAL(18, 0) NOT NULL
)
GO

CREATE TABLE ChiTietHoaDon
(
    MaCT INT IDENTITY(1,1) PRIMARY KEY,
    MaHD INT NOT NULL,
    MaDT INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(18, 0) NOT NULL,
    CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD),
    CONSTRAINT FK_ChiTietHoaDon_DienThoai FOREIGN KEY(MaDT) REFERENCES DienThoai(MaDT)
)
GO

CREATE TABLE TaiKhoan
(
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50) NOT NULL
)
GO

INSERT INTO HangDienThoai(TenHang) VALUES
(N'Apple'),
(N'Samsung'),
(N'Xiaomi'),
(N'OPPO')
GO

INSERT INTO DienThoai(TenDT, MaHang, DonGia, SoLuong, TinhTrang, PhanTram, HinhAnh) VALUES
(N'iPhone 15', (SELECT MaHang FROM HangDienThoai WHERE TenHang = N'Apple'), 22000000, 10, N'Moi', 100, N''),
(N'Galaxy S24', (SELECT MaHang FROM HangDienThoai WHERE TenHang = N'Samsung'), 19000000, 15, N'Moi', 100, N''),
(N'Redmi Note 13', (SELECT MaHang FROM HangDienThoai WHERE TenHang = N'Xiaomi'), 5200000, 25, N'Moi', 100, N''),
(N'OPPO Reno 11', (SELECT MaHang FROM HangDienThoai WHERE TenHang = N'OPPO'), 8990000, 12, N'Moi', 100, N'')
GO

-- Them tai khoan dang nhap tai day neu can.
-- Vi du:
-- INSERT INTO TaiKhoan(TenDangNhap, MatKhau) VALUES(N'tohieu', N'123')
-- GO
