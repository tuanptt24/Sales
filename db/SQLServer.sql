CREATE DATABASE QuanLyBanHang;
GO
USE QuanLyBanHang;
GO

-- Bảng Vai trò
CREATE TABLE VaiTro (
    MaVaiTro INT IDENTITY(1,1) PRIMARY KEY,
    TenVaiTro NVARCHAR(100) NOT NULL
);

-- Bảng Nhân viên
CREATE TABLE NhanVien (
    MaNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    HoNhanVien NVARCHAR(50),
    TenNhanVien NVARCHAR(50),
    SoDienThoai VARCHAR(20),
    MaVaiTro INT FOREIGN KEY REFERENCES VaiTro(MaVaiTro)
);

-- Bảng Tài khoản
CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    MaNhanVien INT FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    TenDangNhap VARCHAR(50) UNIQUE,
    MatKhau VARCHAR(255) NOT NULL,
    TrangThai BIT DEFAULT 1
);

-- Bảng Audit Log
CREATE TABLE AuditLog (
    MaNhatKy INT IDENTITY(1,1) PRIMARY KEY,
    MaNhanVien INT FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    LoaiTacVu NVARCHAR(50),
    NgayGio DATETIME DEFAULT GETDATE()
);

-- Bảng Nhà cung cấp
CREATE TABLE NhaCungCap (
    MaNhaCungCap INT IDENTITY(1,1) PRIMARY KEY,
    TenNhaCungCap NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(100)
);

-- Bảng Sản phẩm
CREATE TABLE SanPham (
    MaSanPham INT IDENTITY(1,1) PRIMARY KEY,
    TenSanPham NVARCHAR(100),
    MaHang VARCHAR(50),
    DonViTinh NVARCHAR(20),
    GiaBan DECIMAL(18,2),
    TrangThai NVARCHAR(20),
    MaNhaCungCap INT FOREIGN KEY REFERENCES NhaCungCap(MaNhaCungCap)
);

-- Bảng Kho
CREATE TABLE Kho (
    MaKho INT IDENTITY(1,1) PRIMARY KEY,
    MaSanPham INT FOREIGN KEY REFERENCES SanPham(MaSanPham),
    SoLuongTon INT,
    NgayCapNhatCuoi DATETIME
);

-- Bảng Khách hàng
CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    TenKhachHang NVARCHAR(100),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(100),
    DiaChi NVARCHAR(200),
    HangKhachHang NVARCHAR(20)
);

-- Bảng Hóa đơn
CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME DEFAULT GETDATE(),
    MaKhachHang INT FOREIGN KEY REFERENCES KhachHang(MaKhachHang),
    MaNhanVien INT FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    TongTien DECIMAL(18,2),
    KhuyenMai DECIMAL(5,2)
);

-- Bảng Chi tiết hóa đơn
CREATE TABLE ChiTietHoaDon (
    MaChiTietHD INT IDENTITY(1,1) PRIMARY KEY,
    MaHoaDon INT FOREIGN KEY REFERENCES HoaDon(MaHoaDon),
    MaSanPham INT FOREIGN KEY REFERENCES SanPham(MaSanPham),
    SoLuong INT,
    DonGia DECIMAL(18,2),
    ThanhTien DECIMAL(18,2)
);

-- Bảng Thanh toán
CREATE TABLE ThanhToan (
    MaThanhToan INT IDENTITY(1,1) PRIMARY KEY,
    MaHoaDon INT FOREIGN KEY REFERENCES HoaDon(MaHoaDon),
    NgayThanhToan DATETIME DEFAULT GETDATE(),
    PhuongThuc NVARCHAR(50),
    SoTien DECIMAL(18,2)
);

-- Bảng Phiếu nhập
CREATE TABLE PhieuNhap (
    MaPhieuNhap INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME DEFAULT GETDATE(),
    MaNhaCungCap INT FOREIGN KEY REFERENCES NhaCungCap(MaNhaCungCap),
    MaNhanVien INT FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    TongTien DECIMAL(18,2),
    TrangThai NVARCHAR(50)
);

-- Bảng Chi tiết phiếu nhập
CREATE TABLE ChiTietPhieuNhap (
    MaChiTietPN INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuNhap INT FOREIGN KEY REFERENCES PhieuNhap(MaPhieuNhap),
    MaSanPham INT FOREIGN KEY REFERENCES SanPham(MaSanPham),
    SoLuongNhap INT,
    GiaNhap DECIMAL(18,2)
);

-- Bảng Phiếu trả hàng
CREATE TABLE PhieuTraHang (
    MaPhieuTra INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME DEFAULT GETDATE(),
    LoaiTra NVARCHAR(20),
    MaNhanVien INT FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    TongTien DECIMAL(18,2)
);

-- Bảng Chi tiết phiếu trả
CREATE TABLE ChiTietPhieuTra (
    MaChiTietPT INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuTra INT FOREIGN KEY REFERENCES PhieuTraHang(MaPhieuTra),
    MaSanPham INT FOREIGN KEY REFERENCES SanPham(MaSanPham),
    SoLuongTra INT,
    GiaTriHoan DECIMAL(18,2)
);