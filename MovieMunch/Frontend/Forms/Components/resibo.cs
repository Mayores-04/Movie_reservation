using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Markup;
using Zen.Barcode;

namespace MovieMunch.Frontend.Forms.Components
{
    public partial class resibo : Form
    {
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDocument printDocument;
        private string _userName;
        private string _movieName;
        private decimal _Price = 300;
        private string _ticketReference;
        private double _Discount = 0;
        private List<string> _seats;
        private double _PaymentInput = 1000;
        private double _ChangeAmount;
        private double _TotalAmount;
        private string reference;

        public resibo(string Id, string movieName, decimal moviePrice, List<string> reservedSeats, string reservedBy)
        {
            InitializeComponent();
            _movieName = movieName;
            _Price = moviePrice;
            _seats = reservedSeats;
            _userName = reservedBy;
            reference = Id?.ToString() ?? string.Empty;


            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            _ChangeAmount = _PaymentInput - Convert.ToDouble(_Price);
            _ticketReference = GeneratedReference();
            _TotalAmount = Convert.ToDouble(_Price);

            try
            {
                CodeQrBarcodeDraw barcode = BarcodeDrawFactory.CodeQr;

                if (string.IsNullOrWhiteSpace(_ticketReference))
                {
                    MessageBox.Show("Please enter text to generate a QR code.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Image qrCodeImage = barcode.Draw(_ticketReference, 50);

                Image resizedQrCodeImage = ResizeImage(qrCodeImage, pictureBox1.Width, pictureBox1.Height);

                pictureBox1.Image = resizedQrCodeImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(img, 0, 0, width, height);
            }
            return resizedImage;
        }

        private string GeneratedReference()
        {
            if (string.IsNullOrEmpty(reference))
            {
                Console.WriteLine("Invalid reference or reference is null");
                return "ERROR";
            }
             
            string digits = new string(reference.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(digits))
            {
                Console.WriteLine("No digits found in reference");
                return "ERROR";
            }

            string uniqueId = digits.Length >= 4 ? digits.Substring(digits.Length - 4) : digits.PadLeft(4, '0');
            string date = DateTime.Now.ToString("yyyyMMdd");
            string prefix = "MOV";
            string seat = _seats[currentSeatIndex];  
            prefix += seat;

            string ticketReference = $"{prefix}-{date}-{uniqueId}";
            return ticketReference;
        }

        private int currentSeatIndex = 0;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 28, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 22, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 22);
            Font subFont = new Font("Arial", 19);

            float x = 50;
            float y = 50;
            float lineHeight = 25;

            string imagePath = "C:\\Users\\jakem\\source\\repos\\MovieMunchTicket\\MovieMunchTicket\\image\\movieMunchTransparentLogo.png";
            if (System.IO.File.Exists(imagePath))
            {
                Image logo = Image.FromFile(imagePath);
                float imageWidth = 500;
                float imageHeight = 250;
                e.Graphics.DrawImage(logo, new RectangleF(x + 130, y, imageWidth, imageHeight));
                y += imageHeight + lineHeight;
            }

            if (_seats.Count == 0)
            {
                MessageBox.Show("No seats to print.");
                return;
            }

            if (currentSeatIndex < _seats.Count)
            {
                string seat = _seats[currentSeatIndex];
                string myRandomNo = GeneratedReference();
                string currentDateTime = DateTime.Now.ToString("MMM dd, yyyy/hh:mm tt");

                e.Graphics.DrawString("MOVIE MUNCH CINEMAS INC.", subHeaderFont, Brushes.Black, new PointF(x, y));
                y += lineHeight;
                e.Graphics.DrawString("Movie Munch Cainta", subHeaderFont, Brushes.Black, new PointF(x, y));
                y += lineHeight;
                e.Graphics.DrawString("Cainta, Rizal", subHeaderFont, Brushes.Black, new PointF(x, y));
                y += lineHeight;

                e.Graphics.DrawString("Ref no. ", subHeaderFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(myRandomNo, subHeaderFont, Brushes.Black, new PointF(x + 120, y));
                y += lineHeight;

                e.Graphics.DrawString(currentDateTime, subHeaderFont, Brushes.Black, new PointF(x, y));
                y += lineHeight;

                e.Graphics.DrawString("______________________________________", bodyFont, Brushes.Black, new PointF(x, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("Name", bodyFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(":", bodyFont, Brushes.Black, new PointF(x + 270, y));
                e.Graphics.DrawString(_userName, bodyFont, Brushes.Black, new PointF(x + 285, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("Movie Name", bodyFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(":", bodyFont, Brushes.Black, new PointF(x + 270, y));
                e.Graphics.DrawString($"{_movieName}", bodyFont, Brushes.Black, new PointF(x + 285, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("Seat No.", bodyFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(":", bodyFont, Brushes.Black, new PointF(x + 270, y));
                e.Graphics.DrawString(seat, bodyFont, Brushes.Black, new PointF(x + 285, y));
                y += lineHeight * 2;


                e.Graphics.DrawString("Price", bodyFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(":", bodyFont, Brushes.Black, new PointF(x + 270, y));
                e.Graphics.DrawString($"₱{_Price}", bodyFont, Brushes.Black, new PointF(x + 285, y));
                y += lineHeight * 2;


                e.Graphics.DrawString("Discount", bodyFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(":", bodyFont, Brushes.Black, new PointF(x + 270, y));
                e.Graphics.DrawString($"{_Discount}%", bodyFont, Brushes.Black, new PointF(x + 285, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("Payment Received", bodyFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(":", bodyFont, Brushes.Black, new PointF(x + 270, y));
                e.Graphics.DrawString($"₱{_PaymentInput}", bodyFont, Brushes.Black, new PointF(x + 285, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("Change", bodyFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(":", bodyFont, Brushes.Black, new PointF(x + 270, y));
                e.Graphics.DrawString($"₱{_ChangeAmount}", bodyFont, Brushes.Black, new PointF(x + 285, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("______________________________________", bodyFont, Brushes.Black, new PointF(x, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("TOTAL AMOUNT", headerFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(":", headerFont, Brushes.Black, new PointF(x + 320, y));
                e.Graphics.DrawString($"₱{_TotalAmount}", headerFont, Brushes.Black, new PointF(x + 355, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("______________________________________", bodyFont, Brushes.Black, new PointF(x, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("Thank you for choosing Movie Munch Cinemas!", subFont, Brushes.Black, new PointF(x, y));
                y += lineHeight;

                e.Graphics.DrawString("This Serves as your official receipt.", subFont, Brushes.Black, new PointF(x, y));
                y += lineHeight;

                e.Graphics.DrawString("Valid only on the screening details indicated.", subFont, Brushes.Black, new PointF(x, y));
                y += lineHeight;

                currentSeatIndex++;

                if (currentSeatIndex < _seats.Count)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    currentSeatIndex = 0;
                    e.HasMorePages = false;
                }
            }
        }

        private void printReceiptBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!");
            this.Close();
        }
    }
}