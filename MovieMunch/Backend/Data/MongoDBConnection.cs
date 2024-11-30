using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch.Backend.Models;
using MovieMunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class MongoDBConnection
{
    private readonly IMongoDatabase _database;

    public MongoDBConnection()
    {
        var client = new MongoClient("mongodb://localhost:27017/");
        _database = client.GetDatabase("MovieReservationDB");

        EnsureCollectionExists<FilmsInCinema>("FilmsInCinema");
        EnsureCollectionExists<ComingSoon>("ComingSoon");
        EnsureCollectionExists<Movie>("Movies");
        EnsureCollectionExists<User>("Users");
        EnsureCollectionExists<AdminAccount>("AdminAccounts");
        EnsureCollectionExists<RegularDeals>("RegularDeals");
        EnsureCollectionExists<SnackDeals>("SnackDeals");
        EnsureCollectionExists<Counts>("number_of_users"); 
        EnsureCollectionExists<Counts>("number_of_users"); 

    }
    public IMongoCollection<CinemaSeats> GetCinemaSeatCollection()
    {
        return _database.GetCollection<CinemaSeats>("CinemaSeats");
    }
    public IMongoCollection<BsonDocument> GetCinemaSeatsAsBsonCollection()
    {
        return _database.GetCollection<BsonDocument>("CinemaSeats");
    }

    private void EnsureCollectionExists<T>(string collectionName)
    {
        var collectionNames = _database.ListCollectionNames().ToList();
        if (!collectionNames.Contains(collectionName))
        {
            _database.CreateCollection(collectionName);
            Console.WriteLine($"Collection '{collectionName}' created.");
        }
    }

    public IMongoCollection<User> GetUsersCollection()
    {
        return _database.GetCollection<User>("Users");
    }


    public IMongoCollection<Counts> GetNumberOfUsersCollection()
    {
        return _database.GetCollection<Counts>("number_of_users");
    }

    public IMongoCollection<Movie> GetMoviesCollection()
    {
        return _database.GetCollection<Movie>("Movies");
    }

    public IMongoCollection<AdminAccount> GetAdminAccountsCollection()
    {
        return _database.GetCollection<AdminAccount>("AdminAccounts");
    }

    public IMongoCollection<FilmsInCinema> GetFilmsInCinemaCollection()
    {
        return _database.GetCollection<FilmsInCinema>("FilmsInCinema");
    }

    public IMongoCollection<ComingSoon> GetComingSoonCollection()
    {
        return _database.GetCollection<ComingSoon>("ComingSoon");
    }

    public IMongoCollection<RegularDeals> GetFoodsCollection()
    {
        return _database.GetCollection<RegularDeals>("RegularDeals");
    }


    public IMongoCollection<SnackDeals> GetSnackFoodsCollection()
    {
        return _database.GetCollection<SnackDeals>("SnackDeals");
    }


    public IMongoDatabase Database => _database;
}
