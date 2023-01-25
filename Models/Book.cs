using MongoDB.Bson.Serialization.Attributes;

namespace lab3.Models
{
    public class Book
    {
        [BsonId, BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int Price { get; set; }
        public int YearPublished { get; set; }
        public List<Reader> Readers { get; set; } = null!;
    }
}
