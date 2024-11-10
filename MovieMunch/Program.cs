using MovieMunch.Admin;
using MovieMunch.Admin.FilmsInCinema;
using MovieMunch.Frontend.Forms;
using MovieMunch.Frontend.Forms.Components;
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

            LoadingForm loadingForm = new LoadingForm();
            Application.Run(loadingForm);

            //AnimateLoadingForm animateLoadingForm = new AnimateLoadingForm();
            //Application.Run(animateLoadingForm);

            //TicketForm ticketForm = new TicketForm();
            //Application.Run(ticketForm);

            //MainAdminForm mainAdminForm = new MainAdminForm();
            //Application.Run(mainAdminForm);

            ////Seat Reservation
            //var dbConnection = new MongoDBConnection();
            //var seatReservationService = new SeatReservationServices(dbConnection);

            //var seatReservationForm = new SeatReservation(seatReservationService);
            //Application.Run(seatReservationForm);

            //PaymentForm paymentForm = new PaymentForm(movieName, selectedSeats, moviePrice, reservedBy);
            //paymentForm.ShowDialog();
        }
    }
}
