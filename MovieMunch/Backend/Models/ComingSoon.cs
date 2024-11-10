﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

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
    }
}
