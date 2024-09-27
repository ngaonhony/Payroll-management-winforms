namespace QLTL
{
    partial class fEditTimeKeeping
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btClose = new Button();
            btSave = new Button();
            cbName = new ComboBox();
            txtYear = new TextBox();
            txtMonth = new TextBox();
            txtSoNgayNghiHuongLuong = new TextBox();
            txtSoNgayCong = new TextBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F);
            label7.Location = new Point(405, 272);
            label7.Name = "label7";
            label7.Size = new Size(40, 18);
            label7.TabIndex = 27;
            label7.Text = "Năm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 272);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 26;
            label6.Text = "Tháng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 197);
            label5.Name = "label5";
            label5.Size = new Size(185, 20);
            label5.TabIndex = 25;
            label5.Text = "Số ngày nghỉ hưởng lương";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 133);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 24;
            label3.Text = "Số ngày công";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 76);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 23;
            label2.Text = "Tên nhân viên";
            label2.UseCompatibleTextRendering = true;
            // 
            // btClose
            // 
            btClose.Location = new Point(382, 344);
            btClose.Margin = new Padding(3, 4, 3, 4);
            btClose.Name = "btClose";
            btClose.Size = new Size(86, 31);
            btClose.TabIndex = 6;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(222, 344);
            btSave.Margin = new Padding(3, 4, 3, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(86, 31);
            btSave.TabIndex = 5;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // cbName
            // 
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(277, 76);
            cbName.Margin = new Padding(3, 4, 3, 4);
            cbName.Name = "cbName";
            cbName.Size = new Size(427, 28);
            cbName.TabIndex = 0;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(448, 265);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(141, 27);
            txtYear.TabIndex = 4;
            txtYear.Validating += txtYear_Validating;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(215, 265);
            txtMonth.Margin = new Padding(3, 4, 3, 4);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(130, 27);
            txtMonth.TabIndex = 3;
            txtMonth.Validating += txtMonth_Validating;
            // 
            // txtSoNgayNghiHuongLuong
            // 
            txtSoNgayNghiHuongLuong.Location = new Point(279, 189);
            txtSoNgayNghiHuongLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoNgayNghiHuongLuong.Name = "txtSoNgayNghiHuongLuong";
            txtSoNgayNghiHuongLuong.Size = new Size(426, 27);
            txtSoNgayNghiHuongLuong.TabIndex = 2;
            txtSoNgayNghiHuongLuong.Validating += txtSoNgayNghiHuongLuong_Validating;
            // 
            // txtSoNgayCong
            // 
            txtSoNgayCong.Location = new Point(278, 128);
            txtSoNgayCong.Margin = new Padding(3, 4, 3, 4);
            txtSoNgayCong.Name = "txtSoNgayCong";
            txtSoNgayCong.Size = new Size(426, 27);
            txtSoNgayCong.TabIndex = 1;
            txtSoNgayCong.Validating += txtSoNgayCong_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(277, 20);
            label1.Name = "label1";
            label1.Size = new Size(241, 41);
            label1.TabIndex = 28;
            label1.Text = "Sửa Chấm Công";
            // 
            // fEditTimeKeeping
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
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
            Name = "fEditTimeKeeping";
            Text = "Sửa nhân viên";
            FormClosing += fEditchamcong_FormClosing;
            Load += fEditchamcong_Load;
            Validating += cbName_Validating;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button btClose;
        private Button btSave;
        private ComboBox cbName;
        private TextBox txtYear;
        private TextBox txtMonth;
        private TextBox txtSoNgayNghiHuongLuong;
        private TextBox txtSoNgayCong;
        private ToolTip toolTip1;
        private Label label1;
    }
}