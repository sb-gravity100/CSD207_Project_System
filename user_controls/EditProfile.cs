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
    public partial class EditProfile : UserControl
    {
        Main p;
        UserModel users = new UserModel();
        public EditProfile(Main parent)
        {
            InitializeComponent();
            p = parent;
            Dock = DockStyle.Top;
            UserName.Text = p.user.UserName;
            DisplayName.Text = p.user.DisplayName;
            Gmail.Text = p.user.Gmail;
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            bool changes = p.user.UserName != UserName.Text || p.user.DisplayName != DisplayName.Text;
            if (changes)
            {
                p.user.UserName = UserName.Text;
                p.user.DisplayName = DisplayName.Text;

                if (await users.Update(p.user))
                {
                    InfoBox.Text = "Updated successfully!";
                }
                else
                {
                    InfoBox.Text = "Something went wrong.";
                }
            }
        }

        private async void materialButton2_Click(object sender, EventArgs e)
        {
            if (Password.Text == p.user.Password)
            {
                if (NewPassword.Text == RepeatPassword.Text)
                {
                    p.user.Password = NewPassword.Text;
                    if (await users.Update(p.user))
                    {
                        PassBox.Text = "Password updated successfully!";
                    }
                }
                else
                {
                    PassBox.Text = "New password does not match.";
                }
            }
            else
            {
                PassBox.Text = "Incorrect Password.";
            }
        }

        private void Gmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            p.PrevPage();
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
