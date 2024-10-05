using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


//Dito dumadaan yung mga data na papasok at lalabas from database collections
public class Counts
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    [BsonElement("number_of_users")]
    public int number_of_users { get; set; } = 0; // Initialize the count to 0.
}