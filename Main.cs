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
using static System.Net.Mime.MediaTypeNames;
using SharpCompress;
using Application = System.Windows.Forms.Application;

namespace CSD207_Project_System
{
    public partial class Main : MaterialForm
    {
        public Themes THEME = MaterialSkinManager.Themes.LIGHT;
        public MaterialSkinManager skin = MaterialSkinManager.Instance;
        public User user;
        private UserControl _currPage;
        private UserControl _prevPage;

        public Main()
        {
            InitializeComponent();
            skin.AddFormToManage(this);
            skin.Theme = THEME;
            //Size = new Size(864, 652);
            skin.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey300, Accent.Cyan700, TextShade.WHITE);

            ControlAdded += (s, e) =>
            {
                foreach (Control item in Controls)
                {
                    if (!item.Equals(themeBtn))
                    {
                        item.Size = UserArea.Size;
                        item.MaximumSize = item.Size;
                    }
                }
            };

            FormClosed += (s, e) => System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private async void TestHome()
        {
            try
            {
                user = await new UserModel().FindByUsername("sbgravity100");
                NextPage(new Home(this));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void NextPage(UserControl next)
        {
            Controls.Remove(_currPage);
            _prevPage = _currPage;
            _currPage = next;
            Controls.Add(_currPage);

        }

        public void PrevPage()
        {
            Controls.Remove(_currPage);
            var prev = _currPage;
            _currPage = _prevPage;
            _prevPage = prev;
            Controls.Add(_currPage);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            NextPage(new Login(this));

        }

        private void themeBtn_Click(object sender, EventArgs e)
        {
            if (THEME == MaterialSkinManager.Themes.DARK)
            {
                THEME = MaterialSkinManager.Themes.LIGHT;
            }
            else
            {
                THEME = MaterialSkinManager.Themes.DARK;
            }

            skin.Theme = THEME;
        }

        public void CtrlBackEnable(object sender, KeyEventArgs e)
        {
            var txtbox = sender as TextBox;
            if (txtbox == null) return;

            if (e.Control && e.KeyCode == Keys.Back)
            {
                int selectionStart = txtbox.SelectionStart;
                if (selectionStart > 0)
                {
                    int wordStart = txtbox.Text.LastIndexOfAny(new char[] { ' ', '\n', '\r' }, selectionStart - 1);
                    if (wordStart == -1)
                        wordStart = 0;
                    txtbox.Text = txtbox.Text.Remove(wordStart, selectionStart - wordStart);
                    txtbox.SelectionStart = wordStart;
                }
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        public string FormatDate(DateTime dateTime)
        {
            TimeSpan timeSpan = DateTime.Now - dateTime;

            if (timeSpan.TotalSeconds < 60)
                return $"{(int)timeSpan.TotalSeconds} seconds ago";
            if (timeSpan.TotalMinutes < 60)
                return $"{(int)timeSpan.TotalMinutes} minutes ago";
            if (timeSpan.TotalHours < 24)
                return $"{(int)timeSpan.TotalHours} hours ago";
            if (timeSpan.TotalDays < 7)
                return $"{(int)timeSpan.TotalDays} days ago";
            if (timeSpan.TotalDays < 30)
                return $"{(int)(timeSpan.TotalDays / 7)} weeks ago";

            return dateTime.ToString("MMMM dd, yyyy");
        }


        public void Logout()
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NextPage(new Login(this));
                user = null;

            }

        }

    }
}
