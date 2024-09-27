using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QLTL.Models;
namespace QLTL
{
    public partial class fSignup : Form
    {
        public fSignup()
        {
            InitializeComponent();
        }
        //Modify modify = new Modify();
        private void btSignup_Click(object sender, EventArgs e)
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
                        var user = new USER
                        {
                            USERNAME = txtUser.Text,
                            PASSWORD = txtPassword.Text // In a real application, make sure to hash the password before saving
                        };
                        db.USER.Add(user);
                        db.SaveChanges();
                    }

                    // Navigate to login page
                    this.Hide(); // Hide the current form
                    var loginForm = new fLogin(); // Assuming you have a form named 'LoginForm'
                    loginForm.Show(); // Show the login form
            }
        }

        private void lbtback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
