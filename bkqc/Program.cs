using bkqc.BLL;
using bkqc.DAL;
using bkqc.DTO;
using bkqc.GUI;
using System.Windows.Forms;

namespace bkqc
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NhanVienBLL bll = new NhanVienBLL();

            if (bll.DangNhap("admin", "admin") == null)
            {
                bll.Insert(new NhanVienDTO
                {
                    TenNhanVien = "admin",
                    TenDangNhap = "admin",
                    MatKhau = "admin",
                    VaiTro = "QuanLy",
                    TrangThai = 1
                });
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmDangNhap());
        }
    }
}