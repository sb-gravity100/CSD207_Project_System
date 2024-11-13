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

        public Main()
        {
            InitializeComponent();
            client = new MongoClient(url);
            db = client.GetDatabase(dbName);
            users = db.GetCollection<User>(Users_Collection);
        }


        async Task AddUser(User user)
        {
            await users.InsertOneAsync(user);
        }

        async Task DeleteUser(string id)
        {
            await users.DeleteOneAsync(_ => _.Id.Equals(id));
        }

        async Task DeleteUser(User user)
        {
            await users.DeleteOneAsync(_ => _.Id.Equals(user.Id));
        }

        async Task DeleteMany(List<string> id)
        {
            var filter = Builders<User>.Filter.In(_ => _.Id, id);
            await users.DeleteManyAsync(filter);
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
            var update = Builders<User>.Update.Set(_ => _.Gmail, user.Gmail)
                .Set(_ => _.Password, user.Password)
                .Set(_ => _.UserName, user.UserName);
            var res = await users.UpdateOneAsync(filter, update);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loginPanel.Controls.Add(new Login());
        }
    }
}
