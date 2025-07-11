namespace QLNT
{
    partial class fPrintIDCard
    {

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCompany;

        private void InitializeComponent()
        {
            panelCard = new Panel();
            lblCompany = new Label();
            lblName = new Label();
            lblPosition = new Label();
            lblID = new Label();
            panelCard.SuspendLayout();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.PowderBlue;
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(lblCompany);
            panelCard.Controls.Add(lblName);
            panelCard.Controls.Add(lblPosition);
            panelCard.Controls.Add(lblID);
            panelCard.Location = new Point(10, 10);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(400, 230);
            panelCard.TabIndex = 0;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.BackColor = Color.Transparent;
            lblCompany.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompany.ForeColor = Color.MidnightBlue;
            lblCompany.Location = new Point(38, 15);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(334, 31);
            lblCompany.TabIndex = 0;
            lblCompany.Text = "THẺ NHÂN VIÊN NHÀ THUỐC";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(27, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(147, 28);
            lblName.TabIndex = 2;
            lblName.Text = "Nguyễn Văn A";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.Location = new Point(29, 123);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(171, 25);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Nhân viên bán hàng";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(32, 176);
            lblID.Name = "lblID";
            lblID.Size = new Size(105, 25);
            lblID.TabIndex = 4;
            lblID.Text = "Mã NV: 001";
            // 
            // fPrintIDCard
            // 
            ClientSize = new Size(437, 287);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "fPrintIDCard";
            Text = "In Thẻ Nhân Viên";
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
        }
    }
}