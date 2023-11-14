using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public frmMain()
        {
            InitializeComponent();
            loginToolStripMenuItem.Visible = false;
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
            }

            else if (userOrAdmin != null)
            {
                loginToolStripMenuItem.Visible = false;
                logoutToolStripMenuItem.Visible = true;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to Logout of current account?", "Login Status", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(d == DialogResult.OK)
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
    }
}
