
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

    public class User : BaseClass
    {
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

        public async Task ToggleLikePost(string userId, string postId)
        {
            var user = await Find(userId);
            if (user != null)
            {
                if (user.LikedPosts == null)
                    user.LikedPosts = new List<string>();

                if (user.LikedPosts.Contains(postId))
                {
                    user.LikedPosts.Remove(postId);
                    await new PostModel().RemoveLike(postId);
                }
                else
                {
                    user.LikedPosts.Add(postId);
                    await new PostModel().AddLike(postId);
                }

                await Update(user);
            }
        }

        public async Task ToggleLikeComment(string userId, string commentId)
        {
            var user = await Find(userId);
            if (user != null)
            {
                if (user.LikedComments == null)
                    user.LikedComments = new List<string>();

                if (user.LikedComments.Contains(commentId))
                {
                    user.LikedComments.Remove(commentId);
                    await new CommentModel().RemoveLike(commentId);
                }
                else
                {
                    user.LikedComments.Add(commentId);
                    await new CommentModel().AddLike(commentId);
                }

                await Update(user);
            }
        }

    }
}
