namespace bkqc.GUI
{
    partial class frmDangNhap
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
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            lblThongBao = new Label();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 104);
            label1.Name = "label1";
            label1.Size = new Size(558, 59);
            label1.TabIndex = 0;
            label1.Text = "Xin moi ban dang nhap...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 238);
            label2.Name = "label2";
            label2.Size = new Size(186, 32);
            label2.TabIndex = 1;
            label2.Text = "Ten dang nhap: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 335);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 2;
            label3.Text = "Mat khau:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(242, 235);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(589, 39);
            txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(242, 335);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(589, 39);
            txtMatKhau.TabIndex = 4;
            // 
            // lblThongBao
            // 
            lblThongBao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblThongBao.ForeColor = Color.Red;
            lblThongBao.Location = new Point(114, 500);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(810, 53);
            lblThongBao.TabIndex = 5;
            lblThongBao.Text = " ";
            lblThongBao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(242, 422);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(292, 46);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Dang nhap";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 562);
            Controls.Add(btnDangNhap);
            Controls.Add(lblThongBao);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Label lblThongBao;
        private Button btnDangNhap;
    }
}