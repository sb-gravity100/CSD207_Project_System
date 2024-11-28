using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSD207_Project_System
{
    public partial class Login : UserControl
    {
        UserModel users;
        Main p;
        public Login(Main parent)
        {
            p = parent;
            users = new UserModel();
            InitializeComponent();
            Dock = DockStyle.Fill;
            username.Focus();

            username.KeyDown += p.CtrlBackEnable;
            password.KeyDown += p.CtrlBackEnable;
        }

        private void regBtn_LinkClicked(object sender, EventArgs e)
        {
            if (p != null)
            {
                p.NextPage(new Register(p));
            }
        }

        public void CtrlBackEnable(object sender, KeyEventArgs e)
        {
            var txtbox = sender as TextBox;
            if (e.Control && e.KeyCode == Keys.Back)
            {
                int selectionStart = txtbox.SelectionStart;
                if (selectionStart > 0)
                {
                    int wordStart = txtbox.Text.LastIndexOf(' ', selectionStart - 1);
                    if (wordStart == -1)
                        wordStart = 0;
                    txtbox.Text = txtbox.Text.Remove(wordStart, selectionStart - wordStart);
                    txtbox.SelectionStart = wordStart;
                }
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void loginBtn_ClickAsync(object sender, EventArgs e)
        {
            HandleLogin();
        }

        private async void HandleLogin()
        {
            bool isAvailable = await users.UsernameExists(username.Text);
            if (isAvailable)
            {
                userLabel.Text = "";
                var u = await users.FindByUsername(username.Text);
                if (u.Password == password.Text.Trim())
                {
                    passLabel.Text = "";
                    p.user = u;
                    p.NextPage(new Home(p));
                }
                else
                {
                    passLabel.Text = "Password incorrect.";
                    password.Focus();
                }
            }
            else
            {
                userLabel.Text = "Username incorrect.";
                username.Focus();
            }
        }

        private void EnterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                HandleLogin();
            }
        }
    }
}
