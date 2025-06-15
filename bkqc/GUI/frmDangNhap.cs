using bkqc.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace bkqc.GUI
{
    public partial class frmDangNhap : Form
    {
        NhanVienBLL bll = new NhanVienBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tdn = txtTenDangNhap.Text.Trim();
            string mk = txtMatKhau.Text.Trim();

            if (tdn == "" || mk == "")
            {
                lblThongBao.Text = "Vui lòng nhập đủ thông tin.";
                return;
            }

            var nhanVien = bll.DangNhap(tdn, mk);

            if (nhanVien != null)
            {
                if (nhanVien.VaiTro == "QuanLy")
                {
                    this.Hide();
                    frmMain f = new frmMain();
                    f.Show();
                }
                else if (nhanVien.VaiTro == "NhanVien")
                {
                    this.Hide();
                    frmBanHang f = new frmBanHang();
                    f.Show();
                }
                else
                {
                    lblThongBao.Text = "Vai trò không hợp lệ.";
                }
            }
            else
            {
                lblThongBao.Text = "Sai tài khoản hoặc mật khẩu, hoặc tài khoản đã bị khóa.";
            }
        }

    }
}
