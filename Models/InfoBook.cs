using MongoDB.Bson.Serialization.Attributes;

namespace lab3.Models
{
    public class InfoBook
    {
        [BsonId, BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        public DateTime DateTakeBook { get; set; }
        public DateTime? DateReturnBook { get; set; }
    }
}
