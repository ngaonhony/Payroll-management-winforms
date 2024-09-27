using Microsoft.EntityFrameworkCore; //sử dụng Include
using QLTL.Models;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace QLTL
{
    public partial class fEditTimeKeeping : Form
    {
        private CHAMCONG chamcong;
        EFDbContext db = new EFDbContext();
        private long MACC;
        public fEditTimeKeeping(long MACC)
        {
            InitializeComponent();
            this.MACC = MACC;
        }

        private void fEditchamcong_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void fEditchamcong_Load(object sender, EventArgs e)
        {
            chamcong = db.CHAMCONG.Single(p => p.MACC == MACC);
            Text += " - Mã NV " + chamcong.MACC.ToString();
            txtSoNgayCong.Text = chamcong.NGAYCONG.ToString(); // Chuyển đổi NGAYCONG sang chuỗi
            txtSoNgayNghiHuongLuong.Text = chamcong.NGHIHL.ToString(); // Chuyển đổi NGHIHL sang chuỗi
            txtMonth.Text = chamcong.THANG.ToString(); // Chuyển đổi THANG sang chuỗi
            txtYear.Text = chamcong.NAM.ToString(); // Chuyển đổi NAM sang chuỗi
            cbName.DisplayMember = "NAME";
            cbName.ValueMember = "MANV";
            var chamcongList = db.NHANVIEN.Select(c => new
            {
                c.MANV,
                c.NAME
            }).ToList();
            cbName.DataSource = chamcongList;


            // Set the selected value
            if (chamcong.NHANVIEN != null)
            {
                cbName.SelectedValue = chamcong.NHANVIEN.MANV;
            }
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

            try
            {
                if (long.TryParse(cbName.SelectedValue.ToString(), out long manv))
                {
                    chamcong.MANV = manv;
                    chamcong = db.CHAMCONG.Single(p => p.MACC == MACC); // Load the existing employee
                    chamcong.NGAYCONG = Convert.ToInt32(txtSoNgayCong.Text);
                    chamcong.NGHIHL = Convert.ToInt32(txtSoNgayNghiHuongLuong.Text);
                    chamcong.THANG = Convert.ToInt32(txtMonth.Text);
                    chamcong.NAM = Convert.ToInt32(txtYear.Text);
                    bool isDuplicateEntry = db.CHAMCONG
            .Any(c => c.THANG == Convert.ToInt32(txtMonth.Text) && c.NAM == Convert.ToInt32(txtYear.Text) && c.MANV == Convert.ToInt64(cbName.SelectedValue));

                    if (isDuplicateEntry)
                    {
                        toolTip1.Show("This employee already has an attendance record for the same month and year.", btSave, 0, 0, 1000);
                        txtMonth.Focus();
                        return;
                    }
                    db.SaveChanges(); // Save the changes to the database

                    txtSoNgayCong.Text = null;
                    txtSoNgayNghiHuongLuong.Text = null;
                    txtMonth.Text = null;
                    txtYear.Text = null;
                    toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
                }
                else
                {
                    toolTip1.Show("Giá trị chọn từ ComboBox không thể chuyển đổi thành số nguyên dài (Int64).", btSave, 0, 0, 1000);
                }
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
            cbName.Focus();
        }

        private void cbName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cbName.Text))
            {
                toolTip1.Show("Hãy nhập tên khách hàng?", cbName, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtSoNgayCong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoNgayCong.Text))
            {
                toolTip1.Show("Hãy nhập số ngày công?", txtSoNgayCong, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (int.TryParse(txtSoNgayCong.Text, out int soNgayCong) && soNgayCong > 31)
            {
                toolTip1.Show("Số ngày công phải nhỏ hơn 31", txtSoNgayCong, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtSoNgayNghiHuongLuong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoNgayNghiHuongLuong.Text))
            {
                toolTip1.Show("Hãy nhập số ngày công?", txtSoNgayNghiHuongLuong, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (int.TryParse(txtSoNgayNghiHuongLuong.Text, out int soNgayNghiHuongLuong))
            {
                if (int.TryParse(txtSoNgayCong.Text, out int soNgayCong))
                {
                    if (soNgayNghiHuongLuong < soNgayCong && (soNgayCong + soNgayNghiHuongLuong) > 31)
                    {
                        toolTip1.Show("Số ngày nghỉ hưởng lương phải nhỏ hơn số ngày công và tổng số ngày công và số ngày nghỉ hưởng lương phải nhỏ hơn 31", txtSoNgayNghiHuongLuong, 0, 0, 1000);
                        e.Cancel = true;
                    }
                }
                else
                {
                    toolTip1.Show("Giá trị của số ngày công không hợp lệ", txtSoNgayCong, 0, 0, 1000);
                    e.Cancel = true;
                }
            }
        }

        private void txtMonth_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMonth.Text))
            {
                toolTip1.Show("Hãy nhập tháng tính lương?", txtMonth, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (int.TryParse(txtMonth.Text, out int thang) && thang > 12)
            {
                toolTip1.Show("Tháng nhận lương phải nhỏ hơn 12", txtMonth, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYear.Text))
            {
                toolTip1.Show("Hãy nhập năm tính lương?", txtYear, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
