namespace bkqc.GUI
{
    partial class frmThemKhachHangCuaNhanVien
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenKhachHang = new TextBox();
            txtSoDienThoai = new TextBox();
            btnThem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(36, 98);
            label1.Name = "label1";
            label1.Size = new Size(473, 54);
            label1.TabIndex = 0;
            label1.Text = "Them khach hang moi...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 259);
            label2.Name = "label2";
            label2.Size = new Size(183, 32);
            label2.TabIndex = 1;
            label2.Text = "Ten khach hang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 363);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 2;
            label3.Text = "So dien thoai";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(290, 259);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(539, 39);
            txtTenKhachHang.TabIndex = 3;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(290, 363);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(539, 39);
            txtSoDienThoai.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(455, 446);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 5;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmThemKhachHangCuaNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 532);
            Controls.Add(btnThem);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTenKhachHang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmThemKhachHangCuaNhanVien";
            Text = "frmThemKhachHangCuaNhanVien";
            Load += frmThemKhachHangCuaNhanVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenKhachHang;
        private TextBox txtSoDienThoai;
        private Button btnThem;
    }
}