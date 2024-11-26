using dotenv.net;
using dotenv.net.Utilities;
using MongoDB.Driver;
using SharpCompress;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CSD207_Project_System
{
    internal static class Program
    {
        public static MongoClient client;
        public static IMongoDatabase db;
        public static IDictionary<string, string> env;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DotEnv.Load(new DotEnvOptions(probeForEnv: true, probeLevelsToSearch: 3));
            DotEnv.Read();

            client = new MongoClient(EnvReader.GetStringValue("MONGO_URL"));
            db = client.GetDatabase(EnvReader.GetStringValue("DB_NAME"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
