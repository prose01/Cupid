using Cupid.Model;
using MongoDB.Driver;

namespace Cupid.Data
{
    public class Context
    {
        private readonly IMongoDatabase _database;

        public Context()
        {
            var client = new MongoClient(Environment.GetEnvironmentVariable("ConnectionString"));
            if (client != null)
                _database = client.GetDatabase(Environment.GetEnvironmentVariable("Database"));
        }
        public IMongoCollection<Profile> Profiles => _database.GetCollection<Profile>("Profile");
    }
}
