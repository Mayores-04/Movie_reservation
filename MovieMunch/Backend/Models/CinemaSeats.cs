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

        [BsonElement("Regular Foods")]
        public List<string> RegularFoodsName { get; set; }

        [BsonElement("Regular Foods Price")]
        public List<decimal> RegularFoodsPrice { get; set; }

        [BsonElement("Regular Foods Quantity")]
        public List<int> RegularFoodsQuantity { get; set; }

        [BsonElement("Snack Foods")]
        public List<string> SnackFoodsName { get; set; }

        [BsonElement("Snack Foods Price")]
        public List<decimal> SnackFoodsPrice { get; set; }

        [BsonElement("Snack Foods Quantity")]
        public List<int> SnackFoodsQuantity { get; set; }
    }
}
