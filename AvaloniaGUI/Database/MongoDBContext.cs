using System.Collections;
using MongoDB.Driver;

namespace AvaloniaGUI
{
    public class MongoDBContext
    {
        public IMongoDatabase Database { get; }

        public MongoDBContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            Database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return Database.GetCollection<T>(name);
        }

        public void InsertOneDoc<T>(string collectionName, T document)
        {
            var collection = GetCollection<T>(collectionName);
            collection.InsertOne(document);
        }

        public IEnumerable FindOne<T>(string collectionName, FilterDefinition<T> filter)
        {
            var collection = Database.GetCollection<T>(collectionName);
            return collection.Find(filter).ToList();
        }

        public void UpdateOne<T>(string collectionName, FilterDefinition<T> filter, UpdateDefinition<T> update)
        {
            var collection = Database.GetCollection<T>(collectionName);
            collection.UpdateOne(filter, update);
        }

        public void DeleteOne<T>(string collectionName, FilterDefinition<T> filter)
        {
            var collection = Database.GetCollection<T>(collectionName);
            collection.DeleteOne(filter);
        }
    }
}