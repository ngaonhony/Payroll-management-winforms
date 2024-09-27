using QLTL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTL
{
    public partial class fNewDepartment : Form
    {
        PHONGBAN department;
        public fNewDepartment()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void fNewDepartment_Load(object sender, EventArgs e)
        {
            // Thiết lập các thông báo tooltip cho các điều khiển
            toolTip1.SetToolTip(txtName, "Nhập tên phòng ban");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Tạo khách hàng mới 
                department = new PHONGBAN(); //Tạo một thể hiện (đối tượng) khách hàng mới 
                department.NAME = txtName.Text;
            

                using (var db = new EFDbContext())
                {
                    bool isDepartmentExists = db.PHONGBAN.Any(d => d.NAME.Equals(department.NAME));
                    if (isDepartmentExists)
                    {
                        toolTip1.Show("Department already exists.", txtName, 0, 0, 1000);
                        txtName.Focus();
                        return;
                    }

                    db.PHONGBAN.Add(department); //Thêm khách hàng vào bối cảnh mô hình 
                    db.SaveChanges(); //Lưu các thay đổi vào csdl 
                }                //Xóa trống và thiết lập lại các điều khiển 

                txtName.Text = null;
             
                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
            txtName.Focus();

        }

      

        private void txtName_Validating(object sender,
System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên phòng ban?", txtName, 0, 0, 1000);
                e.Cancel = false;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên chức vụ <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void fNewDepartment_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
