using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


//Dito dumadaan yung mga data na papasok na user registered
public class Counts
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    [BsonElement("number_of_users")]
    public int number_of_users { get; set; } = 0; 
}