namespace bandienthoai.DTO
{
    public class DienThoaiDTO
    {
        public int MaDT { get; set; }
        public string TenDT { get; set; } = string.Empty;
        public int MaHang { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public string TinhTrang { get; set; } = "Moi";
        public int PhanTram { get; set; } = 100;
        public string HinhAnh { get; set; } = string.Empty;
    }
}
