using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch.Admin;
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



    public List<Movie> GetAllMovies()
    {
        try
        {
            return _movies.Find(movies => true).ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching coming soon in cinema: {ex.Message}");
            return new List<Movie>();
        }
    }


    public List<MovieInfo> GetAllMovieInfos()
    {
        try
        {
            var movies = _movies.Find(movie => true).Limit(4).ToList();

            return movies.Select(movie => new MovieInfo
            {
                Title = movie.MovieTitle,        
                ImagePath = movie.MovieImagePath, 
                Description = movie.MovieDescription,
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

    public void AddMovies(Movie movies)
    {
        try
        {
            _movies.InsertOne(movies);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void AddComingSoon(ComingSoon film)
    {
        try
        {
            _comingSoon.InsertOne(film);
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

    public void UpdateMovies(Movie movie)
    {
        try
        {
            var filter = Builders<Movie>.Filter.Eq(f => f.Id, movie.Id);
            var result = _movies.ReplaceOne(filter, movie);

            if (result.ModifiedCount == 0)
            {
                Console.WriteLine("No movie found with the given ID, so no update was made.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating movie: {ex.Message}");
        }
    }


    public bool UpdateComingSoon(ComingSoon movie)
    {
        try
        {
            var filter = Builders<ComingSoon>.Filter.Eq(m => m.Id, movie.Id);
            var result = _comingSoon.ReplaceOne(filter, movie);

            return result.ModifiedCount > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating movie: {ex.Message}");
            return false;
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

    public bool DeleteMovieByID(ObjectId movieID)
    {
        try
        {
            var filter = Builders<Movie>.Filter.Eq(f => f.Id, movieID);
            var result = _movies.DeleteOne(filter);
            return result.DeletedCount > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting movie: {ex.Message}");
            return false;
        }
    }

    public bool DeleteComingSoonByID(ObjectId csoonId)
    {
        try
        {
            var filter = Builders<ComingSoon>.Filter.Eq(f => f.Id, csoonId);
            var result = _comingSoon.DeleteOne(filter);
            return result.DeletedCount > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting coming soon movie: {ex.Message}");
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

    public Movie GetMovieById(ObjectId id)
    {
        try
        {
            return _movies.Find(movie => movie.Id == id).FirstOrDefault();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching movie by ID: {ex.Message}");
            return null;
        }
    }


    public ComingSoon GetComingSoonById(ObjectId id)
    {
        try
        {
            return _comingSoon.Find(movie => movie.Id == id).FirstOrDefault();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching movie by ID: {ex.Message}");
            return null;
        }
    }


}
