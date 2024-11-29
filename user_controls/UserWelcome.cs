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
    public partial class UserWelcome : UserControl
    {
        Main p;
        public UserWelcome(Main p)
        {
            this.p = p;
            InitializeComponent();
            Dock = DockStyle.Fill;

            UserTxt.Text = p.user.UserName;
            materialButton1.Font = new Font("Roboto", 26F, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            p.NextPage(new Home(p));
        }
    }
}
