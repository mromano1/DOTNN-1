using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace lemmefind
{
    public class ObjectModel
    {
        public ObjectId id { get; set; }
        public string objectName { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public int amount { get; set; }
    }


    public class MongoCRUD
    {
        private IMongoDatabase mDB;


        /*
        string host should look like below 
        [ mongodb+srv://developer1:<password>@qple-core.jxnch.mongodb.net/myFirstDatabase?retryWrites=true&w=majority ]
        
        string db is a database you want to handle.
         */
        public MongoCRUD(string host, string db)    
        {
            var client = new MongoClient(host);
            mDB = client.GetDatabase(db);
        }

        /*
         string table is a name of collection.
         The second parameter, record, is a template.
         */
        public void InsertRecord<T>(string table, T record)
        {
            var collection = mDB.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = mDB.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public List<T> LoadRecordByObject<T>(string table, string objName)
        {
            var collection = mDB.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("objectName", objName);

            return collection.Find(filter).ToList();
        }

        public bool CheckRecordExist<T>(string table, string objName)
        {
            var collection = mDB.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("objectName", objName);
            var ret = collection.Find(filter).FirstOrDefault();

            if (ret != null)
            {
                return true;
            }
            return false;
        }
    }
}
