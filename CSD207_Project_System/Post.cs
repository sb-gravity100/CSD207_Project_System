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
        public DateTime createdAt { get; set; }
    }

    public class Comment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Content { get; set; }
        public string PostId { get; set; }
        public string UserId { get; set; }
        public DateTime createdAt { get; set; }
    }

    public class PopulatedPost
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; }
    }

    public class PopulatedComment
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public PopulatedPost Post { get; set; }
        public User User { get; set; }
    }

    public class PostModel
    {
        private readonly IMongoCollection<Post> _posts;
        private readonly IMongoCollection<User> _users;

        public PostModel(IMongoDatabase database)
        {
            _posts = database.GetCollection<Post>("Posts");
            _users = database.GetCollection<User>("Users");
        }

        public List<PopulatedPost> GetPopulatedPosts()
        {
            try
            {
                var posts = _posts.Find(_ => true).ToList();
                var userIds = posts.Select(p => p.UserId).Distinct().ToList();
                var users = _users.Find(u => userIds.Contains(u.Id)).ToList();

                var populatedPosts = posts.Select(post => new PopulatedPost
                {
                    Id = post.Id,
                    Content = post.Content,
                    Likes = post.Likes,
                    Comments = post.Comments,
                    CreatedAt = post.createdAt,
                    User = users.FirstOrDefault(u => u.Id == post.UserId)
                }).ToList();

                return populatedPosts;
            }
            catch (Exception e) { }
            return new List<PopulatedPost>();
        }
    }

    public class CommentModel
    {
        private readonly IMongoCollection<Comment> _comments;
        private readonly IMongoCollection<Post> _posts;
        private readonly IMongoCollection<User> _users;

        public CommentModel(IMongoDatabase database)
        {
            _comments = database.GetCollection<Comment>("Comments");
            _posts = database.GetCollection<Post>("Posts");
            _users = database.GetCollection<User>("Users");
        }

        public List<PopulatedComment> GetPopulatedComments()
        {
            try
            {
                var comments = _comments.Find(_ => true).ToList();
                var postIds = comments.Select(c => c.PostId).Distinct().ToList();
                var userIds = comments.Select(c => c.UserId).Distinct().ToList();

                var posts = _posts.Find(p => postIds.Contains(p.Id)).ToList();
                var users = _users.Find(u => userIds.Contains(u.Id)).ToList();

                var populatedComments = comments.Select(comment => new PopulatedComment
                {
                    Id = comment.Id,
                    Content = comment.Content,
                    CreatedAt = comment.createdAt,
                    Post = posts
                        .Where(p => p.Id == comment.PostId)
                        .Select(p => new PopulatedPost
                        {
                            Id = p.Id,
                            Content = p.Content,
                            Likes = p.Likes,
                            Comments = p.Comments,
                            CreatedAt = p.createdAt,
                            User = users.FirstOrDefault(u => u.Id == p.UserId)
                        }).FirstOrDefault(),
                    User = users.FirstOrDefault(u => u.Id == comment.UserId)
                }).ToList();

                return populatedComments;
            }
            catch (Exception e) { }
            return new List<PopulatedComment>();
        }
    }

}
