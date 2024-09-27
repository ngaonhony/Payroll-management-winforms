namespace QLTL
{
    partial class fManageTimeKeeping
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
            dataGridView1 = new DataGridView();
            MACC = new DataGridViewTextBoxColumn();
            MANV = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            NGAYCONG = new DataGridViewTextBoxColumn();
            NGHIHL = new DataGridViewTextBoxColumn();
            THANGNAM = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btNew = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnTotalSalary = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MACC, MANV, NAME, NGAYCONG, NGHIHL, THANGNAM, Edit, Delete });
            dataGridView1.Location = new Point(115, 120);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(851, 399);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MACC
            // 
            MACC.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MACC.DataPropertyName = "MACC";
            MACC.HeaderText = "MACC";
            MACC.MinimumWidth = 6;
            MACC.Name = "MACC";
            MACC.Width = 79;
            // 
            // MANV
            // 
            MANV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MANV.DataPropertyName = "MANV";
            MANV.HeaderText = "MANV";
            MANV.MinimumWidth = 6;
            MANV.Name = "MANV";
            MANV.Width = 81;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NAME.DataPropertyName = "NAME";
            NAME.HeaderText = "NAME";
            NAME.MinimumWidth = 6;
            NAME.Name = "NAME";
            NAME.Width = 80;
            // 
            // NGAYCONG
            // 
            NGAYCONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NGAYCONG.DataPropertyName = "NGAYCONG";
            NGAYCONG.HeaderText = "NGAYCONG";
            NGAYCONG.MinimumWidth = 6;
            NGAYCONG.Name = "NGAYCONG";
            NGAYCONG.Width = 116;
            // 
            // NGHIHL
            // 
            NGHIHL.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NGHIHL.DataPropertyName = "NGHIHL";
            NGHIHL.HeaderText = "NGHIHL";
            NGHIHL.MinimumWidth = 6;
            NGHIHL.Name = "NGHIHL";
            NGHIHL.Width = 92;
            // 
            // THANGNAM
            // 
            THANGNAM.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            THANGNAM.DataPropertyName = "THANGNAM";
            THANGNAM.HeaderText = "THANGNAM";
            THANGNAM.MinimumWidth = 6;
            THANGNAM.Name = "THANGNAM";
            THANGNAM.Width = 122;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 40;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 41;
            // 
            // btNew
            // 
            btNew.BackColor = SystemColors.ButtonHighlight;
            btNew.Location = new Point(48, 67);
            btNew.Margin = new Padding(3, 4, 3, 4);
            btNew.Name = "btNew";
            btNew.Size = new Size(103, 35);
            btNew.TabIndex = 0;
            btNew.Text = "Thêm mới";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(716, 82);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 6;
            label1.Text = "Chọn Tháng/Năm :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(855, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(99, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnTotalSalary
            // 
            btnTotalSalary.Location = new Point(980, 73);
            btnTotalSalary.Name = "btnTotalSalary";
            btnTotalSalary.Size = new Size(94, 29);
            btnTotalSalary.TabIndex = 7;
            btnTotalSalary.Text = "Xem";
            btnTotalSalary.UseVisualStyleBackColor = true;
            btnTotalSalary.Click += btnTotalSalary_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(379, 29);
            label2.Name = "label2";
            label2.Size = new Size(342, 41);
            label2.TabIndex = 8;
            label2.Text = "QUẢN LÝ CHẤM CÔNG";
            // 
            // fManageTimeKeeping
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1071, 736);
            Controls.Add(label2);
            Controls.Add(btnTotalSalary);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(btNew);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fManageTimeKeeping";
            Text = "Quản lý nhân viên - Tiền lương - [Chấm công tháng]";
            WindowState = FormWindowState.Maximized;
            Activated += fManageTimeKeeping_Activated;
            Load += fManageTimeKeeping_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btNew;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn MACC;
        private DataGridViewTextBoxColumn MANV;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn NGAYCONG;
        private DataGridViewTextBoxColumn NGHIHL;
        private DataGridViewTextBoxColumn THANGNAM;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnTotalSalary;
        private Label label2;
    }
}