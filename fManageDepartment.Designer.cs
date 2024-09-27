namespace QLTL
{
    partial class fManageDepartment
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
            label2 = new Label();
            txtName = new TextBox();
            btFind = new Button();
            dataGridView1 = new DataGridView();
            MAPB = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(536, 24);
            label1.Name = "label1";
            label1.Size = new Size(354, 60);
            label1.TabIndex = 0;
            label1.Text = "Quản lý Phòng Ban";
            // 
            // btNew
            // 
            btNew.Location = new Point(70, 40);
            btNew.Name = "btNew";
            btNew.Size = new Size(94, 29);
            btNew.TabIndex = 2;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(933, 49);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Phòng Ban";
            // 
            // txtName
            // 
            txtName.Location = new Point(1048, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // btFind
            // 
            btFind.Location = new Point(1196, 46);
            btFind.Name = "btFind";
            btFind.Size = new Size(94, 29);
            btFind.TabIndex = 1;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MAPB, NAME, Edit, Delete });
            dataGridView1.Location = new Point(70, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1271, 350);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MAPB
            // 
            MAPB.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MAPB.DataPropertyName = "MAPB";
            MAPB.HeaderText = "Mã";
            MAPB.MinimumWidth = 6;
            MAPB.Name = "MAPB";
            MAPB.Width = 59;
            // 
            // NAME
            // 
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NAME.DataPropertyName = "NAME";
            NAME.HeaderText = "Tên Phòng Ban";
            NAME.MinimumWidth = 6;
            NAME.Name = "NAME";
            NAME.Width = 136;
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
            // fManageDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1378, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btFind);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btNew);
            Controls.Add(label1);
            Name = "fManageDepartment";
            Text = "fManageDepartment";
            Activated += fManageDepartment_Activated;
            Load += fManageDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btNew;
        private Label label2;
        private TextBox txtName;
        private Button btFind;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MAPB;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}