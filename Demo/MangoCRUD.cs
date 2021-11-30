using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
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
            var result = coll.Find<T>(new BsonDocument()).ToList<T>();
            return result;
        }
    }
}
