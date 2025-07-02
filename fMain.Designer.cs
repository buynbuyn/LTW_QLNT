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
            panelUserInfo = new Panel();
            btnLogout = new Button();
            labelUserInfo = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cửaHàngToolStripMenuItem, hóaĐơnToolStripMenuItem, khoToolStripMenuItem, lịchSửHóaĐơnToolStripMenuItem, doanhThuToolStripMenuItem, kháchHàngToolStripMenuItem, nhânViênToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1367, 50);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cửaHàngToolStripMenuItem
            // 
            cửaHàngToolStripMenuItem.AutoSize = false;
            cửaHàngToolStripMenuItem.Name = "cửaHàngToolStripMenuItem";
            cửaHàngToolStripMenuItem.Size = new Size(150, 40);
            cửaHàngToolStripMenuItem.Text = "Cửa Hàng";
            cửaHàngToolStripMenuItem.Click += cửaHàngToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.AutoSize = false;
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(150, 40);
            hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // khoToolStripMenuItem
            // 
            khoToolStripMenuItem.AutoSize = false;
            khoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khoToolStripMenuItem1 });
            khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            khoToolStripMenuItem.Size = new Size(130, 40);
            khoToolStripMenuItem.Text = "Kho";
            khoToolStripMenuItem.Click += khoToolStripMenuItem_Click;
            // 
            // khoToolStripMenuItem1
            // 
            khoToolStripMenuItem1.Name = "khoToolStripMenuItem1";
            khoToolStripMenuItem1.Size = new Size(123, 28);
            khoToolStripMenuItem1.Text = "kho";
            // 
            // lịchSửHóaĐơnToolStripMenuItem
            // 
            lịchSửHóaĐơnToolStripMenuItem.AutoSize = false;
            lịchSửHóaĐơnToolStripMenuItem.Name = "lịchSửHóaĐơnToolStripMenuItem";
            lịchSửHóaĐơnToolStripMenuItem.Size = new Size(150, 40);
            lịchSửHóaĐơnToolStripMenuItem.Text = "Lịch Sử Hóa Đơn";
            lịchSửHóaĐơnToolStripMenuItem.Click += lịchSửHóaĐơnToolStripMenuItem_Click;
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.AutoSize = false;
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(150, 40);
            doanhThuToolStripMenuItem.Text = "Doanh Thu";
            doanhThuToolStripMenuItem.Click += doanhThuToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.AutoSize = false;
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(150, 40);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.AutoSize = false;
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(150, 40);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.AutoSize = false;
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(150, 40);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click;
            // 
            // panelUserInfo
            // 
            panelUserInfo.BackColor = Color.LightSteelBlue;
            panelUserInfo.Controls.Add(btnLogout);
            panelUserInfo.Controls.Add(labelUserInfo);
            panelUserInfo.Controls.Add(pictureBox1);
            panelUserInfo.Dock = DockStyle.Bottom;
            panelUserInfo.Location = new Point(0, 560);
            panelUserInfo.Name = "panelUserInfo";
            panelUserInfo.Size = new Size(1367, 61);
            panelUserInfo.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 192, 255);
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1206, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(161, 61);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "ĐĂNG XUẤT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // labelUserInfo
            // 
            labelUserInfo.AutoSize = true;
            labelUserInfo.BackColor = Color.Transparent;
            labelUserInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserInfo.Location = new Point(54, 23);
            labelUserInfo.Name = "labelUserInfo";
            labelUserInfo.Size = new Size(75, 23);
            labelUserInfo.TabIndex = 1;
            labelUserInfo.Text = "Tên user";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UserInfo;
            pictureBox1.InitialImage = Properties.Resources.UserInfo;
            pictureBox1.Location = new Point(9, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1367, 621);
            Controls.Add(panelUserInfo);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ NHÀ THUỐC";
            WindowState = FormWindowState.Maximized;
            Load += fMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelUserInfo.ResumeLayout(false);
            panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel panelUserInfo;
        private PictureBox pictureBox1;
        private Label labelUserInfo;
        private Button btnLogout;
    }
}
