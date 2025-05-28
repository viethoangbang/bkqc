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
using bkqc.DTO;

namespace bkqc.GUI
{
    public partial class frmLoaiKhan : Form
    {
        LoaiKhanBLL bll = new LoaiKhanBLL();

        private void LoadData()
        {
            dgvLoaiKhan.DataSource = bll.GetAll();
        }

        public frmLoaiKhan()
        {
            InitializeComponent();
        }

        private void frmLoaiKhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiKhanDTO loai = new LoaiKhanDTO { TenLoai = txtTenLoai.Text };
            if (bll.Insert(loai))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
                ClearInput();
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra dữ liệu.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoaiKhan.SelectedRows.Count > 0)
            {
                int ma = Convert.ToInt32(dgvLoaiKhan.SelectedRows[0].Cells["MaLoaiKhan"].Value);
                if (bll.Delete(ma))
                {
                    MessageBox.Show("Xoá thành công");
                    LoadData();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
        }
        private void ClearInput()
        {
            txtTenLoai.Clear();
            txtTenLoai.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLoaiKhan.SelectedRows.Count > 0)
            {
                int ma = Convert.ToInt32(dgvLoaiKhan.SelectedRows[0].Cells["MaLoaiKhan"].Value);
                LoaiKhanDTO loai = new LoaiKhanDTO
                {
                    MaLoaiKhan = ma,
                    TenLoai = txtTenLoai.Text
                };
                if (bll.Update(loai))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại. Vui lòng kiểm tra dữ liệu.");
                }
            }
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
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
           ClearInput();
        }
    }
}
