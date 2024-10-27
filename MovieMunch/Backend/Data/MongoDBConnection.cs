using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch.Backend.Models;
using MovieMunch.Models;
using System.Threading.Tasks;

public class MongoDBConnection
{
    private readonly IMongoDatabase _database; 

    public MongoDBConnection()
    {
        var client = new MongoClient("mongodb://localhost:27017/"); 

        _database = client.GetDatabase("MovieReservationDB");

        CreateCollectionIfNotExists<FilmsInCinema>("FilmsInCinema");
    }

    private void CreateCollectionIfNotExists<T>(string collectionName)
    {
        var collectionNames = _database.ListCollectionNames().ToList();
        if (!collectionNames.Contains(collectionName))
        {
            _database.CreateCollection(collectionName);
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

    public IMongoDatabase Database => _database;
}
