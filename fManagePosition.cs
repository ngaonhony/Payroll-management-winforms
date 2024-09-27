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
    public partial class fManagePosition : Form
    {
        public fManagePosition()
        {
            InitializeComponent();
        }



        private void fManagePosition_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.CHUCVU.Select(p => new
                {
                    p.MACV,
                    p.NAME,
                    p.LUONG
                }).ToList();
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.CHUCVU.Where(e => e.NAME.Contains(txtName.Text)).Select(p => new
                {
                    p.MACV,
                    p.NAME,
                    p.LUONG
                }).ToList();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewPosition"))
                return;
            fNewPosition f = new fNewPosition();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditPosition"))
                    return;
                fEditPosition f = new fEditPosition
                (Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MACV"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long MACV = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MACV"].Value);
                    using (var db = new EFDbContext())
                    {
                        CHUCVU position = db.CHUCVU.Single(c => c.MACV == MACV);

                        if (MessageBox.Show("Bạn muốn xóa chức vụ " + position.NAME, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.CHUCVU.Remove(position);
                            db.SaveChanges();
                            fManagePosition_Activated(sender, e);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
        }

        private void fManagePosition_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.CHUCVU.Select(p => new
                {
                    p.MACV,
                    p.NAME,
                    p.LUONG
                }).ToList();
            }
        }
    }
}
