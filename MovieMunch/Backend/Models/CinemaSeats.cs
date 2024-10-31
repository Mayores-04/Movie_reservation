using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Dynamic;

namespace MovieMunch.Models
{
    public class CinemaSeats
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("MovieName")]
        public string MovieName { get; set; }

        [BsonElement("MoviePrice")]
        public double MoviePrice { get; set; }

        [BsonElement("SeatNumbers")]
        public List<string> SeatNumbers { get; set; }

        [BsonElement("ReservedBy")]
        public string ReservedBy { get; set; }

        [BsonElement("IsReserved")]
        public bool IsReserved { get; set; }
    }
}
