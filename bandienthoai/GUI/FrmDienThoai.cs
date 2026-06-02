using System.Data;
using bandienthoai.BUS;
using bandienthoai.DTO;

namespace bandienthoai.GUI
{
    public partial class FrmDienThoai : Form
    {
        private readonly DienThoaiBUS dienThoaiBUS = new();
        private readonly HangDienThoaiBUS hangBUS = new();
        private readonly HoaDonBUS hoaDonBUS = new();

        private decimal donGiaDangChon = 0;
        private string hinhAnhDangChon = string.Empty;

        public FrmDienThoai()
        {
            InitializeComponent();
        }

        private void FrmDienThoai_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            HienThiHang();
            HienThiDienThoai();
            HienThiDienThoaiBan();
            HienThiHoaDon();
        }

        private void HienThiDienThoai()
        {
            dgvDienThoai.DataSource = dienThoaiBUS.LayDanhSach();
            DinhDangLuoiDienThoai();
            HienThiAnhTrongBang();
            TinhThongKeTonKho();
        }

        private void DinhDangLuoiDienThoai()
        {
            if (dgvDienThoai.Columns.Count == 0)
            {
                return;
            }

            dgvDienThoai.Columns["MaDT"].HeaderText = "Ma DT";
            dgvDienThoai.Columns["TenDT"].HeaderText = "Ten dien thoai";
            dgvDienThoai.Columns["MaHang"].Visible = false;
            dgvDienThoai.Columns["TenHang"].HeaderText = "Hang";
            dgvDienThoai.Columns["DonGia"].HeaderText = "Don gia";
            dgvDienThoai.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvDienThoai.Columns["SoLuong"].HeaderText = "So luong";
            dgvDienThoai.Columns["TinhTrang"].HeaderText = "Tinh trang";
            dgvDienThoai.Columns["PhanTram"].HeaderText = "%";
            dgvDienThoai.Columns["HinhAnh"].Visible = false;
        }

        private void HienThiAnhTrongBang()
        {
            if (!dgvDienThoai.Columns.Contains("Anh"))
            {
                DataGridViewImageColumn colAnh = new()
                {
                    Name = "Anh",
                    HeaderText = "Anh",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 80
                };

                dgvDienThoai.Columns.Insert(0, colAnh);
            }

            dgvDienThoai.RowTemplate.Height = 60;

            foreach (DataGridViewRow row in dgvDienThoai.Rows)
            {
                string duongDan = row.Cells["HinhAnh"].Value?.ToString() ?? string.Empty;
                row.Cells["Anh"].Value = TaoAnhChoBang(duongDan);
            }
        }

        private static Image? TaoAnhChoBang(string duongDan)
        {
            if (string.IsNullOrWhiteSpace(duongDan) || !File.Exists(duongDan))
            {
                return null;
            }

            using FileStream fs = new(duongDan, FileMode.Open, FileAccess.Read);
            using Image anhGoc = Image.FromStream(fs);
            return new Bitmap(anhGoc, new Size(60, 50));
        }

        private void HienThiHang()
        {
            DataTable dtHang = hangBUS.LayDanhSach();
            dgvHang.DataSource = dtHang.Copy();

            cboHang.DataSource = dtHang.Copy();
            cboHang.DisplayMember = "TenHang";
            cboHang.ValueMember = "MaHang";

            if (dgvHang.Columns.Count > 0)
            {
                dgvHang.Columns["MaHang"].HeaderText = "Ma hang";
                dgvHang.Columns["TenHang"].HeaderText = "Ten hang";
            }
        }

        private void HienThiDienThoaiBan()
        {
            DataTable dtBan = dienThoaiBUS.LayDanhSachBan();
            cboDienThoaiBan.DataSource = dtBan;
            cboDienThoaiBan.DisplayMember = "TenDT";
            cboDienThoaiBan.ValueMember = "MaDT";
            CapNhatThongTinBan();
        }

        private void HienThiHoaDon()
        {
            dgvHoaDon.DataSource = hoaDonBUS.LayDanhSach();

            if (dgvHoaDon.Columns.Count == 0)
            {
                return;
            }

            dgvHoaDon.Columns["MaHD"].HeaderText = "Ma HD";
            dgvHoaDon.Columns["NgayBan"].HeaderText = "Ngay ban";
            dgvHoaDon.Columns["KhachHang"].HeaderText = "Khach hang";
            dgvHoaDon.Columns["TenDT"].HeaderText = "Dien thoai";
            dgvHoaDon.Columns["SoLuong"].HeaderText = "So luong";
            dgvHoaDon.Columns["DonGia"].HeaderText = "Don gia";
            dgvHoaDon.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvHoaDon.Columns["TongTien"].HeaderText = "Tong tien";
            dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";
        }

        private DienThoaiDTO LayDienThoaiTuForm()
        {
            int.TryParse(txtMaDT.Text, out int maDT);

            if (cboHang.SelectedValue == null || cboHang.SelectedValue is DataRowView)
            {
                throw new ArgumentException("Vui long chon hang san xuat.");
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                throw new ArgumentException("Don gia phai la so.");
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                throw new ArgumentException("So luong phai la so nguyen.");
            }

            return new DienThoaiDTO
            {
                MaDT = maDT,
                TenDT = txtTenDT.Text.Trim(),
                MaHang = Convert.ToInt32(cboHang.SelectedValue),
                DonGia = donGia,
                SoLuong = soLuong,
                TinhTrang = cboTinhTrang.SelectedItem?.ToString() == "Cu" ? "Cu" : "Moi",
                PhanTram = (int)numPhanTram.Value,
                HinhAnh = hinhAnhDangChon
            };
        }

        private HangDienThoaiDTO LayHangTuForm()
        {
            int.TryParse(txtMaHang.Text, out int maHang);

            return new HangDienThoaiDTO
            {
                MaHang = maHang,
                TenHang = txtTenHang.Text.Trim()
            };
        }

        private void XoaFormDienThoai()
        {
            txtMaDT.Clear();
            txtTenDT.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtTimKiem.Clear();
            hinhAnhDangChon = string.Empty;
            picDienThoai.Image = null;
            if (cboHang.Items.Count > 0)
            {
                cboHang.SelectedIndex = 0;
            }
            cboTinhTrang.SelectedIndex = 0;
            numPhanTram.Value = 100;
            txtTenDT.Focus();
        }

        private void XoaFormHang()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtTenHang.Focus();
        }

        private void TinhThongKeTonKho()
        {
            DataTable? dt = dgvDienThoai.DataSource as DataTable;
            if (dt == null)
            {
                lblThongKe.Text = "Tong mau: 0 | Tong ton: 0 | Gia tri ton: 0";
                return;
            }

            int tongMau = dt.Rows.Count;
            int tongTon = 0;
            decimal giaTriTon = 0;

            foreach (DataRow row in dt.Rows)
            {
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                decimal donGia = Convert.ToDecimal(row["DonGia"]);
                tongTon += soLuong;
                giaTriTon += soLuong * donGia;
            }

            lblThongKe.Text = $"Tong mau: {tongMau} | Tong ton: {tongTon} | Gia tri ton: {giaTriTon:N0}";
        }

        private void CapNhatThongTinBan()
        {
            if (cboDienThoaiBan.SelectedItem is not DataRowView row)
            {
                lblDonGiaBan.Text = "Don gia: 0";
                lblTonKhoBan.Text = "Ton kho: 0";
                lblTongTienBan.Text = "Tong tien: 0";
                donGiaDangChon = 0;
                return;
            }

            donGiaDangChon = Convert.ToDecimal(row["DonGia"]);
            int tonKho = Convert.ToInt32(row["SoLuong"]);
            int soLuongBan = (int)numSoLuongBan.Value;

            lblDonGiaBan.Text = $"Don gia: {donGiaDangChon:N0}";
            lblTonKhoBan.Text = $"Ton kho: {tonKho}";
            lblTongTienBan.Text = $"Tong tien: {(donGiaDangChon * soLuongBan):N0}";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dienThoaiBUS.Them(LayDienThoaiTuForm());
                TaiDuLieu();
                XoaFormDienThoai();
                MessageBox.Show("Them thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dienThoaiBUS.Sua(LayDienThoaiTuForm());
                TaiDuLieu();
                XoaFormDienThoai();
                MessageBox.Show("Sua thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtMaDT.Text, out int maDT);
                DialogResult result = MessageBox.Show("Ban co muon xoa dien thoai nay?", "Xac nhan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dienThoaiBUS.Xoa(maDT);
                    TaiDuLieu();
                    XoaFormDienThoai();
                    MessageBox.Show("Xoa thanh cong.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaFormDienThoai();
            HienThiDienThoai();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDienThoai.DataSource = dienThoaiBUS.TimKiem(txtTimKiem.Text);
                DinhDangLuoiDienThoai();
                HienThiAnhTrongBang();
                TinhThongKeTonKho();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDienThoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvDienThoai.Rows[e.RowIndex];
            txtMaDT.Text = row.Cells["MaDT"].Value?.ToString();
            txtTenDT.Text = row.Cells["TenDT"].Value?.ToString();
            cboHang.SelectedValue = Convert.ToInt32(row.Cells["MaHang"].Value);
            txtDonGia.Text = Convert.ToDecimal(row.Cells["DonGia"].Value).ToString("0");
            txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();
            cboTinhTrang.SelectedItem = row.Cells["TinhTrang"].Value?.ToString() == "Cu" ? "Cu" : "Moi";
            numPhanTram.Value = Convert.ToInt32(row.Cells["PhanTram"].Value);
            hinhAnhDangChon = row.Cells["HinhAnh"].Value?.ToString() ?? string.Empty;
            HienThiHinhAnh(hinhAnhDangChon);
        }

        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool laMayCu = cboTinhTrang.SelectedItem?.ToString() == "Cu";
            numPhanTram.Enabled = laMayCu;

            if (!laMayCu)
            {
                numPhanTram.Value = 100;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dlg = new();
            dlg.Filter = "Hinh anh|*.jpg;*.jpeg;*.png;*.bmp|Tat ca file|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                hinhAnhDangChon = dlg.FileName;
                HienThiHinhAnh(hinhAnhDangChon);
            }
        }

        private void HienThiHinhAnh(string duongDan)
        {
            picDienThoai.Image = null;

            if (string.IsNullOrWhiteSpace(duongDan) || !File.Exists(duongDan))
            {
                return;
            }

            using FileStream fs = new(duongDan, FileMode.Open, FileAccess.Read);
            picDienThoai.Image = Image.FromStream(fs);
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            try
            {
                hangBUS.Them(LayHangTuForm());
                HienThiHang();
                HienThiDienThoai();
                XoaFormHang();
                MessageBox.Show("Them hang thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            try
            {
                hangBUS.Sua(LayHangTuForm());
                HienThiHang();
                HienThiDienThoai();
                XoaFormHang();
                MessageBox.Show("Sua hang thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtMaHang.Text, out int maHang);
                DialogResult result = MessageBox.Show("Ban co muon xoa hang nay?", "Xac nhan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    hangBUS.Xoa(maHang);
                    HienThiHang();
                    XoaFormHang();
                    MessageBox.Show("Xoa hang thanh cong.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoiHang_Click(object sender, EventArgs e)
        {
            XoaFormHang();
            HienThiHang();
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvHang.Rows[e.RowIndex];
            txtMaHang.Text = row.Cells["MaHang"].Value?.ToString();
            txtTenHang.Text = row.Cells["TenHang"].Value?.ToString();
        }

        private void cboDienThoaiBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongTinBan();
        }

        private void numSoLuongBan_ValueChanged(object sender, EventArgs e)
        {
            CapNhatThongTinBan();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDienThoaiBan.SelectedValue == null || cboDienThoaiBan.SelectedValue is DataRowView)
                {
                    throw new ArgumentException("Vui long chon dien thoai can ban.");
                }

                int maDT = Convert.ToInt32(cboDienThoaiBan.SelectedValue);
                int soLuongBan = (int)numSoLuongBan.Value;

                hoaDonBUS.BanHang(maDT, txtKhachHang.Text, soLuongBan, donGiaDangChon);
                txtKhachHang.Clear();
                numSoLuongBan.Value = 1;
                TaiDuLieu();
                MessageBox.Show("Ban hang thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
