using MovieMunch.Admin.FilmsInCinema;
using System;
using System.Windows.Forms;

namespace MovieMunch.Admin
{
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void moviesToShowBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Showing moviesToShow = new Showing();
            moviesToShow.ShowDialog();
        }

        private void filmsInCinemaBtn_Click(object sender, EventArgs e)
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

        private void foodsBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SnacksForm snacksForm = new SnacksForm();
            snacksForm.ShowDialog();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void EmployeeListBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeeList employeeList = new EmployeeList();
            employeeList.Show();
        }
    }
}
