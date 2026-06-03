using System.Data;
using bandienthoai.DTO;
using Microsoft.
    Data.SqlClient;

namespace bandienthoai.DAL
{
    public class HoaDonDAL : DBConnect
    {
        public bool BanHang(HoaDonDTO hoaDon, ChiTietHoaDonDTO chiTiet)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();
                using SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    using SqlCommand cmdTon = new("SELECT SoLuong FROM DienThoai WHERE MaDT=@MaDT", conn, tran);
                    cmdTon.Parameters.AddWithValue("@MaDT", chiTiet.MaDT);
                    object? tonObj = cmdTon.ExecuteScalar();

                    if (tonObj == null)
                    {
                        throw new Exception("Khong tim thay dien thoai can ban.");
                    }

                    int tonKho = Convert.ToInt32(tonObj);
                    if (chiTiet.SoLuong > tonKho)
                    {
                        throw new Exception("So luong ban lon hon so luong ton kho.");
                    }

                    using SqlCommand cmdHD = new(
                        "INSERT INTO HoaDon(NgayBan, KhachHang, TongTien) OUTPUT INSERTED.MaHD VALUES(@NgayBan, @KhachHang, @TongTien)",
                        conn,
                        tran);
                    cmdHD.Parameters.AddWithValue("@NgayBan", hoaDon.NgayBan);
                    cmdHD.Parameters.AddWithValue("@KhachHang", hoaDon.KhachHang);
                    cmdHD.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);
                    int maHD = Convert.ToInt32(cmdHD.ExecuteScalar());

                    using SqlCommand cmdCT = new(
                        "INSERT INTO ChiTietHoaDon(MaHD, MaDT, SoLuong, DonGia) VALUES(@MaHD, @MaDT, @SoLuong, @DonGia)",
                        conn,
                        tran);
                    cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                    cmdCT.Parameters.AddWithValue("@MaDT", chiTiet.MaDT);
                    cmdCT.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                    cmdCT.Parameters.AddWithValue("@DonGia", chiTiet.DonGia);
                    cmdCT.ExecuteNonQuery();

                    using SqlCommand cmdKho = new(
                        "UPDATE DienThoai SET SoLuong = SoLuong - @SoLuong WHERE MaDT=@MaDT",
                        conn,
                        tran);
                    cmdKho.Parameters.AddWithValue("@MaDT", chiTiet.MaDT);
                    cmdKho.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                    cmdKho.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(LoiKetNoi(ex));
            }
        }

        public DataTable LayDanhSach()
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                using SqlDataAdapter da = new(
                    @"SELECT hd.MaHD, hd.NgayBan, hd.KhachHang, dt.TenDT, ct.SoLuong, ct.DonGia, hd.TongTien
                      FROM HoaDon hd
                      INNER JOIN ChiTietHoaDon ct ON hd.MaHD = ct.MaHD
                      INNER JOIN DienThoai dt ON ct.MaDT = dt.MaDT
                      ORDER BY hd.MaHD DESC",
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
