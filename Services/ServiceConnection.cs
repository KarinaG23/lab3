using lab3.Database;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace lab3.Services
{
    public class ServiceConnection
    {
        public IMongoDatabase MongoDatabase { get; }

        public ServiceConnection(IOptions<DbConnection> db)
        {
            var mongoClient = new MongoClient(db.Value.ConnectionString);
            MongoDatabase = mongoClient.GetDatabase(db.Value.Database);
        }
    }
}
