using bkqc.BLL;
using bkqc.DAL;
using bkqc.DTO;
using System;
using System.Windows.Forms;

namespace bkqc.GUI
{
    public partial class frmKhanQuangCo : Form
    {
        private LoaiKhanBLL loaiKhanBLL = new LoaiKhanBLL();
        private NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
        private KhanQuangCoBLL khanBLL = new KhanQuangCoBLL();

        private bool isAddingNew = false;

        public frmKhanQuangCo()
        {
            InitializeComponent();
        }

        private void LoadComboBoxes()
        {
            try
            {
                cboLoaiKhan.DataSource = loaiKhanBLL.GetAll();
                cboLoaiKhan.DisplayMember = "TenLoai";
                cboLoaiKhan.ValueMember = "MaLoaiKhan";

                cboNhaCungCap.DataSource = nhaCungCapBLL.GetAll();
                cboNhaCungCap.DisplayMember = "TenNhaCungCap";
                cboNhaCungCap.ValueMember = "MaNhaCungCap";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu combo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKhanQuangCo()
        {
            dgvKhanQuangCo.DataSource = khanBLL.GetAll();
            ClearInput();
        }

        private void SetControlState(bool isEditing)
        {
            txtTenKhan.Enabled = !isEditing;
            txtGiaBan.Enabled = !isEditing;
            txtSoLuongTon.Enabled = !isEditing;
            cboLoaiKhan.Enabled = !isEditing;
            cboNhaCungCap.Enabled = !isEditing;

            btnLuu.Enabled = !isEditing;
            btnHuy.Enabled = !isEditing;

            btnThem.Enabled = isEditing;
            btnSua.Enabled = isEditing;
            btnXoa.Enabled = isEditing;
            dgvKhanQuangCo.Enabled = isEditing;
        }

        private void dgvKhanQuangCo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhanQuangCo.CurrentRow != null && dgvKhanQuangCo.CurrentRow.Cells["MaKhan"].Value != null)
            {
                var row = dgvKhanQuangCo.CurrentRow;
                txtMaKhan.Text = row.Cells["MaKhan"].Value.ToString();
                txtTenKhan.Text = row.Cells["TenKhan"].Value.ToString();

                int maLoai = Convert.ToInt32(row.Cells["MaLoaiKhan"].Value);
                int maNhaCC = Convert.ToInt32(row.Cells["MaNhaCungCap"].Value);

                cboLoaiKhan.SelectedValue = maLoai;
                cboNhaCungCap.SelectedValue = maNhaCC;

                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value.ToString();

            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTenKhan.Text))
            {
                MessageBox.Show("Tên khăn quàng cổ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhan.Focus();
                return false;
            }

            if (cboLoaiKhan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại khăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiKhan.Focus();
                return false;
            }

            if (cboNhaCungCap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhaCungCap.Focus();
                return false;
            }

            if (!double.TryParse(txtGiaBan.Text, out double gia))
            {
                MessageBox.Show("Giá bán phải là số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return false;
            }
            if (gia < 0)
            {
                MessageBox.Show("Giá bán phải lớn hơn hoặc bằng 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return false;
            }

            if (!int.TryParse(txtSoLuongTon.Text, out int sl))
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongTon.Focus();
                return false;
            }
            if (sl < 0)
            {
                MessageBox.Show("Số lượng tồn phải lớn hơn hoặc bằng 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongTon.Focus();
                return false;
            }

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKhan.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống.");
                return;
            }

            if (!int.TryParse(txtGiaBan.Text.Trim(), out int giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ!");
                return;
            }

            if (!int.TryParse(txtSoLuongTon.Text.Trim(), out int soLuongTon))
            {
                MessageBox.Show("Số lượng tồn không hợp lệ!");
                return;
            }

            if (cboLoaiKhan.SelectedValue == null || cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ loại khăn và nhà cung cấp!");
                return;
            }

            KhanQuangCoDTO k = new KhanQuangCoDTO
            {
                TenKhan = txtTenKhan.Text.Trim(),
                GiaBan = double.Parse(txtGiaBan.Text),
                MaLoaiKhan = Convert.ToInt32(cboLoaiKhan.SelectedValue),
                MaNhaCungCap = Convert.ToInt32(cboNhaCungCap.SelectedValue),
                SoLuongTon = int.Parse(txtSoLuongTon.Text)
            };


            bool success = false;

            if (isAddingNew)
            {
                if (ValidateInputs())
                {
                success = khanBLL.Insert(k);

                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                k.MaKhan = int.Parse(txtMaKhan.Text);
                success = khanBLL.Update(k);
            }

            if (success)
            {
                MessageBox.Show("Lưu thành công.");
                LoadKhanQuangCo();
                SetControlState(true);
            }
            else
            {
                MessageBox.Show("Lưu thất bại.");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddingNew = true;
            ClearInput();
            SetControlState(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhan.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                return;
            }
            isAddingNew = false;
            SetControlState(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhan.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }
            int maKH = int.Parse(txtMaKhan.Text);
            var result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (khanBLL.Delete(maKH))
                {
                    MessageBox.Show("Xóa thành công.");
                    LoadKhanQuangCo();
                    LoadComboBoxes();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }
        private void ClearInput()
        {
            txtMaKhan.Text = "";
            txtTenKhan.Text = "";
            cboLoaiKhan.SelectedIndex = -1;
            cboNhaCungCap.SelectedIndex = -1;
            txtGiaBan.Text = "";
            txtSoLuongTon.Text = "";
        }

        private void frmKhanQuangCo_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadKhanQuangCo();
            SetControlState(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadKhanQuangCo();
            LoadComboBoxes();
            SetControlState(true);
        }
    }
}
