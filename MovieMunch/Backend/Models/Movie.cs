using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Drawing;

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
        public string MovieImagePath { get; set; }  // Path to the image

        [BsonElement("Price")]
        public double MoviePrice { get; set; }
    }

    public class MovieInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("imagePath")]
        public string ImagePath { get; set; }  // Path to the image (not the Image object)

        [BsonElement("Price")]
        public decimal Price { get; set; }

         ////If you need to store the image in memory, you can use byte[] for MongoDB storage
         //[BsonElement("image")]
         //public byte[] Image { get; set; }  // Uncomment if you want to store the actual image data

        public Image Image { get; internal set; } // This property could be used in the UI (not stored in MongoDB)
    }
}
