using MongoDB.Driver;
using MovieMunch.Backend.Models;
using MovieMunch.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieMunch.Services
{
    public class SeatReservationServices
    {
        private readonly IMongoCollection<CinemaSeats> _cinemaSeats;
        private readonly IMongoCollection<FilmsInCinema> _filmsInCinemaCollection;
        private readonly IMongoCollection<ComingSoon> _comingSoonCollection;
        private readonly IMongoCollection<Movie> _movieCollection;  // Added the Movie collection

        public SeatReservationServices(MongoDBConnection dbConnection)
        {
            _cinemaSeats = dbConnection.Database.GetCollection<CinemaSeats>("CinemaSeats");
            _filmsInCinemaCollection = dbConnection.Database.GetCollection<FilmsInCinema>("FilmsInCinema");
            _comingSoonCollection = dbConnection.Database.GetCollection<ComingSoon>("ComingSoon");
            _movieCollection = dbConnection.Database.GetCollection<Movie>("Movies");  // Initialize the Movie collection
        }

        public async Task ReserveSeatsAsync(string movieName, double moviePrice, List<string> seatNumbers, string reservedBy)
        {
            var reservation = new CinemaSeats
            {
                MovieName = movieName,
                MoviePrice = moviePrice,
                SeatNumbers = seatNumbers,
                ReservedBy = reservedBy,
                IsReserved = true
            };

            await _cinemaSeats.InsertOneAsync(reservation);
        }

        public async Task<List<CinemaSeats>> CheckSeatStatusAsync(string movieName)
        {
            return await _cinemaSeats.Find(seat => seat.MovieName == movieName).ToListAsync();
        }

        public async Task InitializeSeatsAsync(string movieName, double moviePrice, List<string> seatNumbers)
        {
            var existingSeats = await _cinemaSeats.Find(seat => seat.MovieName == movieName).FirstOrDefaultAsync();

            if (existingSeats == null)
            {
                var defaultSeats = new CinemaSeats
                {
                    MovieName = movieName,
                    MoviePrice = moviePrice,
                    SeatNumbers = seatNumbers,
                    ReservedBy = null,
                    IsReserved = false
                };

                await _cinemaSeats.InsertOneAsync(defaultSeats);
            }
        }

        public async Task<string> GetMovieImagePathAsync(string movieTitle)
        {
            // Check the FilmsInCinema collection first
            var filmInCinema = await _filmsInCinemaCollection
                .Find(film => film.FilmTitle == movieTitle)
                .FirstOrDefaultAsync();

            if (filmInCinema != null)
            {
                return filmInCinema.FilmImagePath;
            }

            // If not found in FilmsInCinema, check the ComingSoon collection
            var comingSoonMovie = await _comingSoonCollection
                .Find(m => m.ComingSoonTitle == movieTitle)
                .FirstOrDefaultAsync();

            if (comingSoonMovie != null)
            {
                return comingSoonMovie.ComingSoonImagePath;
            }

            // If not found in ComingSoon, check the Movie collection
            var movie = await _movieCollection
                .Find(m => m.MovieTitle == movieTitle)
                .FirstOrDefaultAsync();

            if (movie != null)
            {
                return movie.MovieImagePath; // Assuming the 'ImagePath' field exists in your Movie model
            }

            // If no image is found in any collection, return a default image path
            return "/path/to/default/movie/image.png";  // Update with your default image path
        }
    }
}
