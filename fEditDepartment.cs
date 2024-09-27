using QLTL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLTL
{
    public partial class fEditDepartment : Form
    {
        EFDbContext db = new EFDbContext();
        PHONGBAN department;
        long MAPB;
        public fEditDepartment(long MAPB)
        {
            InitializeComponent();
            this.MAPB = MAPB;
        }
        private void fEditDepartment_Load(object sender, EventArgs e)

        {

            department = db.PHONGBAN.Single(p => p.MAPB == MAPB);
            Text += "SỬA ĐỔI PHÒNG BAN" + department.MAPB.ToString();
            txtName.Text = department.NAME;
         
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên phòng ban?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }    
            try
            {
                bool isDepartmentExists = db.PHONGBAN.Any(d => d.NAME.Equals(department.NAME));
                if (isDepartmentExists)
                {
                    toolTip1.Show("Department already exists.", txtName, 0, 0, 1000);
                    txtName.Focus();
                    return;
                }

                department.NAME = txtName.Text;
             
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
            txtName.Focus();
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên phòng ban?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên phòng ban<= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }

          }
}
