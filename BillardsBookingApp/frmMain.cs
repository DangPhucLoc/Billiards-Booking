using BillardsBookingApp;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public User userOrAdmin { get; set; }
        frmLogin frmLogin;
        frmApplicationInfo frmApplicationInfo;
        public frmMain()
        {
            InitializeComponent();
            loginToolStripMenuItem.Visible = false;
            manageToolStripMenuItem.Visible = false;
            viewToolStripMenuItem.Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadApp();
        }

        public void LoadApp()
        {
            if (userOrAdmin == null)
            {
                loginToolStripMenuItem.Visible = true;
                logoutToolStripMenuItem.Visible = false;
                menuStripItem_accountInfo.Visible = false;
            }

            else if (userOrAdmin != null)
            {
                loginToolStripMenuItem.Visible = false;
                logoutToolStripMenuItem.Visible = true;
                menuStripItem_accountInfo.Visible = true;
                if (userOrAdmin.Role.Equals("Staff"))
                {
                    manageToolStripMenuItem.Visible = true;
                }
                else if (userOrAdmin.Role.Equals("Customer"))
                {
                    viewToolStripMenuItem.Visible = true;
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to Logout of current account?", "Login Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                userOrAdmin = null;
                MessageBox.Show("Logout successfully!");
                LoadApp();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin(this);
            loginForm.Show();
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmApplicationInfo == null || frmApplicationInfo.IsDisposed)
            {
                frmApplicationInfo = new frmApplicationInfo();
            }
            frmApplicationInfo.Show();
        }

        private void menuStripItem_accountInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
