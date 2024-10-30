
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CSD207_Project_System
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Gmail { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public System.DateTime BirthDate { get; set; }
    }
}
