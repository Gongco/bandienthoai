using bandienthoai.DAL;
using bandienthoai.DTO;

namespace bandienthoai.BUS
{
    public class TaiKhoanBUS
    {
        private readonly TaiKhoanDAL dal = new();

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                throw new ArgumentException("Vui long nhap ten dang nhap va mat khau.");
            }

            TaiKhoanDTO taiKhoan = new()
            {
                TenDangNhap = tenDangNhap.Trim(),
                MatKhau = matKhau.Trim()
            };

            return dal.DangNhap(taiKhoan);
        }
    }
}
