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
    public partial class ErrorPage : UserControl
    {
        Main p;
        public ErrorPage(Main parent)
        {
            p = parent;
            InitializeComponent();
            Dock = DockStyle.Fill;

            ReturnBtn.Click += (s, e) =>
            {
                p.PrevPage();
            };
        }
    }
}