namespace QLNT
{
    partial class fEditAccount
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
            txtEditFullName = new TextBox();
            label3 = new Label();
            ckEditStatus = new CheckBox();
            cbEditRole = new ComboBox();
            label6 = new Label();
            txtEditPassword = new TextBox();
            label5 = new Label();
            txtEditEmail = new TextBox();
            label4 = new Label();
            btnClose = new Button();
            btnSaveEditAccount = new Button();
            txtEditUserName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(106, 20);
            label1.Name = "label1";
            label1.Size = new Size(242, 23);
            label1.TabIndex = 3;
            label1.Text = "SỬA THÔNG TIN TÀI KHOẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Họ và tên";
            // 
            // txtEditFullName
            // 
            txtEditFullName.Location = new Point(12, 93);
            txtEditFullName.Name = "txtEditFullName";
            txtEditFullName.Size = new Size(214, 27);
            txtEditFullName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(293, 59);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Vai trò";
            // 
            // ckEditStatus
            // 
            ckEditStatus.AutoSize = true;
            ckEditStatus.CheckAlign = ContentAlignment.BottomRight;
            ckEditStatus.ImageAlign = ContentAlignment.MiddleRight;
            ckEditStatus.Location = new Point(293, 250);
            ckEditStatus.Name = "ckEditStatus";
            ckEditStatus.Size = new Size(97, 24);
            ckEditStatus.TabIndex = 19;
            ckEditStatus.Text = "Trạng thái";
            ckEditStatus.TextAlign = ContentAlignment.MiddleRight;
            ckEditStatus.UseVisualStyleBackColor = true;
            // 
            // cbEditRole
            // 
            cbEditRole.FormattingEnabled = true;
            cbEditRole.Location = new Point(12, 246);
            cbEditRole.Name = "cbEditRole";
            cbEditRole.Size = new Size(121, 28);
            cbEditRole.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 223);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 17;
            label6.Text = "Role";
            // 
            // txtEditPassword
            // 
            txtEditPassword.Location = new Point(293, 179);
            txtEditPassword.Name = "txtEditPassword";
            txtEditPassword.Size = new Size(125, 27);
            txtEditPassword.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(293, 147);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 15;
            label5.Text = "Password";
            // 
            // txtEditEmail
            // 
            txtEditEmail.Location = new Point(12, 179);
            txtEditEmail.Name = "txtEditEmail";
            txtEditEmail.Size = new Size(176, 27);
            txtEditEmail.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(69, 304);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 44);
            btnClose.TabIndex = 21;
            btnClose.Text = "HỦY";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSaveEditAccount
            // 
            btnSaveEditAccount.BackColor = Color.Maroon;
            btnSaveEditAccount.BackgroundImageLayout = ImageLayout.None;
            btnSaveEditAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveEditAccount.ForeColor = Color.White;
            btnSaveEditAccount.Location = new Point(225, 303);
            btnSaveEditAccount.Name = "btnSaveEditAccount";
            btnSaveEditAccount.Size = new Size(165, 45);
            btnSaveEditAccount.TabIndex = 20;
            btnSaveEditAccount.Text = "LƯU THÔNG TIN";
            btnSaveEditAccount.UseVisualStyleBackColor = false;
            btnSaveEditAccount.Click += btnSaveEditAccount_Click;
            // 
            // txtEditUserName
            // 
            txtEditUserName.Location = new Point(293, 93);
            txtEditUserName.Name = "txtEditUserName";
            txtEditUserName.Size = new Size(125, 27);
            txtEditUserName.TabIndex = 22;
            // 
            // fEditAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEditUserName);
            Controls.Add(btnClose);
            Controls.Add(btnSaveEditAccount);
            Controls.Add(ckEditStatus);
            Controls.Add(cbEditRole);
            Controls.Add(label6);
            Controls.Add(txtEditPassword);
            Controls.Add(label5);
            Controls.Add(txtEditEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEditFullName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fEditAccount";
            Text = "fEditAccount";
            Load += fEditAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEditFullName;
        private Label label3;
        private CheckBox ckEditStatus;
        private ComboBox cbEditRole;
        private Label label6;
        private TextBox txtEditPassword;
        private Label label5;
        private TextBox txtEditEmail;
        private Label label4;
        private Button btnClose;
        private Button btnSaveEditAccount;
        private TextBox txtEditUserName;
    }
}