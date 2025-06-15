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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowDrop = true;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kháchHàngToolStripMenuItem, nhàCungCấpToolStripMenuItem, loạiKhănToolStripMenuItem, khănQuảngCáoToolStripMenuItem, hóaĐơnToolStripMenuItem, chiTiếtHóaĐơnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(625, 102);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(93, 98);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            nhàCungCấpToolStripMenuItem.Size = new Size(105, 98);
            nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            nhàCungCấpToolStripMenuItem.Click += nhàCungCấpToolStripMenuItem_Click;
            // 
            // loạiKhănToolStripMenuItem
            // 
            loạiKhănToolStripMenuItem.Name = "loạiKhănToolStripMenuItem";
            loạiKhănToolStripMenuItem.Size = new Size(80, 98);
            loạiKhănToolStripMenuItem.Text = "Loại khăn";
            loạiKhănToolStripMenuItem.Click += loạiKhănToolStripMenuItem_Click;
            // 
            // khănQuảngCáoToolStripMenuItem
            // 
            khănQuảngCáoToolStripMenuItem.Name = "khănQuảngCáoToolStripMenuItem";
            khănQuảngCáoToolStripMenuItem.Size = new Size(113, 98);
            khănQuảngCáoToolStripMenuItem.Text = "Khăn quàng cổ";
            khănQuảngCáoToolStripMenuItem.Click += khănQuảngCáoToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(74, 98);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
            chiTiếtHóaĐơnToolStripMenuItem.Size = new Size(120, 98);
            chiTiếtHóaĐơnToolStripMenuItem.Text = "Chi tiết hóa đơn";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 102);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
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
    }
}