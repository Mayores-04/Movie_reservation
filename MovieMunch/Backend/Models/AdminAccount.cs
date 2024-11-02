using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

public class AdminAccount
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId Id { get; set; }

    [BsonElement("Name")]
    public string employeeName { get; set; }

    [BsonElement("email")]
    public string employeeEmail { get; set; }

    [BsonElement("password")]
    public string employeePassword { get; set; }

    [BsonElement("Profile Picture")]
    public string employeeProfilePic { get; set; }

    [BsonElement("createdAt")]
    public DateTime CreatedAt { get; set; }
}
