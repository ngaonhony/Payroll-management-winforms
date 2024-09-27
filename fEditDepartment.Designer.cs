namespace QLTL
{
    partial class fEditDepartment
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
            toolTip1 = new ToolTip(components);
            btClose = new Button();
            btSave = new Button();
            txtName = new TextBox();
            label1 = new Label();
            toolTip2 = new ToolTip(components);
            label3 = new Label();
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.Location = new Point(536, 379);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 13;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(324, 379);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 12;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(361, 238);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 27);
            txtName.TabIndex = 10;
            txtName.Validating += txtName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 245);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 11;
            label1.Text = "Tên Phòng Ban";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(315, 93);
            label3.Name = "label3";
            label3.Size = new Size(315, 60);
            label3.TabIndex = 14;
            label3.Text = "SỬA PHÒNG BAN";
            // 
            // fEditDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "fEditDepartment";
            Text = "Sửa đổi phòng ban";
            WindowState = FormWindowState.Maximized;
            Load += fEditDepartment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private Button btClose;
        private Button btSave;
        private TextBox txtName;
        private Label label1;
        private ToolTip toolTip2;
        private Label label3;
    }
}