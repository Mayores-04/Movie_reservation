using MongoDB.Driver;
using MovieMunch.Backend.Models;
using MovieMunch.Models;
using System;
using System.Collections.Generic;

namespace CashierApplication.Backend.Services
{
    public class Reports
    {
        private readonly IMongoCollection<Counts> _countsCollection;
        private readonly IMongoCollection<User> _userCollection;
        private readonly IMongoCollection<CinemaSeats> _cinemaSeatsCollection;
        private readonly IMongoCollection<Sales> _salesCollection;

        public Reports()
        {
            var dbConnection = new MongoDBConnection();
            _countsCollection = dbConnection.GetNumberOfUsersCollection();
            _userCollection = dbConnection.GetUsersCollection();
            _cinemaSeatsCollection = dbConnection.GetCinemaSeatCollection();
            _salesCollection = dbConnection.GetSalesCollection();
        }
        public void UpdateMovieSales(string salesId)
        {
            var filter = Builders<Sales>.Filter.Eq(s => s.Id, salesId);

            var update = Builders<Sales>.Update.Set(s => s.MovieSales, GetTotalPriceOfAllMovies());

            _salesCollection.UpdateOne(filter, update);
        }


        public int GetUserCount()
        {
            var countDocument = _countsCollection.Find(Builders<Counts>.Filter.Empty).FirstOrDefault();

            if (countDocument == null)
            {
                var initialCount = new Counts { number_of_users = 0 };
                _countsCollection.InsertOne(initialCount);
                return 0;
            }

            return countDocument.number_of_users;
        }


        public Dictionary<string, decimal> GetMovieSales()
        {
            var users = _userCollection.Find(Builders<User>.Filter.Empty).ToList();

            var cinemaSeats = _cinemaSeatsCollection.Find(Builders<CinemaSeats>.Filter.Empty).ToList();

            var salesData = new Dictionary<string, decimal>();

            foreach (var user in users)
            {
                if (user.TicketList != null)
                {
                    foreach (var ticket in user.TicketList)
                    {
                        if (!salesData.ContainsKey(ticket.MovieTitle))
                        {
                            salesData[ticket.MovieTitle] = 0;
                        }

                        int numberOfTickets = ticket.SeatTicketMapping.Count;
                        decimal totalSalesForTicket = ticket.MoviePrice * numberOfTickets;

                        salesData[ticket.MovieTitle] += totalSalesForTicket;
                    }
                }
            }

            foreach (var cinemaSeat in cinemaSeats)
            {
                string movieTitle = cinemaSeat.MovieName;
                decimal moviePrice = (decimal)cinemaSeat.MoviePrice;
                int seatsSold = cinemaSeat.SeatNumbers.Count;

                if (!salesData.ContainsKey(movieTitle))
                {
                    salesData[movieTitle] = 0;
                }

                decimal totalSalesForCinemaSeat = moviePrice;
                    salesData[movieTitle] += totalSalesForCinemaSeat;
            }

            return salesData;
        }

        public decimal GetTotalPriceOfAllMovies()
        {
            var movieSales = GetMovieSales();

            decimal totalPrice = 0;

            foreach (var sale in movieSales)
            {
                totalPrice += sale.Value;
            }

            return totalPrice;
        }

        public Dictionary<string, int> GetReservedSeatsPerMovie()
        {
            var cinemaSeatsCollection = _cinemaSeatsCollection.Find(Builders<CinemaSeats>.Filter.Eq(c => c.IsReserved, true)).ToList();

            var reservedSeatsData = new Dictionary<string, int>();

            foreach (var cinemaSeat in cinemaSeatsCollection)
            {
                string movieTitle = cinemaSeat.MovieName;
                int reservedSeats = cinemaSeat.SeatNumbers.Count;

                if (!reservedSeatsData.ContainsKey(movieTitle))
                {
                    reservedSeatsData[movieTitle] = 0;
                }

                reservedSeatsData[movieTitle] += reservedSeats;
            }

            return reservedSeatsData;
        }

        public int GetTotalReservedSeats()
        {
            var cinemaSeatsCollection = _cinemaSeatsCollection.Find(Builders<CinemaSeats>.Filter.Eq(c => c.IsReserved, true)).ToList();

            int totalReservedSeats = 0;

            foreach (var cinemaSeat in cinemaSeatsCollection)
            {
                totalReservedSeats += cinemaSeat.SeatNumbers.Count;
            }

            return totalReservedSeats;
        }

    }
}
