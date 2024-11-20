using CSD207_Project_System.classes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD207_Project_System
{

    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class PostModel : BaseModel<Post>
    {
        public PostModel() : base("Posts") { }

        public async Task<Post> Get(string id) =>
            await Find(id);

        public async Task<User> GetUser(string userId) =>
            await new UserModel().Find(userId);

        public async Task<List<Comment>> GetComments(string postId) =>
            await new CommentModel().Find(Builders<Comment>.Filter.Eq("PostId", postId));

        public async Task AddLike(string postId)
        {
            var post = await Find(postId);
            if (post != null)
            {
                post.Likes++;
                await Update(postId, post);
            }
        }

        public async Task AddComment(string postId)
        {
            var post = await Find(postId);
            if (post != null)
            {
                post.Comments++;
                await Update(postId, post);
            }
        }
    }
}
