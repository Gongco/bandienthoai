using System.Data;
using bandienthoai.DAL;
using bandienthoai.DTO;

namespace bandienthoai.BUS
{
    public class DienThoaiBUS
    {
        private readonly DienThoaiDAL dal = new();

        public DataTable LayDanhSach()
        {
            return dal.LayDanhSach();
        }

        public DataTable TimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                return LayDanhSach();
            }

            return dal.TimKiem(tuKhoa.Trim());
        }

        public DataTable LayDanhSachBan()
        {
            return dal.LayDanhSachBan();
        }

        public bool Them(DienThoaiDTO dt)
        {
            KiemTraDuLieu(dt, canMa: false);
            return dal.Them(dt);
        }

        public bool Sua(DienThoaiDTO dt)
        {
            KiemTraDuLieu(dt, canMa: true);
            return dal.Sua(dt);
        }

        public bool Xoa(int maDT)
        {
            if (maDT <= 0)
            {
                throw new ArgumentException("Vui long chon dien thoai can xoa.");
            }

            return dal.Xoa(maDT);
        }

        private static void KiemTraDuLieu(DienThoaiDTO dt, bool canMa)
        {
            if (canMa && dt.MaDT <= 0)
            {
                throw new ArgumentException("Vui long chon dien thoai can sua.");
            }

            if (string.IsNullOrWhiteSpace(dt.TenDT))
            {
                throw new ArgumentException("Ten dien thoai khong duoc de trong.");
            }

            if (dt.MaHang <= 0)
            {
                throw new ArgumentException("Vui long chon hang san xuat.");
            }

            if (dt.DonGia < 0)
            {
                throw new ArgumentException("Don gia phai lon hon hoac bang 0.");
            }

            if (dt.SoLuong < 0)
            {
                throw new ArgumentException("So luong phai lon hon hoac bang 0.");
            }

            if (dt.TinhTrang != "Moi" && dt.TinhTrang != "Cu")
            {
                throw new ArgumentException("Tinh trang chi duoc chon Moi hoac Cu.");
            }

            if (dt.PhanTram < 1 || dt.PhanTram > 100)
            {
                throw new ArgumentException("Phan tram tinh trang phai tu 1 den 100.");
            }

            if (dt.TinhTrang == "Moi" && dt.PhanTram != 100)
            {
                dt.PhanTram = 100;
            }
        }
    }
}
