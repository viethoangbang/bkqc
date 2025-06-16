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
    public partial class frmLichSuHoaDon : Form
    {
        HoaDonBLL hd = new HoaDonBLL();
        public frmLichSuHoaDon()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvLichSuHoaDon.DataSource = hd.GetAll();
        }
        private void frmLichSuHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvLichSuHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maHoaDon = Convert.ToInt32(dgvLichSuHoaDon.Rows[e.RowIndex].Cells["MaHoaDon"].Value);
                frmChiTietHoaDon frm = new frmChiTietHoaDon(maHoaDon);
                frm.ShowDialog();
            }
        }
    }
}
