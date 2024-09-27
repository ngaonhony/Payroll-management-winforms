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
using System.Xml.Linq;

namespace QLTL
{
    public partial class fEditReward : Form
    {
        private KHENTHUONGKYLUAT reward;
        private long MAKHENTHUONGKILUAT;
        EFDbContext db = new EFDbContext();
        public fEditReward(long MAKHENTHUONGKILUAT)
        {
            InitializeComponent();
            this.MAKHENTHUONGKILUAT = MAKHENTHUONGKILUAT;
        }

        private void fEditReward_Load(object sender, EventArgs e)
        {
            reward = db.KHENTHUONGKYLUAT.Single(p => p.MAKHENTHUONGKILUAT == MAKHENTHUONGKILUAT);
            Text += " - Mã NV " + reward.MANV.ToString();
            mSOTIEN.Text = reward.SOTIEN.ToString();
            dateTimePicker1.Text = reward.NGAYAPDUNG.ToString();
            txtReason.Text = reward.LYDO;

            // Set the selected value
            if (reward.NHANVIEN != null)
            {
                cbName.SelectedValue = reward.NHANVIEN.MANV;
            }


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
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                toolTip1.Show("Hãy nhập lý do?", txtReason, 0, 0, 1000);
                txtReason.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(mSOTIEN.Text))
            {
                toolTip1.Show("Hãy nhập mức lương?", mSOTIEN, 0, 0, 1000);
                mSOTIEN.Focus();
                return;
            }
            reward.MANV = Convert.ToInt64(cbName.SelectedValue);
            try
            {
                reward.SOTIEN = Convert.ToDecimal(mSOTIEN.Text);
                reward.NGAYAPDUNG = dateTimePicker1.Value.Date;
                reward.LYDO = txtReason.Text;
                if (rbReward.Checked)
                {
                    reward.THUONGPHAT = "Thưởng";
                }
                else if (rbPunish.Checked)
                {
                    reward.THUONGPHAT = "Phạt";
                }
                db.SaveChanges();
                //using (var db = new EFDbContext())
                //{
                //    db.KHENTHUONGKYLUAT.Add(reward);

                //}

                //Xóa trống và thiết lập lại các điều khiển
                txtReason.Text = null;
                mSOTIEN.Text = null;
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

