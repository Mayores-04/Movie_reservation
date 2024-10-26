using MongoDB.Driver;
using MovieMunch.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieMunch.Services
{
    public class SeatReservationServices
    {
        private readonly IMongoCollection<CinemaSeats> _cinemaSeats;

        public SeatReservationServices(MongoDBConnection dbConnection)
        {
            _cinemaSeats = dbConnection.Database.GetCollection<CinemaSeats>("CinemaSeats");
        }

        public async Task ReserveSeatsAsync(string movieName, List<string> seatNumbers, string reservedBy)
        {
            var reservation = new CinemaSeats
            {
                MovieName = movieName,
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

        public async Task InitializeSeatsAsync(string movieName, List<string> seatNumbers)
        {
            var existingSeats = await _cinemaSeats.Find(seat => seat.MovieName == movieName).FirstOrDefaultAsync();

            if (existingSeats == null)
            {
                var defaultSeats = new CinemaSeats
                {
                    MovieName = movieName,
                    SeatNumbers = seatNumbers,
                    ReservedBy = null,
                    IsReserved = false
                };

                await _cinemaSeats.InsertOneAsync(defaultSeats);
            }
        }

    }
}
