using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QLTL.Models;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTL
{
    public partial class fLogin : Form
    {

        public fLogin()
        {
            InitializeComponent();
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = ""; // Clear any previous messages

            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                lblMessage.Text = "Bạn phải nhập tên người dùng?";
                txtUser.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMessage.Text = "Bạn phải nhập mật khẩu?";
                txtPassword.Select();
            }
            else
            {
                try
                {
                    using (var db = new EFDbContext())
                    {
                        Utility.user = db.USER.SingleOrDefault(e => e.USERNAME == txtUser.Text && e.PASSWORD == txtPassword.Text);
                        if (Utility.user != null)
                            DialogResult = DialogResult.OK;
                        else
                        {
                            lblMessage.Text = "Sai tên người dùng hoặc mật khẩu";
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Lỗi khi kết nối với cơ sở dữ liệu: " + ex.Message;
                }
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbtSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fSignup signupForm = new fSignup();

            // Hiển thị form đăng ký
            signupForm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fPassword passwordForm = new fPassword();

            // Hiển thị form đăng ký
            passwordForm.ShowDialog();
        }


    }
}
