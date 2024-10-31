using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MovieMunch.Backend.Models
{
    public class ComingSoon
    {

        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("title")]
        public string FilmTitle { get; set; }

        [BsonElement("description")]
        public string FilmsDescription { get; set; }

        [BsonElement("imagePath")]
        public string FilmImagePath { get; set; }
    }
}
