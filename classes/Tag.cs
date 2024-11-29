using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSD207_Project_System
{
    public class Tag : BaseClass
    {
        public string Name { get; set; }
    }

    public class TagModel : BaseModel<Tag>
    {
        public TagModel() : base("Tags") { }

        public async Task<List<Tag>> GetAllTags() =>
            await _collection.Find(Builders<Tag>.Filter.Empty).ToListAsync();

        public async Task<bool> TagExists(string tagName) =>
            await _collection.Find(Builders<Tag>.Filter.Eq("Name", tagName)).AnyAsync();

        public async Task<Tag> FindByName(string tagName) =>
            await _collection.Find(Builders<Tag>.Filter.Eq("Name", tagName)).FirstOrDefaultAsync();

        public async Task AddTag(string tagName)
        {
            var tag = await FindByName(tagName);
            if (tag == null)
            {
                tag = new Tag { Name = tagName };
                await Insert(tag);
            }
        }

        public async Task RemoveTag(string tagName)
        {
            var tag = await FindByName(tagName);
            if (tag != null)
            {
                await Delete(tag);
            }
        }
    }
}
