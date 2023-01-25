using MongoDB.Bson.Serialization.Attributes;

namespace lab3.Models
{
    public class Ticket
    {
        [BsonId, BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        
    }
}
