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

        public Insert
    }
}
