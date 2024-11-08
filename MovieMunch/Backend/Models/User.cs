using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;


//Dito dumadaan yung mga data na papasok at lalabas from database collections
public class User 
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("age")]
    public int Age { get; set; }

    [BsonElement("phoneNumber")]
    public long PhoneNumber { get; set; }

    [BsonElement("email")]
    public string Email { get; set; }

    [BsonElement("password")]
    public string Password { get; set; }

    [BsonElement("confirmPassword")]
    public string ConfirmPassword { get; set; }

    [BsonElement("Status")]
    public string Status { get; set; }

    [BsonElement("createdAt")]
    public DateTime CreatedAt { get; set; }
}
