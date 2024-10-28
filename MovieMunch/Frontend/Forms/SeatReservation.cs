﻿using MovieMunch.Services;
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
        private string txtMovieName = "Spiderman";
        private string txtReservedBy = "Jake";

        public SeatReservation(SeatReservationServices seatReservationService)
        {
            InitializeComponent();
            _seatReservationService = seatReservationService;

            _allSeats = new List<string>();
            for (int i = 1; i <= 10; i++) 
            {
                for (char j = 'A'; j <= 'J'; j++)
                {
                    _allSeats.Add($"{j}{i}"); // Adds seats as "A1", "B2", etc.
                }
            }

            this.Load += SeatReservation_Load;
        }



        private async void SeatReservation_Load(object sender, EventArgs e)
        {
            string movieName = txtMovieName;

            await _seatReservationService.InitializeSeatsAsync(movieName, _allSeats);
            await LoadSeatStatusAsync(movieName);

            // Loop through the controls to find buttons
            foreach (var seat in _allSeats)
            {
                // Check if the control is a BunifuButton by its name
                Control seatButton = this.Controls.Find(seat, true).FirstOrDefault();

                if (seatButton is Bunifu.UI.WinForms.BunifuButton.BunifuButton btn)
                {
                    btn.Click += SeatButton_Click;
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
                // Toggle between Green and Red colors for selected/unselected states
                if (seatButton.BackColor == Color.Green)
                {
                    seatButton.BackColor = Color.Red; // Selected
                }
                else if (seatButton.BackColor == Color.Red)
                {
                    seatButton.BackColor = Color.Green; // Unselected
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
                        // Use Controls.Find to ensure you find the button correctly
                        Control seatButton = this.Controls.Find(seatNumber, true).FirstOrDefault();

                        if (seatButton is Bunifu.UI.WinForms.BunifuButton.BunifuButton btn)
                        {
                            btn.BackColor = reservation.IsReserved ? Color.Gray : Color.Green; // Set color based on status
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
                if (control is Bunifu.UI.WinForms.BunifuButton.BunifuButton btn && btn.BackColor == Color.Red) 
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
