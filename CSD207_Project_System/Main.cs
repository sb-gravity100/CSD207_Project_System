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
            l.Clear();
            var u = await users.FindAsync(r => true);
            foreach (var x in await u.ToListAsync())
            {
                l.Add(x);
            }
            userTable.Refresh();
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

        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(ShowUsers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(firstNameBox.Text.Trim()) && !String.IsNullOrEmpty(lastNameBox.Text.Trim()) && !String.IsNullOrEmpty(passwordBox.Text.Trim()))
            {
                User user = new User()
                {
                    firstName = firstNameBox.Text,
                    lastName = lastNameBox.Text,
                    password = passwordBox.Text
                };
                Task.Run(async () =>
                {
                    await AddUser(user);
                    firstNameBox.Text = "";
                    lastNameBox.Text = "";
                    passwordBox.Text = "";
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idBox.Text.Trim()))
            {
                Task.Run(async () =>
                {
                    await DeleteUser(idBox.Text);
                    idBox.Text = "";
                });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await ShowUsers());
        }

        private void selectChange(object sender, EventArgs e)
        {
            MessageBox.Show("Selection");
        }

        private void deletePress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Delete))
            {
                
            }
            foreach (var i in userTable.SelectedCells)
            {
                MessageBox.Show(i.ToString());
            }
        }
    }
}
