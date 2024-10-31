using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch.Backend.Models;
using MovieMunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class MovieService
{
    private readonly IMongoCollection<FilmsInCinema> _filmsInCinema;
    private readonly IMongoCollection<Movie> _movies;
    private readonly IMongoCollection<ComingSoon> _comingSoon;

    public MovieService()
    {
        var dbConnection = new MongoDBConnection();
        _filmsInCinema = dbConnection.GetFilmsInCinemaCollection();
        _movies = dbConnection.GetMoviesCollection();
        _comingSoon = dbConnection.GetComingSoonCollection();
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

    public List<ComingSoon> GetComingSoons()
    {
        try
        {
            return _comingSoon.Find(csoon => true).ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching coming soon in cinema: {ex.Message}");
            return new List<ComingSoon>();
        }
    }

    public List<MovieInfo> GetAllMovieInfos()
    {
        try
        {
            var movies = _movies.Find(movie => true).Limit(4).ToList();
            // Map to a list of MovieInfo with title and price
            return movies.Select(movie => new MovieInfo
            {
                Title = movie.MovieTitle,        
                ImagePath = movie.MovieImagePath, 
                Price = movie.MoviePrice           
            }).ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching movies: {ex.Message}");
            return new List<MovieInfo>();
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

    public bool DeleteFilmById(ObjectId filmId)
    {
        try
        {
            var filter = Builders<FilmsInCinema>.Filter.Eq(f => f.Id, filmId);
            var result = _filmsInCinema.DeleteOne(filter);
            return result.DeletedCount > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting film: {ex.Message}");
            return false;
        }
    }

    public FilmsInCinema GetFilmById(ObjectId id)
    {
        try
        {
            return _filmsInCinema.Find(film => film.Id == id).FirstOrDefault();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching film by ID: {ex.Message}");
            return null;
        }
    }
}
