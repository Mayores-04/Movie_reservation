using MovieMunch.Admin.Components;
using MovieMunch.Frontend.Forms;
using MovieMunch.Services;
using System;
using System.Windows.Forms;

namespace MovieMunch
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //LoadingForm loadingForm = new LoadingForm();
            //Application.Run(loadingForm);

            //MainAdminForm mainAdminForm = new MainAdminForm();
            //Application.Run(mainAdminForm);

            //FilmsInCinemaForm filmsInCinema = new FilmsInCinemaForm();
            //Application.Run(filmsInCinema);

            //Seat Reservation
            //var dbConnection = new MongoDBConnection();
            //var seatReservationService = new SeatReservationServices(dbConnection);

            //var seatReservationForm = new SeatReservation(seatReservationService);
            //Application.Run(seatReservationForm);

            PaymentForm paymentForm = new PaymentForm();
            Application.Run(paymentForm);
        }
    }
}
