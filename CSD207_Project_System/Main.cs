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

namespace CSD207_Project_System
{
    public partial class Main : Form
    {
        public static string url = "mongodb+srv://sb:sbgravity100@main.pa1uh.mongodb.net/";
        public static string dbName = "main";
        public static string Users_Collection = "Users";
        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<User> users;
        BindingList<User> l = new BindingList<User>();

        public Main()
        {
            InitializeComponent();
            client = new MongoClient(url);
            db = client.GetDatabase(dbName);
            users = db.GetCollection<User>(Users_Collection);
            userTable.DataSource = l;
        }

        async Task ShowUsers()
        {
            try
            {
                userTable.Rows.Clear();
                l.Clear();
                var u = await users.FindAsync(r => true);
                foreach (var x in await u.ToListAsync())
                {
                    l.Add(x);
                }
                userTable.Refresh();
            }
            catch (Exception ex)
            {

            }
        }

        async Task AddUser(User user)
        {
            await users.InsertOneAsync(user);
            await ShowUsers();
            MessageBox.Show("User added!");
        }

        async Task DeleteUser(string id)
        {
            await users.DeleteOneAsync(_ => _.Id.Equals(id));
            await ShowUsers();
            MessageBox.Show("User deleted!");
        }

        async Task DeleteUser(User user)
        {
            await users.DeleteOneAsync(_ => _.Id.Equals(user.Id));
            await ShowUsers();
            MessageBox.Show("User deleted!");
        }

        async Task DeleteMany(List<string> id)
        {
            var filter = Builders<User>.Filter.In(_ => _.Id, id);
            await users.DeleteManyAsync(filter);
            await ShowUsers();
            MessageBox.Show("Users deleted!");
        }

        async Task UserExists(string id, Object[] x)
        {
            var u = await users.FindAsync(_ => _.Id.Equals(id));
            bool flag = u.ToList().Count > 0;
            foreach (Button k in x)
            {
                k.Enabled = flag;
            }
        }

        async Task UpdateUser(string id, User user)
        {
            var filter = Builders<User>.Filter.Eq("Id", id);
            var update = Builders<User>.Update.Set(_ => _.FullName, user.FullName)
                .Set(_ => _.Gmail, user.Gmail)
                .Set(_ => _.Password, user.Password)
                .Set(_ => _.UserName, user.UserName)
                .Set(_ => _.BirthDate, user.BirthDate)
                .Set(_ => _.Mobile, user.Mobile);
            var res = await users.UpdateOneAsync(filter, update);
            if (res.IsAcknowledged)
            {
                await ShowUsers();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(ShowUsers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                FullName = FullNameBox.Text,
                UserName = UserNameBox.Text,
                Password = PasswordBox.Text,
                BirthDate = BirthDateBox.Value.Date,
                Gmail = GmailBox.Text,
                Mobile = MobileBox.Text,
            };
            Task.Run(async () =>
            {
                await AddUser(user);
                FullNameBox.Text = "";
                UserNameBox.Text = "";
                PasswordBox.Text = "";
                GmailBox.Text = "";
                MobileBox.Text = "";
                BirthDateUpdateBox.Value = DateTime.Today;
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(new DateTime(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToFileTimeUtc()));
            Task.Run(async () => await ShowUsers());
        }

        private void deletePress(object sender, KeyPressEventArgs e)
        {
            foreach (var i in userTable.SelectedCells)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void idUpdateBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idUpdateBox.Text))
            {
                FullNameUpdateBox.Text = String.Empty;
                GmailUpdateBox.Text = String.Empty;
                PasswordUpdateBox.Text = String.Empty;
                MobileUpdateBox.Text = String.Empty;
                BirthDateUpdateBox.Value = DateTime.Now;
                UserNameUpdateBox.Text = String.Empty;
                UpdateBtn.Enabled = false;
            }
            else
            {
                Object[] s = { UpdateBtn };
                Task.Run(async () =>
                {
                    await UserExists(idUpdateBox.Text, s);
                    if (UpdateBtn.Enabled)
                    {
                        var u = (await users.FindAsync(_ => _.Id.Equals(idUpdateBox.Text))).First();
                        FullNameUpdateBox.Text = u.FullName;
                        UserNameUpdateBox.Text = u.UserName;
                        MobileUpdateBox.Text = u.Mobile;
                        BirthDateUpdateBox.Value = u.BirthDate;
                        GmailUpdateBox.Text = u.Gmail;
                        PasswordUpdateBox.Text = u.Password;
                    }
                });
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var d = BirthDateUpdateBox.Value.Date.AddHours(-16);
            User u = new User() { FullName = FullNameUpdateBox.Text, UserName = UserNameUpdateBox.Text, Password = PasswordUpdateBox.Text, Gmail = GmailUpdateBox.Text, Mobile = MobileUpdateBox.Text, BirthDate = d };
            Task.Run(async () =>
            {
                await UpdateUser(idUpdateBox.Text, u);
                idUpdateBox.Text = String.Empty;
                FullNameUpdateBox.Text = String.Empty;
                GmailUpdateBox.Text = String.Empty;
                PasswordUpdateBox.Text = String.Empty;
                UpdateBtn.Enabled = false;
            });
        }

        private void handleErrpr(object sender, DataGridViewDataErrorEventArgs e)
        {
            userTable.Refresh();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete these users?", "Delete User", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Task.Run(async () =>
                {
                    var s = new List<String>();
                    foreach (DataGridViewTextBoxCell x in userTable.SelectedCells)
                    {
                        var index = x.RowIndex;
                        s.Add(userTable.Rows[index].Cells[0].Value.ToString());
                    }
                    await DeleteMany(s);
                }
                );
            }
        }

        private void TextAddChange(object sender, EventArgs e)
        {
            AddButton.Enabled = !String.IsNullOrEmpty(FullNameBox.Text.Trim()) && !String.IsNullOrEmpty(UserNameBox.Text.Trim()) && !String.IsNullOrEmpty(PasswordBox.Text.Trim()) && !String.IsNullOrEmpty(GmailBox.Text.Trim()) && !String.IsNullOrEmpty(MobileBox.Text.Trim());
        }
    }
}
