IF DB_ID(N'QLBanDienThoai') IS NULL
BEGIN
    CREATE DATABASE QLBanDienThoai
END
GO

USE QLBanDienThoai
GO

IF OBJECT_ID(N'HangDienThoai', N'U') IS NULL
BEGIN
    CREATE TABLE HangDienThoai
    (
        MaHang INT IDENTITY(1,1) PRIMARY KEY,
        TenHang NVARCHAR(50) NOT NULL UNIQUE
    )
END
GO

IF OBJECT_ID(N'DienThoai', N'U') IS NULL
BEGIN
    CREATE TABLE DienThoai
    (
        MaDT INT IDENTITY(1,1) PRIMARY KEY,
        TenDT NVARCHAR(100) NOT NULL,
        MaHang INT NOT NULL,
        DonGia DECIMAL(18, 0) NOT NULL,
        SoLuong INT NOT NULL,
        CONSTRAINT FK_DienThoai_Hang FOREIGN KEY(MaHang) REFERENCES HangDienThoai(MaHang)
    )
END
GO

IF COL_LENGTH('DienThoai', 'MaHang') IS NULL
BEGIN
    ALTER TABLE DienThoai ADD MaHang INT NULL
END
GO

IF COL_LENGTH('DienThoai', 'TinhTrang') IS NULL
BEGIN
    ALTER TABLE DienThoai ADD TinhTrang NVARCHAR(10) NOT NULL CONSTRAINT DF_DienThoai_TinhTrang DEFAULT N'Moi'
END
GO

IF COL_LENGTH('DienThoai', 'PhanTram') IS NULL
BEGIN
    ALTER TABLE DienThoai ADD PhanTram INT NOT NULL CONSTRAINT DF_DienThoai_PhanTram DEFAULT 100
END
GO

IF COL_LENGTH('DienThoai', 'HinhAnh') IS NULL
BEGIN
    ALTER TABLE DienThoai ADD HinhAnh NVARCHAR(255) NOT NULL CONSTRAINT DF_DienThoai_HinhAnh DEFAULT N''
END
GO

IF NOT EXISTS (SELECT 1 FROM HangDienThoai WHERE TenHang = N'Apple')
    INSERT INTO HangDienThoai(TenHang) VALUES(N'Apple')
IF NOT EXISTS (SELECT 1 FROM HangDienThoai WHERE TenHang = N'Samsung')
    INSERT INTO HangDienThoai(TenHang) VALUES(N'Samsung')
IF NOT EXISTS (SELECT 1 FROM HangDienThoai WHERE TenHang = N'Xiaomi')
    INSERT INTO HangDienThoai(TenHang) VALUES(N'Xiaomi')
IF NOT EXISTS (SELECT 1 FROM HangDienThoai WHERE TenHang = N'OPPO')
    INSERT INTO HangDienThoai(TenHang) VALUES(N'OPPO')
GO

IF COL_LENGTH('DienThoai', 'HangSX') IS NOT NULL
BEGIN
    UPDATE dt
    SET MaHang = h.MaHang
    FROM DienThoai dt
    INNER JOIN HangDienThoai h ON dt.HangSX = h.TenHang
    WHERE dt.MaHang IS NULL
END
GO

UPDATE DienThoai
SET MaHang = (SELECT TOP 1 MaHang FROM HangDienThoai ORDER BY MaHang)
WHERE MaHang IS NULL
GO

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_DienThoai_Hang')
BEGIN
    ALTER TABLE DienThoai
    WITH CHECK ADD CONSTRAINT FK_DienThoai_Hang FOREIGN KEY(MaHang) REFERENCES HangDienThoai(MaHang)
END
GO

IF NOT EXISTS (SELECT 1 FROM DienThoai)
BEGIN
    INSERT INTO DienThoai(TenDT, MaHang, DonGia, SoLuong, TinhTrang, PhanTram, HinhAnh) VALUES
    (N'iPhone 15', (SELECT MaHang FROM HangDienThoai WHERE TenHang = N'Apple'), 22000000, 10, N'Moi', 100, N''),
    (N'Galaxy S24', (SELECT MaHang FROM HangDienThoai WHERE TenHang = N'Samsung'), 19000000, 15, N'Moi', 100, N''),
    (N'Redmi Note 13', (SELECT MaHang FROM HangDienThoai WHERE TenHang = N'Xiaomi'), 5200000, 25, N'Moi', 100, N''),
    (N'OPPO Reno 11', (SELECT MaHang FROM HangDienThoai WHERE TenHang = N'OPPO'), 8990000, 12, N'Moi', 100, N'')
END
GO

IF OBJECT_ID(N'HoaDon', N'U') IS NULL
BEGIN
    CREATE TABLE HoaDon
    (
        MaHD INT IDENTITY(1,1) PRIMARY KEY,
        NgayBan DATETIME NOT NULL,
        KhachHang NVARCHAR(100) NOT NULL,
        TongTien DECIMAL(18, 0) NOT NULL
    )
END
GO

IF OBJECT_ID(N'ChiTietHoaDon', N'U') IS NULL
BEGIN
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
END
GO

IF OBJECT_ID(N'TaiKhoan', N'U') IS NULL
BEGIN
    CREATE TABLE TaiKhoan
    (
        TenDangNhap NVARCHAR(50) PRIMARY KEY,
        MatKhau NVARCHAR(50) NOT NULL
    )
END
GO
