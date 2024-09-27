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
    public partial class fEditPosition : Form
    {
        EFDbContext db = new EFDbContext();
        CHUCVU position;
        long MACV;
        public fEditPosition(long MACV)
        {
            InitializeComponent();
            this.MACV = MACV;
        }
        private void fEditPosition_Load(object sender, EventArgs e)

        {

            position = db.CHUCVU.Single(p => p.MACV == MACV);
            Text += "SỬA ĐỔI CHỨC VỤ " + position.MACV.ToString();
            txtName.Text = position.NAME;
            mMUCLUONG.Text = position.LUONG.ToString();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên chức vụ?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(mMUCLUONG.Text))
            {
                toolTip1.Show("Hãy nhập mức lương?", mMUCLUONG, 0, 0,
               1000);
                mMUCLUONG.Focus();
                return;
            }
            try
            {

               
                position.NAME = txtName.Text;
                position.LUONG = Convert.ToDecimal(mMUCLUONG.Text);
                bool isPositionExists = db.CHUCVU.Any(p => p.NAME.Equals(position.NAME));

                if (isPositionExists)
                {
                    toolTip1.Show("Position already exists.", txtName, 0, 0, 1000);
                    txtName.Focus();
                    return;
                }
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
                toolTip1.Show("Hãy nhập tên chức vụ?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên chức vụ<= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mMUCLUONG_Validating(object sender,System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mMUCLUONG.Text))
            {
                toolTip1.Show("Hãy nhập giá ?", mMUCLUONG, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (mMUCLUONG.Text.Length > 250)
            {
                toolTip1.Show("Số lượng <= 250 ký tự?", mMUCLUONG, 0, 0,
               1000);
                e.Cancel = true;
            }

            }
        }
}
