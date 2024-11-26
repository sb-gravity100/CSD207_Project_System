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
        }

        private void regBtn_LinkClicked(object sender, EventArgs e)
        {
            if (p != null)
            {
                p.Controls.Remove(this);
                p.Controls.Add(new Register(p));
            }
        }

        private void loginBtn_ClickAsync(object sender, EventArgs e)
        {
            Task.Run(HandleLogin);
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
                    MessageBox.Show("You got in!");

                }
                else
                {
                    passLabel.Text = "Password incorrect.";
                    username.Text = "";
                    password.Text = "";
                }
            }
            else
            {
                userLabel.Text = "Username incorrect.";
                username.Text = "";
                password.Text = "";
            }
        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                Task.Run(HandleLogin);
            }
        }
    }
}
