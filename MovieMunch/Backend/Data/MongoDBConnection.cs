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

        // Ensure essential collections exist
        EnsureCollectionExists<FilmsInCinema>("FilmsInCinema");
        EnsureCollectionExists<ComingSoon>("ComingSoon");
        EnsureCollectionExists<Movie>("Movies");
        EnsureCollectionExists<User>("Users");
        EnsureCollectionExists<AdminAccount>("AdminAccounts");
        EnsureCollectionExists<Foods>("Foods");
        EnsureCollectionExists<Counts>("number_of_users");
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

    public IMongoCollection<Foods> GetFoodsCollection()
    {
        return _database.GetCollection<Foods>("Foods");
    }

    public IMongoDatabase Database => _database;
}
