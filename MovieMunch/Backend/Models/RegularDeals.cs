using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace MovieMunch.Backend.Models
{
    public class RegularDeals
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("FoodName")]
        public string FoodName { get; set; }

        [BsonElement("FoodPrice")]
        public decimal FoodPrice { get; set; }

        [BsonElement("FoodImagePath")]
        public string FoodImagePath { get; set; }
    }
}