using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch.Backend.Models;
using MovieMunch.Models;
using System;
using System.Collections.Generic;

public class MovieService
{
    private readonly IMongoCollection<FilmsInCinema> _filmsInCinema;
    private readonly IMongoCollection<Movie> _movies; 

    public MovieService()
    {
        var dbConnection = new MongoDBConnection();
        _filmsInCinema = dbConnection.GetFilmsInCinemaCollection();
        _movies = dbConnection.GetMoviesCollection(); 
    }

    public List<FilmsInCinema> GetFilmsInCinemas()
    {
        try
        {
            return _filmsInCinema.Find(film => true).ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching films in cinema: {ex.Message}");
            return new List<FilmsInCinema>();
        }
    }

    public List<Movie> GetAllMovies()
    {
        try
        {
            return _movies.Find(movie => true).Limit(4).ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching movies: {ex.Message}");
            return new List<Movie>();
        }
    }

    public void AddFilm(FilmsInCinema film)
    {
        try
        {
            _filmsInCinema.InsertOne(film);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding film: {ex.Message}");
        }
    }

    public void UpdateFilm(FilmsInCinema film)
    {
        try
        {
            var filter = Builders<FilmsInCinema>.Filter.Eq(f => f.Id, film.Id);
            var result = _filmsInCinema.ReplaceOne(filter, film);

            if (result.ModifiedCount == 0)
            {
                Console.WriteLine("No film found with the given ID, so no update was made.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating film: {ex.Message}");
        }
    }
    public bool DeleteFilm(FilmsInCinema film)
    {
        try
        {
            var filter = Builders<FilmsInCinema>.Filter.Eq(f => f.Id, film.Id);

            var result = _filmsInCinema.DeleteOne(filter);

            return result.DeletedCount > 0; 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting film: {ex.Message}");
            return false;
        }
    }
}
