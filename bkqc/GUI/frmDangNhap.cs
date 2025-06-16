using bkqc.BLL;
using bkqc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
namespace bkqc.GUI
{
    public partial class frmDangNhap : Form
    {
        NhanVienBLL bll = new NhanVienBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }
        public void ClearInput()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
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
                PhienDangNhap.TenDangNhap = nhanVien.TenDangNhap;
                PhienDangNhap.MaNhanVien = nhanVien.MaNhanVien;
                PhienDangNhap.VaiTro = nhanVien.VaiTro;
                if (nhanVien.VaiTro == "QuanLy")
                {
                    this.Hide(); 
                    frmMain f = new frmMain();
                    f.FormClosed += (s, args) => this.Show(); 
                    f.Show();
                }
                else if (nhanVien.VaiTro == "NhanVien")
                {
                    this.Hide();
                    frmBanHang f = new frmBanHang();
                    f.FormClosed += (s, args) => this.Show();
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
            ClearInput();
        }

    }
}
