namespace bkqc.GUI
{
    partial class frmNhanVien
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
            dgvNhanVien = new DataGridView();
            txtID = new TextBox();
            txtTenDangNhap = new TextBox();
            txtTenNhanVien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMatKhau = new TextBox();
            cboVaiTro = new ComboBox();
            label4 = new Label();
            chbxTrangThai = new CheckBox();
            label5 = new Label();
            btnLuu = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Top;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 82;
            dgvNhanVien.Size = new Size(1688, 440);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(255, 128, 128);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Dock = DockStyle.Left;
            txtID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtID.ForeColor = Color.Black;
            txtID.Location = new Point(0, 440);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(113, 43);
            txtID.TabIndex = 1;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(50, 726);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(449, 39);
            txtTenDangNhap.TabIndex = 2;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(50, 597);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(449, 39);
            txtTenNhanVien.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 548);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 4;
            label1.Text = "Ten nhan vien";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 680);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 5;
            label2.Text = "Ten dang nhap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 680);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 7;
            label3.Text = "Mat khau";
            label3.Click += label3_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(550, 726);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(294, 39);
            txtMatKhau.TabIndex = 6;
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(559, 596);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(285, 40);
            cboVaiTro.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 548);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 9;
            label4.Text = "Vai tro";
            // 
            // chbxTrangThai
            // 
            chbxTrangThai.AutoSize = true;
            chbxTrangThai.Location = new Point(906, 600);
            chbxTrangThai.Name = "chbxTrangThai";
            chbxTrangThai.Size = new Size(160, 36);
            chbxTrangThai.TabIndex = 10;
            chbxTrangThai.Text = "Hoat dong";
            chbxTrangThai.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(906, 548);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 11;
            label5.Text = "Trang thai";
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Location = new Point(1197, 719);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(239, 46);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(1197, 506);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(456, 46);
            btnThem.TabIndex = 13;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Location = new Point(1451, 719);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(202, 46);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Huy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(1197, 578);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(456, 46);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Location = new Point(1197, 652);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(456, 46);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Dock = DockStyle.Left;
            txtTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimKiem.Location = new Point(113, 440);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tim kiem...";
            txtTimKiem.Size = new Size(953, 43);
            txtTimKiem.TabIndex = 17;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1688, 786);
            Controls.Add(txtTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(label5);
            Controls.Add(chbxTrangThai);
            Controls.Add(label4);
            Controls.Add(cboVaiTro);
            Controls.Add(label3);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtID);
            Controls.Add(dgvNhanVien);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNhanVien;
        private TextBox txtID;
        private TextBox txtTenDangNhap;
        private TextBox txtTenNhanVien;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMatKhau;
        private ComboBox cboVaiTro;
        private Label label4;
        private CheckBox chbxTrangThai;
        private Label label5;
        private Button btnLuu;
        private Button btnThem;
        private Button btnHuy;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtTimKiem;
    }
}