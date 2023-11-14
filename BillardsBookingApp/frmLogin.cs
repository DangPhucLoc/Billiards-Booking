using BussinessObject.Models;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        UserRepository userRepository = new UserRepository();
        frmMain mainForm;

        public frmLogin(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (txt_email.Text.Equals("") || txt_password.Text.Equals(""))
            {
                btn_login.Enabled = false;
            }

            else
            {
                btn_login.Enabled = true;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_email.Text.Equals("") || txt_password.Text.Equals(""))
            {
                btn_login.Enabled = false;
            }

            else
            {
                btn_login.Enabled = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txt_email.Focus();
            btn_login.Enabled = false;
            txt_password.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            User u = userRepository.GetUserByUserNameAndPassword(txt_email.Text, txt_password.Text);

            if (u != null)
            {
                this.Hide();
                mainForm.userOrAdmin = u;
                mainForm.LoadApp();
                this.Cursor = Cursors.Default;
                MessageBox.Show($"Login Successfully as {u.FirstName}", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else if (u == null)
            {
                u = userRepository.GetUserByUserName(txt_email.Text);
                if (u == null)
                {
                    MessageBox.Show("Wrong Email, Please try again!", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Wrong Password, Please try again!", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_login.PerformClick();
                e.Handled = true;
            }
        }
    }
}
