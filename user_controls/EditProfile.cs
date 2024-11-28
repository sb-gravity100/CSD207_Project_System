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
        public EditProfile(Main parent)
        {
            InitializeComponent();
            p = parent;
            Dock = DockStyle.Top;
        }
    }
}
