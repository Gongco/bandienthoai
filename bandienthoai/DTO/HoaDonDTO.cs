namespace bandienthoai.DTO
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public DateTime NgayBan { get; set; } = DateTime.Now;
        public string KhachHang { get; set; } = string.Empty;
        public decimal TongTien { get; set; }
    }
}
