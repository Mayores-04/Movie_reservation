using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MovieMunch.Backend.Models
{
    public class FilmsInCinema
    {
        [BsonId]
        public ObjectId Id { get; set; } 

        [BsonElement("title")]
        public string FilmTitle { get; set; }

        [BsonElement("price")]
        public double FilmsPrice { get; set; }

        [BsonElement("description")]
        public string FilmsDescription { get; set; }

        [BsonElement("imagePath")]
        public string FilmImagePath { get; set; }
    }
}
