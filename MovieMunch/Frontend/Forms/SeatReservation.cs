﻿using Guna.UI2.WinForms;
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

        private List<string> _selectedSeats;

        public SeatReservation(string movieTitle, decimal moviePrice, string reservedBy)
        {
            InitializeComponent();

            _movieName = movieTitle;
            _moviePrice = moviePrice;
            _reservedBy = reservedBy;

            var dbConnection = new MongoDBConnection();
            _seatReservationService = new SeatReservationServices(dbConnection);

            _selectedSeats = new List<string>();

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

        private async void SeatReservation_Load(object sender, EventArgs e)
        {
            await LoadSeatStatusAsync(_movieName);
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
                            btn.Refresh(); 
                        }
                    }
                }
            }
        }


        private async void btnReserveSeat_Click(object sender, EventArgs e)
        {
            if (_selectedSeats.Count > 0)
            {
                decimal totalPrice = _moviePrice * _selectedSeats.Count;

                PaymentForm paymentForm = new PaymentForm(_movieName, totalPrice, _selectedSeats, _reservedBy);
                paymentForm.ShowDialog();

                if (paymentForm.IsPaymentSuccessful)
                {
                    await _seatReservationService.ReserveSeatsAsync(_movieName, (double)totalPrice, _selectedSeats, _reservedBy);
                    MessageBox.Show("Seats reserved successfully!");

                    foreach (string seat in _selectedSeats)
                    {
                        if (this.Controls[seat] is Guna2Button seatButton)
                        {
                            seatButton.FillColor = Color.FromArgb(199, 44, 65); 
                            seatButton.Refresh(); 
                        }
                    }

                    await LoadSeatStatusAsync(_movieName);

                    _selectedSeats.Clear();
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


        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button seatButton)
            {
                if (seatButton.FillColor == Color.White || seatButton.FillColor == Color.Yellow)
                {
                    if (!_selectedSeats.Contains(seatButton.Name))
                    {
                        seatButton.FillColor = Color.Yellow; 
                        _selectedSeats.Add(seatButton.Name); 
                    }
                    else
                    {
                        seatButton.FillColor = Color.White;
                        _selectedSeats.Remove(seatButton.Name);
                    }

                    seatButton.Refresh();
                }
            }
        }
    }
}
