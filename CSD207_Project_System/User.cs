
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CSD207_Project_System
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Gmail { get; set; }
        public string Password { get; set; }
    }

    public class UserModel
    {
        private readonly IMongoCollection<User> _users;

        public UserModel(string connectionString, string dbName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(dbName);
            _users = database.GetCollection<User>(collectionName);
        }

        // Create (Insert) a new user
        public bool CreateUser(User user)
        {
            try
            {
                _users.InsertOne(user);  // InsertOne is still appropriate, MongoDB doesn't have an Insert method
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Read (Find) a user by their Id
        public User GetUserById(string id)
        {
            try
            {
                return _users.Find(user => user.Id == id).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        // Read (Find) a user by their Username
        public User GetUserByUsername(string username)
        {
            try
            {
                return _users.Find(user => user.UserName == username).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        // Update (Modify) an existing user using InsertOne for replacement
        public bool UpdateUser(string id, User updatedUser)
        {
            try
            {
                var result = _users.ReplaceOne(user => user.Id == id, updatedUser);
                return result.ModifiedCount > 0;
            }
            catch
            {
                return false;
            }
        }

        // Delete a user by their Id
        public bool DeleteUser(string id)
        {
            try
            {
                var result = _users.DeleteOne(user => user.Id == id);
                return result.DeletedCount > 0;
            }
            catch
            {
                return false;
            }
        }

        // Get all users
        public List<User> GetAllUsers()
        {
            try
            {
                return _users.Find(user => true).ToList();
            }
            catch
            {
                return new List<User>();
            }
        }
    }
}
