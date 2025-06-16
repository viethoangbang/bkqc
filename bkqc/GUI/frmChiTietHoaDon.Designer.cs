namespace bkqc.GUI
{
    partial class frmChiTietHoaDon
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
            dgvChiTiet = new DataGridView();
            lblMaHD = new Label();
            lblNV = new Label();
            lblNgay = new Label();
            lblTongTien = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Dock = DockStyle.Top;
            dgvChiTiet.Location = new Point(0, 0);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 82;
            dgvChiTiet.Size = new Size(1431, 387);
            dgvChiTiet.TabIndex = 0;
            // 
            // lblMaHD
            // 
            lblMaHD.BorderStyle = BorderStyle.FixedSingle;
            lblMaHD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaHD.Location = new Point(28, 443);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(448, 64);
            lblMaHD.TabIndex = 1;
            lblMaHD.Text = "label1";
            lblMaHD.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNV
            // 
            lblNV.BorderStyle = BorderStyle.FixedSingle;
            lblNV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNV.Location = new Point(28, 564);
            lblNV.Name = "lblNV";
            lblNV.Size = new Size(448, 64);
            lblNV.TabIndex = 2;
            lblNV.Text = "label1";
            lblNV.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNgay
            // 
            lblNgay.BorderStyle = BorderStyle.FixedSingle;
            lblNgay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNgay.Location = new Point(807, 443);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(448, 64);
            lblNgay.TabIndex = 3;
            lblNgay.Text = "label2";
            lblNgay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTongTien
            // 
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTien.Location = new Point(807, 564);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(448, 64);
            lblTongTien.TabIndex = 4;
            lblTongTien.Text = "label3";
            lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 718);
            Controls.Add(lblTongTien);
            Controls.Add(lblNgay);
            Controls.Add(lblNV);
            Controls.Add(lblMaHD);
            Controls.Add(dgvChiTiet);
            Name = "frmChiTietHoaDon";
            Text = "frmChiTietHoaDon";
            Load += frmChiTietHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvChiTiet;
        private Label lblMaHD;
        private Label lblNV;
        private Label lblNgay;
        private Label lblTongTien;
    }
}