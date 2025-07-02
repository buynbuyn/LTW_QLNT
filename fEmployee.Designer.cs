using System.Diagnostics;

namespace QLNT
{
    partial class fEmployee
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
            dtgvEmployee = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            HireDate = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            EmailEmployee = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            panel1 = new Panel();
            btnFindEmployee = new Button();
            btnAddEmployee = new Button();
            panelEmployee = new Panel();
            panelEmployeeCard = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(682, 22);
            label1.Name = "label1";
            label1.Size = new Size(304, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dtgvEmployee
            // 
            dtgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvEmployee.BackgroundColor = Color.White;
            dtgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEmployee.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, EmployeeName, Gender, Position, Salary, HireDate, PhoneNumber, EmailEmployee, Status });
            dtgvEmployee.EnableHeadersVisualStyles = false;
            dtgvEmployee.GridColor = Color.LightSteelBlue;
            dtgvEmployee.Location = new Point(12, 83);
            dtgvEmployee.Name = "dtgvEmployee";
            dtgvEmployee.RowHeadersVisible = false;
            dtgvEmployee.RowHeadersWidth = 51;
            dtgvEmployee.Size = new Size(974, 497);
            dtgvEmployee.TabIndex = 1;
            dtgvEmployee.CellContentClick += dtgvEmployee_CellContentClick;
            // 
            // EmployeeID
            // 
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.HeaderText = "ID";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Width = 53;
            // 
            // EmployeeName
            // 
            EmployeeName.DataPropertyName = "EmployeeName";
            EmployeeName.HeaderText = "Họ và tên";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.Width = 102;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 94;
            // 
            // Position
            // 
            Position.DataPropertyName = "Position";
            Position.HeaderText = "Vị trí";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.Width = 69;
            // 
            // Salary
            // 
            Salary.DataPropertyName = "Salary";
            Salary.HeaderText = "Lương";
            Salary.MinimumWidth = 6;
            Salary.Name = "Salary";
            Salary.Width = 80;
            // 
            // HireDate
            // 
            HireDate.DataPropertyName = "HireDate";
            HireDate.HeaderText = "Ngày làm việc";
            HireDate.MinimumWidth = 6;
            HireDate.Name = "HireDate";
            HireDate.Width = 132;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "SĐT";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 65;
            // 
            // EmailEmployee
            // 
            EmailEmployee.DataPropertyName = "EmailEmployee";
            EmailEmployee.HeaderText = "Email";
            EmailEmployee.MinimumWidth = 6;
            EmailEmployee.Name = "EmailEmployee";
            EmailEmployee.Width = 75;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 81;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFindEmployee);
            panel1.Controls.Add(btnAddEmployee);
            panel1.Location = new Point(1093, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 43);
            panel1.TabIndex = 2;
            // 
            // btnFindEmployee
            // 
            btnFindEmployee.BackColor = SystemColors.ControlDark;
            btnFindEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFindEmployee.Location = new Point(166, -1);
            btnFindEmployee.Name = "btnFindEmployee";
            btnFindEmployee.Size = new Size(157, 36);
            btnFindEmployee.TabIndex = 1;
            btnFindEmployee.Text = "Tìm nhân viên";
            btnFindEmployee.UseVisualStyleBackColor = false;
            btnFindEmployee.Click += btnFindEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = SystemColors.ControlDark;
            btnAddEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmployee.Location = new Point(3, 0);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(154, 36);
            btnAddEmployee.TabIndex = 0;
            btnAddEmployee.Text = "Thêm nhân viên";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // panelEmployee
            // 
            panelEmployee.BackColor = SystemColors.ActiveBorder;
            panelEmployee.Location = new Point(1020, 132);
            panelEmployee.Name = "panelEmployee";
            panelEmployee.Size = new Size(491, 448);
            panelEmployee.TabIndex = 3;
            panelEmployee.Visible = false;
            // 
            // panelEmployeeCard
            // 
            panelEmployeeCard.Location = new Point(12, 586);
            panelEmployeeCard.Name = "panelEmployeeCard";
            panelEmployeeCard.Size = new Size(397, 247);
            panelEmployeeCard.TabIndex = 4;
            // 
            // fEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 845);
            Controls.Add(panelEmployeeCard);
            Controls.Add(panelEmployee);
            Controls.Add(panel1);
            Controls.Add(dtgvEmployee);
            Controls.Add(label1);
            Name = "fEmployee";
            Text = "QUẢN LÝ NHÂN VIÊN";
            WindowState = FormWindowState.Maximized;
            Load += fEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvEmployee;
        private Panel panel1;
        private Button btnFindEmployee;
        private Button btnAddEmployee;
        private Panel panelEmployee;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn HireDate;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn EmailEmployee;
        private DataGridViewCheckBoxColumn Status;
        private Panel panelEmployeeCard;
    }
}