using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTL.Models;
namespace QLTL
{
    public partial class fManageTimeKeeping : Form
    {
        public fManageTimeKeeping()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewTimeKeeping"))
                return;
            fNewTimeKeeping f = new fNewTimeKeeping();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void fManageTimeKeeping_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.CHAMCONG.Select(p => new
                {
                    p.MACC,
                    p.MANV,
                    p.NHANVIEN.NAME,
                    p.NGAYCONG,
                    p.NGHIHL,
                    THANGNAM = string.Format("{0} / {1}", p.THANG, p.NAM)
                }).ToList();
            }
        }

        private void fManageTimeKeeping_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.CHAMCONG.Select(p => new
                {
                    p.MACC,
                    p.MANV,
                    p.NHANVIEN.NAME,
                    p.NGAYCONG,
                    p.NGHIHL,
                    THANGNAM = string.Format("{0} / {1}", p.THANG, p.NAM)
                }).ToList();
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int selectedMonth = dateTimePicker1.Value.Month;
            int selectedYear = dateTimePicker1.Value.Year;

            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.CHAMCONG.Where(p => p.THANG == selectedMonth && p.NAM == selectedYear).Select(p => new
                {
                    p.MACC,
                    p.MANV,
                    p.NHANVIEN.NAME,
                    p.NGAYCONG,
                    p.NGHIHL,
                    THANGNAM = string.Format("{0} / {1}", p.THANG, p.NAM)
                }).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    using (var db = new EFDbContext())
                    {
                        long MACC = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MACC"].Value);
                        CHAMCONG chamcong = db.CHAMCONG.Single(c => c.MACC == MACC);
                        if (MessageBox.Show("Bạn muốn xóa  " + chamcong.MACC, "Xóa", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.CHAMCONG.Remove(chamcong);
                            db.SaveChanges();
                            fManageTimeKeeping_Activated(sender, e);
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
                if (Utility.IsOpeningForm("fEditTimeKeeping"))
                    return;
                fEditTimeKeeping f = new fEditTimeKeeping(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MACC"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();

            }
        }

        private void btnTotalSalary_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fTongLuong"))
                return;
            fTongLuong f = new fTongLuong(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            f.MdiParent = this.MdiParent;
            f.Show();
            
        }
    }
}
