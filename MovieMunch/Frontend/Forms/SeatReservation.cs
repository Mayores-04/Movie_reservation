using Guna.UI2.WinForms;
using MovieMunch.Frontend.Forms;
using MovieMunch.Models;
using MovieMunch.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
             
            _allSeats = new List<string>();
            for (int i = 1; i <= 24; i++)
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
                if (control is Guna2Button btn && btn.FillColor == Color.Yellow)
                {
                    selectedSeats.Add(btn.Name);
                }
            }

            if (selectedSeats.Count > 0)
            { 
                decimal totalPrice = moviePrice * selectedSeats.Count;
                 
                PaymentForm paymentForm = new PaymentForm(movieName, totalPrice, selectedSeats, reservedBy);
                paymentForm.ShowDialog();

                if (paymentForm.IsPaymentSuccessful)
                { 
                    await _seatReservationService.ReserveSeatsAsync(movieName, (double)totalPrice, selectedSeats, reservedBy);
                    MessageBox.Show("Seats reserved successfully!");
                     
                    foreach (string seat in selectedSeats)
                    {
                        if (this.Controls[seat] is Guna2Button seatButton)
                        {
                            seatButton.FillColor = Color.FromArgb(199, 44, 65);
                            seatButton.Refresh(); 
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
            await LoadSeatStatusAsync(_movieName); 

            foreach (var seat in _allSeats)
            {
                Control seatButton = this.Controls.Find(seat, true).FirstOrDefault();

                if (seatButton is Guna2Button btn)
                {
                    if (btn.FillColor != Color.FromArgb(199, 44, 65)) 
                    {
                        btn.FillColor = Color.White;
                    }

                    btn.Click += SeatButton_Click;
                    btn.Refresh();
                }
                else
                {
                    MessageBox.Show($"Button {seat} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        Control seatButton = this.Controls.Find(seatNumber, true).FirstOrDefault();

                        if (seatButton is Guna2Button btn)
                        {
                            btn.FillColor = reservation.IsReserved ? Color.FromArgb(199, 44, 65) : Color.White;
                        }
                    }
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button seatButton)
            {
                // Toggle colors between selected (Yellow) and unselected (White)
                if (seatButton.FillColor == Color.White)
                {
                    seatButton.FillColor = Color.Yellow;
                }
                else if (seatButton.FillColor == Color.Yellow)
                {
                    seatButton.FillColor = Color.White;
                }
            }
        }
    }
}
