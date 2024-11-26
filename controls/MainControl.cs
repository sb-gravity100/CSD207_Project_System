using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSD207_Project_System.controls
{
    public partial class MainControl : UserControl
    {
        Main p;
        public MainControl(Main parent)
        {
            p = parent;
            InitializeComponent();
        }
    }
}
