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

        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgvNhaCungCap.DataSource = bll.GetAll();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var ncc = new NhaCungCapDTO
            {
                TenNhaCungCap = txtTenNCC.Text,
                SoDienThoai = txtSDT.Text,
                DiaChi = txtDiaChi.Text
            };
            if (bll.Insert(ncc))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
                ClearInput();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để sửa.");
                return;
            }

            var ncc = new NhaCungCapDTO
            {
                MaNhaCungCap = int.Parse(txtID.Text), 
                TenNhaCungCap = txtTenNCC.Text,
                SoDienThoai = txtSDT.Text,
                DiaChi = txtDiaChi.Text
            };

            bool result = bll.Update(ncc); 

            if (result)
            {
                MessageBox.Show("Cập nhật thành công.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp để sửa.");
            }
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
    }
}
