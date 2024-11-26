using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Text.RegularExpressions;
using MaterialSkin;
using static MaterialSkin.MaterialSkinManager;
using MaterialSkin.Controls;

namespace CSD207_Project_System
{
    public partial class Main : MaterialForm
    {
        public Themes THEME = MaterialSkinManager.Themes.LIGHT;
        public MaterialSkinManager skin = MaterialSkinManager.Instance;

        public Main()
        {
            InitializeComponent();
            skin.AddFormToManage(this);
            skin.Theme = THEME;
            skin.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loginPanel.Controls.Add(new Login(this));
        }

        private void themeBtn_Click(object sender, EventArgs e)
        {
            if (THEME == MaterialSkinManager.Themes.DARK)
            {
                THEME = MaterialSkinManager.Themes.LIGHT;
            } else
            {
                THEME = MaterialSkinManager.Themes.DARK;
            }

            skin.Theme = THEME;
        }
    }
}
