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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
        }

        private void loạiKhănToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiKhan f = new frmLoaiKhan();
            f.ShowDialog();
        }

        private void khănQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhanQuangCo f = new frmKhanQuangCo();
            f.ShowDialog();
        }
    }
}
