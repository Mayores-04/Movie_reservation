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
            var dbConnection = new MongoDBConnection();
            var seatReservationService = new SeatReservationServices(dbConnection);

            // Pass the service to the SeatReservation form
            var seatReservationForm = new SeatReservation(seatReservationService);
            Application.Run(seatReservationForm);
        }
    }
}
