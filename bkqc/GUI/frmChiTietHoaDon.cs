using bkqc.BLL;
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
    public partial class frmChiTietHoaDon : Form
    {
        private int _maHoaDon;
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        ChiTietHoaDonBLL chiTietHoaDonBLL = new ChiTietHoaDonBLL();
        public frmChiTietHoaDon(int maHoaDon)
        {
            InitializeComponent();
            _maHoaDon = maHoaDon;
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {

            var hoaDon = hoaDonBLL.GetById(_maHoaDon);
            lblMaHD.Text = "Ma HD: " + hoaDon.MaHoaDon.ToString();
            lblNgay.Text = "Ngay lap: " + hoaDon.NgayLap.ToString("dd/MM/yyyy");
            lblNV.Text = "Ma NV: " + hoaDon.MaNhanVien.ToString();
            lblTongTien.Text = "Tong tien: " + hoaDon.TongTien.ToString("N0");

            var chiTiet = chiTietHoaDonBLL.GetByMaHoaDon(_maHoaDon);
            dgvChiTiet.DataSource = chiTiet;
        }
    }
}
