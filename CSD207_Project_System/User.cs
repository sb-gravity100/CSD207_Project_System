
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CSD207_Project_System
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
    }
}
