
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
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
        public string[] Likes { get; set; }
    }

    public class UserModel
    {
        private readonly IMongoCollection<User> _users;

        public UserModel(IMongoDatabase database)
        {
            _users = database.GetCollection<User>("Users");
        }

        public void InsertUser(User user)
        {
            try
            {
                _users.InsertOne(user);
            }
            catch (Exception e) { }
        }

        public bool UpdateUser(string id, User updatedUser)
        {
            try
            {
                var result = _users.ReplaceOne(u => u.Id == id, updatedUser);
                return result.ModifiedCount > 0;
            }
            catch (Exception e) { }
            return false;
        }

        public bool DeleteUser(string id)
        {
            try
            {
                var result = _users.DeleteOne(u => u.Id == id);
                return result.DeletedCount > 0;
            }
            catch (Exception e) { }
            return false;
        }

        public bool UserExists(string id)
        {
            try
            {
                return _users.Find(u => u.Id == id).Any();
            }
            catch (Exception e) { }
            return false;
        }

        public List<User> Search(string query)
        {
            try
            {
                var filter = Builders<User>.Filter.Text(query);
                return _users.Find(filter).ToList();
            }
            catch (Exception e) { }
            return new List<User>();
        }
    }
}
