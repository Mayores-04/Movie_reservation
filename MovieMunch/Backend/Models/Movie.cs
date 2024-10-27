using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MovieMunch.Models
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("title")]
        public string MovieTitle { get; set; }

        [BsonElement("description")]
        public string MovieDescription { get; set; }

        [BsonElement("imagePath")]
        public string MovieImagePath { get; set; }
    }
}
