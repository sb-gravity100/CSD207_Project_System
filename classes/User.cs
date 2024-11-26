
using CSD207_Project_System.classes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSD207_Project_System
{

    public class User : BsonDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Gmail { get; set; }
        public string Password { get; set; }
        public List<String> LikedPosts = new List<string>();
        public List<String> LikedComments = new List<string>();
    }

    public class UserModel : BaseModel<User>
    {
        public UserModel() : base("Users") { }


        public async Task<bool> UsernameExists(string username) =>
            await _collection.Find(Builders<User>.Filter.Eq("UserName", username)).AnyAsync();

        public async Task<List<Post>> GetPosts(string userId) =>
            await new PostModel().Find(Builders<Post>.Filter.Eq("UserId", userId));

        public async Task<List<Comment>> GetComments(string userId) =>
            await new CommentModel().Find(Builders<Comment>.Filter.Eq("UserId", userId));

        public async Task<User> FindByUsername(string username) =>
            await _collection.Find(Builders<User>.Filter.Eq("UserName", username)).FirstOrDefaultAsync();

        public async Task AddLikePost(string userId, string postId)
        {
            var user = await Find(userId);
            if (user != null)
            {
                if (user.LikedPosts == null)
                    user.LikedPosts = new List<String> { postId };
                else if (!user.LikedPosts.Contains(postId))
                    user.LikedPosts = (List<string>)user.LikedPosts.Intersect(new List<string> { postId });
                await Update(userId, user);
                await new PostModel().AddLike(postId);
            }
        }

        public async Task AddLikeComment(string userId, string commentId)
        {
            var user = await Find(userId);
            if (user != null)
            {
                if (user.LikedComments == null)
                    user.LikedComments = new List<String> { commentId };
                else if (!user.LikedComments.Contains(commentId))
                    user.LikedComments = (List<string>)user.LikedComments.Concat(new List<string> { commentId });
                await Update(userId, user);
                await new CommentModel().AddLike(commentId);
            }
        }
    }
}
