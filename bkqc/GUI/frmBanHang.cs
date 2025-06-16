using bkqc.BLL;
using bkqc.DAL;
using bkqc.DTO;
using System.Data;

namespace bkqc.GUI
{
    public partial class frmBanHang : Form
    {
        KhanQuangCoBLL kqcBLL = new KhanQuangCoBLL();
        KhachHangBLL khBLL = new KhachHangBLL();
        HoaDonBLL hdBLL = new HoaDonBLL();
        List<ChiTietHoaDonDTO> gioHang = new List<ChiTietHoaDonDTO>();
        private ChiTietHoaDonBLL ctBLL = new ChiTietHoaDonBLL();
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            PhienDangNhap.TenDangNhap = null;
            PhienDangNhap.MaNhanVien = 0;
            PhienDangNhap.VaiTro = null;
            this.Close();
        }

        private void lklbThemKhachHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmThemKhachHangCuaNhanVien f = new frmThemKhachHangCuaNhanVien();
            f.FormClosed += (s, args) => this.Show();
            f.FormClosed += (s, args) => LoadKhachHang();
            f.ShowDialog();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            lblNhanVien.Text = "Nhan vien: " + PhienDangNhap.TenDangNhap;

            int maNV = PhienDangNhap.MaNhanVien;
            LoadKhachHang();
            LoadSanPham();
        }
        public void ClearInput()
        {
            txtTenSanPham.Clear();
            numSoLuong.Value = 0;
            txtTenKhachHang.Clear();
            txtMaKhachHang.Clear();
            txtMaSanPham.Clear();
            txtDonGia.Clear();

        }
        public void LoadSanPham()
        {
            dgvSanPham.DataSource = kqcBLL.GetAll();
            ClearInput();
        }
        public void LoadKhachHang()
        {
            dgvKhachHang.DataSource = khBLL.GetAll();
            ClearInput();
        }
        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int SoLuongTon = 0;
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenSanPham.Text = dgvSanPham.Rows[e.RowIndex].Cells["TenKhan"].Value.ToString();
                txtMaSanPham.Text = dgvSanPham.Rows[e.RowIndex].Cells["MaKhan"].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString();
                SoLuongTon = int.Parse(dgvSanPham.Rows[e.RowIndex].Cells["SoLuongTon"].Value.ToString());
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtTenKhachHang.Text = dgvKhachHang.Rows[e.RowIndex].Cells["TenKhachHang"].Value.ToString();
                txtMaKhachHang.Text = dgvKhachHang.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int soLuong = (int)numSoLuong.Value;

            if (int.Parse(txtMaSanPham.Text) == 0 || int.Parse(txtMaKhachHang.Text) == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng và sản phẩm.");
                return;
            }

            if (soLuong <= 0 || soLuong > SoLuongTon)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            var item = gioHang.FirstOrDefault(x => x.MaKhan == int.Parse(txtMaSanPham.Text));
            if (item != null)
            {
                item.SoLuong += soLuong;
                item.ThanhTien = item.SoLuong * item.DonGia;
            }
            else
            {
                gioHang.Add(new ChiTietHoaDonDTO
                {
                    MaKhan = int.Parse(txtMaSanPham.Text),
                    SoLuong = soLuong,
                    DonGia = double.Parse(txtDonGia.Text),
                    ThanhTien = soLuong * double.Parse(txtDonGia.Text)
                });
            }

            CapNhatDSGioHang();
        }
        private void CapNhatDSGioHang()
        {
            dgvSanPhamDaChon.DataSource = null;
            dgvSanPhamDaChon.DataSource = gioHang.Select(x => new
            {
                x.MaKhan,
                TenKhan = kqcBLL.GetById(x.MaKhan)?.TenKhan ?? "(Không tìm thấy)",
                x.SoLuong,
                x.DonGia,
                x.ThanhTien
            }).ToList();

            lblTongTien.Text = $"Tổng tiền: {gioHang.Sum(x => x.ThanhTien):N0} đ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống.");
                return;
            }

            if (string.IsNullOrEmpty(txtMaKhachHang.Text) || !int.TryParse(txtMaKhachHang.Text, out int maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }

            HoaDonDTO hd = new HoaDonDTO
            {
                MaKhachHang = maKH,
                MaNhanVien = PhienDangNhap.MaNhanVien,
                NgayLap = DateTime.Now,
                TongTien = gioHang.Sum(x => x.ThanhTien)
            };

            int maHD = hdBLL.Insert(hd);
            if (maHD <= 0)
            {
                MessageBox.Show("Không thể tạo hóa đơn.");
                return;
            }

            foreach (var item in gioHang)
            {
                item.MaHoaDon = maHD;

                if (!ctBLL.Insert(item))
                {
                    MessageBox.Show($"Không thể thêm chi tiết cho sản phẩm {item.MaKhan}");
                    return;
                }

                kqcBLL.TruSoLuongTon(item.MaKhan, item.SoLuong);
            }

            MessageBox.Show("Thanh toán thành công!");

            gioHang.Clear();
            CapNhatDSGioHang();
            LoadSanPham();
            ClearInput();
        }

        private void txtTimKiemSP_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemSP.Text.ToLower();
            var allSP = kqcBLL.GetAll();

            var filtered = allSP.Where(sp =>
                sp.TenKhan.ToLower().Contains(keyword)
            ).ToList();

            dgvSanPham.DataSource = filtered;
        }

        private void txtTimKiemKH_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemKH.Text.ToLower();
            var allKH = khBLL.GetAll();

            var filtered = allKH.Where(kh =>
                kh.TenKhachHang.ToLower().Contains(keyword) ||
                kh.SoDienThoai.ToLower().Contains(keyword)
            ).ToList();

            dgvKhachHang.DataSource = filtered;
        }
    }
}
