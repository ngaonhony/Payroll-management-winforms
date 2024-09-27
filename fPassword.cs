using QLTL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTL
{
    public partial class fPassword : Form
    {
        public fPassword()
        {
            InitializeComponent();
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btPassword_Click(object sender, EventArgs e)
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
            else if (string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                lblMessage.Text = "Bạn phải nhập lại mật khẩu?";
                txtConfirm.Select();
            }
            else if (txtPassword.Text != txtConfirm.Text)
            {
                lblMessage.Text = "Mật khẩu và mật khẩu xác nhận không khớp.";
                txtConfirm.Select();
            }
            else
            {
                // Assuming you have a DbContext class named 'MyDbContext'
                using (var db = new EFDbContext())
                {
                    var user = db.USER.SingleOrDefault(u => u.USERNAME == txtUser.Text);
                    if (user != null)
                    {
                        // Update the user's password
                        user.PASSWORD = txtPassword.Text; // In a real application, hash the password before saving
                        db.SaveChanges();

                        lblMessage.Text = "Mật khẩu đã được thay đổi thành công. Bạn có thể đăng nhập với mật khẩu mới.";

                        // Navigate to login page
                        this.Hide(); // Hide the current form
                        var loginForm = new fLogin(); // Assuming you have a form named 'fLogin'
                        loginForm.Show(); // Show the login form
                    }
                    else
                    {
                        lblMessage.Text = "Tên người dùng không tồn tại.";
                        txtUser.Select();
                    }
                }
            }
        }
    }
}
