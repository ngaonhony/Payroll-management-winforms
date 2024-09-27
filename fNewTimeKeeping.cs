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
using static System.Net.Mime.MediaTypeNames;


namespace QLTL
{
    public partial class fNewTimeKeeping : Form
    {
        private CHAMCONG chamcong;
        public fNewTimeKeeping()
        {
            InitializeComponent();
        }

        private void fNewTimeKeeping_Load(object sender, EventArgs e)
        {
            cbName.DisplayMember = "NAME";
            cbName.ValueMember = "MANV";
            using (var db = new EFDbContext())
            {
                cbName.DataSource = db.NHANVIEN.Select(c => new
                {
                    c.MANV,
                    c.NAME
                }).ToList();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fNewTimeKeeping_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbName.Text))
            {
                toolTip1.Show("Hãy chọn tên nhân viên?", cbName, 0, 0, 1000);
                cbName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoNgayCong.Text))
            {
                toolTip1.Show("Hãy nhập số ngày công?", txtSoNgayCong, 0, 0, 1000);
                txtSoNgayCong.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoNgayNghiHuongLuong.Text))
            {
                toolTip1.Show("Hãy nhập số ngày nghỉ hưởng lương?", txtSoNgayNghiHuongLuong, 0, 0, 1000);
                txtSoNgayNghiHuongLuong.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMonth.Text))
            {
                toolTip1.Show("Hãy nhập tháng?", txtMonth, 0, 0, 1000);
                txtMonth.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtYear.Text))
            {
                toolTip1.Show("Hãy nhập năm?", txtYear, 0, 0, 1000);
                txtYear.Focus();
                return;
            }
            CHAMCONG chamcong = new CHAMCONG();
            chamcong.MANV = Convert.ToInt64(cbName.SelectedValue);
            try
            {
                chamcong.NGAYCONG = Convert.ToInt32(txtSoNgayCong.Text);
                chamcong.NGHIHL = Convert.ToInt32(txtSoNgayNghiHuongLuong.Text);
                chamcong.THANG = Convert.ToInt32(txtMonth.Text);
                chamcong.NAM = Convert.ToInt32(txtYear.Text);

                using (var db = new EFDbContext())
                {
                    bool isDuplicateEntry = db.CHAMCONG
             .Any(c => c.THANG == Convert.ToInt32(txtMonth.Text) && c.NAM == Convert.ToInt32(txtYear.Text) && c.MANV == Convert.ToInt64(cbName.SelectedValue));

                    if (isDuplicateEntry)
                    {
                        toolTip1.Show("This employee already has an attendance record for the same month and year.", btSave, 0, 0, 1000);
                        txtMonth.Focus();
                        return;
                    }
                    db.CHAMCONG.Add(chamcong);
                    db.SaveChanges();
                }

                //Xóa trống và thiết lập lại các điều khiển
                txtSoNgayCong.Text = null;
                txtSoNgayNghiHuongLuong.Text = null;
                txtMonth.Text = null;
                txtYear.Text = null;
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                // Log the error or display a more user-friendly error message
                toolTip1.Show("Lưu thất bại. Vui lòng thử lại.", btSave, 0, 0, 1000);
                // Log the exception for debugging purposes
                Console.WriteLine("Error occurred while saving attendance record: " + ex.Message);
            }

            cbName.Focus();
        }

       
    }
}
