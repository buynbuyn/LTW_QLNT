namespace QLNT
{
    partial class HoaDonChiTiet
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
            textBox1 = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label12 = new Label();
            textBox10 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(539, 7);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn chi tiết";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(14, 90);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 31);
            label2.TabIndex = 0;
            label2.Text = "Mã Hóa Đơn";
            label2.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 38);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 2);
            label3.Name = "label3";
            label3.Size = new Size(255, 31);
            label3.TabIndex = 2;
            label3.Text = "Thông tin Khách Hàng";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(14, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(1232, 619);
            panel1.TabIndex = 3;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(1025, 581);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(165, 38);
            textBox9.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(1025, 537);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(165, 38);
            textBox8.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1025, 493);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(165, 38);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1025, 450);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(165, 38);
            textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1025, 406);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 38);
            textBox5.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(65, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1106, 208);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên sản phẩm";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Số lượng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn vị tính";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Thành tiền";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(864, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(326, 38);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(488, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(275, 38);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(9, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 38);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(850, 584);
            label11.Name = "label11";
            label11.Size = new Size(129, 31);
            label11.TabIndex = 2;
            label11.Text = "Thành tiền";
            label11.Click += label3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(850, 540);
            label10.Name = "label10";
            label10.Size = new Size(112, 31);
            label10.TabIndex = 2;
            label10.Text = "Thuế: 5%";
            label10.Click += label3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(850, 496);
            label9.Name = "label9";
            label9.Size = new Size(109, 31);
            label9.TabIndex = 2;
            label9.Text = "Giảm giá";
            label9.Click += label3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(850, 453);
            label8.Name = "label8";
            label8.Size = new Size(117, 31);
            label8.TabIndex = 2;
            label8.Text = "Tổng tiền";
            label8.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(850, 409);
            label7.Name = "label7";
            label7.Size = new Size(169, 31);
            label7.TabIndex = 2;
            label7.Text = "Tổng số lượng";
            label7.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(864, 54);
            label6.Name = "label6";
            label6.Size = new Size(193, 31);
            label6.TabIndex = 2;
            label6.Text = "SĐT Khách Hàng";
            label6.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 48);
            label5.Name = "label5";
            label5.Size = new Size(209, 31);
            label5.TabIndex = 2;
            label5.Text = "Email Khách Hàng";
            label5.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 48);
            label4.Name = "label4";
            label4.Size = new Size(225, 31);
            label4.TabIndex = 2;
            label4.Text = "Họ Tên Khách Hàng";
            label4.Click += label3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label12.Location = new Point(1094, 90);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(76, 31);
            label12.TabIndex = 0;
            label12.Text = "Ngày:";
            label12.Click += label1_Click;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(999, 124);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(247, 38);
            textBox10.TabIndex = 1;
            // 
            // HoaDonChiTiet
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 795);
            Controls.Add(panel1);
            Controls.Add(textBox10);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "HoaDonChiTiet";
            Text = "Hóa đơn chi tiết";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Panel panel1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label12;
        private TextBox textBox10;
    }
}