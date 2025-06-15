using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bkqc.BLL;
using bkqc.DAL;
using bkqc.DTO;
namespace bkqc.GUI
{
    public partial class frmNhaCungCap : Form
    {
        private NhaCungCapBLL bll = new NhaCungCapBLL();
        bool isAddingNew = false;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgvNhaCungCap.DataSource = bll.GetAll();
            ClearInput();
        }

        private void SetControlState(bool isEditing)
        {
            txtTenNCC.Enabled = !isEditing;
            txtSDT.Enabled = !isEditing;
            txtDiaChi.Enabled = !isEditing;

            btnLuu.Enabled = !isEditing;
            btnHuy.Enabled = !isEditing;

            btnThem.Enabled = isEditing;
            btnSua.Enabled = isEditing;
            btnXoa.Enabled = isEditing;
            dgvNhaCungCap.Enabled = isEditing;
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa.");
                return;
            }

            int id = int.Parse(txtID.Text);

            var result = bll.Delete(id);

            if (result)
            {
                MessageBox.Show("Xóa thành công.");
                LoadData();
                ClearInput();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp để xóa.");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTenNCC.Text;
            dgvNhaCungCap.DataSource = bll.GetAll()
                .Where(n => n.TenNhaCungCap.ToLower().Contains(keyword.ToLower()))
                .ToList();
        }
        private void ClearInput()
        {
            txtID.Clear();
            txtTenNCC.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtTenNCC.Focus();
        }
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhaCungCap.Rows.Count)
            {
                DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];
                txtID.Text = row.Cells["MaNhaCungCap"].Value?.ToString();
                txtTenNCC.Text = row.Cells["TenNhaCungCap"].Value?.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNCC.Text))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống.");
                return;
            }

            NhaCungCapDTO ncc = new NhaCungCapDTO
            {
                TenNhaCungCap = txtTenNCC.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
            };

            bool success = false;

            if (isAddingNew)
            {
                success = bll.Insert(ncc);
            }
            else
            {
                ncc.MaNhaCungCap = int.Parse(txtID.Text);
                success = bll.Update(ncc);
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
