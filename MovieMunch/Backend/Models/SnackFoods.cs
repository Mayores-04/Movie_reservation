using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace MovieMunch.Backend.Models
{
    public class SnackDeals
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("SFoodName")]
        public string SFoodName { get; set; }

        [BsonElement("SFoodPrice")]
        public decimal SFoodPrice { get; set; }

        [BsonElement("SFoodImagePath")]
        public string SFoodImagePath { get; set; }
    }
}