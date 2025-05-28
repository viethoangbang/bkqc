using System;
using System.Windows.Forms;
using bkqc.BLL;
using bkqc.DTO;

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
            LoadComboBoxes();
            LoadKhanQuangCo();
            SetControlState(isEditing: false);

            dgvKhanQuangCo.SelectionChanged += dgvKhanQuangCo_SelectionChanged;
        }

        private void LoadComboBoxes()
        {
            try
            {
                cboLoaiKhan.DataSource = loaiKhanBLL.GetAll();
                cboLoaiKhan.DisplayMember = "TenLoaiKhan";
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
            try
            {
                dgvKhanQuangCo.DataSource = khanBLL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu khăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetControlState(bool isEditing)
        {
            txtMaKhan.Enabled = !isEditing;
            txtTenKhan.Enabled = isEditing;
            cboLoaiKhan.Enabled = isEditing;
            cboNhaCungCap.Enabled = isEditing;
            txtGiaBan.Enabled = isEditing;
            txtSoLuongTon.Enabled = isEditing;

            btnLuu.Enabled = isEditing;
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
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

                SetControlState(isEditing: false);
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
            if (!ValidateInputs()) return;

            try
            {
                KhanQuangCoDTO kh = new KhanQuangCoDTO
                {
                    TenKhan = txtTenKhan.Text.Trim(),
                    MaLoaiKhan = (int)cboLoaiKhan.SelectedValue,
                    MaNhaCungCap = (int)cboNhaCungCap.SelectedValue,
                    GiaBan = double.Parse(txtGiaBan.Text.Trim()),
                    SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim())
                };

                bool success;
                if (isAddingNew)
                {
                    success = khanBLL.Insert(kh);
                }
                else
                {
                    if (!int.TryParse(txtMaKhan.Text, out int maKhan))
                    {
                        MessageBox.Show("Mã khăn quàng cổ không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    kh.MaKhan = maKhan;
                    success = khanBLL.Update(kh);
                }

                if (success)
                {
                    MessageBox.Show("Lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhanQuangCo();
                    SetControlState(isEditing: false);
                    isAddingNew = false;
                }
                else
                {
                    MessageBox.Show("Lưu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddingNew = true;
            ClearInputFields();
            SetControlState(isEditing: true);
            txtMaKhan.Enabled = false; 
            txtTenKhan.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhan.Text))
            {
                MessageBox.Show("Vui lòng chọn khăn cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAddingNew = false;
            SetControlState(isEditing: true);
            txtTenKhan.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhan.Text))
            {
                MessageBox.Show("Vui lòng chọn khăn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa khăn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int maKhan = int.Parse(txtMaKhan.Text);
                    bool success = khanBLL.Delete(maKhan);
                    if (success)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKhanQuangCo();
                        ClearInputFields();
                        SetControlState(isEditing: false);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearInputFields()
        {
            txtMaKhan.Text = "";
            txtTenKhan.Text = "";
            cboLoaiKhan.SelectedIndex = -1;
            cboNhaCungCap.SelectedIndex = -1;
            txtGiaBan.Text = "";
            txtSoLuongTon.Text = "";
        }
    }
}
