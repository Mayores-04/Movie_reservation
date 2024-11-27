using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("email")]
    public string Email { get; set; }

    [BsonElement("password")]
    public string Password { get; set; }

    [BsonElement("confirmPassword")]
    public string ConfirmPassword { get; set; }

    [BsonElement("createdAt")]
    public DateTime CreatedAt { get; set; }

    [BsonElement("Status")]
    public string Status { get; set; }

    [BsonElement("watchLater")]
    public List<MovieDetails> WatchLater { get; set; } = new List<MovieDetails>();
    public List<TicketDetails> TicketList { get; set; } = new List<TicketDetails>();
}

public class MovieDetails
{
    [BsonElement("movieTitle")]
    public string MovieTitle { get; set; }

    [BsonElement("movieDescription")]
    public string MovieDescription { get; set; }

    [BsonElement("moviePrice")]
    public decimal MoviePrice { get; set; }

    [BsonElement("moviePic")]
    public string MoviePic { get; set; } 
}

public class TicketDetails
{
    [BsonElement("movieId")]
    public string MovieId { get; set; }

    [BsonElement("userName")]
    public string UserName { get; set; }

    [BsonElement("movieTitle")]
    public string MovieTitle { get; set; }

    [BsonElement("moviePrice")]
    public decimal MoviePrice { get; set; }

    [BsonElement("seatTicketMapping")]
    public Dictionary<string, string> SeatTicketMapping { get; set; } = new Dictionary<string, string>();

    [BsonElement("datePurchased")]
    public DateTime DatePurchased { get; set; }
}
