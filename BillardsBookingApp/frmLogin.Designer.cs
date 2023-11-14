namespace SalesWinApp
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            txt_email = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 96);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(119, 36);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(196, 30);
            txt_email.TabIndex = 1;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(119, 87);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(196, 30);
            txt_password.TabIndex = 2;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.Control;
            btn_login.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.ForestGreen;
            btn_login.Location = new Point(130, 140);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(90, 29);
            btn_login.TabIndex = 3;
            btn_login.Text = "Sign In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            btn_login.KeyPress += btn_login_KeyPress;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(342, 193);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.MenuHighlight;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_password;
        private Button btn_login;
    }
}