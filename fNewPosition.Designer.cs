namespace QLTL
{
    partial class fNewPosition
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
            txtName = new TextBox();
            btSave = new Button();
            btClose = new Button();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            mMUCLUONG = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 152);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Chức Vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 255);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Mức Lương";
            // 
            // txtName
            // 
            txtName.Location = new Point(266, 152);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 27);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // btSave
            // 
            btSave.Location = new Point(258, 376);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 7;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(470, 383);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 8;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(249, 39);
            label3.Name = "label3";
            label3.Size = new Size(315, 60);
            label3.TabIndex = 9;
            label3.Text = "THÊM CHỨC VỤ";
            // 
            // mMUCLUONG
            // 
            mMUCLUONG.Location = new Point(266, 252);
            mMUCLUONG.Name = "mMUCLUONG";
            mMUCLUONG.Size = new Size(125, 27);
            mMUCLUONG.TabIndex = 1;
            mMUCLUONG.Validating += mMUCLUONG_Validating;
            // 
            // fNewPosition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(839, 450);
            ControlBox = false;
            Controls.Add(mMUCLUONG);
            Controls.Add(label3);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fNewPosition";
            Text = "Nhập thêm nhân viên mới";
            WindowState = FormWindowState.Maximized;
            FormClosing += fNewPosition_FormClosing;
            Load += fNewPostion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private Button btSave;
        private Button btClose;
        private ToolTip toolTip1;
        private MaskedTextBox mMUCLUONG;
    }
}