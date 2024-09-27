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
    public partial class fManageReward : Form
    {
        public fManageReward()
        {
            InitializeComponent();
        }

        private void fManageReward_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.KHENTHUONGKYLUAT
                    .ToList();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditReward"))
                    return;
                fEditReward f = new fEditReward
                (Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MAKHENTHUONGKILUAT"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long MAKHENTHUONGKILUAT = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MAKHENTHUONGKILUAT"].Value);
                    using (var db = new EFDbContext())
                    {
                        KHENTHUONGKYLUAT reward = db.KHENTHUONGKYLUAT.Single(c => c.MAKHENTHUONGKILUAT == MAKHENTHUONGKILUAT);

                        if (MessageBox.Show("Bạn muốn xóa phần khen thưởng này", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.KHENTHUONGKYLUAT.Remove(reward);
                            db.SaveChanges();
                            fManageReward_Activated(sender, e);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewReward"))
                return;
            fNewReward f = new fNewReward();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
