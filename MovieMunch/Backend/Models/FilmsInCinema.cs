using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MovieMunch.Backend.Models
{
    public class FilmsInCinema
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("title")]
        public string FilmTitle { get; set; } 

        [BsonElement("description")]
        public string FilmsDescription { get; set; } 

        [BsonElement("imagePath")]
        public string FilmImagePath { get; set; }
    }
}
