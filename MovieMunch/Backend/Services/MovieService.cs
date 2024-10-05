using MongoDB.Driver;
using MovieMunch.Models;
using System.Collections.Generic;
using System;


public class MovieService
{
    private readonly IMongoCollection<Movie> _movies;

    public MovieService()
    {
        var dbConnection = new MongoDBConnection();
        _movies = dbConnection.GetMoviesCollection();
    }

    
}

