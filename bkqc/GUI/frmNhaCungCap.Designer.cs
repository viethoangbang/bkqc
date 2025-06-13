namespace bkqc.GUI
{
    partial class frmNhaCungCap
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
            txtTenNCC = new TextBox();
            dgvNhaCungCap = new DataGridView();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            txtID = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(12, 324);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.PlaceholderText = "Tên nhà cung cấp";
            txtTenNCC.Size = new Size(369, 23);
            txtTenNCC.TabIndex = 0;
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Location = new Point(12, 12);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.Size = new Size(776, 262);
            dgvNhaCungCap.TabIndex = 1;
            dgvNhaCungCap.CellClick += dgvNhaCungCap_CellClick;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(12, 385);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "Địa chỉ";
            txtDiaChi.Size = new Size(369, 23);
            txtDiaChi.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(12, 356);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "Số điện thoại";
            txtSDT.Size = new Size(369, 23);
            txtSDT.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 192, 192);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Location = new Point(427, 315);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(169, 32);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(192, 255, 255);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(427, 280);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(169, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 192);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(619, 280);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(169, 29);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.DarkRed;
            txtID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.ForeColor = SystemColors.Window;
            txtID.Location = new Point(12, 295);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(369, 23);
            txtID.TabIndex = 11;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LightGreen;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Location = new Point(427, 376);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(169, 62);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Silver;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Location = new Point(619, 376);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(169, 62);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtID);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(txtSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(dgvNhaCungCap);
            Controls.Add(txtTenNCC);
            Name = "frmNhaCungCap";
            Text = "frmNhaCungCap";
            Load += frmNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenNCC;
        private DataGridView dgvNhaCungCap;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private TextBox txtID;
        private Button btnLuu;
        private Button btnHuy;
    }
}