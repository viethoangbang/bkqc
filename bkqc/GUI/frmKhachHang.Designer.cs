namespace bkqc.GUI
{
    partial class frmKhachHang
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
            dgvKhachHang = new DataGridView();
            txtMaKhachHang = new TextBox();
            txtTenKhachHang = new TextBox();
            txtSoDienThoai = new TextBox();
            dtpNgayDangKy = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(12, 12);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(776, 212);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.SelectionChanged += dgvKhachHang_SelectionChanged;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.BackColor = Color.Maroon;
            txtMaKhachHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaKhachHang.ForeColor = Color.White;
            txtMaKhachHang.Location = new Point(12, 244);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.PlaceholderText = "Mã...";
            txtMaKhachHang.ReadOnly = true;
            txtMaKhachHang.Size = new Size(84, 25);
            txtMaKhachHang.TabIndex = 1;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(12, 288);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.PlaceholderText = "Tên khách hàng";
            txtTenKhachHang.Size = new Size(236, 23);
            txtTenKhachHang.TabIndex = 2;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(12, 328);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "Số điện thoại";
            txtSoDienThoai.Size = new Size(236, 23);
            txtSoDienThoai.TabIndex = 3;
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Location = new Point(12, 372);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(236, 23);
            dtpNgayDangKy.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(192, 255, 255);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(301, 244);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(126, 67);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 192);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(475, 244);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(126, 67);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 192, 192);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Location = new Point(641, 244);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(126, 67);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(192, 192, 255);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Location = new Point(475, 352);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(126, 67);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(255, 192, 128);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Location = new Point(641, 352);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(126, 67);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dtpNgayDangKy);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtMaKhachHang);
            Controls.Add(dgvKhachHang);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKhachHang;
        private TextBox txtMaKhachHang;
        private TextBox txtTenKhachHang;
        private TextBox txtSoDienThoai;
        private DateTimePicker dtpNgayDangKy;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuy;
    }
}