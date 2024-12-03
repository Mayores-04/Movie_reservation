using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace MovieMunch.Backend.Models
{
    public class ComingSoon
    {

        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("title")]
        public string ComingSoonTitle { get; set; }

        [BsonElement("price")]
        public double ComingSoonPrice { get; set; }

        [BsonElement("description")]
        public string ComingSoonDescription { get; set; }

        [BsonElement("imagePath")]
        public string ComingSoonImagePath { get; set; }


        [BsonElement("Day")]
        public string Day { get; set; }

        [BsonElement("StartTime")]
        public DateTime StartTime { get; set; }

        [BsonElement("EndTime")]
        public DateTime EndTime { get; set; }

    }
}
