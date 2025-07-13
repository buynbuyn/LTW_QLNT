namespace QLNT
{
    partial class fAddProductDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblProductName;
        private Label lblDosage;
        private Label lblUnit;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblExpirationDate;
        private Label lblDescription;
        private TextBox txtQuantity;
        private DateTimePicker dtpExpirationDate;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnCancel;
        private Panel panelProductInfo;
        private Panel panelInput;
        private Panel panelButtons;

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
            lblProductName = new Label();
            lblDosage = new Label();
            lblUnit = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblExpirationDate = new Label();
            lblDescription = new Label();
            txtQuantity = new TextBox();
            dtpExpirationDate = new DateTimePicker();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            panelProductInfo = new Panel();
            panelInput = new Panel();
            panelButtons = new Panel();

            panelProductInfo.SuspendLayout();
            panelInput.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();

            // 
            // panelProductInfo
            // 
            panelProductInfo.BorderStyle = BorderStyle.FixedSingle;
            panelProductInfo.Controls.Add(lblProductName);
            panelProductInfo.Controls.Add(lblDosage);
            panelProductInfo.Controls.Add(lblUnit);
            panelProductInfo.Controls.Add(lblPrice);
            panelProductInfo.Location = new Point(12, 12);
            panelProductInfo.Name = "panelProductInfo";
            panelProductInfo.Size = new Size(360, 120);
            panelProductInfo.TabIndex = 0;

            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.ForeColor = Color.DarkBlue;
            lblProductName.Location = new Point(10, 10);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(120, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Sản phẩm: ";

            // 
            // lblDosage
            // 
            lblDosage.AutoSize = true;
            lblDosage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDosage.Location = new Point(10, 35);
            lblDosage.Name = "lblDosage";
            lblDosage.Size = new Size(80, 17);
            lblDosage.TabIndex = 1;
            lblDosage.Text = "Liều lượng: ";

            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnit.Location = new Point(10, 60);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(50, 17);
            lblUnit.TabIndex = 2;
            lblUnit.Text = "Đơn vị: ";

            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(10, 85);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 17);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Giá: ";

            // 
            // panelInput
            // 
            panelInput.BorderStyle = BorderStyle.FixedSingle;
            panelInput.Controls.Add(lblQuantity);
            panelInput.Controls.Add(txtQuantity);
            panelInput.Controls.Add(lblExpirationDate);
            panelInput.Controls.Add(dtpExpirationDate);
            panelInput.Controls.Add(lblDescription);
            panelInput.Controls.Add(txtDescription);
            panelInput.Location = new Point(12, 140);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(360, 180);
            panelInput.TabIndex = 1;

            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantity.Location = new Point(10, 15);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(67, 17);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Số lượng:";

            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(120, 12);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(220, 25);
            txtQuantity.TabIndex = 1;
            txtQuantity.TextAlign = HorizontalAlignment.Right;

            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpirationDate.Location = new Point(10, 50);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(96, 17);
            lblExpirationDate.TabIndex = 2;
            lblExpirationDate.Text = "Ngày hết hạn:";

            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpExpirationDate.Format = DateTimePickerFormat.Short;
            dtpExpirationDate.Location = new Point(120, 47);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(220, 25);
            dtpExpirationDate.TabIndex = 3;

            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(10, 85);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(50, 17);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Mô tả:";

            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(120, 82);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(220, 80);
            txtDescription.TabIndex = 5;

            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnSave);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Location = new Point(12, 330);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(360, 50);
            panelButtons.TabIndex = 2;

            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(180, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;

            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(270, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;

            // 
            // fAddProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 392);
            Controls.Add(panelProductInfo);
            Controls.Add(panelInput);
            Controls.Add(panelButtons);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fAddProductDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm sản phẩm vào kho";

            panelProductInfo.ResumeLayout(false);
            panelProductInfo.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}