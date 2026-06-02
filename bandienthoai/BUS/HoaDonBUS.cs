using System.Data;
using bandienthoai.DAL;
using bandienthoai.DTO;

namespace bandienthoai.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL dal = new();

        public bool BanHang(int maDT, string khachHang, int soLuong, decimal donGia)
        {
            if (maDT <= 0)
            {
                throw new ArgumentException("Vui long chon dien thoai can ban.");
            }

            if (soLuong <= 0)
            {
                throw new ArgumentException("So luong ban phai lon hon 0.");
            }

            HoaDonDTO hoaDon = new()
            {
                NgayBan = DateTime.Now,
                KhachHang = string.IsNullOrWhiteSpace(khachHang) ? "Khach le" : khachHang.Trim(),
                TongTien = soLuong * donGia
            };

            ChiTietHoaDonDTO chiTiet = new()
            {
                MaDT = maDT,
                SoLuong = soLuong,
                DonGia = donGia
            };

            return dal.BanHang(hoaDon, chiTiet);
        }

        public DataTable LayDanhSach()
        {
            return dal.LayDanhSach();
        }
    }
}
