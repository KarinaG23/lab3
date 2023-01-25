using MongoDB.Driver;

namespace lab3.Services
{
    public class GetCollection<T>
    {
        private readonly ServiceConnection _serviceConnection;
        private readonly IMongoCollection<T> _collection;
        
        public GetCollection(ServiceConnection serviceConnection)
        {
            _serviceConnection = serviceConnection;
            _collection = _serviceConnection.MongoDatabase.GetCollection<T>(typeof(T).Name+"s");
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            
            return await _collection.Find(a => true).ToListAsync();
        }
    }
}
