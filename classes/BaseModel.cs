using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using SharpCompress;

namespace CSD207_Project_System
{
    public class BaseClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }

    public class BaseModel<T> where T : BaseClass
    {
        protected readonly IMongoCollection<T> _collection;

        public BaseModel(string collectionName)
        {
            _collection = Program.db.GetCollection<T>(collectionName);
        }

        public async Task<T> Find(string id)
        {
            return await _collection.Find(Builders<T>.Filter.Eq("_id", new ObjectId(id))).FirstOrDefaultAsync();
        }

        public async Task<List<T>> Find(FilterDefinition<T> filter)
        {
            return await _collection.Find(filter).ToListAsync();
        }

        public async Task<bool> Insert(T document)
        {
            try
            {
                await _collection.InsertOneAsync(document);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Insert(IEnumerable<T> documents)
        {
            try
            {
                await _collection.InsertManyAsync(documents);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Update(T document)
        {
            try
            {
                var result = await _collection.ReplaceOneAsync(Builders<T>.Filter.Eq("_id", new ObjectId(document.Id)), document);
                return result.ModifiedCount > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Update(string id, string property, object value)
        {
            try
            {
                var updateDefinition = Builders<T>.Update.Set(property, value);
                var result = await _collection.UpdateOneAsync(Builders<T>.Filter.Eq("_id", new ObjectId(id)), updateDefinition);
                return result.ModifiedCount > 0;
            }
            catch
            {
                return false;
            }
        }


        public async Task<bool> Delete(string id)
        {
            try
            {
                var result = await _collection.DeleteOneAsync(Builders<T>.Filter.Eq("_id", new ObjectId(id)));
                return result.DeletedCount > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(T document)
        {
            try
            {
                var result = await _collection.DeleteOneAsync(Builders<T>.Filter.Eq("_id", new ObjectId(document.Id)));
                return result.DeletedCount > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(IEnumerable<string> ids)
        {
            try
            {
                var newlist = new List<ObjectId>();
                ids.ForEach(t => newlist.Add(new ObjectId(t)));
                var result = await _collection.DeleteManyAsync(Builders<T>.Filter.In("_id", newlist));
                return result.DeletedCount > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(IEnumerable<T> documents)
        {
            try
            {
                var ids = documents.Select(d => d.Id);
                var newlist = new List<ObjectId>();
                ids.ForEach(t => newlist.Add(new ObjectId(t)));
                var result = await _collection.DeleteManyAsync(Builders<T>.Filter.In("_id", newlist));
                return result.DeletedCount > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Exists(string id)
        {
            return await _collection.Find(Builders<T>.Filter.Eq("_id", new ObjectId(id))).AnyAsync();
        }

        public async Task<List<T>> Search(string searchTerm)
        {
            return await _collection.Find(Builders<T>.Filter.Text(searchTerm)).ToListAsync();
        }
    }
}
