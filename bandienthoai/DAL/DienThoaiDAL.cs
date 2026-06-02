using System.Data;
using bandienthoai.DTO;
using Microsoft.Data.SqlClient;

namespace bandienthoai.DAL
{
    public class DienThoaiDAL : DBConnect
    {
        public DataTable LayDanhSach()
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlDataAdapter da = new(
                    @"SELECT dt.MaDT, dt.TenDT, dt.MaHang, h.TenHang, dt.DonGia, dt.SoLuong,
                             dt.TinhTrang, dt.PhanTram, dt.HinhAnh
                      FROM DienThoai dt
                      INNER JOIN HangDienThoai h ON dt.MaHang = h.MaHang",
                    conn);
                DataTable dt = new();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }

        public DataTable TimKiem(string tuKhoa)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlCommand cmd = new(
                    @"SELECT dt.MaDT, dt.TenDT, dt.MaHang, h.TenHang, dt.DonGia, dt.SoLuong,
                             dt.TinhTrang, dt.PhanTram, dt.HinhAnh
                      FROM DienThoai dt
                      INNER JOIN HangDienThoai h ON dt.MaHang = h.MaHang
                      WHERE dt.MaDT LIKE @TuKhoa OR dt.TenDT LIKE @TuKhoa OR h.TenHang LIKE @TuKhoa OR dt.TinhTrang LIKE @TuKhoa",
                    conn);
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                using SqlDataAdapter da = new(cmd);
                DataTable dt = new();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }

        public bool Them(DienThoaiDTO dt)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlCommand cmd = new(
                    @"INSERT INTO DienThoai(TenDT, MaHang, DonGia, SoLuong, TinhTrang, PhanTram, HinhAnh)
                      VALUES(@TenDT, @MaHang, @DonGia, @SoLuong, @TinhTrang, @PhanTram, @HinhAnh)",
                    conn);
                cmd.Parameters.AddWithValue("@TenDT", dt.TenDT);
                cmd.Parameters.AddWithValue("@MaHang", dt.MaHang);
                cmd.Parameters.AddWithValue("@DonGia", dt.DonGia);
                cmd.Parameters.AddWithValue("@SoLuong", dt.SoLuong);
                cmd.Parameters.AddWithValue("@TinhTrang", dt.TinhTrang);
                cmd.Parameters.AddWithValue("@PhanTram", dt.PhanTram);
                cmd.Parameters.AddWithValue("@HinhAnh", dt.HinhAnh);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }

        public bool Sua(DienThoaiDTO dt)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlCommand cmd = new(
                    @"UPDATE DienThoai
                      SET TenDT=@TenDT, MaHang=@MaHang, DonGia=@DonGia, SoLuong=@SoLuong,
                          TinhTrang=@TinhTrang, PhanTram=@PhanTram, HinhAnh=@HinhAnh
                      WHERE MaDT=@MaDT",
                    conn);
                cmd.Parameters.AddWithValue("@MaDT", dt.MaDT);
                cmd.Parameters.AddWithValue("@TenDT", dt.TenDT);
                cmd.Parameters.AddWithValue("@MaHang", dt.MaHang);
                cmd.Parameters.AddWithValue("@DonGia", dt.DonGia);
                cmd.Parameters.AddWithValue("@SoLuong", dt.SoLuong);
                cmd.Parameters.AddWithValue("@TinhTrang", dt.TinhTrang);
                cmd.Parameters.AddWithValue("@PhanTram", dt.PhanTram);
                cmd.Parameters.AddWithValue("@HinhAnh", dt.HinhAnh);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }

        public bool Xoa(int maDT)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlCommand cmd = new("DELETE FROM DienThoai WHERE MaDT=@MaDT", conn);
                cmd.Parameters.AddWithValue("@MaDT", maDT);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }

        public DataTable LayDanhSachBan()
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlDataAdapter da = new(
                    @"SELECT dt.MaDT, dt.TenDT, h.TenHang, dt.DonGia, dt.SoLuong, dt.TinhTrang, dt.PhanTram
                      FROM DienThoai dt
                      INNER JOIN HangDienThoai h ON dt.MaHang = h.MaHang
                      WHERE dt.SoLuong > 0",
                    conn);
                DataTable dt = new();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }
    }
}
