USE QuanLyBanHang;
GO

-- Thêm Vai trò
INSERT INTO VaiTro (TenVaiTro) VALUES
(N'Quản lý cửa hàng'),
(N'Nhân viên bán hàng'),
(N'Quản lý kho');

-- Thêm Nhân viên
INSERT INTO NhanVien (HoNhanVien, TenNhanVien, SoDienThoai, MaVaiTro) VALUES
(N'Nguyen', N'An', '0901234567', 1),
(N'Tran', N'Binh', '0902345678', 2),
(N'Le', N'Chi', '0903456789', 3);

-- Thêm Tài khoản
INSERT INTO TaiKhoan (MaNhanVien, TenDangNhap, MatKhau, TrangThai) VALUES
(1, 'admin', '123456', 1),
(2, 'binh_nv', '123456', 1),
(3, 'chi_kho', '123456', 1);

-- Thêm Audit Log
INSERT INTO AuditLog (MaNhanVien, LoaiTacVu) VALUES
(1, N'Thêm sản phẩm'),
(2, N'Tạo hóa đơn'),
(3, N'Nhập kho');

-- Thêm Nhà cung cấp
INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi, SoDienThoai, Email) VALUES
(N'Công ty A', N'123 Lê Lợi, Q1, HCM', '0281234567', 'ncc_a@gmail.com'),
(N'Công ty B', N'456 Nguyễn Trãi, Q5, HCM', '0287654321', 'ncc_b@gmail.com');

-- Thêm Sản phẩm
INSERT INTO SanPham (TenSanPham, MaHang, DonViTinh, GiaBan, TrangThai, MaNhaCungCap) VALUES
(N'Sữa tươi Vinamilk', 'SP001', N'Hộp', 15000, N'Còn hàng', 1),
(N'Mì Hảo Hảo', 'SP002', N'Gói', 4000, N'Còn hàng', 1),
(N'Coca Cola', 'SP003', N'Lon', 10000, N'Hết hàng', 2);

-- Thêm Kho
INSERT INTO Kho (MaSanPham, SoLuongTon, NgayCapNhatCuoi) VALUES
(1, 100, GETDATE()),
(2, 200, GETDATE()),
(3, 0, GETDATE());

-- Thêm Khách hàng
INSERT INTO KhachHang (TenKhachHang, SoDienThoai, Email, DiaChi, HangKhachHang) VALUES
(N'Nguyễn Văn A', '0911111111', 'a@gmail.com', N'123 Lê Duẩn, HN', N'VIP'),
(N'Trần Thị B', '0922222222', 'b@gmail.com', N'456 Hai Bà Trưng, HCM', N'Bình thường'),
(N'Lê Văn C', '0933333333', 'c@gmail.com', N'789 Nguyễn Huệ, HCM', N'Mới');

-- Thêm Hóa đơn
INSERT INTO HoaDon (NgayLap, MaKhachHang, MaNhanVien, TongTien, KhuyenMai) VALUES
(GETDATE(), 1, 2, 50000, 0),
(GETDATE(), 2, 2, 20000, 5);

-- Thêm Chi tiết hóa đơn
INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, SoLuong, DonGia, ThanhTien) VALUES
(1, 1, 2, 15000, 30000),
(1, 2, 5, 4000, 20000),
(2, 3, 2, 10000, 20000);

-- Thêm Thanh toán
INSERT INTO ThanhToan (MaHoaDon, NgayThanhToan, PhuongThuc, SoTien) VALUES
(1, GETDATE(), N'Tiền mặt', 50000),
(2, GETDATE(), N'Thẻ', 19000);

-- Thêm Phiếu nhập
INSERT INTO PhieuNhap (NgayLap, MaNhaCungCap, MaNhanVien, TongTien, TrangThai) VALUES
(GETDATE(), 1, 3, 100000, N'Đã nhập đủ'),
(GETDATE(), 2, 3, 50000, N'Đang chờ');

-- Thêm Chi tiết phiếu nhập
INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaSanPham, SoLuongNhap, GiaNhap) VALUES
(1, 1, 50, 12000),
(1, 2, 100, 3000),
(2, 3, 30, 8000);

-- Thêm Phiếu trả hàng
INSERT INTO PhieuTraHang (NgayLap, LoaiTra, MaNhanVien, TongTien) VALUES
(GETDATE(), N'Trá hàng khách', 2, 10000),
(GETDATE(), N'Trá hàng NCC', 3, 15000);

-- Thêm Chi tiết phiếu trả
INSERT INTO ChiTietPhieuTra (MaPhieuTra, MaSanPham, SoLuongTra, GiaTriHoan) VALUES
(1, 2, 2, 8000),
(2, 3, 1, 10000);
