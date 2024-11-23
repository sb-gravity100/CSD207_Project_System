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
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void regBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var p = this.Parent.Parent as Main;
            if (p != null)
            {
                var loginPanel = p.Controls["loginPanel"];
                loginPanel.Controls.Clear();
                loginPanel.Controls.Add(new Register());
            }
        }
    }
}
