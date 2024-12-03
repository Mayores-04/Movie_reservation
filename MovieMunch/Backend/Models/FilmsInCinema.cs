using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

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


        [BsonElement("Day")]
        public string Day { get; set; }

        [BsonElement("StartTime")]
        public DateTime StartTime { get; set; }

        [BsonElement("EndTime")]
        public DateTime EndTime { get; set; }

    }
}
