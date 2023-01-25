using MongoDB.Bson.Serialization.Attributes;

namespace lab3.Models
{
    public class Reader
    {
        [BsonId, BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string PatronymicName { get; set; } = null!;
        public string Address { get; set; } = null!;
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string TicketID { get; set; } = null!;
        public int Phone { get; set; }
        public DateTime DateBirth { get; set; }

        public List<Ticket> Tickets { get; set; } = null!;
        public List<InfoBook> InfoBooks { get; set; } = null!;
    }
}
