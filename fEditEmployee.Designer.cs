namespace QLTL
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
            components = new System.ComponentModel.Container();
            label3 = new Label();
            txtGioitinh = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cbPhongban = new ComboBox();
            cbChucvu = new ComboBox();
            btBrowse = new Button();
            txtImageFile = new TextBox();
            pictureBox1 = new PictureBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            label10 = new Label();
            dateTimePicker2 = new DateTimePicker();
            btClose = new Button();
            btSave = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 176);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 40;
            label3.Text = "Giới tính";
            // 
            // txtGioitinh
            // 
            txtGioitinh.Location = new Point(608, 173);
            txtGioitinh.Name = "txtGioitinh";
            txtGioitinh.Size = new Size(151, 27);
            txtGioitinh.TabIndex = 32;
            txtGioitinh.Validating += txtGioitinh_Validating;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(224, 168);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 27);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // cbPhongban
            // 
            cbPhongban.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPhongban.FormattingEnabled = true;
            cbPhongban.Location = new Point(608, 312);
            cbPhongban.Name = "cbPhongban";
            cbPhongban.Size = new Size(151, 28);
            cbPhongban.TabIndex = 36;
            cbPhongban.Validating += cbPhongban_Validating;
            // 
            // cbChucvu
            // 
            cbChucvu.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbChucvu.FormattingEnabled = true;
            cbChucvu.ItemHeight = 20;
            cbChucvu.Location = new Point(608, 240);
            cbChucvu.Name = "cbChucvu";
            cbChucvu.Size = new Size(151, 28);
            cbChucvu.TabIndex = 34;
            cbChucvu.Validating += cbChucvu_Validating;
            // 
            // btBrowse
            // 
            btBrowse.BackColor = SystemColors.ButtonFace;
            btBrowse.Location = new Point(409, 305);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(53, 29);
            btBrowse.TabIndex = 28;
            btBrowse.Text = "...";
            btBrowse.UseVisualStyleBackColor = false;
            btBrowse.Click += btBrowse_Click;
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(222, 305);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(181, 27);
            txtImageFile.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(222, 360);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(608, 101);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(154, 27);
            txtPhone.TabIndex = 30;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(222, 239);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(181, 27);
            txtAddress.TabIndex = 24;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(224, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 27);
            txtName.TabIndex = 21;
            txtName.Validating += txtName_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(504, 312);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 35;
            label9.Text = "Phòng ban";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(504, 244);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 33;
            label8.Text = "Chức vụ ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(469, 168);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 304);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 29;
            label6.Text = "Tập tin hình";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 104);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 27;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 244);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 25;
            label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 168);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 23;
            label2.Text = "Ngày sinh ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 104);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 20;
            label1.Text = "Tên nhân viên ";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(496, 372);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 44;
            label10.Text = "Ngày Vào Làm";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(608, 372);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(179, 27);
            dateTimePicker2.TabIndex = 41;
            dateTimePicker2.Validating += dateTimePicker2_Validating;
            // 
            // btClose
            // 
            btClose.Location = new Point(668, 457);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 43;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(507, 457);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 42;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(296, 25);
            label11.Name = "label11";
            label11.Size = new Size(315, 60);
            label11.TabIndex = 45;
            label11.Text = "SỬA NHÂN VIÊN";
            // 
            // fEditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dateTimePicker2);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label3);
            Controls.Add(txtGioitinh);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbPhongban);
            Controls.Add(cbChucvu);
            Controls.Add(btBrowse);
            Controls.Add(txtImageFile);
            Controls.Add(pictureBox1);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fEditEmployee";
            Text = "Sửa nhân viên";
            WindowState = FormWindowState.Maximized;
            FormClosing += fEditNhanVien_FormClosing;
            Load += fEditNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtGioitinh;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbPhongban;
        private ComboBox cbChucvu;
        private Button btBrowse;
        private TextBox txtImageFile;
        private PictureBox pictureBox1;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private Button btClose;
        private Button btSave;
        private Label label11;
    }
}