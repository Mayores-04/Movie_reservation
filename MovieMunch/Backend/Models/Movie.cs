using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MovieMunch.Models
{
    public class Movie
    {

        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("title")]
        public string MovieTitle { get; set; }

        [BsonElement("description")]
        public string MovieDescription { get; set; }

        [BsonElement("imagePath")]
        public string MovieImagePath { get; set; }

        [BsonElement("Price")]
        public double MoviePrice { get; set; }
    }

    public class MovieInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
    }
}
