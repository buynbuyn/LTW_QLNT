namespace QLNT
{
    partial class fAccount
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
            dataGridView1 = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Fix = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnAddAccount = new Button();
            panelAccount = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(202, 22);
            label1.Name = "label1";
            label1.Size = new Size(406, 38);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ TÀI KHOẢN ADMIN";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserID, UserName, FullName, Email, Role, Status, Fix, Delete });
            dataGridView1.Location = new Point(12, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(683, 359);
            dataGridView1.TabIndex = 2;
            // 
            // UserID
            // 
            UserID.HeaderText = "ID";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.Width = 125;
            // 
            // UserName
            // 
            UserName.HeaderText = "Vai trò";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.Width = 125;
            // 
            // FullName
            // 
            FullName.HeaderText = "Họ và tên";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Role
            // 
            Role.HeaderText = "Quyền";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Fix
            // 
            Fix.HeaderText = "Sửa";
            Fix.MinimumWidth = 6;
            Fix.Name = "Fix";
            Fix.Resizable = DataGridViewTriState.True;
            Fix.SortMode = DataGridViewColumnSortMode.Automatic;
            Fix.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 125;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = SystemColors.ActiveBorder;
            btnAddAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAccount.Location = new Point(814, 63);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(146, 40);
            btnAddAccount.TabIndex = 3;
            btnAddAccount.Text = "Thêm tài khoản";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // panelAccount
            // 
            panelAccount.BackColor = SystemColors.ActiveBorder;
            panelAccount.Location = new Point(732, 126);
            panelAccount.Name = "panelAccount";
            panelAccount.Size = new Size(326, 296);
            panelAccount.TabIndex = 4;
            // 
            // fAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 503);
            Controls.Add(panelAccount);
            Controls.Add(btnAddAccount);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "fAccount";
            Text = "QUẢN LÝ TÀI KHOẢN";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Fix;
        private DataGridViewButtonColumn Delete;
        private Button btnAddAccount;
        private Panel panelAccount;
    }
}