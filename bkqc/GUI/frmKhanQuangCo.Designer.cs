namespace bkqc.GUI
{
    partial class frmKhanQuangCo
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
            txtMaKhan = new TextBox();
            dgvKhanQuangCo = new DataGridView();
            txtGiaBan = new TextBox();
            txtTenKhan = new TextBox();
            txtSoLuongTon = new TextBox();
            cboNhaCungCap = new ComboBox();
            btnLuu = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            cboLoaiKhan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKhanQuangCo).BeginInit();
            SuspendLayout();
            // 
            // txtMaKhan
            // 
            txtMaKhan.BackColor = Color.Maroon;
            txtMaKhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaKhan.ForeColor = Color.White;
            txtMaKhan.Location = new Point(530, 12);
            txtMaKhan.Name = "txtMaKhan";
            txtMaKhan.PlaceholderText = "ID";
            txtMaKhan.Size = new Size(258, 23);
            txtMaKhan.TabIndex = 0;
            // 
            // dgvKhanQuangCo
            // 
            dgvKhanQuangCo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhanQuangCo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhanQuangCo.Dock = DockStyle.Left;
            dgvKhanQuangCo.Location = new Point(0, 0);
            dgvKhanQuangCo.Name = "dgvKhanQuangCo";
            dgvKhanQuangCo.Size = new Size(524, 450);
            dgvKhanQuangCo.TabIndex = 1;
            dgvKhanQuangCo.SelectionChanged += dgvKhanQuangCo_SelectionChanged;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(530, 70);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.PlaceholderText = "Giá bán";
            txtGiaBan.Size = new Size(258, 23);
            txtGiaBan.TabIndex = 2;
            // 
            // txtTenKhan
            // 
            txtTenKhan.Location = new Point(530, 41);
            txtTenKhan.Name = "txtTenKhan";
            txtTenKhan.PlaceholderText = "Tên khăn";
            txtTenKhan.Size = new Size(258, 23);
            txtTenKhan.TabIndex = 3;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Location = new Point(530, 99);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.PlaceholderText = "Số lượng";
            txtSoLuongTon.Size = new Size(258, 23);
            txtSoLuongTon.TabIndex = 4;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(530, 186);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(258, 23);
            cboNhaCungCap.TabIndex = 7;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(255, 192, 128);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(530, 391);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(121, 47);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(192, 192, 255);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.ForeColor = Color.Black;
            btnHuy.Location = new Point(657, 391);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(131, 47);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 128);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(530, 331);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(258, 40);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(192, 255, 255);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(530, 239);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(258, 40);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 192);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(530, 285);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(258, 40);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // cboLoaiKhan
            // 
            cboLoaiKhan.FormattingEnabled = true;
            cboLoaiKhan.Location = new Point(530, 157);
            cboLoaiKhan.Name = "cboLoaiKhan";
            cboLoaiKhan.Size = new Size(258, 23);
            cboLoaiKhan.TabIndex = 18;
            // 
            // frmKhanQuangCo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboLoaiKhan);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(cboNhaCungCap);
            Controls.Add(txtSoLuongTon);
            Controls.Add(txtTenKhan);
            Controls.Add(txtGiaBan);
            Controls.Add(dgvKhanQuangCo);
            Controls.Add(txtMaKhan);
            Name = "frmKhanQuangCo";
            Text = "frmKhanQuangCo";
            Load += frmKhanQuangCo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhanQuangCo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaKhan;
        private DataGridView dgvKhanQuangCo;
        private TextBox txtGiaBan;
        private TextBox txtTenKhan;
        private TextBox txtSoLuongTon;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private ComboBox cboNhaCungCap;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private ComboBox cboLoaiKhan;
    }
}