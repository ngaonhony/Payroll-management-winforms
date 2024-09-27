namespace QLTL
{
    partial class fManageReward
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
            btNew = new Button();
            dataGridView1 = new DataGridView();
            MAKHENTHUONGKILUAT = new DataGridViewTextBoxColumn();
            MANV = new DataGridViewTextBoxColumn();
            THUONGPHAT = new DataGridViewTextBoxColumn();
            LYDO = new DataGridViewTextBoxColumn();
            NGAYAPDUNG = new DataGridViewTextBoxColumn();
            SOTIEN = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(405, 42);
            label1.Name = "label1";
            label1.Size = new Size(369, 41);
            label1.TabIndex = 1;
            label1.Text = "KHEN THƯỞNG KỶ LUẬT";
            // 
            // btNew
            // 
            btNew.BackColor = SystemColors.ButtonFace;
            btNew.Location = new Point(39, 107);
            btNew.Name = "btNew";
            btNew.Size = new Size(94, 29);
            btNew.TabIndex = 2;
            btNew.Text = "Thêm mới";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MAKHENTHUONGKILUAT, MANV, THUONGPHAT, LYDO, NGAYAPDUNG, SOTIEN, Edit, Delete });
            dataGridView1.Location = new Point(153, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(937, 315);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MAKHENTHUONGKILUAT
            // 
            MAKHENTHUONGKILUAT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MAKHENTHUONGKILUAT.DataPropertyName = "MAKHENTHUONGKILUAT";
            MAKHENTHUONGKILUAT.HeaderText = "Mã";
            MAKHENTHUONGKILUAT.MinimumWidth = 6;
            MAKHENTHUONGKILUAT.Name = "MAKHENTHUONGKILUAT";
            MAKHENTHUONGKILUAT.Width = 59;
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
            // THUONGPHAT
            // 
            THUONGPHAT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            THUONGPHAT.DataPropertyName = "THUONGPHAT";
            THUONGPHAT.HeaderText = "THUONGPHAT";
            THUONGPHAT.MinimumWidth = 6;
            THUONGPHAT.Name = "THUONGPHAT";
            THUONGPHAT.Width = 135;
            // 
            // LYDO
            // 
            LYDO.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LYDO.DataPropertyName = "LYDO";
            LYDO.HeaderText = "LYDO";
            LYDO.MinimumWidth = 6;
            LYDO.Name = "LYDO";
            LYDO.Width = 74;
            // 
            // NGAYAPDUNG
            // 
            NGAYAPDUNG.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NGAYAPDUNG.DataPropertyName = "NGAYAPDUNG";
            NGAYAPDUNG.HeaderText = "NGAYAPDUNG";
            NGAYAPDUNG.MinimumWidth = 6;
            NGAYAPDUNG.Name = "NGAYAPDUNG";
            NGAYAPDUNG.Width = 135;
            // 
            // SOTIEN
            // 
            SOTIEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SOTIEN.DataPropertyName = "SOTIEN";
            SOTIEN.HeaderText = "SOTIEN";
            SOTIEN.MinimumWidth = 6;
            SOTIEN.Name = "SOTIEN";
            SOTIEN.Width = 87;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 64;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 82;
            // 
            // fManageReward
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1264, 621);
            Controls.Add(btNew);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "fManageReward";
            Text = "Quản lý thưởng phạt";
            TopMost = true;
            Activated += fManageReward_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btNew;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MAKHENTHUONGKILUAT;
        private DataGridViewTextBoxColumn MANV;
        private DataGridViewTextBoxColumn THUONGPHAT;
        private DataGridViewTextBoxColumn LYDO;
        private DataGridViewTextBoxColumn NGAYAPDUNG;
        private DataGridViewTextBoxColumn SOTIEN;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}