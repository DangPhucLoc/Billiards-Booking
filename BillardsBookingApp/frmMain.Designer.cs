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
            controlToolStripMenuItem = new ToolStripMenuItem();
            menuStripItem_clubs = new ToolStripMenuItem();
            menuStripItem_members = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            contactToolStripMenuItem = new ToolStripMenuItem();
            menuStrip_Control.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_Control
            // 
            menuStrip_Control.ImageScalingSize = new Size(20, 20);
            menuStrip_Control.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, controlToolStripMenuItem, aboutToolStripMenuItem });
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
            // controlToolStripMenuItem
            // 
            controlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuStripItem_clubs, menuStripItem_members });
            controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            controlToolStripMenuItem.Size = new Size(55, 24);
            controlToolStripMenuItem.Text = "View";
            // 
            // menuStripItem_clubs
            // 
            menuStripItem_clubs.Name = "menuStripItem_clubs";
            menuStripItem_clubs.Size = new Size(224, 26);
            menuStripItem_clubs.Text = "Clubs";
            // 
            // menuStripItem_members
            // 
            menuStripItem_members.Name = "menuStripItem_members";
            menuStripItem_members.Size = new Size(224, 26);
            menuStripItem_members.Text = "Members";
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
            applicationToolStripMenuItem.Size = new Size(224, 26);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // contactToolStripMenuItem
            // 
            contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            contactToolStripMenuItem.Size = new Size(224, 26);
            contactToolStripMenuItem.Text = "Contact";
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
        private ToolStripMenuItem controlToolStripMenuItem;
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
    }
}