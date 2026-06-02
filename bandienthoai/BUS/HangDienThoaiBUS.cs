using System.Data;
using bandienthoai.DAL;
using bandienthoai.DTO;

namespace bandienthoai.BUS
{
    public class HangDienThoaiBUS
    {
        private readonly HangDienThoaiDAL dal = new();

        public DataTable LayDanhSach()
        {
            return dal.LayDanhSach();
        }

        public bool Them(HangDienThoaiDTO hang)
        {
            KiemTra(hang, canMa: false);
            return dal.Them(hang);
        }

        public bool Sua(HangDienThoaiDTO hang)
        {
            KiemTra(hang, canMa: true);
            return dal.Sua(hang);
        }

        public bool Xoa(int maHang)
        {
            if (maHang <= 0)
            {
                throw new ArgumentException("Vui long chon hang can xoa.");
            }

            return dal.Xoa(maHang);
        }

        private static void KiemTra(HangDienThoaiDTO hang, bool canMa)
        {
            if (canMa && hang.MaHang <= 0)
            {
                throw new ArgumentException("Vui long chon hang can sua.");
            }

            if (string.IsNullOrWhiteSpace(hang.TenHang))
            {
                throw new ArgumentException("Ten hang khong duoc de trong.");
            }
        }
    }
}
