using MovieMunch.Frontend.Forms;
using MovieMunch.Models;
using MovieMunch.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class SeatReservation : Form
    {
        private readonly SeatReservationServices _seatReservationService;
        private List<string> _allSeats;

        private string _movieName;
        private string _reservedBy;
        private decimal _moviePrice;
        private List<string> _reservedSeats;

        public SeatReservation(string movieTitle, decimal moviePrice, string reservedBy)
        {
            InitializeComponent();

            _movieName = movieTitle;
            _moviePrice = moviePrice;
            _reservedBy = reservedBy;

            var dbConnection = new MongoDBConnection();
            _seatReservationService = new SeatReservationServices(dbConnection);

            // Generate seats as "A1", "B2", etc.
            _allSeats = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                for (char j = 'A'; j <= 'J'; j++)
                {
                    _allSeats.Add($"{j}{i}");
                }
            }

            this.Load += SeatReservation_Load;
        }

        private async void btnReserveSeat_Click(object sender, EventArgs e)
        {
            string movieName = _movieName;
            decimal moviePrice = _moviePrice;
            string reservedBy = _reservedBy;

            List<string> selectedSeats = new List<string>();
            foreach (Control control in this.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuButton.BunifuButton btn && btn.OnIdleState.FillColor == Color.Yellow)
                {
                    selectedSeats.Add(btn.Name);
                }
            }

            if (selectedSeats.Count > 0)
            {
                // Calculate the total price
                decimal totalPrice = moviePrice * selectedSeats.Count;

                // Pass the calculated total price to the payment form
                PaymentForm paymentForm = new PaymentForm(movieName, totalPrice, selectedSeats, reservedBy);
                paymentForm.ShowDialog();

                if (paymentForm.IsPaymentSuccessful)
                {
                    // Save the reservation with the total price in the database
                    await _seatReservationService.ReserveSeatsAsync(movieName, (double)totalPrice, selectedSeats, reservedBy);
                    MessageBox.Show("Seats reserved successfully!");

                    // Change the button color for reserved seats
                    foreach (string seat in selectedSeats)
                    {
                        if (this.Controls[seat] is Bunifu.UI.WinForms.BunifuButton.BunifuButton seatButton)
                        {
                            seatButton.OnIdleState.FillColor = Color.Red;
                            seatButton.OnPressedState.FillColor = Color.Red;
                            seatButton.onHoverState.FillColor = Color.Red;
                            seatButton.Refresh(); // Apply changes immediately
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Payment was not successful. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("No seats selected.");
            }
        }

        private async void SeatReservation_Load(object sender, EventArgs e)
        {
            // Load existing seat status directly
            await LoadSeatStatusAsync(_movieName); // Load current seat status from the database

            // Setup buttons for all seats
            foreach (var seat in _allSeats)
            {
                Control seatButton = this.Controls.Find(seat, true).FirstOrDefault();

                if (seatButton is Bunifu.UI.WinForms.BunifuButton.BunifuButton btn)
                {
                    // Initial fill color setup for each seat, if it's not reserved
                    if (btn.OnIdleState.FillColor != Color.Red) // Only reset if not reserved
                    {
                        btn.OnIdleState.FillColor = Color.White;
                    }

                    btn.Click += SeatButton_Click; // Add event handler
                    btn.Refresh();
                }
                else
                {
                    MessageBox.Show($"Button {seat} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is Bunifu.UI.WinForms.BunifuButton.BunifuButton seatButton)
            {
                // Toggle colors between selected (Red) and unselected (Green)
                if (seatButton.OnIdleState.FillColor == Color.White)
                {
                    seatButton.OnIdleState.FillColor = Color.Yellow;
                    seatButton.OnPressedState.FillColor = Color.Yellow;
                    seatButton.onHoverState.FillColor = Color.Yellow;
                }
                else if (seatButton.OnIdleState.FillColor == Color.Yellow)
                {
                    seatButton.OnIdleState.FillColor = Color.White;
                    seatButton.OnPressedState.FillColor = Color.White;
                    seatButton.onHoverState.FillColor = Color.White;
                }
            }
        }

        private async Task LoadSeatStatusAsync(string movieName)
        {
            var reservedSeats = await _seatReservationService.CheckSeatStatusAsync(movieName);

            if (reservedSeats != null)
            {
                foreach (var reservation in reservedSeats)
                {
                    foreach (string seatNumber in reservation.SeatNumbers)
                    {
                        // Use Controls.Find to ensure you find the button correctly
                        Control seatButton = this.Controls.Find(seatNumber, true).FirstOrDefault();

                        if (seatButton is Bunifu.UI.WinForms.BunifuButton.BunifuButton btn)
                        {
                            btn.OnIdleState.FillColor = reservation.IsReserved ? Color.Red : Color.White; // Set color based on status
                        }
                    }
                }
            }
        }
    }
}
