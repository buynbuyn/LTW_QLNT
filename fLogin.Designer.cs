namespace QLNT
{
    partial class fLogin
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
            txtName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 44);
            label1.Name = "label1";
            label1.Size = new Size(291, 28);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 99);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(391, 27);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(218, 169);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(218, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(391, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(348, 244);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fLogin";
            Text = "ĐĂNG NHẬP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}