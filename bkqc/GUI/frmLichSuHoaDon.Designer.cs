namespace bkqc.GUI
{
    partial class frmLichSuHoaDon
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
            dgvLichSuHoaDon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuHoaDon).BeginInit();
            SuspendLayout();
            // 
            // dgvLichSuHoaDon
            // 
            dgvLichSuHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSuHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLichSuHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSuHoaDon.Dock = DockStyle.Fill;
            dgvLichSuHoaDon.Location = new Point(0, 0);
            dgvLichSuHoaDon.Name = "dgvLichSuHoaDon";
            dgvLichSuHoaDon.RowHeadersWidth = 82;
            dgvLichSuHoaDon.Size = new Size(1811, 606);
            dgvLichSuHoaDon.TabIndex = 0;
            dgvLichSuHoaDon.CellClick += dgvLichSuHoaDon_CellClick;
            // 
            // frmLichSuHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1811, 606);
            Controls.Add(dgvLichSuHoaDon);
            Name = "frmLichSuHoaDon";
            Text = "frmLichSuHoaDon";
            Load += frmLichSuHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichSuHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLichSuHoaDon;
    }
}