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

        [BsonElement("Price")]
        public decimal MoviePrice { get; set; }
    }

    public class MovieInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
    }
}
