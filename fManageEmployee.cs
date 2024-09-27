using QLTL.Models;
using System.Data;
using System.Windows.Forms;
using QLTL.Models;
namespace QLTL
{
    public partial class fManageEmployee : Form
    {
        private long MAPB;
        public fManageEmployee()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewEmployee"))
                return;
            fNewEmployee f = new fNewEmployee();
            f.MdiParent = this.MdiParent;
            f.Show();
        }





        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var result = db.NHANVIEN
                    .Where(c => c.NAME.Contains(txtName.Text))
                    .Select(c => new
                    {
                        c.MANV,
                        c.NAME,
                        c.THUMBNAIL,
                        c.BIRTHDAY,
                        c.GENDER,
                        c.ADDRESS,
                        c.NGAYVAOLAM,
                        c.PHONE,
                        TENCHUCVU = c.CHUCVU.NAME,
                        TENPHONGBAN = c.PHONGBAN.NAME
                        // Thêm các thuộc tính khác trừ MAPB, MACV, KHENTHUONGKYLUAT, và CHAMCONG
                    }).ToList();

                dataGridView1.DataSource = result;
            }
        }

        private void ManageEmployee_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                MAPB = Convert.ToInt64(cbPhongban.SelectedValue);
                dataGridView1.DataSource = db.NHANVIEN.Select(p => new
                {
                    p.MANV,
                    p.NAME,
                    p.THUMBNAIL,
                    p.BIRTHDAY,
                    p.NGAYVAOLAM,
                    p.GENDER,
                    p.ADDRESS,
                    p.PHONE,
                    TENPHONGBAN = p.PHONGBAN.NAME,
                    TENCHUCVU = p.CHUCVU.NAME
                }).ToList();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.ImageLocation = Utility.ImagePath + dataGridView1.Rows[e.RowIndex].Cells["THUMBNAIL"].Value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    using (var db = new EFDbContext())
                    {
                        long MANV = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value);
                        NHANVIEN nhanvien = db.NHANVIEN.Single(c => c.MANV == MANV);
                        if (MessageBox.Show("Bạn muốn xóa sản phẩm " + nhanvien.NAME, "Xóa", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.NHANVIEN.Remove(nhanvien);
                            db.SaveChanges();
                            ManageEmployee_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditEmployee"))
                    return;
                fEditEmployee f = new fEditEmployee(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();

            }
        }

        private void cbPhongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                MAPB = Convert.ToInt64(cbPhongban.SelectedValue);
                dataGridView1.DataSource = db.NHANVIEN.Where(p =>
                p.MAPB == MAPB).Select(p => new
                {
                    p.MANV,
                    p.NAME,
                    p.THUMBNAIL,
                    p.BIRTHDAY,
                    p.NGAYVAOLAM,
                    p.GENDER,
                    p.ADDRESS,
                    p.PHONE
                }).ToList();
            }
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                cbPhongban.DisplayMember = "NAME";
                cbPhongban.ValueMember = "MAPB";
                //sau 2 lệnh trên
                cbPhongban.DataSource =db.PHONGBAN.Select(c => new { c.MAPB, c.NAME }).ToList();
                //cbCategories.Text = null;
                dataGridView1.Width = ClientSize.Width - 10;
            }

        }
      
    }

}
