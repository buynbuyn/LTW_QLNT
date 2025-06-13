namespace QLNT
{
    partial class fFindEmployee
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
            btnClose = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(285, 23);
            label1.TabIndex = 1;
            label1.Text = "TÌM KIẾM THÔNG TIN NHÂN VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(12, 92);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(339, 27);
            txtEmployeeName.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(12, 158);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 45);
            btnClose.TabIndex = 17;
            btnClose.Text = "HỦY";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Maroon;
            btnFind.BackgroundImageLayout = ImageLayout.None;
            btnFind.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(225, 158);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(126, 45);
            btnFind.TabIndex = 18;
            btnFind.Text = "TÌM KIẾM";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // fFindEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFind);
            Controls.Add(btnClose);
            Controls.Add(txtEmployeeName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fFindEmployee";
            Text = "TÌM NHÂN VIÊN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmployeeName;
        private Button btnClose;
        private Button btnFind;
    }
}