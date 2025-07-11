namespace QLNT
{
    partial class fAddAccount
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
            txtFullName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            cbRole = new ComboBox();
            ckStatus = new CheckBox();
            btnSaveAddAccount = new Button();
            btnClose = new Button();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(114, 33);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 1;
            label1.Text = "THÊM TÀI KHOẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 78);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Vai trò";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 78);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Họ và tên";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(31, 110);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(176, 27);
            txtFullName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 163);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 27);
            txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(229, 163);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(229, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 239);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 10;
            label6.Text = "Role";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(31, 262);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(121, 28);
            cbRole.TabIndex = 11;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.BottomRight;
            ckStatus.ImageAlign = ContentAlignment.MiddleRight;
            ckStatus.Location = new Point(229, 264);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 12;
            ckStatus.Text = "Trạng thái";
            ckStatus.TextAlign = ContentAlignment.MiddleRight;
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // btnSaveAddAccount
            // 
            btnSaveAddAccount.BackColor = Color.Maroon;
            btnSaveAddAccount.BackgroundImageLayout = ImageLayout.None;
            btnSaveAddAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAddAccount.ForeColor = Color.White;
            btnSaveAddAccount.Location = new Point(189, 313);
            btnSaveAddAccount.Name = "btnSaveAddAccount";
            btnSaveAddAccount.Size = new Size(165, 45);
            btnSaveAddAccount.TabIndex = 16;
            btnSaveAddAccount.Text = "LƯU THÔNG TIN";
            btnSaveAddAccount.UseVisualStyleBackColor = false;
            btnSaveAddAccount.Click += btnSaveAddAccount_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(33, 314);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 44);
            btnClose.TabIndex = 17;
            btnClose.Text = "HỦY";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(229, 110);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 18;
            // 
            // fAddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUserName);
            Controls.Add(btnClose);
            Controls.Add(btnSaveAddAccount);
            Controls.Add(ckStatus);
            Controls.Add(cbRole);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fAddAccount";
            Text = "THÊM TÀI KHOẢN ADMIN";
            Load += fAddAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFullName;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private ComboBox cbRole;
        private CheckBox ckStatus;
        private Button btnSaveAddAccount;
        private Button btnClose;
        private TextBox txtUserName;
    }
}