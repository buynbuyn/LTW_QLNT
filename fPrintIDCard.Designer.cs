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
            panelCard.BackColor = Color.Thistle;
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(lblCompany);
            panelCard.Controls.Add(lblName);
            panelCard.Controls.Add(lblPosition);
            panelCard.Controls.Add(lblID);
            panelCard.Location = new Point(10, 10);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(300, 180);
            panelCard.TabIndex = 0;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.BackColor = Color.Transparent;
            lblCompany.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompany.ForeColor = Color.MidnightBlue;
            lblCompany.Location = new Point(3, 11);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(294, 28);
            lblCompany.TabIndex = 0;
            lblCompany.Text = "THẺ NHÂN VIÊN NHÀ THUỐC";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblName.Location = new Point(38, 63);
            lblName.Name = "lblName";
            lblName.Size = new Size(123, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Nguyễn Văn A";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(38, 103);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(141, 20);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Nhân viên bán hàng";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(38, 141);
            lblID.Name = "lblID";
            lblID.Size = new Size(85, 20);
            lblID.TabIndex = 4;
            lblID.Text = "Mã NV: 001";
            // 
            // fPrintIDCard
            // 
            ClientSize = new Size(320, 200);
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