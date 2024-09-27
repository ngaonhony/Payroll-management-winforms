namespace QLTL
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            menuStrip1 = new MenuStrip();
            SystemToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            manageEmployeeToolStripMenuItem = new ToolStripMenuItem();
            managePositionToolStripMenuItem = new ToolStripMenuItem();
            manageDepartmentToolStripMenuItem = new ToolStripMenuItem();
            salaryToolStripMenuItem = new ToolStripMenuItem();
            managaTimeKeepingToolStripMenuItem = new ToolStripMenuItem();
            manageRewardToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { SystemToolStripMenuItem, employeeToolStripMenuItem, salaryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(911, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
          
            // 
            // SystemToolStripMenuItem
            // 
            SystemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem });
            SystemToolStripMenuItem.Image = Properties.Resources.th__2_;
            SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            SystemToolStripMenuItem.Size = new Size(105, 24);
            SystemToolStripMenuItem.Text = "Hệ thống";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(130, 26);
            logOutToolStripMenuItem.Text = "Thoát";
            logOutToolStripMenuItem.Click += systemToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.BackColor = SystemColors.Control;
            employeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageEmployeeToolStripMenuItem, managePositionToolStripMenuItem, manageDepartmentToolStripMenuItem });
            employeeToolStripMenuItem.Image = Properties.Resources.tải_xuống;
            employeeToolStripMenuItem.ImageTransparentColor = Color.White;
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(109, 24);
            employeeToolStripMenuItem.Text = "Nhân viên";
            // 
            // manageEmployeeToolStripMenuItem
            // 
            manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            manageEmployeeToolStripMenuItem.Size = new Size(219, 26);
            manageEmployeeToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            manageEmployeeToolStripMenuItem.Click += manageEmployeeToolStripMenuItem_Click;
            // 
            // managePositionToolStripMenuItem
            // 
            managePositionToolStripMenuItem.Name = "managePositionToolStripMenuItem";
            managePositionToolStripMenuItem.Size = new Size(219, 26);
            managePositionToolStripMenuItem.Text = "Quản Lý Chức Vụ";
            managePositionToolStripMenuItem.Click += managePositionToolStripMenuItem_Click;
            // 
            // manageDepartmentToolStripMenuItem
            // 
            manageDepartmentToolStripMenuItem.Name = "manageDepartmentToolStripMenuItem";
            manageDepartmentToolStripMenuItem.Size = new Size(219, 26);
            manageDepartmentToolStripMenuItem.Text = "Quản Lý Phòng Ban";
            manageDepartmentToolStripMenuItem.Click += manageDepartmentToolStripMenuItem_Click;
            // 
            // salaryToolStripMenuItem
            // 
            salaryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managaTimeKeepingToolStripMenuItem, manageRewardToolStripMenuItem });
            salaryToolStripMenuItem.Image = Properties.Resources.th1;
            salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            salaryToolStripMenuItem.Size = new Size(85, 24);
            salaryToolStripMenuItem.Text = "Lương";
            // 
            // managaTimeKeepingToolStripMenuItem
            // 
            managaTimeKeepingToolStripMenuItem.Name = "managaTimeKeepingToolStripMenuItem";
            managaTimeKeepingToolStripMenuItem.Size = new Size(236, 26);
            managaTimeKeepingToolStripMenuItem.Text = "Quản Lý Chấm Công";
            managaTimeKeepingToolStripMenuItem.Click += managaTimeKeepingToolStripMenuItem_Click;
            // 
            // manageRewardToolStripMenuItem
            // 
            manageRewardToolStripMenuItem.Name = "manageRewardToolStripMenuItem";
            manageRewardToolStripMenuItem.Size = new Size(236, 26);
            manageRewardToolStripMenuItem.Text = "Quản Lý Khen Thưởng";
            manageRewardToolStripMenuItem.Click += manageRewardToolStripMenuItem_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(911, 653);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Tiền Lương";
            Load += fMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem SystemToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private ToolStripMenuItem salaryToolStripMenuItem;
        private ToolStripMenuItem managePositionToolStripMenuItem;
        private ToolStripMenuItem manageDepartmentToolStripMenuItem;
        private ToolStripMenuItem managaTimeKeepingToolStripMenuItem;
        private ToolStripMenuItem manageRewardToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}
