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
            BringToFront();
            Dock = DockStyle.Fill;
            Console.WriteLine("HELO");
            materialCard1.BringToFront();
            materialButton1.BringToFront();
        }
    }
}
