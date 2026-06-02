using bandienthoai.BUS;

namespace bandienthoai.GUI
{
    public partial class FrmDangNhap : Form
    {
        private readonly TaiKhoanBUS bus = new();

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Sai ten dang nhap hoac mat khau.");
                }
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
    }
}
