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
    public partial class fNewPosition : Form
    {
        CHUCVU position;
        public fNewPosition()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void fNewPostion_Load(object sender, EventArgs e)
        {
            // Thiết lập các thông báo tooltip cho các điều khiển
            toolTip1.SetToolTip(txtName, "Nhập tên chức vụ");
            toolTip1.SetToolTip(mMUCLUONG, "Nhập mức lương cho chức vụ");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Tạo khách hàng mới 
                position = new CHUCVU(); //Tạo một thể hiện (đối tượng) khách hàng mới 
                position.NAME = txtName.Text;
                position.LUONG = Convert.ToDecimal(mMUCLUONG.Text);
            

                using (var db = new EFDbContext())
                {
                    bool isPositionExists = db.CHUCVU.Any(p => p.NAME.Equals(position.NAME));

                    if (isPositionExists)
                    {
                        toolTip1.Show("Position already exists.", txtName, 0, 0, 1000);
                        txtName.Focus();
                        return;
                    }


                    db.CHUCVU.Add(position); //Thêm khách hàng vào bối cảnh mô hình 
                    db.SaveChanges(); //Lưu các thay đổi vào csdl 
                }                //Xóa trống và thiết lập lại các điều khiển 

                txtName.Text = null;
                mMUCLUONG.Text = null;
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
                toolTip1.Show("Hãy nhập tên chức vụ?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên chức vụ <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void mMUCLUONG_Validating(object sender,
      System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mMUCLUONG.Text))
            {
                toolTip1.Show("Hãy nhập mức lương?", mMUCLUONG, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (mMUCLUONG.Text.Length > 250)
            {
                toolTip1.Show("Số lượng <= 250 kí tự?", mMUCLUONG, 0, 0,
               1000);
                e.Cancel = true;
            }
        }
        private void fNewPosition_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
