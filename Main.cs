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
        public static string USERS = "Users";
        MongoClient client;
        IMongoDatabase db;
        UserModel users;

        public Main()
        {
            InitializeComponent();
            client = new MongoClient(url);
            db = client.GetDatabase(dbName);
            users = new UserModel(db);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loginPanel.Controls.Add(new Login());
        }
    }
}
