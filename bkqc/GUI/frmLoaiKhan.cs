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
    public partial class frmLoaiKhan : Form
    {
        LoaiKhanBLL bll = new LoaiKhanBLL();
        bool isAddingNew = false;
        private void LoadData()
        {
            dgvLoaiKhan.DataSource = bll.GetAll();
            ClearInput();
        }
        private void SetControlState(bool isEditing)
        {
            txtTenLoai.Enabled = !isEditing;
            txtID.Enabled = !isEditing;

            btnLuu.Enabled = !isEditing;
            btnHuy.Enabled = !isEditing;

            btnThem.Enabled = isEditing;
            btnSua.Enabled = isEditing;
            btnXoa.Enabled = isEditing;
            dgvLoaiKhan.Enabled = isEditing;
        }
        public frmLoaiKhan()
        {
            InitializeComponent();
        }

        private void frmLoaiKhan_Load(object sender, EventArgs e)
        {
            LoadData();
            SetControlState(true);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddingNew = true;
            ClearInput();
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
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }
        private void ClearInput()
        {
            txtTenLoai.Clear();
            txtTenLoai.Focus();
            txtID.Clear();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn loại khăn cần sửa.");
                return;
            }
            isAddingNew = false;
            SetControlState(false);
        }

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLoaiKhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLoaiKhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiKhan.Rows[e.RowIndex];

                txtTenLoai.Text = row.Cells["TenLoai"].Value?.ToString();
                txtID.Text = row.Cells["MaLoaiKhan"].Value?.ToString();

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show("Tên loại khăn không được để trống.");
                return;
            }

            LoaiKhanDTO lk = new LoaiKhanDTO
            {
                TenLoai = txtTenLoai.Text.Trim(),
            };

            bool success = false;

            if (isAddingNew)
            {
                success = bll.Insert(lk);
            }
            else
            {
                lk.MaLoaiKhan = int.Parse(txtID.Text);
                success = bll.Update(lk);
            }

            if (success)
            {
                MessageBox.Show("Lưu thành công.");
                LoadData();
                SetControlState(true);
            }
            else
            {
                MessageBox.Show("Lưu thất bại.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
            SetControlState(true);
        }
    }
}
