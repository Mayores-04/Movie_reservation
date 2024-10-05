using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;


//Dito dumadaan yung mga data na papasok at lalabas from database collections
public class User 
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
