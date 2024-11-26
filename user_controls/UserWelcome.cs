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
            var users = Program.db.GetCollection<User>("Users");
            SearchBox.InitializeMongo(users, new List<string>() { "UserName", "DisplayName" }, new Dictionary<string, Func<User, string>>() {
                {"UserName", s => s.UserName },
                {"DisplayName", s => s.DisplayName},
            });
        }
    }
}
