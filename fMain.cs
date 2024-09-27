using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace QLTL
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void managePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManagePosition"))
                return;
            fManagePosition f = new fManagePosition();
    
            f.MdiParent = this;
            f.Show();
        }

        private void manageDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageDepartment"))
                return;
            fManageDepartment f = new fManageDepartment();
          
            f.MdiParent = this;
            f.Show();
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageEmployee"))
                return;
            fManageEmployee f = new fManageEmployee();
         
            f.MdiParent = this;
            f.Show();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            if (f.ShowDialog() == DialogResult.OK)
                Text = "Quản lý Tiền lương " + Utility.user.USERNAME;
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create a new instance of the fMain form (or you could use an existing instance if available)
            fMain mainForm = new fMain();

            // Show the fMain form
            mainForm.Show();
        }
        private void managaTimeKeepingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageTimeKeeping"))
                return;
            fManageTimeKeeping f = new fManageTimeKeeping();
       
            f.MdiParent = this;
            f.Show();
        }

        private void manageRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageReward"))
                return;
            fManageReward f = new fManageReward();
        
            f.MdiParent = this;
            f.Show();
        }

        
    }
}
