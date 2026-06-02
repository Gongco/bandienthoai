using bandienthoai.GUI;

namespace bandienthoai
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using FrmDangNhap dangNhap = new();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmDienThoai());
            }
        }
    }
}
