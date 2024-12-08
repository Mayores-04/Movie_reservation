using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using Zen.Barcode;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace MovieMunch.Frontend.Forms.Components
{
    public partial class resibo : Form
    {
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDocument printDocument;
        private string _userName;
        private string _movieName;
        private decimal _Price = 0;
        private string _ticketReference;
        private double _Discount = 0;
        private List<string> _seats;
        private double _PaymentInput = 0;
        private double _ChangeAmount;
        private double _TotalAmount;
        private string reference;

        private List<string> ticketReference;
        public resibo(string Id, string movieName, decimal moviePrice, List<string> reservedSeats, string reservedBy)
        {
            InitializeComponent();
            _movieName = movieName;
            _Price = moviePrice;
            _seats = reservedSeats;
            _userName = reservedBy;
            reference = Id?.ToString() ?? string.Empty;

            Random randomAmount = new Random();
            _PaymentInput = Convert.ToDouble(_Price) + randomAmount.Next(0, 100);

            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            _ChangeAmount = _PaymentInput - Convert.ToDouble(_Price);
            _TotalAmount = Convert.ToDouble(_Price);

            try
            {
                _ticketReference = GenerateReferenceForQRCode();

                if (string.IsNullOrWhiteSpace(_ticketReference))
                {
                    MessageBox.Show("Ticket reference is missing. Please check your data.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CodeQrBarcodeDraw barcode = BarcodeDrawFactory.CodeQr;
                Image qrCodeImage = barcode.Draw(_ticketReference, 50);

                Image resizedQrCodeImage = ResizeImage(qrCodeImage, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = resizedQrCodeImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private readonly UserService _userService = new UserService();

        private string GenerateReferenceForQRCode()
        {
            string generatedReference = string.Empty;

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

            generatedReference = $"{prefix}-{date}-{uniqueId}";

            return generatedReference;
        }

        public async Task AddTicketDataAsync()
        {
            try
            {
                if (string.IsNullOrEmpty(_movieName) || string.IsNullOrEmpty(_userName))
                {
                    MessageBox.Show("Please select a valid movie and user before proceeding.");
                    return;
                }

                if (_seats == null || !_seats.Any())
                {
                    MessageBox.Show("No seats selected. Please reserve at least one seat.");
                    return;
                }

                Dictionary<string, string> seatTicketMapping = _seats.ToDictionary(
                    seat => seat,
                    seat => GenerateReference(seat) 
                );

                var ticketDetails = new TicketDetails
                {
                    MovieId = reference,
                    UserName = _userName,
                    MovieTitle = _movieName,
                    MoviePrice = _Price,
                    SeatTicketMapping = seatTicketMapping,
                    DatePurchased = DateTime.Now,
                    RegularFoodsName = _foodName,
                    RegularFoodsPrice = _foodPrice,
                    RegularFoodsQuantity = _foodQuantity,
                    SnackFoodsName = _snackName,
                    SnackFoodsPrice = _snackPrice,
                    SnackFoodsQuantity = _snackQuantity
                };

                await _userService.SaveTicketDetails(ticketDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding tickets: {ex.Message}");
            }
        }

        private string GenerateReference(string seat)
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

            prefix += seat;

            return $"{prefix}-{date}-{uniqueId}";
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

        private int currentSeatIndex = 0;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 24, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 20, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 20);
            Font subFont = new Font("Arial", 16);
            Font orderedFont = new Font("Arial", 12);

            float x = 50;
            float y = 15;
            float lineHeight = 25;

            string imagePath = "C:\\Users\\jakem\\source\\repos\\Movie_reservation\\MovieMunch\\Frontend\\Forms\\Assets\\MovieMunchLogo-removebg-preview_1.png";
            if (System.IO.File.Exists(imagePath))
            {
                Image logo = Image.FromFile(imagePath);
                float imageWidth = 300;
                float imageHeight = 150;
                e.Graphics.DrawImage(logo, new RectangleF(x + 230, y, imageWidth, imageHeight));
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
                string myRandomNo = GenerateReference(seat);
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

                e.Graphics.DrawString("______________________________________________", bodyFont, Brushes.Black, new PointF(x, y));
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

                e.Graphics.DrawString("Movie Price", bodyFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(":", bodyFont, Brushes.Black, new PointF(x + 270, y));
                e.Graphics.DrawString($"₱{_Price}", bodyFont, Brushes.Black, new PointF(x + 285, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("Ordered Foods", subHeaderFont, Brushes.Black, new PointF(x, y));
                y += lineHeight * 2;

                if (_foodName != null && _foodName.Count > 0)
                {
                    e.Graphics.DrawString("Regular Foods:", bodyFont, Brushes.Black, new PointF(x, y));
                    y += lineHeight + 10;  

                    for (int i = 0; i < _foodName.Count; i++)
                    {
                        e.Graphics.DrawString($"{_foodName[i]} x {_foodQuantity[i]} - ₱{_foodPrice[i] * _foodQuantity[i]}", orderedFont, Brushes.Black, new PointF(x + 20, y));
                        y += lineHeight;
                    }

                    y += 15; 
                }

                if (_snackName != null && _snackName.Count > 0)
                {
                    e.Graphics.DrawString("Snack Foods:", bodyFont, Brushes.Black, new PointF(x, y));
                    y += lineHeight + 10;  

                    for (int i = 0; i < _snackName.Count; i++)
                    {
                        e.Graphics.DrawString($"{_snackName[i]} x {_snackQuantity[i]} - ₱{_snackPrice[i] * _snackQuantity[i]}", orderedFont, Brushes.Black, new PointF(x + 20, y));
                        y += lineHeight;
                    }

                    y -= 20;
                }

                e.Graphics.DrawString("______________________________________________", bodyFont, Brushes.Black, new PointF(x, y));
                y += lineHeight + 10;

                e.Graphics.DrawString("TOTAL AMOUNT", headerFont, Brushes.Black, new PointF(x, y));
                e.Graphics.DrawString(":", headerFont, Brushes.Black, new PointF(x + 320, y));
                e.Graphics.DrawString($"₱{_TotalAmount}", headerFont, Brushes.Black, new PointF(x + 355, y));
                y += lineHeight * 2;

                e.Graphics.DrawString("Thank you for choosing Movie Munch Cinemas!", subFont, Brushes.Black, new PointF(x, y));
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
            Task task = AddTicketDataAsync();
            this.Close();
        }
    }
}