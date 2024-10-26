using MovieMunch.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class SeatReservation : Form
    {
        private readonly SeatReservationServices _seatReservationService;
        private List<string> _allSeats;
        private string txtMovieName = "Spiderman";
        private string txtReservedBy = "Jake";

        public SeatReservation(SeatReservationServices seatReservationService)
        {
            InitializeComponent();
            _seatReservationService = seatReservationService;

            // Define all seats here
            _allSeats = new List<string>();
            for (int i = 1; i <= 10; i++) // Assuming 10 rows and 10 columns
            {
                for (char j = 'A'; j <= 'J'; j++)
                {
                    _allSeats.Add($"btnSeat{j}{i}");
                }
            }

            this.Load += SeatReservation_Load;
        }


        private async void SeatReservation_Load(object sender, EventArgs e)
        {
            string movieName = txtMovieName; 

            await _seatReservationService.InitializeSeatsAsync(movieName, _allSeats);

            await LoadSeatStatusAsync(movieName);

            foreach (var seat in _allSeats)
            {
                if (this.Controls.ContainsKey(seat))
                {
                    this.Controls[seat].Click += SeatButton_Click;
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is Bunifu.UI.WinForms.BunifuButton.BunifuButton seatButton)
            {
                if (seatButton.BackColor == Color.Green) 
                {
                    seatButton.BackColor = Color.Red;
                }
                else if (seatButton.BackColor == Color.Red)
                {
                    seatButton.BackColor = Color.Green;
                }
            }
            else
            {
                MessageBox.Show("Error: Seat button could not be identified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (this.Controls.ContainsKey(seatNumber))
                        {
                            this.Controls[seatNumber].BackColor = reservation.IsReserved ? Color.Gray : Color.Green;
                        }
                    }
                }
            }
        }

        private async void btnReserveSeat_Click(object sender, EventArgs e)
        {
            string movieName = txtMovieName;
            string reservedBy = txtReservedBy;

            List<string> selectedSeats = new List<string>();
            foreach (Control control in this.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuButton.BunifuButton btn && btn.BackColor == Color.Red) // Collect selected seats
                {
                    selectedSeats.Add(btn.Name);
                }
            }

            if (selectedSeats.Count > 0)
            {
                await _seatReservationService.ReserveSeatsAsync(movieName, selectedSeats, reservedBy);
                MessageBox.Show("Seats reserved successfully!");

                foreach (string seat in selectedSeats)
                {
                    if (this.Controls[seat] is Bunifu.UI.WinForms.BunifuButton.BunifuButton seatButton)
                    {
                        seatButton.BackColor = Color.Gray; 
                    }
                }
            }
            else
            {
                MessageBox.Show("No seats selected.");
            }
        }
    }
}
