﻿using MovieMunch.Frontend.Forms.Components;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using ZstdSharp.Unsafe;

namespace MovieMunch.Frontend.Forms
{
    public partial class PaymentForm : Form
    {
        private string _movieName;
        private List<string> _reservedSeats;
        private decimal _moviePrice;
        private string _reservedBy;
        private string _movieId;
        public bool IsPaymentSuccessful { get; private set; }

        public PaymentForm(string Id, string movieName, decimal moviePrice, List<string> reservedSeats,  string reservedBy)
        {
            InitializeComponent();
            _movieId = Id;
            _movieName = movieName;
            _reservedSeats = reservedSeats;
            _moviePrice = moviePrice;
            _reservedBy = reservedBy;
        }

        private List<string> _foodName;
        private List<int> _foodQuantity = new List<int>();
        private List<decimal> _foodPrice = new List<decimal>();

        public void GetOrderedRegularFoods(List<string> foodName, List<int> quantity, List<decimal> foodPrice)
        {
            _foodName = foodName;
            _foodQuantity = quantity;
            _foodPrice = foodPrice;
        }

        private List<string> _snackName;
        private List<int> _snackQuantity = new List<int>();
        private List<decimal> _snackPrice = new List<decimal>();

        public void GetOrderedSnacksFoods(List<string> snackName, List<int> quantity, List<decimal> snackPrice)
        {
            _snackName = snackName;
            _snackQuantity = quantity;
            _snackPrice = snackPrice;
        }

        public void clearText()
        {
            gcashPaypalUserNameInput.Text = null;
            gcashPaypalUserEmailInput.Text = null;
        }

        private void gcashBtn_Click(object sender, EventArgs e)
        {
            gcashPaymentBtn.Text = "Proceed to GCash payment";
            cardPaymentPanel.Visible = false;
            gcashPaypalPaymentPanel.Visible = true;
            clearText();
        }

        private void paypalBtn_Click_1(object sender, EventArgs e)
        {
            gcashPaymentBtn.Text = "Proceed to PayPal payment";
            gcashPaypalPaymentPanel.Visible = true;
            cardPaymentPanel.Visible = false;
            clearText();
        }

        private void gcashPaymentBtn_Click(object sender, EventArgs e)
        {
            decimal totalRegularFoodCost = 0;

            for (int i = 0; i < _foodQuantity.Count; i++)
            {
                totalRegularFoodCost += _foodQuantity[i] * _foodPrice[i];
            }

            decimal totalSnackFoodCost = 0;

            for (int i = 0; i < _snackQuantity.Count; i++)
            {
                totalSnackFoodCost += _snackQuantity[i] * _snackPrice[i];
            }

            decimal totalFoodCost = totalRegularFoodCost + totalSnackFoodCost;

            decimal totalAmount = (_moviePrice * _reservedSeats.Count) + totalFoodCost;

            //Gcash payment btn
            if (gcashPaymentBtn.Text == "Proceed to GCash payment")
            {
                string gcashName = gcashPaypalUserNameInput.Text;
                string gcashEmail = gcashPaypalUserEmailInput.Text;

                NameDetails.Text = _reservedBy;
                AccountName.Text = gcashName;
                MovietoReserveDetails.Text = _movieName;
                SeatsDetails.Text = string.Join(", ", _reservedSeats);
                PayWithDetails.Text = "GCash";

                var regpairs = new List<string>();
                for (int i = 0; i < _foodName.Count; i++)
                {
                    regpairs.Add($"{_foodName[i]} x {_foodQuantity[i]}");
                }
                regularFoodsLabel.Text = string.Join("\n", regpairs);

                var snackpairs = new List<string>();
                for (int i = 0; i < _snackName.Count; i++)
                {
                    snackpairs.Add($"{_snackName[i]} x {_snackQuantity[i]}");
                }
                snackFoodLabel.Text = string.Join("\n", snackpairs);

                totalPriceDetails.Text = totalAmount.ToString("C");

                gcashPaypalPaymentPanel.Visible = false;
                orderDetailsPanel.Visible = true;
            }

            //Paypal payment btn
            else if (gcashPaymentBtn.Text == "Proceed to PayPal payment")
            {
                string paypalName = gcashPaypalUserNameInput.Text;
                string paypalEmail = gcashPaypalUserEmailInput.Text;

                NameDetails.Text = _reservedBy;
                AccountName.Text = paypalName;
                MovietoReserveDetails.Text = _movieName;
                SeatsDetails.Text = string.Join(", ", _reservedSeats);
                PayWithDetails.Text = "PayPal";

                var regpairs = new List<string>();
                for (int i = 0; i < _foodName.Count; i++)
                {
                    regpairs.Add($"{_foodName[i]} x {_foodQuantity[i]}");
                }
                regularFoodsLabel.Text = string.Join("\n", regpairs);

                var snackpairs = new List<string>();
                for (int i = 0; i < _snackName.Count; i++)
                {
                    snackpairs.Add($"{_snackName[i]} x {_snackQuantity[i]}");
                }
                snackFoodLabel.Text = string.Join("\n", snackpairs);



                totalPriceDetails.Text = totalAmount.ToString("C");

                gcashPaypalPaymentPanel.Visible = false;
                orderDetailsPanel.Visible = true;
            }

            orderDetailsPanel.Refresh();
        }

        private void ConfirmOrderDetailsBtn_Click(object sender, EventArgs e)
        {
            if (gcashPaymentBtn.Text == "Proceed to GCash payment")
            {
                gcashPaypalPaymentPanel.Visible = false;
                orderDetailsPanel.Visible = true;
            }
            else if (gcashPaymentBtn.Text == "Proceed to PayPal payment")
            {
                gcashPaypalPaymentPanel.Visible = false;
                orderDetailsPanel.Visible = true;
            }
            resibo resibo = new resibo(_movieId, _movieName, _moviePrice, _reservedSeats, _reservedBy);
            resibo.GetOrderedRegularFoods(_foodName, _foodQuantity, _foodPrice);
            resibo.GetOrderedSnacksFoods(_snackName, _snackQuantity, _snackPrice);
            resibo.ShowDialog();

            IsPaymentSuccessful = true;
            Close();
        }


        private void cardPaymentBtn_Click(object sender, EventArgs e)
        {
            decimal totalRegularFoodCost = 0;

            for (int i = 0; i < _foodQuantity.Count; i++)
            {
                totalRegularFoodCost += _foodQuantity[i] * _foodPrice[i];
            }

            decimal totalSnackFoodCost = 0;

            for (int i = 0; i < _snackQuantity.Count; i++)
            {
                totalSnackFoodCost += _snackQuantity[i] * _snackPrice[i];
            }

            decimal totalFoodCost = totalRegularFoodCost + totalSnackFoodCost;

            decimal totalAmount = (_moviePrice * _reservedSeats.Count) + totalFoodCost;
            string cardName = cardNameInput.Text;
            string cardNumber = cardNumberInput.Text;
            string monthExpiration = cardMonthInput.Text;
            string yearExpiration = cardYearInput.Text;
            string securityCode = cardSecuInput.Text;
            string country = cardCountryInput.Text;
            string postalCode = cardPostalCodeInput.Text;

            NameDetails.Text = _reservedBy;
            AccountName.Text = cardName;
            MovietoReserveDetails.Text = _movieName;
            SeatsDetails.Text = string.Join(", ", _reservedSeats);
            PayWithDetails.Text = "Card";

            var regpairs = new List<string>();
            for (int i = 0; i < _foodName.Count; i++)
            {
                regpairs.Add($"{_foodName[i]} x {_foodQuantity[i]}");
            }
            regularFoodsLabel.Text = string.Join("\n", regpairs);

            var snackpairs = new List<string>();
            for (int i = 0; i < _snackName.Count; i++)
            {
                snackpairs.Add($"{_snackName[i]} x {_snackQuantity[i]}");
            }
            snackFoodLabel.Text = string.Join("\n", snackpairs);

            totalPriceDetails.Text = totalAmount.ToString("C");

            cardPaymentPanel.Visible = false;
            orderDetailsPanel.Visible = true;

            orderDetailsPanel.Refresh();
        }

        private void closeModal_Click(object sender, EventArgs e)
        {
            gcashPaypalPaymentPanel.Visible = true;
            orderDetailsPanel.Visible = false;
        }

        private void cardPaymentMethodBtn_Click(object sender, EventArgs e)
        {
            cardPaymentPanel.Visible = true;
            gcashPaypalPaymentPanel.Visible = false;
            clearText();
        }

        private void paymentFormClose(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
