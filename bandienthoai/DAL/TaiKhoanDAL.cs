using bandienthoai.DTO;
using Microsoft.Data.SqlClient;

namespace bandienthoai.DAL
{
    public class TaiKhoanDAL : DBConnect
    {
        public bool DangNhap(TaiKhoanDTO taiKhoan)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlCommand cmd = new(
                    "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@TenDangNhap AND MatKhau=@MatKhau",
                    conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", taiKhoan.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }
    }
}
