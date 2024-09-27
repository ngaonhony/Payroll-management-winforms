namespace QLTL
{
    partial class fNewReward
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
            txtReason = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btSave = new Button();
            btClose = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbName = new ComboBox();
            label6 = new Label();
            rbReward = new RadioButton();
            rbPunish = new RadioButton();
            label1 = new Label();
            mSOTIEN = new MaskedTextBox();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // txtReason
            // 
            txtReason.Location = new Point(69, 280);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(553, 27);
            txtReason.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(403, 216);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // btSave
            // 
            btSave.Location = new Point(681, 151);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 7;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(681, 204);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 8;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 178);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 10;
            label3.Text = "Ngày áp dụng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 101);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 11;
            label4.Text = "Số tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 257);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 12;
            label5.Text = "Lý do ";
            // 
            // cbName
            // 
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(70, 124);
            cbName.Name = "cbName";
            cbName.Size = new Size(175, 28);
            cbName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 101);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 14;
            label6.Text = "Tên nhân viên";
            // 
            // rbReward
            // 
            rbReward.AutoSize = true;
            rbReward.Location = new Point(69, 209);
            rbReward.Name = "rbReward";
            rbReward.Size = new Size(81, 24);
            rbReward.TabIndex = 3;
            rbReward.TabStop = true;
            rbReward.Text = "Thưởng";
            rbReward.UseVisualStyleBackColor = true;
            // 
            // rbPunish
            // 
            rbPunish.AutoSize = true;
            rbPunish.Location = new Point(169, 209);
            rbPunish.Name = "rbPunish";
            rbPunish.Size = new Size(59, 24);
            rbPunish.TabIndex = 4;
            rbPunish.TabStop = true;
            rbPunish.Text = "Phạt";
            rbPunish.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(218, 40);
            label1.Name = "label1";
            label1.Size = new Size(369, 41);
            label1.TabIndex = 17;
            label1.Text = "KHEN THƯỞNG KỶ LUẬT";
            // 
            // mSOTIEN
            // 
            mSOTIEN.Location = new Point(403, 125);
            mSOTIEN.Name = "mSOTIEN";
            mSOTIEN.Size = new Size(125, 27);
            mSOTIEN.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 178);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 18;
            label2.Text = "Thưởng/Phạt";
            // 
            // fNewReward
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(label2);
            Controls.Add(mSOTIEN);
            Controls.Add(label1);
            Controls.Add(rbPunish);
            Controls.Add(rbReward);
            Controls.Add(label6);
            Controls.Add(cbName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtReason);
            Name = "fNewReward";
            Text = "Thêm mới thưởng phạt";
            Load += fNewReward_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtReason;
        private DateTimePicker dateTimePicker1;
        private Button btSave;
        private Button btClose;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbName;
        private Label label6;
        private RadioButton rbReward;
        private RadioButton rbPunish;
        private Label label1;
        private MaskedTextBox mSOTIEN;
        private Label label2;
        private ToolTip toolTip1;
    }
}