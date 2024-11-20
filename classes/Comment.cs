using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD207_Project_System.classes
{
    public class Comment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Content { get; set; }
        public string PostId { get; set; }
        public string UserId { get; set; }
        public int Likes { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CommentModel : BaseModel<Comment>
    {
        public CommentModel() : base("Comments") { }

        public async Task<Comment> Get(string id) =>
            await Find(id);

        public async Task<User> GetUser(string userId) =>
            await new UserModel().Find(userId);

        public async Task<Post> GetPost(string postId) =>
            await new PostModel().Find(postId);

        public async Task AddLike(string commentId)
        {
            var comment = await Find(commentId);
            if (comment != null)
            {
                comment.Likes++;
                await Update(commentId, comment);
            }
        }
    }
}
