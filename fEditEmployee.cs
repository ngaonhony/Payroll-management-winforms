using Microsoft.EntityFrameworkCore; //sử dụng Include
using QLTL.Models;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
namespace QLTL
{
    public partial class fEditEmployee : Form
    {
        private NHANVIEN nhanvien;
        private long MANV;
        EFDbContext db = new EFDbContext();
        public fEditEmployee(long MANV)
        {
            InitializeComponent();
            this.MANV = MANV;
        }

        private void fEditNhanVien_Load(object sender, EventArgs e)
        {
            nhanvien = db.NHANVIEN.Single(p => p.MANV == MANV);
            Text += " - Mã NV " + nhanvien.MANV.ToString();
            txtName.Text = nhanvien.NAME;
            dateTimePicker1.Text = nhanvien.BIRTHDAY.ToString();
            txtGioitinh.Text = nhanvien.GENDER;
            dateTimePicker2.Text = nhanvien.NGAYVAOLAM.ToString();
            txtAddress.Text = nhanvien.ADDRESS;
            txtPhone.Text = nhanvien.PHONE;
            //Hiển thị hình
            txtImageFile.Text = string.IsNullOrWhiteSpace(nhanvien.THUMBNAIL) ? null : Utility.ImagePath + nhanvien.THUMBNAIL;
            pictureBox1.ImageLocation = txtImageFile.Text;
            cbChucvu.DisplayMember = "NAME";
            cbChucvu.ValueMember = "MACV";
            var chucvuList = db.CHUCVU.Select(c => new
            {
                c.MACV,
                c.NAME
            }).ToList();
            cbChucvu.DataSource = chucvuList;

            // Set the selected value
            if (nhanvien.CHUCVU != null)
            {
                cbChucvu.SelectedValue = nhanvien.CHUCVU.MACV;
            }

            // cbPhongban
            cbPhongban.DisplayMember = "NAME";
            cbPhongban.ValueMember = "MAPB";
            var phongbanList = db.PHONGBAN.Select(c => new
            {
                c.MAPB,
                c.NAME
            }).ToList();
            cbPhongban.DataSource = phongbanList;

            // Set the selected value
            if (nhanvien.PHONGBAN != null)
            {
                cbPhongban.SelectedValue = nhanvien.PHONGBAN.MAPB;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên nhân viên?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                toolTip1.Show("Hãy nhập số điện thoại?", txtPhone, 0, 0, 1000);
                txtPhone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ?", txtAddress, 0, 0, 1000);
                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGioitinh.Text))
            {
                toolTip1.Show("Hãy nhập giới tính?", txtGioitinh, 0, 0, 1000);
                txtGioitinh.Focus();
                return;
            }

            try
            {
                using (var db = new EFDbContext())
                {
                   
                    nhanvien = db.NHANVIEN.Single(p => p.MANV == MANV); // Load the existing employee
                    nhanvien.NAME = txtName.Text;
                    nhanvien.BIRTHDAY = dateTimePicker1.Value.Date;
                    nhanvien.GENDER = txtGioitinh.Text;
                    nhanvien.NGAYVAOLAM = dateTimePicker2.Value.Date;
                    nhanvien.ADDRESS = txtAddress.Text;
                    nhanvien.PHONE = txtPhone.Text;
                    nhanvien.MACV = Convert.ToInt64(cbChucvu.SelectedValue);
                    nhanvien.MAPB = Convert.ToInt64(cbPhongban.SelectedValue);
                    bool isDuplicateEntry = db.NHANVIEN.Any(e =>
       e.NAME == nhanvien.NAME &&
       e.BIRTHDAY == nhanvien.BIRTHDAY &&
       e.GENDER == nhanvien.GENDER &&
       e.NGAYVAOLAM == nhanvien.NGAYVAOLAM &&
       e.ADDRESS == nhanvien.ADDRESS &&
       e.PHONE == nhanvien.PHONE &&
       e.MACV == nhanvien.MACV &&
       e.MAPB == nhanvien.MAPB
   );

                    if (isDuplicateEntry)
                    {
                        toolTip1.Show("Nhân viên này đã tồn tại trong hệ thống.", btSave, 0, 0, 1000);
                        txtName.Focus();
                        return;
                    }
                    if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                    {
                        string ext = txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."),
                           txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                        nhanvien.THUMBNAIL = nhanvien.MANV + ext;
                        pictureBox1.Image.Save(Utility.ImagePath + nhanvien.MANV + ext);
                    }

                    db.SaveChanges(); // Save the changes to the database
                }

                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
            txtName.Focus();
        }


        private void btBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All file|*.*|BitmapFile | *.bmp; *.dib | JPEG | *.jpg; *.jpe; *.jpeg; *.jfif | GIF | *.gif | TIFF | *.tif; *.tiff | PNG | *.png | ICO | *.ico";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                e.Cancel = false;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên khách hàng <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }

        }
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ?", txtAddress, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtAddress.Text.Length > 250)
            {
                toolTip1.Show("Địa chỉ <= 250 ký tự?", txtAddress, 0, 0, 1000);
                e.Cancel = true;
            }

        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length == 10)
                return;
            toolTip1.Show("Không đúng dạng số điện thoại?", txtPhone, 0, 0, 1000);
            e.Cancel = true;
        }
        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại?", dateTimePicker1, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker2.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại?", dateTimePicker2, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtGioitinh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGioitinh.Text))
            {
                toolTip1.Show("Hãy nhập giới tính?", txtGioitinh, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtGioitinh.Text.Length > 100)
            {
                toolTip1.Show("Giới tính <= 100 ký tự?", txtGioitinh, 0, 0, 1000);
                e.Cancel = true;
            }

        }
        private void cbChucvu_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbChucvu.FindStringExact(cbChucvu.Text) < 0)
            {
                toolTip1.Show("Chọn sai chức vụ?", cbChucvu, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void cbPhongban_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbPhongban.FindStringExact(cbPhongban.Text) < 0)
            {
                toolTip1.Show("Chọn sai phòng ban?", cbPhongban, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void fEditNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}

