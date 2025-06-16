namespace bkqc.GUI
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDangXuat = new Button();
            dgvSanPham = new DataGridView();
            dgvKhachHang = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lklbThemKhachHang = new LinkLabel();
            dgvSanPhamDaChon = new DataGridView();
            label3 = new Label();
            txtTimKiemKH = new TextBox();
            txtTimKiemSP = new TextBox();
            txtTenSanPham = new TextBox();
            numSoLuong = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            btnThem = new Button();
            txtTenKhachHang = new TextBox();
            label6 = new Label();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            txtMaKhachHang = new TextBox();
            txtMaSanPham = new TextBox();
            label9 = new Label();
            txtDonGia = new TextBox();
            lblNhanVien = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamDaChon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDangXuat.ForeColor = Color.Red;
            btnDangXuat.Location = new Point(1711, 987);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(150, 46);
            btnDangXuat.TabIndex = 1;
            btnDangXuat.Text = "Dang xuat";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(28, 140);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 82;
            dgvSanPham.Size = new Size(1107, 353);
            dgvSanPham.TabIndex = 2;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(28, 589);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 82;
            dgvKhachHang.Size = new Size(1107, 300);
            dgvKhachHang.TabIndex = 3;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(28, 81);
            label1.Name = "label1";
            label1.Size = new Size(184, 47);
            label1.TabIndex = 4;
            label1.Text = "San pham";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(28, 530);
            label2.Name = "label2";
            label2.Size = new Size(214, 47);
            label2.TabIndex = 5;
            label2.Text = "Khach hang";
            // 
            // lklbThemKhachHang
            // 
            lklbThemKhachHang.AutoSize = true;
            lklbThemKhachHang.Location = new Point(28, 909);
            lklbThemKhachHang.Name = "lklbThemKhachHang";
            lklbThemKhachHang.Size = new Size(265, 32);
            lklbThemKhachHang.TabIndex = 6;
            lklbThemKhachHang.TabStop = true;
            lklbThemKhachHang.Text = "Them khach hang moi?";
            lklbThemKhachHang.LinkClicked += lklbThemKhachHang_LinkClicked;
            // 
            // dgvSanPhamDaChon
            // 
            dgvSanPhamDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPhamDaChon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSanPhamDaChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPhamDaChon.Location = new Point(1185, 589);
            dgvSanPhamDaChon.Name = "dgvSanPhamDaChon";
            dgvSanPhamDaChon.RowHeadersWidth = 82;
            dgvSanPhamDaChon.Size = new Size(635, 300);
            dgvSanPhamDaChon.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(1185, 539);
            label3.Name = "label3";
            label3.Size = new Size(325, 47);
            label3.TabIndex = 8;
            label3.Text = "San pham da chon";
            // 
            // txtTimKiemKH
            // 
            txtTimKiemKH.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemKH.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimKiemKH.Location = new Point(248, 536);
            txtTimKiemKH.Name = "txtTimKiemKH";
            txtTimKiemKH.PlaceholderText = "  Tim kiem khach hang...";
            txtTimKiemKH.Size = new Size(590, 43);
            txtTimKiemKH.TabIndex = 9;
            txtTimKiemKH.TextChanged += txtTimKiemKH_TextChanged;
            // 
            // txtTimKiemSP
            // 
            txtTimKiemSP.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiemSP.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimKiemSP.Location = new Point(218, 87);
            txtTimKiemSP.Name = "txtTimKiemSP";
            txtTimKiemSP.PlaceholderText = "  Tim kiem san pham...";
            txtTimKiemSP.Size = new Size(590, 43);
            txtTimKiemSP.TabIndex = 10;
            txtTimKiemSP.TextChanged += txtTimKiemSP_TextChanged;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.BorderStyle = BorderStyle.FixedSingle;
            txtTenSanPham.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTenSanPham.Location = new Point(1185, 161);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.PlaceholderText = "  @-@";
            txtTenSanPham.ReadOnly = true;
            txtTenSanPham.Size = new Size(503, 43);
            txtTenSanPham.TabIndex = 11;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(1185, 375);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(635, 39);
            numSoLuong.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1181, 118);
            label4.Name = "label4";
            label4.Size = new Size(163, 32);
            label4.TabIndex = 13;
            label4.Text = "Ten san pham";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1181, 339);
            label5.Name = "label5";
            label5.Size = new Size(110, 32);
            label5.TabIndex = 14;
            label5.Text = "So luong";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(255, 255, 192);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(1657, 533);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(163, 46);
            btnThem.TabIndex = 15;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTenKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTenKhachHang.Location = new Point(1185, 272);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.PlaceholderText = "  @-@";
            txtTenKhachHang.ReadOnly = true;
            txtTenKhachHang.Size = new Size(503, 43);
            txtTenKhachHang.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1181, 234);
            label6.Name = "label6";
            label6.Size = new Size(140, 32);
            label6.TabIndex = 17;
            label6.Text = "Khach hang";
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(1181, 909);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(639, 47);
            lblTongTien.TabIndex = 19;
            lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(192, 255, 192);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThanhToan.Location = new Point(689, 967);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(384, 54);
            btnThanhToan.TabIndex = 20;
            btnThanhToan.Text = "Thanh toan";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtMaKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtMaKhachHang.Location = new Point(1711, 272);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.PlaceholderText = "  @-@";
            txtMaKhachHang.ReadOnly = true;
            txtMaKhachHang.Size = new Size(92, 43);
            txtMaKhachHang.TabIndex = 21;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.BorderStyle = BorderStyle.FixedSingle;
            txtMaSanPham.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtMaSanPham.Location = new Point(1711, 161);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.PlaceholderText = "  @-@";
            txtMaSanPham.ReadOnly = true;
            txtMaSanPham.Size = new Size(92, 43);
            txtMaSanPham.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1181, 427);
            label9.Name = "label9";
            label9.Size = new Size(98, 32);
            label9.TabIndex = 24;
            label9.Text = "Don gia";
            // 
            // txtDonGia
            // 
            txtDonGia.BorderStyle = BorderStyle.FixedSingle;
            txtDonGia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtDonGia.Location = new Point(1185, 470);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.PlaceholderText = "  @-@";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(618, 43);
            txtDonGia.TabIndex = 23;
            // 
            // lblNhanVien
            // 
            lblNhanVien.Cursor = Cursors.No;
            lblNhanVien.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNhanVien.ForeColor = Color.Fuchsia;
            lblNhanVien.Location = new Point(28, 26);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(1107, 52);
            lblNhanVien.TabIndex = 25;
            lblNhanVien.Text = "test";
            lblNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1862, 1058);
            Controls.Add(lblNhanVien);
            Controls.Add(label9);
            Controls.Add(txtDonGia);
            Controls.Add(txtMaSanPham);
            Controls.Add(txtMaKhachHang);
            Controls.Add(btnThanhToan);
            Controls.Add(lblTongTien);
            Controls.Add(label6);
            Controls.Add(txtTenKhachHang);
            Controls.Add(btnThem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numSoLuong);
            Controls.Add(txtTenSanPham);
            Controls.Add(txtTimKiemSP);
            Controls.Add(txtTimKiemKH);
            Controls.Add(label3);
            Controls.Add(dgvSanPhamDaChon);
            Controls.Add(lklbThemKhachHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvKhachHang);
            Controls.Add(dgvSanPham);
            Controls.Add(btnDangXuat);
            Name = "frmBanHang";
            Text = "frmBanHang";
            Load += frmBanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamDaChon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDangXuat;
        private DataGridView dgvSanPham;
        private DataGridView dgvKhachHang;
        private Label label1;
        private Label label2;
        private LinkLabel lklbThemKhachHang;
        private DataGridView dgvSanPhamDaChon;
        private Label label3;
        private TextBox txtTimKiemKH;
        private TextBox txtTimKiemSP;
        private TextBox txtTenSanPham;
        private NumericUpDown numSoLuong;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private TextBox txtTenKhachHang;
        private Label label6;
        private Label lblTongTien;
        private Button btnThanhToan;
        private TextBox txtMaKhachHang;
        private TextBox txtMaSanPham;
        private Label label9;
        private TextBox txtDonGia;
        private Label lblNhanVien;
    }
}