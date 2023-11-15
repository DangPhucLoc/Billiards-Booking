namespace SalesWinApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip_Control = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            menuStripItem_accountInfo = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            menuStripItem_clubs = new ToolStripMenuItem();
            menuStripItem_members = new ToolStripMenuItem();
            tablesToolStripMenuItem = new ToolStripMenuItem();
            slotsToolStripMenuItem = new ToolStripMenuItem();
            bookingsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            contactToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            clubToolStripMenuItem1 = new ToolStripMenuItem();
            bookingsHistoryToolStripMenuItem = new ToolStripMenuItem();
            menuStrip_Control.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_Control
            // 
            menuStrip_Control.ImageScalingSize = new Size(20, 20);
            menuStrip_Control.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, manageToolStripMenuItem, viewToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip_Control.Location = new Point(0, 0);
            menuStrip_Control.Name = "menuStrip_Control";
            menuStrip_Control.Size = new Size(1582, 28);
            menuStrip_Control.TabIndex = 2;
            menuStrip_Control.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuStripItem_accountInfo, logoutToolStripMenuItem, loginToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(77, 24);
            accountToolStripMenuItem.Text = "Account";
            // 
            // menuStripItem_accountInfo
            // 
            menuStripItem_accountInfo.Name = "menuStripItem_accountInfo";
            menuStripItem_accountInfo.Size = new Size(210, 26);
            menuStripItem_accountInfo.Text = "Show Information";
            menuStripItem_accountInfo.Click += menuStripItem_accountInfo_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(210, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(210, 26);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuStripItem_clubs, menuStripItem_members, tablesToolStripMenuItem, slotsToolStripMenuItem, bookingsToolStripMenuItem });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(77, 24);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // menuStripItem_clubs
            // 
            menuStripItem_clubs.Name = "menuStripItem_clubs";
            menuStripItem_clubs.Size = new Size(154, 26);
            menuStripItem_clubs.Text = "Club";
            // 
            // menuStripItem_members
            // 
            menuStripItem_members.Name = "menuStripItem_members";
            menuStripItem_members.Size = new Size(154, 26);
            menuStripItem_members.Text = "Members";
            // 
            // tablesToolStripMenuItem
            // 
            tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            tablesToolStripMenuItem.Size = new Size(154, 26);
            tablesToolStripMenuItem.Text = "Tables";
            // 
            // slotsToolStripMenuItem
            // 
            slotsToolStripMenuItem.Name = "slotsToolStripMenuItem";
            slotsToolStripMenuItem.Size = new Size(154, 26);
            slotsToolStripMenuItem.Text = "Slots";
            // 
            // bookingsToolStripMenuItem
            // 
            bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            bookingsToolStripMenuItem.Size = new Size(154, 26);
            bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { applicationToolStripMenuItem, contactToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(169, 26);
            applicationToolStripMenuItem.Text = "Application";
            applicationToolStripMenuItem.Click += applicationToolStripMenuItem_Click;
            // 
            // contactToolStripMenuItem
            // 
            contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            contactToolStripMenuItem.Size = new Size(169, 26);
            contactToolStripMenuItem.Text = "Contact";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clubToolStripMenuItem1, bookingsHistoryToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // clubToolStripMenuItem1
            // 
            clubToolStripMenuItem1.Name = "clubToolStripMenuItem1";
            clubToolStripMenuItem1.Size = new Size(224, 26);
            clubToolStripMenuItem1.Text = "Club";
            // 
            // bookingsHistoryToolStripMenuItem
            // 
            bookingsHistoryToolStripMenuItem.Name = "bookingsHistoryToolStripMenuItem";
            bookingsHistoryToolStripMenuItem.Size = new Size(224, 26);
            bookingsHistoryToolStripMenuItem.Text = "Bookings History";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(menuStrip_Control);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip_Control;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billiards Table Booking Application";
            Load += frmMain_Load;
            menuStrip_Control.ResumeLayout(false);
            menuStrip_Control.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_Control;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem menuStripItem_clubs;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem showInformationToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem menuStripItem_accountInfo;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem menuStripItem_members;
        private ToolStripMenuItem contactToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem tablesToolStripMenuItem;
        private ToolStripMenuItem slotsToolStripMenuItem;
        private ToolStripMenuItem bookingsToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem clubToolStripMenuItem1;
        private ToolStripMenuItem bookingsHistoryToolStripMenuItem;
    }
}