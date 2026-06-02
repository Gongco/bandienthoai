namespace bandienthoai.DAL
{
    public class DBConnect
    {
        protected readonly string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanDienThoai;Integrated Security=True;TrustServerCertificate=True";

        protected static string LoiKetNoi(Exception ex)
        {
            return "Khong ket noi duoc co so du lieu. Hay kiem tra SQL Server va database QLBanDienThoai. Chi tiet: " + ex.Message;
        }
    }
}
