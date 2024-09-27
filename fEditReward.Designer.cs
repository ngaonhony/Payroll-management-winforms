namespace QLTL
{
    partial class fEditReward
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
            label2 = new Label();
            mSOTIEN = new MaskedTextBox();
            label1 = new Label();
            rbPunish = new RadioButton();
            rbReward = new RadioButton();
            label6 = new Label();
            cbName = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btClose = new Button();
            btSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtReason = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 230);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 32;
            label2.Text = "Thưởng/Phạt";
            // 
            // mSOTIEN
            // 
            mSOTIEN.Location = new Point(381, 177);
            mSOTIEN.Name = "mSOTIEN";
            mSOTIEN.Size = new Size(125, 27);
            mSOTIEN.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(231, 86);
            label1.Name = "label1";
            label1.Size = new Size(369, 41);
            label1.TabIndex = 31;
            label1.Text = "KHEN THƯỞNG KỶ LUẬT";
            // 
            // rbPunish
            // 
            rbPunish.AutoSize = true;
            rbPunish.Location = new Point(147, 261);
            rbPunish.Name = "rbPunish";
            rbPunish.Size = new Size(59, 24);
            rbPunish.TabIndex = 22;
            rbPunish.TabStop = true;
            rbPunish.Text = "Phạt";
            rbPunish.UseVisualStyleBackColor = true;
            // 
            // rbReward
            // 
            rbReward.AutoSize = true;
            rbReward.Location = new Point(47, 261);
            rbReward.Name = "rbReward";
            rbReward.Size = new Size(81, 24);
            rbReward.TabIndex = 21;
            rbReward.TabStop = true;
            rbReward.Text = "Thưởng";
            rbReward.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 153);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 30;
            label6.Text = "Tên nhân viên";
            // 
            // cbName
            // 
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(48, 176);
            cbName.Name = "cbName";
            cbName.Size = new Size(175, 28);
            cbName.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 309);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 29;
            label5.Text = "Lý do ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 153);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 28;
            label4.Text = "Số tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 230);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 27;
            label3.Text = "Ngày áp dụng";
            // 
            // btClose
            // 
            btClose.Location = new Point(659, 256);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 26;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(659, 203);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 25;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(381, 268);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(47, 332);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(553, 27);
            txtReason.TabIndex = 24;
            // 
            // fEditReward
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
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
            Name = "fEditReward";
            Text = "KHEN THƯỞNG KỶ LUẬT";
            Load += fEditReward_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private MaskedTextBox mSOTIEN;
        private Label label1;
        private RadioButton rbPunish;
        private RadioButton rbReward;
        private Label label6;
        private ComboBox cbName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btClose;
        private Button btSave;
        private DateTimePicker dateTimePicker1;
        private TextBox txtReason;
        private ToolTip toolTip1;
    }
}