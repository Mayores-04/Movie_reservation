using CashierApplication.Backend.Services;
using MovieMunch.Admin.FilmsInCinema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieMunch.Admin
{
    public partial class MainAdmin : Form
    {
        private readonly Reports _reports;
        private string _userName;
        private string _profilePic;
        public MainAdmin()
        {
            InitializeComponent();
            var dbConnection = new MongoDBConnection();
            _reports = new Reports();
            formOptionsPanel.BringToFront();
            this.Load += new System.EventHandler(this.SystemReportData_Load);
            SetUserNamme(_userName, _profilePic);
        }

        public void SetUserNamme(string name, string profilePic)
        {
            _userName = name;
            _profilePic = profilePic; 
            userNameHolder.Text = _userName;
            userNameHolder.Text = name;
            try
            {
                if (!string.IsNullOrEmpty(profilePic) && File.Exists(profilePic))
                {
                    userProfileBtn.Image = System.Drawing.Image.FromFile(profilePic);
                    userProfileBtn.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    userProfileBtn.Image = Properties.Resources.DefaultBackground;
                    userProfileBtn.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SystemReportData_Load(object sender, EventArgs e)
        {
            UpdateLabels();
            UpdateCharts();
        }

        private void UpdateLabels()
        {
            try
            {
                salesPerMovieTable.Rows.Clear();
                seatsPerMovieTable.Rows.Clear();

                if (salesPerMovieTable.Columns.Count == 0)
                {
                    salesPerMovieTable.Columns.Add("MovieTitle", "Movie Title");
                    salesPerMovieTable.Columns.Add("SalesAmount", "Sales Amount");
                    salesPerMovieTable.Columns.Add("ReservedSeats", "Reserved Seats");
                }

                if (seatsPerMovieTable.Columns.Count == 0)
                {
                    seatsPerMovieTable.Columns.Add("MovieSeatsTitle", "Movie Title");
                    seatsPerMovieTable.Columns.Add("ReservedSeatsSeats", "Reserved Seats");
                }

                int userCount = _reports.GetUserCount();
                labelUserCount.Text = $"{userCount}";

                decimal totalSales = _reports.GetTotalPriceOfAllMovies();
                labelMovieSales.Text = totalSales == 0 ? "No sales data available." : $"{totalSales:C}";

                

                int totalReservedSeats = _reports.GetTotalReservedSeats();
                labelReservedSeats.Text = $"{totalReservedSeats}";

                var movieSales = _reports.GetMovieSales();

                var movieData = new Dictionary<string, (decimal Sales, int ReservedSeats)>();

                foreach (var movie in movieSales)
                {
                    movieData[movie.Key] = (movie.Value, 0); 
                }

                var reservedSeats = _reports.GetReservedSeatsPerMovie();
                foreach (var movie in reservedSeats)
                {
                    if (movieData.ContainsKey(movie.Key))
                    {
                        movieData[movie.Key] = (movieData[movie.Key].Sales, movie.Value);  
                    }
                    else
                    {
                        movieData[movie.Key] = (0, movie.Value); 
                    }
                }


                foreach (var movie in movieData)
                {
                    salesPerMovieTable.Rows.Add(movie.Key, $"{movie.Value.Sales:C}", $"{movie.Value.ReservedSeats} seats");
                    seatsPerMovieTable.Rows.Add(movie.Key, $"{movie.Value.ReservedSeats} seats");

                    string salesId = "63f19f1e8e8d2c5fb0d1c84d";
                    Reports report = new Reports();
                    report.UpdateMovieSales(salesId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCharts()
        {
            var reservedSeats = _reports.GetReservedSeatsPerMovie();
            chartSales.Series.Clear();
            chartReservedSeats.Series.Clear();

            chartSales.Series.Add("Sales");
            chartSales.Series["Sales"].ChartType = SeriesChartType.Pie;
            chartSales.Series["Sales"]["DoughnutRadius"] = "50";
            chartSales.Series["Sales"].BorderWidth = 2;
            chartSales.Series["Sales"].IsValueShownAsLabel = true;
            chartSales.Series["Sales"].LabelFormat = "C";

            chartSales.Series["Sales"].LabelForeColor = Color.White;
            var movieSales = _reports.GetMovieSales();
            decimal totalSales = movieSales.Values.Sum();  

            foreach (var movie in movieSales)
            {
                int index = chartSales.Series["Sales"].Points.AddXY(movie.Key, movie.Value);

                var point = chartSales.Series["Sales"].Points[index];

                double percentage = (double)movie.Value / (double)totalSales * 100;

                if (percentage > 5) 
                {
                    point.Label = $"{percentage:F1}%";  
                }
                else
                {
                    point.Label = "‎ "; 
                }

                point.ToolTip = $"{movie.Key}: {movie.Value:C} ({percentage:F1}%)";
                point.LegendText = movie.Key;
            }

            chartReservedSeats.Series.Add("ReservedSeats");
            chartReservedSeats.Series["ReservedSeats"].ChartType = SeriesChartType.Pie;
            chartReservedSeats.Series["ReservedSeats"]["DoughnutRadius"] = "50";
            chartReservedSeats.Series["ReservedSeats"].BorderWidth = 2;
            chartReservedSeats.Series["ReservedSeats"].LabelForeColor = Color.White;
            chartReservedSeats.Series["ReservedSeats"].IsValueShownAsLabel = true;
            chartSales.Series["Sales"].SmartLabelStyle.Enabled = false;

            int totalReservedSeats = reservedSeats.Values.Sum();  

            foreach (var movie in reservedSeats)
            {
                int index = chartReservedSeats.Series["ReservedSeats"].Points.AddXY(movie.Key, movie.Value);

                var point = chartReservedSeats.Series["ReservedSeats"].Points[index];

                double percentage = (double)movie.Value / totalReservedSeats * 100;

                if (percentage > 5)  
                {
                    point.Label = $"{percentage:F1}%";
                }
                else
                {
                    point.Label = "‎"; 
                }

                point.ToolTip = $"{movie.Key}: {movie.Value} seats ({percentage:F1}%)";

                point.LegendText = movie.Key;
            }
        }


        private void showingBtn_Click(object sender, EventArgs e)
        {
            SetUserNamme(_userName, _profilePic);
            Showing moviesToShow = new Showing(_userName, _profilePic);
            moviesToShow.ShowDialog();
            this.Visible = false;
        }

        private void filmsBtn_Click(object sender, EventArgs e)
        {
            SetUserNamme(_userName, _profilePic);
            FilmsInCinemaForm filmsInCinemaForm = new FilmsInCinemaForm(_userName, _profilePic);
            filmsInCinemaForm.ShowDialog();
            this.Visible = false;
        }

        private void comingSoonBtn_Click(object sender, EventArgs e)
        {
            SetUserNamme(_userName, _profilePic);
            ComingSoonMoviesForm comingSoonMoviesForm = new ComingSoonMoviesForm(_userName, _profilePic);
            comingSoonMoviesForm.ShowDialog();
            this.Visible = false;
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            SetUserNamme(_userName, _profilePic);
            EmployeesManagementForm employeeList = new EmployeesManagementForm(_userName, _profilePic);
            employeeList.Show();
            this.Close();
        }

        private void foodsBtn_Click(object sender, EventArgs e)
        {
            SetUserNamme(_userName, _profilePic);
            CinemaFoodDeals snacksForm = new CinemaFoodDeals(_userName, _profilePic);
            snacksForm.ShowDialog();
            this.Visible = false;
        }

        private void switchToUserBtn_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            this.Close();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            if (formOptionsPanel.Visible == true)
            {
                formOptionsPanel.Visible = false;
            }
            else
            {
                formOptionsPanel.Visible = true;
                adminProfilePanel.Visible = false;
            }
        }

        private void userProfileBtn_Click_1(object sender, EventArgs e)
        {
            if (adminProfilePanel.Visible == true)
            {
                adminProfilePanel.Visible = false;
            }
            else
            {
                adminProfilePanel.Visible = true;
                formOptionsPanel.Visible = false;
            }
        }
    }
}
