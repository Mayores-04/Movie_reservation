using MongoDB.Driver;
using MovieMunch.Models;
using System.Collections.Generic;
using System;
using MovieMunch.Backend.Models;

public class MovieService
{
    private readonly IMongoCollection<Movie> _movies;
    private readonly IMongoCollection<FilmsInCinema> _filmsInCinema;
    // Constructor to initialize the MongoDB collection
    public MovieService()
    {
        var dbConnection = new MongoDBConnection();
        _movies = dbConnection.GetMoviesCollection();
        _filmsInCinema = dbConnection.GetFilmsInCinemaCollection();
    }

    // Method to get all movies from MongoDB
    public List<Movie> GetAllMovies()
    {
        try
        {
            // Fetch all movies, limiting to a maximum of 7
            return _movies.Find(movie => true).Limit(4).ToList(); 
        }
        catch (Exception ex)
        {
            // Handle any errors that might occur during the database call
            Console.WriteLine($"Error fetching movies: {ex.Message}");
            return new List<Movie>(); // Return an empty list in case of error
        }
    }

    public List<FilmsInCinema> GetFilmsInCinemas()
    {
        try
        {
            return _filmsInCinema.Find(movies => true).Limit(8).ToList();
        } catch(Exception jik)
        {
            return new List<FilmsInCinema>();
        }
    }

}
