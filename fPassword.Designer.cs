namespace QLTL
{
    partial class fPassword
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
            pictureBox6 = new PictureBox();
            btPassword = new Button();
            txtConfirm = new TextBox();
            label4 = new Label();
            lblMessage = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUser = new TextBox();
            label1 = new Label();
            btOut = new Button();
            label5 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(609, 346);
            pictureBox6.Margin = new Padding(1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(29, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // btPassword
            // 
            btPassword.BackColor = Color.White;
            btPassword.ForeColor = Color.Black;
            btPassword.Location = new Point(319, 403);
            btPassword.Margin = new Padding(2, 3, 2, 3);
            btPassword.Name = "btPassword";
            btPassword.Size = new Size(321, 37);
            btPassword.TabIndex = 27;
            btPassword.Text = "Đổi mật khẩu";
            btPassword.UseVisualStyleBackColor = false;
            btPassword.Click += btPassword_Click;
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Courier New", 12F);
            txtConfirm.ForeColor = Color.FromArgb(63, 61, 86);
            txtConfirm.Location = new Point(320, 350);
            txtConfirm.Margin = new Padding(1);
            txtConfirm.MaxLength = 50;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(317, 30);
            txtConfirm.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(322, 323);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(214, 22);
            label4.TabIndex = 29;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(335, 137);
            lblMessage.Margin = new Padding(2, 0, 2, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 28;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(609, 278);
            pictureBox5.Margin = new Padding(2, 3, 2, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(610, 213);
            pictureBox4.Margin = new Padding(2, 3, 2, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Courier New", 12F);
            txtPassword.ForeColor = Color.FromArgb(63, 61, 86);
            txtPassword.Location = new Point(320, 281);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(318, 30);
            txtPassword.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(319, 253);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 22);
            label2.TabIndex = 23;
            label2.Text = "New Password";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Courier New", 12F);
            txtUser.ForeColor = Color.FromArgb(63, 61, 86);
            txtUser.Location = new Point(320, 216);
            txtUser.Margin = new Padding(2, 3, 2, 3);
            txtUser.MaxLength = 50;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(318, 30);
            txtUser.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(320, 181);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 21;
            label1.Text = "Username";
            // 
            // btOut
            // 
            btOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btOut.ForeColor = Color.Red;
            btOut.Location = new Point(884, 12);
            btOut.Margin = new Padding(2, 3, 2, 3);
            btOut.Name = "btOut";
            btOut.Size = new Size(53, 40);
            btOut.TabIndex = 32;
            btOut.Text = "X";
            btOut.UseVisualStyleBackColor = true;
            btOut.Click += btOut_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SlateBlue;
            label5.Location = new Point(276, 88);
            label5.Name = "label5";
            label5.Size = new Size(447, 69);
            label5.TabIndex = 35;
            label5.Text = "Quên Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(323, 45);
            label3.TabIndex = 34;
            label3.Text = "QUẢN LÝ TIỀN LƯƠNG";
            // 
            // fPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(948, 546);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btOut);
            Controls.Add(pictureBox6);
            Controls.Add(btPassword);
            Controls.Add(txtConfirm);
            Controls.Add(label4);
            Controls.Add(lblMessage);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Name = "fPassword";
            Text = "Quên mật khẩu";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox6;
        private Button btPassword;
        private TextBox txtConfirm;
        private Label label4;
        private Label lblMessage;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUser;
        private Label label1;
        private Button btOut;
        private Label label5;
        private Label label3;
    }
}