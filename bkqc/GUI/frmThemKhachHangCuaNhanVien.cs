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

namespace bkqc.GUI
{
    public partial class frmThemKhachHangCuaNhanVien : Form
    {
        KhachHangBLL bll = new KhachHangBLL();
        public frmThemKhachHangCuaNhanVien()
        {
            InitializeComponent();
        }
        public void ClearInputs()
        {
            txtSoDienThoai.Clear();
            txtTenKhachHang.Clear();
        }
        private void frmThemKhachHangCuaNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO
            {
                TenKhachHang = txtTenKhachHang.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                NgayDangKy = DateTime.Now
            };
            if (string.IsNullOrEmpty(kh.TenKhachHang) || string.IsNullOrEmpty(kh.SoDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
            }
            else
            {
                if (bll.Insert(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công.");
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại. Vui lòng thử lại.");
                }
            }
        }
    }
}
