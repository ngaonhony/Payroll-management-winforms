namespace QLTL
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btOut = new Button();
            lbtSignup = new LinkLabel();
            lblMessage = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            btLogin = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUser = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btOut
            // 
            btOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btOut.ForeColor = Color.Red;
            btOut.Location = new Point(1002, 12);
            btOut.Margin = new Padding(2, 3, 2, 3);
            btOut.Name = "btOut";
            btOut.Size = new Size(53, 40);
            btOut.TabIndex = 14;
            btOut.Text = "X";
            btOut.UseVisualStyleBackColor = true;
            btOut.Click += btOut_Click;
            // 
            // lbtSignup
            // 
            lbtSignup.ActiveLinkColor = Color.White;
            lbtSignup.AutoSize = true;
            lbtSignup.LinkColor = Color.Black;
            lbtSignup.Location = new Point(586, 413);
            lbtSignup.Margin = new Padding(2, 0, 2, 0);
            lbtSignup.Name = "lbtSignup";
            lbtSignup.Size = new Size(61, 20);
            lbtSignup.TabIndex = 25;
            lbtSignup.TabStop = true;
            lbtSignup.Text = "Sign Up";
            lbtSignup.LinkClicked += lbtSignup_LinkClicked;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(397, 196);
            lblMessage.Margin = new Padding(2, 0, 2, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 24;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(488, 444);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 20);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(397, 416);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 17);
            label3.TabIndex = 22;
            label3.Text = "Don't have an acount ?";
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Transparent;
            btLogin.ForeColor = Color.Black;
            btLogin.Location = new Point(377, 356);
            btLogin.Margin = new Padding(2, 3, 2, 3);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(317, 37);
            btLogin.TabIndex = 21;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(665, 306);
            pictureBox5.Margin = new Padding(2, 3, 2, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(667, 241);
            pictureBox4.Margin = new Padding(2, 3, 2, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Courier New", 12F);
            txtPassword.ForeColor = Color.FromArgb(63, 61, 86);
            txtPassword.Location = new Point(377, 309);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(318, 30);
            txtPassword.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(372, 280);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 17;
            label2.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Courier New", 12F);
            txtUser.ForeColor = Color.FromArgb(63, 61, 86);
            txtUser.Location = new Point(377, 244);
            txtUser.Margin = new Padding(2, 3, 2, 3);
            txtUser.MaxLength = 50;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(318, 30);
            txtUser.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(376, 216);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 15;
            label1.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SlateBlue;
            label4.Location = new Point(34, 12);
            label4.Name = "label4";
            label4.Size = new Size(323, 45);
            label4.TabIndex = 26;
            label4.Text = "QUẢN LÝ TIỀN LƯƠNG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SlateBlue;
            label5.Location = new Point(377, 101);
            label5.Name = "label5";
            label5.Size = new Size(330, 69);
            label5.TabIndex = 27;
            label5.Text = "Đăng Nhập";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1066, 661);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbtSignup);
            Controls.Add(lblMessage);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(btLogin);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(btOut);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1066, 661);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btOut;
        private LinkLabel lbtSignup;
        private Label lblMessage;
        private LinkLabel linkLabel1;
        private Label label3;
        private Button btLogin;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUser;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}
