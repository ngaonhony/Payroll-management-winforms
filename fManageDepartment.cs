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

namespace QLTL
{
    public partial class fManageDepartment : Form
    {
        public fManageDepartment()
        {
            InitializeComponent();
        }



        private void fManageDepartment_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.PHONGBAN.Select(p => new
                {
                    p.MAPB,
                    p.NAME,
                }).ToList();
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.PHONGBAN.Where(e => e.NAME.Contains(txtName.Text)).Select(p => new
                {
                    p.MAPB,
                    p.NAME,
                }).ToList();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewDepartment"))
                return;
            fNewDepartment f = new fNewDepartment();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditDepartment"))
                    return;
                fEditDepartment f = new fEditDepartment(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MAPB"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long MAPB = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MAPB"].Value);
                    using (var db = new EFDbContext())
                    {
                     PHONGBAN department = db.PHONGBAN.Single(c => c.MAPB == MAPB);

                        if (MessageBox.Show("Bạn muốn xóa chức vụ " + department.NAME, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.PHONGBAN.Remove(department);
                            db.SaveChanges();
                            fManageDepartment_Activated(sender, e);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
        }

        private void fManageDepartment_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.PHONGBAN.Select(p => new
                {
                    p.MAPB,
                    p.NAME,
            
                }).ToList();
            }
        }
    }
}
