namespace QLNT
{
    partial class fAddEmployee
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
            txtEmployeeName = new TextBox();
            label3 = new Label();
            cbGender = new ComboBox();
            label4 = new Label();
            cbPosition = new ComboBox();
            label5 = new Label();
            txtSalary = new TextBox();
            label6 = new Label();
            txtEmailEmployee = new TextBox();
            label7 = new Label();
            txtPhoneNumber = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnSaveAddEmployee = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(141, 25);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 0;
            label1.Text = "THÊM NHÂN VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(12, 92);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(214, 27);
            txtEmployeeName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(265, 69);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Giới tính";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(265, 91);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(138, 28);
            cbGender.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(265, 140);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 5;
            label4.Text = "Vị trí";
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(265, 165);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(138, 28);
            cbPosition.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 140);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 7;
            label5.Text = "Lương";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(14, 165);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(212, 27);
            txtSalary.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(265, 215);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 9;
            label6.Text = "SĐT";
            // 
            // txtEmailEmployee
            // 
            txtEmailEmployee.Location = new Point(16, 241);
            txtEmailEmployee.Name = "txtEmailEmployee";
            txtEmailEmployee.Size = new Size(210, 27);
            txtEmailEmployee.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 214);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 11;
            label7.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(265, 240);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(138, 27);
            txtPhoneNumber.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 305);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 13;
            label8.Text = "Ngày vào làm việc";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(158, 300);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(235, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // btnSaveAddEmployee
            // 
            btnSaveAddEmployee.BackColor = Color.Maroon;
            btnSaveAddEmployee.BackgroundImageLayout = ImageLayout.None;
            btnSaveAddEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAddEmployee.ForeColor = Color.White;
            btnSaveAddEmployee.Location = new Point(168, 359);
            btnSaveAddEmployee.Name = "btnSaveAddEmployee";
            btnSaveAddEmployee.Size = new Size(235, 45);
            btnSaveAddEmployee.TabIndex = 15;
            btnSaveAddEmployee.Text = "LƯU THÔNG TIN";
            btnSaveAddEmployee.UseVisualStyleBackColor = false;
            btnSaveAddEmployee.Click += btnSaveAddEmployee_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(16, 359);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 45);
            btnClose.TabIndex = 16;
            btnClose.Text = "HỦY";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // fAddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(btnClose);
            Controls.Add(btnSaveAddEmployee);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label7);
            Controls.Add(txtEmailEmployee);
            Controls.Add(label6);
            Controls.Add(txtSalary);
            Controls.Add(label5);
            Controls.Add(cbPosition);
            Controls.Add(label4);
            Controls.Add(cbGender);
            Controls.Add(label3);
            Controls.Add(txtEmployeeName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fAddEmployee";
            Text = "THÊM NHÂN VIÊN";
            Load += fAddEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmployeeName;
        private Label label3;
        private ComboBox cbGender;
        private Label label4;
        private ComboBox cbPosition;
        private Label label5;
        private TextBox txtSalary;
        private Label label6;
        private TextBox txtEmailEmployee;
        private Label label7;
        private TextBox txtPhoneNumber;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Button btnSaveAddEmployee;
        private Button btnClose;
    }
}