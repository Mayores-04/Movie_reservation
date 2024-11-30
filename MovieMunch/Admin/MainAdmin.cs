using CashierApplication.Backend.Services;
using MovieMunch.Admin.FilmsInCinema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieMunch.Admin
{
    public partial class MainAdmin : Form
    {
        private readonly Reports _reports;
        public MainAdmin()
        {
            InitializeComponent();
            var dbConnection = new MongoDBConnection();
            _reports = new Reports();
            formOptionsPanel.BringToFront();
            this.Load += new System.EventHandler(this.SystemReportData_Load);
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


        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Visible = true;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            if (formOptionsPanel.Visible == false)
            {
                formOptionsPanel.Visible = true;
            }
            else
            {
                formOptionsPanel.Visible = false;
            }
        }

        private void showingBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Showing moviesToShow = new Showing();
            moviesToShow.ShowDialog();
        }

        private void filmsBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FilmsInCinemaForm filmsInCinemaForm = new FilmsInCinemaForm();
            filmsInCinemaForm.ShowDialog();
        }

        private void comingSoonBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ComingSoonMoviesForm comingSoonMoviesForm = new ComingSoonMoviesForm();
            comingSoonMoviesForm.ShowDialog();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeeList employeeList = new EmployeeList();
            employeeList.Show();
        }

        private void foodsBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegularDealsForm snacksForm = new RegularDealsForm();
            snacksForm.ShowDialog();
        }

    }
}
