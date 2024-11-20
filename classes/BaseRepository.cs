using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace CSD207_Project_System.classes
{
    public class BaseModel<T>
    {
        protected readonly IMongoCollection<T> _collection;

        public BaseModel(string collectionName)
        {
            _collection = Program.db.GetCollection<T>(collectionName);
        }

        public async Task<T> Find(string id) =>
            await _collection.Find(Builders<T>.Filter.Eq("_id", id)).FirstOrDefaultAsync();

        public async Task<List<T>> Find(FilterDefinition<T> filter) =>
            await _collection.Find(filter).ToListAsync();

        public async Task Insert(T document) =>
            await _collection.InsertOneAsync(document);

        public async Task Update(string id, T document) =>
            await _collection.ReplaceOneAsync(Builders<T>.Filter.Eq("_id", id), document);

        public async Task Delete(string id) =>
            await _collection.DeleteOneAsync(Builders<T>.Filter.Eq("_id", id));

        public async Task<bool> Exists(string id) =>
            await _collection.Find(Builders<T>.Filter.Eq("_id", id)).AnyAsync();

        public async Task<List<T>> Search(string searchTerm) =>
            await _collection.Find(Builders<T>.Filter.Text(searchTerm)).ToListAsync();
    }


}
