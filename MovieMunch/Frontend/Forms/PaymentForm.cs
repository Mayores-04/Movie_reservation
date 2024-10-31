using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MovieMunch.Frontend.Forms
{
    public partial class PaymentForm : Form
    {
        private string _movieName;
        private List<string> _reservedSeats;
        private decimal _moviePrice;
        private string _reservedBy;

        public bool IsPaymentSuccessful { get; private set; } 

        public PaymentForm(string movieName, decimal moviePrice, List<string> reservedSeats,  string reservedBy)
        {
            InitializeComponent();
            _movieName = movieName;
            _reservedSeats = reservedSeats;
            _moviePrice = moviePrice;
            _reservedBy = reservedBy;

        }
        public void SetUserInfo(string name)
        {
            _reservedBy = name;
            MovietoReserveDetails.Text = name;

            orderDetailsPanel.Refresh();
        }

        private void cardPaymentMethodBtn_Click_1(object sender, EventArgs e)
        {
            gcashPaypalPaymentPanel.Visible = false;
            cardPaymentPanel.Visible = true;
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
            //Gcash payment btn
            if (gcashPaymentBtn.Text == "Proceed to GCash payment")
            {
                string gcashName = gcashPaypalUserNameInput.Text;
                string gcashEmail = gcashPaypalUserEmailInput.Text;

                MovietoReserveDetails.Text = _movieName;
                SeatsDetails.Text = string.Join(", ", _reservedSeats);
                PayWithDetails.Text = "GCash";
                totalPriceDetails.Text = _moviePrice.ToString("C");

                gcashPaypalPaymentPanel.Visible = false;
                orderDetailsPanel.Visible = true;
            }

            //Paypal payment btn
            else if (gcashPaymentBtn.Text == "Proceed to PayPal payment")
            {
                string paypalName = gcashPaypalUserNameInput.Text;
                string paypalEmail = gcashPaypalUserEmailInput.Text;

                MovietoReserveDetails.Text = _movieName;
                SeatsDetails.Text = string.Join(", ", _reservedSeats);
                PayWithDetails.Text = "PayPal"; 
                totalPriceDetails.Text = _moviePrice.ToString("C"); 

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

            IsPaymentSuccessful = true;
            Close();
        }


        private void cardPaymentBtn_Click(object sender, EventArgs e)
        {
            string cardName = cardNameInput.Text;
            string cardNumber = cardNumberInput.Text;
            string monthExpiration = cardMonthInput.Text;
            string yearExpiration = cardYearInput.Text;
            string securityCode = cardSecuInput.Text;
            string country = cardCountryInput.Text;
            string postalCode = cardPostalCodeInput.Text;

        }

        private void closeModal_Click(object sender, EventArgs e)
        {
            gcashPaypalPaymentPanel.Visible = true;
            orderDetailsPanel.Visible = false;
        }
    }
}
