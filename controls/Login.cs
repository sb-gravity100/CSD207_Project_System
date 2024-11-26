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
        public Login()
        {
            users = new UserModel();
            InitializeComponent();
        }

        private void regBtn_LinkClicked(object sender, EventArgs e)
        {
            var p = this.Parent.Parent as Main;
            if (p != null)
            {
                var loginPanel = p.Controls["loginPanel"];
                loginPanel.Controls.Clear();
                loginPanel.Controls.Add(new Register());
            }
        }

        private async void loginBtn_ClickAsync(object sender, EventArgs e)
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
    }
}
