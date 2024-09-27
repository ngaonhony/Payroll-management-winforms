namespace QLTL
{
    partial class fNewEmployee
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            pictureBox1 = new PictureBox();
            btSave = new Button();
            btClose = new Button();
            txtImageFile = new TextBox();
            cbChucvu = new ComboBox();
            cbPhongban = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            toolTip1 = new ToolTip(components);
            btBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtGioitinh = new TextBox();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 66);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 130);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 206);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 66);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 266);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 5;
            label6.Text = "Tập tin hình";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 130);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(430, 206);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 7;
            label8.Text = "Chức vụ ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(430, 274);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 8;
            label9.Text = "Phòng ban";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 27);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(148, 201);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(181, 27);
            txtAddress.TabIndex = 2;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(534, 64);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(154, 27);
            txtPhone.TabIndex = 5;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(148, 322);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btSave
            // 
            btSave.Location = new Point(433, 434);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(594, 434);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 10;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // txtImageFile
            // 
            txtImageFile.Enabled = false;
            txtImageFile.Location = new Point(148, 268);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(181, 27);
            txtImageFile.TabIndex = 3;
            // 
            // cbChucvu
            // 
            cbChucvu.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbChucvu.FormattingEnabled = true;
            cbChucvu.ItemHeight = 20;
            cbChucvu.Location = new Point(534, 202);
            cbChucvu.Name = "cbChucvu";
            cbChucvu.Size = new Size(151, 28);
            cbChucvu.TabIndex = 7;
            cbChucvu.Validating += cbChucvu_Validating;
            // 
            // cbPhongban
            // 
            cbPhongban.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPhongban.FormattingEnabled = true;
            cbPhongban.Location = new Point(534, 274);
            cbPhongban.Name = "cbPhongban";
            cbPhongban.Size = new Size(151, 28);
            cbPhongban.TabIndex = 8;
            cbPhongban.Validating += cbPhongban_Validating;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(150, 130);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // btBrowse
            // 
            btBrowse.BackColor = SystemColors.ButtonFace;
            btBrowse.Location = new Point(336, 268);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(53, 29);
            btBrowse.TabIndex = 4;
            btBrowse.Text = "...";
            btBrowse.UseVisualStyleBackColor = false;
            btBrowse.Click += btBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtGioitinh
            // 
            txtGioitinh.Location = new Point(534, 136);
            txtGioitinh.Name = "txtGioitinh";
            txtGioitinh.Size = new Size(151, 27);
            txtGioitinh.TabIndex = 6;
            txtGioitinh.Validating += txtGioitinh_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 138);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 19;
            label3.Text = "Giới tính";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(534, 349);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(179, 27);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Validating += dateTimePicker2_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(422, 349);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 21;
            label10.Text = "Ngày Vào Làm";
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(244, 1);
            label11.Name = "label11";
            label11.Size = new Size(353, 60);
            label11.TabIndex = 22;
            label11.Text = "THÊM NHÂN VIÊN";
            // 
            // fNewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(809, 475);
            ControlBox = false;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(txtGioitinh);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbPhongban);
            Controls.Add(cbChucvu);
            Controls.Add(btBrowse);
            Controls.Add(txtImageFile);
            Controls.Add(btClose);
            Controls.Add(btSave);
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
            Name = "fNewEmployee";
            Text = "Thêm nhân viên";
            WindowState = FormWindowState.Maximized;
            FormClosing += NewNhanVien_FormClosing;
            Load += NewNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private PictureBox pictureBox1;
        private Button btSave;
        private Button btClose;
        private TextBox txtImageFile;
        private ComboBox cbChucvu;
        private ComboBox cbPhongban;
        private DateTimePicker dateTimePicker1;
        private ToolTip toolTip1;
        private Button btBrowse;
        private OpenFileDialog openFileDialog1;
        private TextBox txtGioitinh;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private Label label11;
    }
}