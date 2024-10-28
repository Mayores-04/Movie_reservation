using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


public class Counts
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("number_of_users")]
    public int number_of_users { get; set; } = 0; 
}