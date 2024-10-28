using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMunch.Frontend.Forms
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }
        private void gcashBtn_Click(object sender, EventArgs e)
        {
            cardPaymentPanel.Visible = false;
            gcashPaymentPanel.Visible = true;
            paypalPaymentPanel.Visible = false;

        }
        private void cardPaymentMethodBtn_Click(object sender, EventArgs e)
        {
            gcashPaymentPanel.Visible = false;
            cardPaymentPanel.Visible = true;
            paypalPaymentPanel.Visible = false;
        }

        private void paypalBtn_Click(object sender, EventArgs e)
        {
            gcashPaymentPanel.Visible = false;
            cardPaymentPanel.Visible = false;
            paypalPaymentPanel.Visible = true;
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


            MessageBox.Show($"{cardName},{cardNumber}, {monthExpiration}, {yearExpiration}, {securityCode}, {postalCode}");
        }

        private void gcashPaymentBtn_Click(object sender, EventArgs e)
        {
            string gcashName = gcashUserNameInput.Text;
            string gcashEmail = gcashUserEmailInput.Text;

            MessageBox.Show($"{gcashName},{gcashEmail}");
        }

        private void paypalPaymentBtn_Click(object sender, EventArgs e)
        {

            string paypalName = paypalUserNameInput.Text;
            string paypalEmail = paypalUserEmailInput.Text;

            MessageBox.Show($"{paypalName},{paypalEmail}");
        }
    }
}
