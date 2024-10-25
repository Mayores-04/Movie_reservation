using MongoDB.Driver;
using MovieMunch.Backend.Models;
using MovieMunch.Models;

public class MongoDBConnection
{
    private readonly IMongoDatabase _database;  // Private field to store the database connection.

    public MongoDBConnection()
    {
        var client = new MongoClient("mongodb://localhost:27017/"); //mongodb://localhost:27017/ ito yung mongoDB string, link sya ng server sa database

        _database = client.GetDatabase("MovieReservationDB");  //MovieReservationDB the Name of the database.
    }

    public IMongoCollection<User> GetUsersCollection()
    {
        return _database.GetCollection<User>("Users");  // Returns the Users collection. Users is yung collection sa database na MovieReservationDB.
    }
    public IMongoCollection<Counts> GetNumberOfUsersCollection()
    {
        return _database.GetCollection<Counts>("number_of_users"); // Collection for counting the number of users.
    }

    public IMongoCollection<Movie> GetMoviesCollection()
    {
        return _database.GetCollection<Movie>("Movies"); //Collection for Movies 
    }

    public IMongoCollection<AdminAccount> GetAdminAccountsCollection()
    {
        return _database.GetCollection<AdminAccount>("AdminAccounts");
    }

    public IMongoCollection<FilmsInCinema> GetFilmsInCinemaCollection()
    {
        return _database.GetCollection<FilmsInCinema>("FilmsInCinema");
    }
}
