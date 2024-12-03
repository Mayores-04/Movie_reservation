using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
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
        public string MovieImagePath { get; set; }

        [BsonElement("Price")]
        public double MoviePrice { get; set; }

        [BsonElement("Day")]
        public string Day { get; set; }

        [BsonElement("StartTime")]
        public DateTime StartTime { get; set; }

        [BsonElement("EndTime")]
        public DateTime EndTime { get; set; }


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
        public string ImagePath { get; set; }

        [BsonElement("Price")]
        public decimal Price { get; set; }
        public string Day { get; internal set; }
        public DateTime StartTime { get; internal set; }
        public DateTime EndTime { get; internal set; }
    }
}
