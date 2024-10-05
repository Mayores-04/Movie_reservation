using System;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 4000; // Sets the timer interval to 4 seconds (4000 milliseconds)
            timer.Start(); // Starts the timer countdown

            // Subscribes the Timer_Tick method to the Tick event. 
            // When 4 seconds pass, the Tick event is triggered, and the Timer_Tick method is executed.
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Stops the timer to prevent the Tick event from firing again
            this.Hide(); // Hides the current loading form

            MainPage mainPage = new MainPage(); // Creates an instance of the MainPage form
            mainPage.Show(); // Displays the MainPage form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
