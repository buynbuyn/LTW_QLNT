namespace QLNT
{
    partial class fEditEmployee
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
            txtEditEmployeeName = new TextBox();
            label3 = new Label();
            cbEditGender = new ComboBox();
            label4 = new Label();
            txtEditSalary = new TextBox();
            label5 = new Label();
            cbEditPosition = new ComboBox();
            label6 = new Label();
            txtEditEmail = new TextBox();
            label7 = new Label();
            txtEditPhone = new TextBox();
            label8 = new Label();
            dtEditTime = new DateTimePicker();
            btnSaveEditEmployee = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(78, 28);
            label1.Name = "label1";
            label1.Size = new Size(243, 23);
            label1.TabIndex = 2;
            label1.Text = "SỬA THÔNG TIN NHÂN VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 66);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Họ và tên";
            // 
            // txtEditEmployeeName
            // 
            txtEditEmployeeName.Location = new Point(27, 97);
            txtEditEmployeeName.Name = "txtEditEmployeeName";
            txtEditEmployeeName.Size = new Size(214, 27);
            txtEditEmployeeName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(267, 69);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Giới tính";
            // 
            // cbEditGender
            // 
            cbEditGender.FormattingEnabled = true;
            cbEditGender.Location = new Point(265, 96);
            cbEditGender.Name = "cbEditGender";
            cbEditGender.Size = new Size(138, 28);
            cbEditGender.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 146);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Lương";
            // 
            // txtEditSalary
            // 
            txtEditSalary.Location = new Point(27, 169);
            txtEditSalary.Name = "txtEditSalary";
            txtEditSalary.Size = new Size(214, 27);
            txtEditSalary.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(265, 146);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 9;
            label5.Text = "Vị trí";
            // 
            // cbEditPosition
            // 
            cbEditPosition.FormattingEnabled = true;
            cbEditPosition.Location = new Point(265, 169);
            cbEditPosition.Name = "cbEditPosition";
            cbEditPosition.Size = new Size(138, 28);
            cbEditPosition.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 217);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // txtEditEmail
            // 
            txtEditEmail.Location = new Point(27, 246);
            txtEditEmail.Name = "txtEditEmail";
            txtEditEmail.Size = new Size(214, 27);
            txtEditEmail.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(263, 217);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 13;
            label7.Text = "SĐT";
            // 
            // txtEditPhone
            // 
            txtEditPhone.Location = new Point(263, 246);
            txtEditPhone.Name = "txtEditPhone";
            txtEditPhone.Size = new Size(140, 27);
            txtEditPhone.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 299);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 15;
            label8.Text = "Ngày vào làm việc";
            // 
            // dtEditTime
            // 
            dtEditTime.Format = DateTimePickerFormat.Custom;
            dtEditTime.Location = new Point(169, 297);
            dtEditTime.Name = "dtEditTime";
            dtEditTime.Size = new Size(235, 27);
            dtEditTime.TabIndex = 16;
            // 
            // btnSaveEditEmployee
            // 
            btnSaveEditEmployee.BackColor = Color.Maroon;
            btnSaveEditEmployee.BackgroundImageLayout = ImageLayout.None;
            btnSaveEditEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveEditEmployee.ForeColor = Color.White;
            btnSaveEditEmployee.Location = new Point(168, 352);
            btnSaveEditEmployee.Name = "btnSaveEditEmployee";
            btnSaveEditEmployee.Size = new Size(235, 45);
            btnSaveEditEmployee.TabIndex = 17;
            btnSaveEditEmployee.Text = "LƯU THÔNG TIN";
            btnSaveEditEmployee.UseVisualStyleBackColor = false;
            btnSaveEditEmployee.Click += btnSaveEditEmployee_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(23, 352);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 45);
            btnClose.TabIndex = 18;
            btnClose.Text = "HỦY";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // fEditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSaveEditEmployee);
            Controls.Add(dtEditTime);
            Controls.Add(label8);
            Controls.Add(txtEditPhone);
            Controls.Add(label7);
            Controls.Add(txtEditEmail);
            Controls.Add(label6);
            Controls.Add(cbEditPosition);
            Controls.Add(label5);
            Controls.Add(txtEditSalary);
            Controls.Add(label4);
            Controls.Add(cbEditGender);
            Controls.Add(label3);
            Controls.Add(txtEditEmployeeName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fEditEmployee";
            Text = "fEditEmployee";
            Load += fEditEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEditEmployeeName;
        private Label label3;
        private ComboBox cbEditGender;
        private Label label4;
        private TextBox txtEditSalary;
        private Label label5;
        private ComboBox cbEditPosition;
        private Label label6;
        private TextBox txtEditEmail;
        private Label label7;
        private TextBox txtEditPhone;
        private Label label8;
        private DateTimePicker dtEditTime;
        private Button btnSaveEditEmployee;
        private Button btnClose;
    }
}