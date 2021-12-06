using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class MongoCRUD
    {
        private IMongoDatabase db;
        public MongoCRUD(String dbName)
        {
            var client = new MongoClient();
            db = client.GetDatabase(dbName);
        }
        public void Create<T>(String tableName, T record)
        {
            var collection = db.GetCollection<T>(tableName);
            collection.InsertOne(record);
        }
        public List<T> ReadAll<T>(String tableName)
        {
            var coll = db.GetCollection<T>(tableName);
            var result = coll.Find(new BsonDocument()).ToList();
            return result;
        }
        public T Read<T>(String tableName, Guid searchId)
        {
            var coll = db.GetCollection<T>(tableName);
            var filter = Builders<T>.Filter.Eq("Id", searchId);
            var result = coll.Find(filter).FirstOrDefault();
            return result;
        }
        public void Upsert<T>(String tableName, Guid searchId, T rec) 
        {
            var coll = db.GetCollection<T>(tableName);
            var filter = Builders<T>.Filter.Eq("Id", searchId);
            // var result =
            coll.ReplaceOne( filter, rec, new ReplaceOptions { IsUpsert = true } );
        }
        public void Delete<T>(String tableName, Guid searchId)
        {
            var coll = db.GetCollection<T>(tableName);
            var filter = Builders<T>.Filter.Eq("Id", searchId);
            coll.DeleteOne(filter);
        }
    }
}
