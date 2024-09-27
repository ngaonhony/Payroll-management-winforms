namespace QLTL
{
    partial class fManageEmployee
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
            btNew = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            MANV = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            THUMBNAIL = new DataGridViewTextBoxColumn();
            BIRTHDAY = new DataGridViewTextBoxColumn();
            NGAYVAOLAM = new DataGridViewTextBoxColumn();
            GENDER = new DataGridViewTextBoxColumn();
            ADDRESS = new DataGridViewTextBoxColumn();
            PHONE = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btFind = new Button();
            txtName = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            cbPhongban = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btNew
            // 
            btNew.Location = new Point(78, 97);
            btNew.Name = "btNew";
            btNew.Size = new Size(129, 29);
            btNew.TabIndex = 2;
            btNew.Text = "Thêm nhân viên";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(370, 36);
            label1.Name = "label1";
            label1.Size = new Size(304, 38);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MANV, NAME, THUMBNAIL, BIRTHDAY, NGAYVAOLAM, GENDER, ADDRESS, PHONE, Edit, Delete });
            dataGridView1.Location = new Point(78, 137);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1287, 423);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MANV
            // 
            MANV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MANV.DataPropertyName = "MANV";
            MANV.HeaderText = "Mã";
            MANV.MinimumWidth = 6;
            MANV.Name = "MANV";
            MANV.Width = 59;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NAME.DataPropertyName = "NAME";
            NAME.HeaderText = "Họ Tên";
            NAME.MinimumWidth = 6;
            NAME.Name = "NAME";
            NAME.Width = 85;
            // 
            // THUMBNAIL
            // 
            THUMBNAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            THUMBNAIL.DataPropertyName = "THUMBNAIL";
            THUMBNAIL.HeaderText = "Hình Ảnh";
            THUMBNAIL.MinimumWidth = 6;
            THUMBNAIL.Name = "THUMBNAIL";
            THUMBNAIL.Width = 99;
            // 
            // BIRTHDAY
            // 
            BIRTHDAY.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BIRTHDAY.DataPropertyName = "BIRTHDAY";
            BIRTHDAY.HeaderText = "Ngày Sinh";
            BIRTHDAY.MinimumWidth = 6;
            BIRTHDAY.Name = "BIRTHDAY";
            BIRTHDAY.Width = 105;
            // 
            // NGAYVAOLAM
            // 
            NGAYVAOLAM.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NGAYVAOLAM.DataPropertyName = "NGAYVAOLAM";
            NGAYVAOLAM.HeaderText = "Ngày Vào Làm";
            NGAYVAOLAM.MinimumWidth = 6;
            NGAYVAOLAM.Name = "NGAYVAOLAM";
            NGAYVAOLAM.Width = 134;
            // 
            // GENDER
            // 
            GENDER.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GENDER.DataPropertyName = "GENDER";
            GENDER.HeaderText = "Giới Tính";
            GENDER.MinimumWidth = 6;
            GENDER.Name = "GENDER";
            GENDER.Width = 97;
            // 
            // ADDRESS
            // 
            ADDRESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ADDRESS.DataPropertyName = "ADDRESS";
            ADDRESS.HeaderText = "Địa Chỉ";
            ADDRESS.MinimumWidth = 6;
            ADDRESS.Name = "ADDRESS";
            ADDRESS.Width = 86;
            // 
            // PHONE
            // 
            PHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PHONE.DataPropertyName = "PHONE";
            PHONE.HeaderText = "Số Điện Thoại";
            PHONE.MinimumWidth = 6;
            PHONE.Name = "PHONE";
            PHONE.Resizable = DataGridViewTriState.True;
            PHONE.Width = 131;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 41;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 59;
            // 
            // btFind
            // 
            btFind.Location = new Point(883, 97);
            btFind.Name = "btFind";
            btFind.Size = new Size(94, 29);
            btFind.TabIndex = 1;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(716, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 27);
            txtName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 103);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 6;
            label3.Text = "Nhập tên nhân viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(307, 589);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 412);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 691);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 8;
            label2.Text = "HÌNH ẢNH";
            // 
            // cbPhongban
            // 
            cbPhongban.FormattingEnabled = true;
            cbPhongban.Location = new Point(355, 96);
            cbPhongban.Margin = new Padding(3, 4, 3, 4);
            cbPhongban.Name = "cbPhongban";
            cbPhongban.Size = new Size(138, 28);
            cbPhongban.TabIndex = 4;
            cbPhongban.SelectedIndexChanged += cbPhongban_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 100);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 10;
            label4.Text = "Phòng ban";
            // 
            // fManageEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1413, 1044);
            Controls.Add(label4);
            Controls.Add(cbPhongban);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(btFind);
            Controls.Add(label1);
            Controls.Add(btNew);
            Controls.Add(dataGridView1);
            Name = "fManageEmployee";
            Text = "Quản lý nhân viên";
            WindowState = FormWindowState.Maximized;
            Activated += ManageEmployee_Activated;
            Load += ManageEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNew;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btFind;
        private TextBox txtName;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox cbPhongban;
        private Label label4;
        private DataGridViewTextBoxColumn MANV;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn THUMBNAIL;
        private DataGridViewTextBoxColumn BIRTHDAY;
        private DataGridViewTextBoxColumn NGAYVAOLAM;
        private DataGridViewTextBoxColumn GENDER;
        private DataGridViewTextBoxColumn ADDRESS;
        private DataGridViewTextBoxColumn PHONE;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}