using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSD207_Project_System
{
    internal static class Program
    {
        public static string url = "mongodb+srv://sb:sbgravity100@main.pa1uh.mongodb.net/";
        public static string dbName = "main";
        public static MongoClient client;
        public static IMongoDatabase db;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            client = new MongoClient(url);
            db = client.GetDatabase(dbName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
