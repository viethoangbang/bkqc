namespace bkqc.GUI
{
    partial class frmLoaiKhan
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
            btnThem = new Button();
            dgvLoaiKhan = new DataGridView();
            txtTenLoai = new TextBox();
            btnLamMoi = new Button();
            btnTim = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiKhan).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(192, 255, 255);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(12, 324);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 114);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvLoaiKhan
            // 
            dgvLoaiKhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiKhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiKhan.Location = new Point(12, 12);
            dgvLoaiKhan.Name = "dgvLoaiKhan";
            dgvLoaiKhan.Size = new Size(776, 224);
            dgvLoaiKhan.TabIndex = 1;
            dgvLoaiKhan.CellClick += dgvLoaiKhan_CellClick;
            dgvLoaiKhan.CellContentClick += dgvLoaiKhan_CellContentClick;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(12, 254);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.PlaceholderText = "Tên loại khăn";
            txtTenLoai.Size = new Size(776, 23);
            txtTenLoai.TabIndex = 2;
            txtTenLoai.TextChanged += txtTenLoai_TextChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Silver;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Location = new Point(713, 283);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 30);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm sạch";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(255, 192, 128);
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Location = new Point(511, 324);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(129, 114);
            btnTim.TabIndex = 7;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 192, 192);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Location = new Point(336, 324);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 114);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 192);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(166, 324);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 114);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // frmLoaiKhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(btnLamMoi);
            Controls.Add(txtTenLoai);
            Controls.Add(dgvLoaiKhan);
            Controls.Add(btnThem);
            Name = "frmLoaiKhan";
            Text = "frmLoaiKhan";
            Load += frmLoaiKhan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoaiKhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private DataGridView dgvLoaiKhan;
        private TextBox txtTenLoai;
        private Button btnLamMoi;
        private Button btnTim;
        private Button btnXoa;
        private Button btnSua;
    }
}