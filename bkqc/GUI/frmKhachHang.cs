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
    public partial class frmKhachHang : Form
    {
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        bool isAddingNew = false;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            SetControlState(true);
        }
        private void LoadKhachHang()
        {
            dgvKhachHang.DataSource = khachHangBLL.GetAll();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            dtpNgayDangKy.Value = DateTime.Now;
        }
        private void SetControlState(bool isEditing)
        {
            txtTenKhachHang.Enabled = !isEditing;
            txtSoDienThoai.Enabled = !isEditing;
            dtpNgayDangKy.Enabled = !isEditing;

            btnLuu.Enabled = !isEditing;
            btnHuy.Enabled = !isEditing;

            btnThem.Enabled = isEditing;
            btnSua.Enabled = isEditing;
            btnXoa.Enabled = isEditing;
            dgvKhachHang.Enabled = isEditing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddingNew = true;
            ClearInputs();
            SetControlState(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                return;
            }
            isAddingNew = false;
            SetControlState(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }
            int maKH = int.Parse(txtMaKhachHang.Text);
            var result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (khachHangBLL.Delete(maKH))
                {
                    MessageBox.Show("Xóa thành công.");
                    LoadKhachHang();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKhachHang.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống.");
                return;
            }

            KhachHangDTO kh = new KhachHangDTO
            {
                TenKhachHang = txtTenKhachHang.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                NgayDangKy = dtpNgayDangKy.Value
            };

            bool success = false;

            if (isAddingNew)
            {
                success = khachHangBLL.Insert(kh);
            }
            else
            {
                kh.MaKhachHang = int.Parse(txtMaKhachHang.Text);
                success = khachHangBLL.Update(kh);
            }

            if (success)
            {
                MessageBox.Show("Lưu thành công.");
                LoadKhachHang();
                SetControlState(true);
            }
            else
            {
                MessageBox.Show("Lưu thất bại.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
            SetControlState(true);
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                var row = dgvKhachHang.CurrentRow;
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                DateTime ngayDK;
                if (DateTime.TryParse(row.Cells["NgayDangKy"].Value?.ToString(), out ngayDK))
                    dtpNgayDangKy.Value = ngayDK;
                else
                    dtpNgayDangKy.Value = DateTime.Now;
            }
        }
    }
}
