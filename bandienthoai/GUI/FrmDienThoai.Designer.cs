namespace bandienthoai.GUI
{
    partial class FrmDienThoai
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabDienThoai = new TabPage();
            lblThongKe = new Label();
            btnThoat = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            dgvDienThoai = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboHang = new ComboBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            txtTenDT = new TextBox();
            txtMaDT = new TextBox();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            lblHangSX = new Label();
            lblTinhTrang = new Label();
            lblPhanTram = new Label();
            lblHinhAnh = new Label();
            lblTenDT = new Label();
            lblMaDT = new Label();
            cboTinhTrang = new ComboBox();
            numPhanTram = new NumericUpDown();
            picDienThoai = new PictureBox();
            btnChonAnh = new Button();
            tabHang = new TabPage();
            dgvHang = new DataGridView();
            btnLamMoiHang = new Button();
            btnXoaHang = new Button();
            btnSuaHang = new Button();
            btnThemHang = new Button();
            txtTenHang = new TextBox();
            txtMaHang = new TextBox();
            lblTenHang = new Label();
            lblMaHang = new Label();
            tabBanHang = new TabPage();
            btnBanHang = new Button();
            lblTongTienBan = new Label();
            lblTonKhoBan = new Label();
            lblDonGiaBan = new Label();
            numSoLuongBan = new NumericUpDown();
            txtKhachHang = new TextBox();
            cboDienThoaiBan = new ComboBox();
            lblSoLuongBan = new Label();
            lblKhachHang = new Label();
            lblDienThoaiBan = new Label();
            tabHoaDon = new TabPage();
            dgvHoaDon = new DataGridView();
            lblTitle = new Label();
            tabMain.SuspendLayout();
            tabDienThoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDienThoai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPhanTram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDienThoai).BeginInit();
            tabHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHang).BeginInit();
            tabBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            tabHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabDienThoai);
            tabMain.Controls.Add(tabHang);
            tabMain.Controls.Add(tabBanHang);
            tabMain.Controls.Add(tabHoaDon);
            tabMain.Location = new Point(20, 62);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(860, 548);
            tabMain.TabIndex = 0;
            // 
            // tabDienThoai
            // 
            tabDienThoai.Controls.Add(lblThongKe);
            tabDienThoai.Controls.Add(btnThoat);
            tabDienThoai.Controls.Add(btnTimKiem);
            tabDienThoai.Controls.Add(txtTimKiem);
            tabDienThoai.Controls.Add(lblTimKiem);
            tabDienThoai.Controls.Add(dgvDienThoai);
            tabDienThoai.Controls.Add(btnLamMoi);
            tabDienThoai.Controls.Add(btnXoa);
            tabDienThoai.Controls.Add(btnSua);
            tabDienThoai.Controls.Add(btnThem);
            tabDienThoai.Controls.Add(cboHang);
            tabDienThoai.Controls.Add(cboTinhTrang);
            tabDienThoai.Controls.Add(numPhanTram);
            tabDienThoai.Controls.Add(picDienThoai);
            tabDienThoai.Controls.Add(btnChonAnh);
            tabDienThoai.Controls.Add(txtSoLuong);
            tabDienThoai.Controls.Add(txtDonGia);
            tabDienThoai.Controls.Add(txtTenDT);
            tabDienThoai.Controls.Add(txtMaDT);
            tabDienThoai.Controls.Add(lblSoLuong);
            tabDienThoai.Controls.Add(lblDonGia);
            tabDienThoai.Controls.Add(lblHangSX);
            tabDienThoai.Controls.Add(lblTinhTrang);
            tabDienThoai.Controls.Add(lblPhanTram);
            tabDienThoai.Controls.Add(lblHinhAnh);
            tabDienThoai.Controls.Add(lblTenDT);
            tabDienThoai.Controls.Add(lblMaDT);
            tabDienThoai.Location = new Point(4, 24);
            tabDienThoai.Name = "tabDienThoai";
            tabDienThoai.Padding = new Padding(3);
            tabDienThoai.Size = new Size(852, 520);
            tabDienThoai.TabIndex = 0;
            tabDienThoai.Text = "Dien thoai";
            tabDienThoai.UseVisualStyleBackColor = true;
            // 
            // lblThongKe
            // 
            lblThongKe.AutoSize = true;
            lblThongKe.Location = new Point(25, 491);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(235, 15);
            lblThongKe.TabIndex = 19;
            lblThongKe.Text = "Tong mau: 0 | Tong ton: 0 | Gia tri ton: 0";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(477, 170);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(90, 32);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(588, 218);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(90, 32);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tim";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(120, 222);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(445, 23);
            txtTimKiem.TabIndex = 9;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(25, 225);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(58, 15);
            lblTimKiem.TabIndex = 16;
            lblTimKiem.Text = "Tim kiem";
            // 
            // dgvDienThoai
            // 
            dgvDienThoai.AllowUserToAddRows = false;
            dgvDienThoai.AllowUserToDeleteRows = false;
            dgvDienThoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDienThoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDienThoai.Location = new Point(25, 265);
            dgvDienThoai.MultiSelect = false;
            dgvDienThoai.Name = "dgvDienThoai";
            dgvDienThoai.ReadOnly = true;
            dgvDienThoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDienThoai.Size = new Size(800, 213);
            dgvDienThoai.TabIndex = 11;
            dgvDienThoai.CellClick += dgvDienThoai_CellClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(363, 170);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 32);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Lam moi";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(249, 170);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 32);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(135, 170);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 32);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 170);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 32);
            btnThem.TabIndex = 4;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboHang
            // 
            cboHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHang.FormattingEnabled = true;
            cboHang.Location = new Point(120, 92);
            cboHang.Name = "cboHang";
            cboHang.Size = new Size(230, 23);
            cboHang.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(505, 92);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(120, 23);
            txtSoLuong.TabIndex = 3;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(505, 52);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(120, 23);
            txtDonGia.TabIndex = 2;
            // 
            // txtTenDT
            // 
            txtTenDT.Location = new Point(120, 52);
            txtTenDT.Name = "txtTenDT";
            txtTenDT.Size = new Size(230, 23);
            txtTenDT.TabIndex = 0;
            // 
            // txtMaDT
            // 
            txtMaDT.Location = new Point(120, 15);
            txtMaDT.Name = "txtMaDT";
            txtMaDT.ReadOnly = true;
            txtMaDT.Size = new Size(230, 23);
            txtMaDT.TabIndex = 9;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(410, 95);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(53, 15);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "So luong";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(410, 55);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(49, 15);
            lblDonGia.TabIndex = 3;
            lblDonGia.Text = "Don gia";
            // 
            // lblHangSX
            // 
            lblHangSX.AutoSize = true;
            lblHangSX.Location = new Point(25, 95);
            lblHangSX.Name = "lblHangSX";
            lblHangSX.Size = new Size(51, 15);
            lblHangSX.TabIndex = 2;
            lblHangSX.Text = "Hang SX";
            // 
            // lblTenDT
            // 
            lblTenDT.AutoSize = true;
            lblTenDT.Location = new Point(25, 55);
            lblTenDT.Name = "lblTenDT";
            lblTenDT.Size = new Size(79, 15);
            lblTenDT.TabIndex = 1;
            lblTenDT.Text = "Ten dien thoai";
            // 
            // lblMaDT
            // 
            lblMaDT.AutoSize = true;
            lblMaDT.Location = new Point(25, 18);
            lblMaDT.Name = "lblMaDT";
            lblMaDT.Size = new Size(41, 15);
            lblMaDT.TabIndex = 0;
            lblMaDT.Text = "Ma DT";
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location = new Point(25, 132);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(61, 15);
            lblTinhTrang.TabIndex = 20;
            lblTinhTrang.Text = "Tinh trang";
            // 
            // lblPhanTram
            // 
            lblPhanTram.AutoSize = true;
            lblPhanTram.Location = new Point(410, 132);
            lblPhanTram.Name = "lblPhanTram";
            lblPhanTram.Size = new Size(72, 15);
            lblPhanTram.TabIndex = 21;
            lblPhanTram.Text = "Phan tram %";
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Location = new Point(660, 18);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(53, 15);
            lblHinhAnh.TabIndex = 22;
            lblHinhAnh.Text = "Hinh anh";
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Items.AddRange(new object[] { "Moi", "Cu" });
            cboTinhTrang.Location = new Point(120, 129);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(230, 23);
            cboTinhTrang.TabIndex = 4;
            cboTinhTrang.SelectedIndex = 0;
            cboTinhTrang.SelectedIndexChanged += cboTinhTrang_SelectedIndexChanged;
            // 
            // numPhanTram
            // 
            numPhanTram.Location = new Point(505, 129);
            numPhanTram.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPhanTram.Name = "numPhanTram";
            numPhanTram.Size = new Size(120, 23);
            numPhanTram.TabIndex = 5;
            numPhanTram.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // picDienThoai
            // 
            picDienThoai.BorderStyle = BorderStyle.FixedSingle;
            picDienThoai.Location = new Point(660, 38);
            picDienThoai.Name = "picDienThoai";
            picDienThoai.Size = new Size(155, 110);
            picDienThoai.SizeMode = PictureBoxSizeMode.Zoom;
            picDienThoai.TabIndex = 23;
            picDienThoai.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(660, 154);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(155, 32);
            btnChonAnh.TabIndex = 6;
            btnChonAnh.Text = "Chon anh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // tabHang
            // 
            tabHang.Controls.Add(dgvHang);
            tabHang.Controls.Add(btnLamMoiHang);
            tabHang.Controls.Add(btnXoaHang);
            tabHang.Controls.Add(btnSuaHang);
            tabHang.Controls.Add(btnThemHang);
            tabHang.Controls.Add(txtTenHang);
            tabHang.Controls.Add(txtMaHang);
            tabHang.Controls.Add(lblTenHang);
            tabHang.Controls.Add(lblMaHang);
            tabHang.Location = new Point(4, 24);
            tabHang.Name = "tabHang";
            tabHang.Padding = new Padding(3);
            tabHang.Size = new Size(852, 520);
            tabHang.TabIndex = 1;
            tabHang.Text = "Hang";
            tabHang.UseVisualStyleBackColor = true;
            // 
            // dgvHang
            // 
            dgvHang.AllowUserToAddRows = false;
            dgvHang.AllowUserToDeleteRows = false;
            dgvHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHang.Location = new Point(25, 150);
            dgvHang.MultiSelect = false;
            dgvHang.Name = "dgvHang";
            dgvHang.ReadOnly = true;
            dgvHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHang.Size = new Size(510, 300);
            dgvHang.TabIndex = 8;
            dgvHang.CellClick += dgvHang_CellClick;
            // 
            // btnLamMoiHang
            // 
            btnLamMoiHang.Location = new Point(366, 95);
            btnLamMoiHang.Name = "btnLamMoiHang";
            btnLamMoiHang.Size = new Size(90, 32);
            btnLamMoiHang.TabIndex = 5;
            btnLamMoiHang.Text = "Lam moi";
            btnLamMoiHang.UseVisualStyleBackColor = true;
            btnLamMoiHang.Click += btnLamMoiHang_Click;
            // 
            // btnXoaHang
            // 
            btnXoaHang.Location = new Point(252, 95);
            btnXoaHang.Name = "btnXoaHang";
            btnXoaHang.Size = new Size(90, 32);
            btnXoaHang.TabIndex = 4;
            btnXoaHang.Text = "Xoa";
            btnXoaHang.UseVisualStyleBackColor = true;
            btnXoaHang.Click += btnXoaHang_Click;
            // 
            // btnSuaHang
            // 
            btnSuaHang.Location = new Point(138, 95);
            btnSuaHang.Name = "btnSuaHang";
            btnSuaHang.Size = new Size(90, 32);
            btnSuaHang.TabIndex = 3;
            btnSuaHang.Text = "Sua";
            btnSuaHang.UseVisualStyleBackColor = true;
            btnSuaHang.Click += btnSuaHang_Click;
            // 
            // btnThemHang
            // 
            btnThemHang.Location = new Point(25, 95);
            btnThemHang.Name = "btnThemHang";
            btnThemHang.Size = new Size(90, 32);
            btnThemHang.TabIndex = 2;
            btnThemHang.Text = "Them";
            btnThemHang.UseVisualStyleBackColor = true;
            btnThemHang.Click += btnThemHang_Click;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(115, 55);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(250, 23);
            txtTenHang.TabIndex = 1;
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(115, 18);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.ReadOnly = true;
            txtMaHang.Size = new Size(250, 23);
            txtMaHang.TabIndex = 3;
            // 
            // lblTenHang
            // 
            lblTenHang.AutoSize = true;
            lblTenHang.Location = new Point(25, 58);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(56, 15);
            lblTenHang.TabIndex = 1;
            lblTenHang.Text = "Ten hang";
            // 
            // lblMaHang
            // 
            lblMaHang.AutoSize = true;
            lblMaHang.Location = new Point(25, 21);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(54, 15);
            lblMaHang.TabIndex = 0;
            lblMaHang.Text = "Ma hang";
            // 
            // tabBanHang
            // 
            tabBanHang.Controls.Add(btnBanHang);
            tabBanHang.Controls.Add(lblTongTienBan);
            tabBanHang.Controls.Add(lblTonKhoBan);
            tabBanHang.Controls.Add(lblDonGiaBan);
            tabBanHang.Controls.Add(numSoLuongBan);
            tabBanHang.Controls.Add(txtKhachHang);
            tabBanHang.Controls.Add(cboDienThoaiBan);
            tabBanHang.Controls.Add(lblSoLuongBan);
            tabBanHang.Controls.Add(lblKhachHang);
            tabBanHang.Controls.Add(lblDienThoaiBan);
            tabBanHang.Location = new Point(4, 24);
            tabBanHang.Name = "tabBanHang";
            tabBanHang.Padding = new Padding(3);
            tabBanHang.Size = new Size(852, 520);
            tabBanHang.TabIndex = 2;
            tabBanHang.Text = "Ban hang";
            tabBanHang.UseVisualStyleBackColor = true;
            // 
            // btnBanHang
            // 
            btnBanHang.Location = new Point(120, 190);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(110, 35);
            btnBanHang.TabIndex = 3;
            btnBanHang.Text = "Lap hoa don";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // lblTongTienBan
            // 
            lblTongTienBan.AutoSize = true;
            lblTongTienBan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongTienBan.Location = new Point(120, 145);
            lblTongTienBan.Name = "lblTongTienBan";
            lblTongTienBan.Size = new Size(89, 20);
            lblTongTienBan.TabIndex = 8;
            lblTongTienBan.Text = "Tong tien: 0";
            // 
            // lblTonKhoBan
            // 
            lblTonKhoBan.AutoSize = true;
            lblTonKhoBan.Location = new Point(390, 62);
            lblTonKhoBan.Name = "lblTonKhoBan";
            lblTonKhoBan.Size = new Size(58, 15);
            lblTonKhoBan.TabIndex = 7;
            lblTonKhoBan.Text = "Ton kho: 0";
            // 
            // lblDonGiaBan
            // 
            lblDonGiaBan.AutoSize = true;
            lblDonGiaBan.Location = new Point(390, 25);
            lblDonGiaBan.Name = "lblDonGiaBan";
            lblDonGiaBan.Size = new Size(58, 15);
            lblDonGiaBan.TabIndex = 6;
            lblDonGiaBan.Text = "Don gia: 0";
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(120, 97);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(230, 23);
            numSoLuongBan.TabIndex = 2;
            numSoLuongBan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuongBan.ValueChanged += numSoLuongBan_ValueChanged;
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(120, 59);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(230, 23);
            txtKhachHang.TabIndex = 1;
            // 
            // cboDienThoaiBan
            // 
            cboDienThoaiBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDienThoaiBan.FormattingEnabled = true;
            cboDienThoaiBan.Location = new Point(120, 22);
            cboDienThoaiBan.Name = "cboDienThoaiBan";
            cboDienThoaiBan.Size = new Size(230, 23);
            cboDienThoaiBan.TabIndex = 0;
            cboDienThoaiBan.SelectedIndexChanged += cboDienThoaiBan_SelectedIndexChanged;
            // 
            // lblSoLuongBan
            // 
            lblSoLuongBan.AutoSize = true;
            lblSoLuongBan.Location = new Point(25, 99);
            lblSoLuongBan.Name = "lblSoLuongBan";
            lblSoLuongBan.Size = new Size(53, 15);
            lblSoLuongBan.TabIndex = 2;
            lblSoLuongBan.Text = "So luong";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(25, 62);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(69, 15);
            lblKhachHang.TabIndex = 1;
            lblKhachHang.Text = "Khach hang";
            // 
            // lblDienThoaiBan
            // 
            lblDienThoaiBan.AutoSize = true;
            lblDienThoaiBan.Location = new Point(25, 25);
            lblDienThoaiBan.Name = "lblDienThoaiBan";
            lblDienThoaiBan.Size = new Size(59, 15);
            lblDienThoaiBan.TabIndex = 0;
            lblDienThoaiBan.Text = "Dien thoai";
            // 
            // tabHoaDon
            // 
            tabHoaDon.Controls.Add(dgvHoaDon);
            tabHoaDon.Location = new Point(4, 24);
            tabHoaDon.Name = "tabHoaDon";
            tabHoaDon.Padding = new Padding(3);
            tabHoaDon.Size = new Size(852, 520);
            tabHoaDon.TabIndex = 3;
            tabHoaDon.Text = "Hoa don";
            tabHoaDon.UseVisualStyleBackColor = true;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(20, 20);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(810, 470);
            dgvHoaDon.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(271, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(316, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "QUAN LY BAN DIEN THOAI";
            // 
            // FrmDienThoai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 630);
            Controls.Add(lblTitle);
            Controls.Add(tabMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDienThoai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quan ly ban dien thoai";
            Load += FrmDienThoai_Load;
            tabMain.ResumeLayout(false);
            tabDienThoai.ResumeLayout(false);
            tabDienThoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDienThoai).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPhanTram).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDienThoai).EndInit();
            tabHang.ResumeLayout(false);
            tabHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHang).EndInit();
            tabBanHang.ResumeLayout(false);
            tabBanHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            tabHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabDienThoai;
        private TabPage tabHang;
        private TabPage tabBanHang;
        private TabPage tabHoaDon;
        private Label lblTitle;
        private Label lblMaDT;
        private Label lblTenDT;
        private Label lblHangSX;
        private Label lblTinhTrang;
        private Label lblPhanTram;
        private Label lblHinhAnh;
        private Label lblDonGia;
        private Label lblSoLuong;
        private TextBox txtMaDT;
        private TextBox txtTenDT;
        private ComboBox cboHang;
        private ComboBox cboTinhTrang;
        private NumericUpDown numPhanTram;
        private PictureBox picDienThoai;
        private Button btnChonAnh;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvDienThoai;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnThoat;
        private Label lblThongKe;
        private Label lblMaHang;
        private Label lblTenHang;
        private TextBox txtMaHang;
        private TextBox txtTenHang;
        private Button btnThemHang;
        private Button btnSuaHang;
        private Button btnXoaHang;
        private Button btnLamMoiHang;
        private DataGridView dgvHang;
        private Label lblDienThoaiBan;
        private Label lblKhachHang;
        private Label lblSoLuongBan;
        private ComboBox cboDienThoaiBan;
        private TextBox txtKhachHang;
        private NumericUpDown numSoLuongBan;
        private Label lblDonGiaBan;
        private Label lblTonKhoBan;
        private Label lblTongTienBan;
        private Button btnBanHang;
        private DataGridView dgvHoaDon;
    }
}
