using System.Data;
using bandienthoai.DTO;
using Microsoft.Data.SqlClient;

namespace bandienthoai.DAL
{
    public class HangDienThoaiDAL : DBConnect
    {
        public DataTable LayDanhSach()
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlDataAdapter da = new("SELECT MaHang, TenHang FROM HangDienThoai", conn);
                DataTable dt = new();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }

        public bool Them(HangDienThoaiDTO hang)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlCommand cmd = new("INSERT INTO HangDienThoai(TenHang) VALUES(@TenHang)", conn);
                cmd.Parameters.AddWithValue("@TenHang", hang.TenHang);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }

        public bool Sua(HangDienThoaiDTO hang)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlCommand cmd = new("UPDATE HangDienThoai SET TenHang=@TenHang WHERE MaHang=@MaHang", conn);
                cmd.Parameters.AddWithValue("@MaHang", hang.MaHang);
                cmd.Parameters.AddWithValue("@TenHang", hang.TenHang);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }

        public bool Xoa(int maHang)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlCommand cmd = new("DELETE FROM HangDienThoai WHERE MaHang=@MaHang", conn);
                cmd.Parameters.AddWithValue("@MaHang", maHang);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }
    }
}
