namespace QLNT
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cửaHàngToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            khoToolStripMenuItem = new ToolStripMenuItem();
            khoToolStripMenuItem1 = new ToolStripMenuItem();
            lịchSửHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cửaHàngToolStripMenuItem, hóaĐơnToolStripMenuItem, khoToolStripMenuItem, lịchSửHóaĐơnToolStripMenuItem, doanhThuToolStripMenuItem, kháchHàngToolStripMenuItem, nhânViênToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cửaHàngToolStripMenuItem
            // 
            cửaHàngToolStripMenuItem.Name = "cửaHàngToolStripMenuItem";
            cửaHàngToolStripMenuItem.Size = new Size(89, 24);
            cửaHàngToolStripMenuItem.Text = "Cửa Hàng";
            cửaHàngToolStripMenuItem.Click += cửaHàngToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(83, 24);
            hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // khoToolStripMenuItem
            // 
            khoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khoToolStripMenuItem1 });
            khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            khoToolStripMenuItem.Size = new Size(49, 24);
            khoToolStripMenuItem.Text = "Kho";
            khoToolStripMenuItem.Click += khoToolStripMenuItem_Click;
            // 
            // khoToolStripMenuItem1
            // 
            khoToolStripMenuItem1.Name = "khoToolStripMenuItem1";
            khoToolStripMenuItem1.Size = new Size(116, 26);
            khoToolStripMenuItem1.Text = "kho";
            // 
            // lịchSửHóaĐơnToolStripMenuItem
            // 
            lịchSửHóaĐơnToolStripMenuItem.Name = "lịchSửHóaĐơnToolStripMenuItem";
            lịchSửHóaĐơnToolStripMenuItem.Size = new Size(134, 24);
            lịchSửHóaĐơnToolStripMenuItem.Text = "Lịch Sử Hóa Đơn";
            lịchSửHóaĐơnToolStripMenuItem.Click += lịchSửHóaĐơnToolStripMenuItem_Click;
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(95, 24);
            doanhThuToolStripMenuItem.Text = "Doanh Thu";
            doanhThuToolStripMenuItem.Click += doanhThuToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(100, 24);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(89, 24);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(85, 24);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ NHÀ THUỐC";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private MenuStrip menuStrip1;
        private ToolStripMenuItem cửaHàngToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem khoToolStripMenuItem;
        private ToolStripMenuItem lịchSửHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem khoToolStripMenuItem1;
    }
}
