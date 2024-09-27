namespace QLTL
{
    partial class fNewTimeKeeping
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
            components = new System.ComponentModel.Container();
            txtSoNgayCong = new TextBox();
            txtSoNgayNghiHuongLuong = new TextBox();
            txtMonth = new TextBox();
            txtYear = new TextBox();
            cbName = new ComboBox();
            btSave = new Button();
            btClose = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSoNgayCong
            // 
            txtSoNgayCong.Location = new Point(264, 159);
            txtSoNgayCong.Margin = new Padding(3, 4, 3, 4);
            txtSoNgayCong.Name = "txtSoNgayCong";
            txtSoNgayCong.Size = new Size(426, 27);
            txtSoNgayCong.TabIndex = 1;
            // 
            // txtSoNgayNghiHuongLuong
            // 
            txtSoNgayNghiHuongLuong.Location = new Point(263, 221);
            txtSoNgayNghiHuongLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoNgayNghiHuongLuong.Name = "txtSoNgayNghiHuongLuong";
            txtSoNgayNghiHuongLuong.Size = new Size(426, 27);
            txtSoNgayNghiHuongLuong.TabIndex = 3;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(201, 296);
            txtMonth.Margin = new Padding(3, 4, 3, 4);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(130, 27);
            txtMonth.TabIndex = 4;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(434, 296);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(141, 27);
            txtYear.TabIndex = 5;
            // 
            // cbName
            // 
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(263, 107);
            cbName.Margin = new Padding(3, 4, 3, 4);
            cbName.Name = "cbName";
            cbName.Size = new Size(427, 28);
            cbName.TabIndex = 7;
            // 
            // btSave
            // 
            btSave.Location = new Point(208, 375);
            btSave.Margin = new Padding(3, 4, 3, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(86, 31);
            btSave.TabIndex = 8;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(368, 375);
            btClose.Margin = new Padding(3, 4, 3, 4);
            btClose.Name = "btClose";
            btClose.Size = new Size(86, 31);
            btClose.TabIndex = 9;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 107);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 10;
            label2.Text = "Tên nhân viên";
            label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 165);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 11;
            label3.Text = "Số ngày công";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 228);
            label5.Name = "label5";
            label5.Size = new Size(185, 20);
            label5.TabIndex = 13;
            label5.Text = "Số ngày nghỉ hưởng lương";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 303);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 14;
            label6.Text = "Tháng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F);
            label7.Location = new Point(390, 303);
            label7.Name = "label7";
            label7.Size = new Size(40, 18);
            label7.TabIndex = 15;
            label7.Text = "Năm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(263, 33);
            label1.Name = "label1";
            label1.Size = new Size(267, 41);
            label1.TabIndex = 18;
            label1.Text = "Thêm Chấm Công";
            // 
            // fNewTimeKeeping
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(776, 452);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(cbName);
            Controls.Add(txtYear);
            Controls.Add(txtMonth);
            Controls.Add(txtSoNgayNghiHuongLuong);
            Controls.Add(txtSoNgayCong);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fNewTimeKeeping";
            Text = "Thêm mới chấm công";
            WindowState = FormWindowState.Maximized;
            FormClosing += fNewTimeKeeping_FormClosing;
            Load += fNewTimeKeeping_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSoNgayCong;
        private TextBox txtSoNgayNghiHuongLuong;
        private TextBox txtMonth;
        private TextBox txtYear;
        private ComboBox cbName;
        private Button btSave;
        private Button btClose;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private ToolTip toolTip1;
        private Label label1;
    }
}