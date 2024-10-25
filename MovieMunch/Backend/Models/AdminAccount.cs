using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;


public class AdminAccount
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("email")]
    public string Email { get; set; }

    [BsonElement("password")]
    public string Password { get; set; }

    [BsonElement("createdAt")]
    public DateTime CreatedAt { get; set; }
}
