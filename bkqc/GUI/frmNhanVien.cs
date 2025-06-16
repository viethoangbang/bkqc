using bkqc.BLL;
using bkqc.DAL;
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
    public partial class frmNhanVien : Form
    {
        NhanVienBLL bll = new NhanVienBLL();
        bool isAddingNew = false;


        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void SetControlState(bool isEditing)
        {
            txtTenDangNhap.Enabled = !isEditing;
            txtTenNhanVien.Enabled = !isEditing;
            txtMatKhau.Enabled = !isEditing;
            cboVaiTro.Enabled = !isEditing;
            chbxTrangThai.Enabled = !isEditing;

            btnLuu.Enabled = !isEditing;
            btnHuy.Enabled = !isEditing;

            btnThem.Enabled = isEditing;
            btnSua.Enabled = isEditing;
            btnXoa.Enabled = isEditing;
            dgvNhanVien.Enabled = isEditing;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            SetControlState(true);
        }
        public void LoadNhanVien()
        {
            dgvNhanVien.DataSource = bll.GetAll();
            cboVaiTro.Items.Add("QuanLy");
            cboVaiTro.Items.Add("NhanVien");
            cboVaiTro.SelectedIndex = 0;

            ClearInputs();
        }
        private void ClearInputs()
        {
            txtID.Clear();
            txtTenDangNhap.Text = "";
            txtTenNhanVien.Text = "";
            txtMatKhau.Text = "";
            cboVaiTro.SelectedIndex = 0;
            chbxTrangThai.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddingNew = true;
            ClearInputs();
            SetControlState(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                return;
            }
            isAddingNew = false;
            SetControlState(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }
            int maKH = int.Parse(txtID.Text);
            var result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (bll.Delete(maKH))
                {
                    MessageBox.Show("Xóa thành công.");
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Tên nhan vien không được để trống.");
                return;
            }

            NhanVienDTO nv = new NhanVienDTO
            {
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                TenNhanVien = txtTenNhanVien.Text.Trim(),
                MatKhau = txtMatKhau.Text.Trim(),
                VaiTro = cboVaiTro.SelectedItem != null ? cboVaiTro.SelectedItem.ToString() : "NhanVien",
                TrangThai = chbxTrangThai.Checked ? 1 : 0
            };

            bool success = false;

            if (isAddingNew)
            {
                success = bll.Insert(nv);
            }
            else
            {
                nv.MaNhanVien = int.Parse(txtID.Text);
                success = bll.Update(nv);
            }

            if (success)
            {
                MessageBox.Show("Lưu thành công.");
                LoadNhanVien();
                SetControlState(true);
            }
            else
            {
                MessageBox.Show("Lưu thất bại.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
            SetControlState(true);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhanVien.Rows[e.RowIndex].Cells["MaNhanVien"].Value != null)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtID.Text = row.Cells["MaNhanVien"].Value?.ToString();
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value?.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();

                string vaiTro = row.Cells["VaiTro"].Value?.ToString();
                if (!string.IsNullOrEmpty(vaiTro) && cboVaiTro.Items.Contains(vaiTro))
                {
                    cboVaiTro.SelectedItem = vaiTro;
                }
                else
                {
                    cboVaiTro.SelectedIndex = -1; 
                }

                chbxTrangThai.Checked = row.Cells["TrangThai"].Value?.ToString() == "1";
            }
        }

    }
}
