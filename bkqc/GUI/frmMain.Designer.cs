namespace bkqc.GUI
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            loạiKhănToolStripMenuItem = new ToolStripMenuItem();
            khănQuảngCáoToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            chiTiếtHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            btnDangXuat = new Button();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowDrop = true;
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kháchHàngToolStripMenuItem, nhàCungCấpToolStripMenuItem, loạiKhănToolStripMenuItem, khănQuảngCáoToolStripMenuItem, hóaĐơnToolStripMenuItem, chiTiếtHóaĐơnToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 87);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1262, 346);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(176, 338);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            nhàCungCấpToolStripMenuItem.Size = new Size(200, 338);
            nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            nhàCungCấpToolStripMenuItem.Click += nhàCungCấpToolStripMenuItem_Click;
            // 
            // loạiKhănToolStripMenuItem
            // 
            loạiKhănToolStripMenuItem.Name = "loạiKhănToolStripMenuItem";
            loạiKhănToolStripMenuItem.Size = new Size(151, 338);
            loạiKhănToolStripMenuItem.Text = "Loại khăn";
            loạiKhănToolStripMenuItem.Click += loạiKhănToolStripMenuItem_Click;
            // 
            // khănQuảngCáoToolStripMenuItem
            // 
            khănQuảngCáoToolStripMenuItem.Name = "khănQuảngCáoToolStripMenuItem";
            khănQuảngCáoToolStripMenuItem.Size = new Size(215, 338);
            khănQuảngCáoToolStripMenuItem.Text = "Khăn quàng cổ";
            khănQuảngCáoToolStripMenuItem.Click += khănQuảngCáoToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(20, 338);
            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
            chiTiếtHóaĐơnToolStripMenuItem.Size = new Size(250, 338);
            chiTiếtHóaĐơnToolStripMenuItem.Text = "Quan ly nhan vien";
            chiTiếtHóaĐơnToolStripMenuItem.Click += chiTiếtHóaĐơnToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(223, 338);
            toolStripMenuItem1.Text = "Lich su hoa don";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(152, 45);
            label1.TabIndex = 1;
            label1.Text = "Quan ly: ";
            // 
            // btnDangXuat
            // 
            btnDangXuat.ForeColor = Color.Red;
            btnDangXuat.Location = new Point(1100, 19);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(150, 46);
            btnDangXuat.TabIndex = 2;
            btnDangXuat.Text = "Dang xuat";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 19);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 433);
            Controls.Add(label2);
            Controls.Add(btnDangXuat);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "frmMain";
            Text = "frmMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem loạiKhănToolStripMenuItem;
        private ToolStripMenuItem khănQuảngCáoToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label label1;
        private Button btnDangXuat;
        private Label label2;
    }
}