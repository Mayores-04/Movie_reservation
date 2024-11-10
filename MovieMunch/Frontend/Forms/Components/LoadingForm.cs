using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using System;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class LoadingForm : Form
    {
        private int circleCount = 0;
        private Timer circleTimer;
        private Timer delayTimer;  

        public LoadingForm()
        {
            InitializeComponent();

            circleTimer = new Timer
            {
                Interval = 300
            };
            circleTimer.Tick += CircleTimer_Tick;
        }

        private void CircleTimer_Tick(object sender, EventArgs e)
        {
            switch (circleCount)
            {
                case 0:
                    firstCircle.Visible = true;
                    break;
                case 1:
                    firstCircle.Visible = false;
                    secondCircle.Visible = true;
                    break;
                case 2:
                    secondCircle.Visible = false;
                    thirdCircle.Visible = true;
                    break;
                case 3:
                    thirdCircle.Visible = false;
                    fourthCircle.Visible = true;
                    break;
                case 4:
                    fourthCircle.Visible = false;
                    fifthCircle.Visible = true;
                    break;
                case 5:
                    fifthCircle.Visible = false;
                    sixthCircle.Visible = true;
                    break;
                case 6:
                    sixthCircle.Visible = false;
                    seventhCircle.Visible = true;
                    break;
                case 7:
                    lastLogo.Visible = true;
                    seventhCircle.Visible = false;
                    circleTimer.Stop();
                    MainPage mainPage = new MainPage();
                    mainPage.Show();
                    this.Hide();
                    break;
            }
            circleCount++;
        }
        private void LoadingForm_Load(object sender, EventArgs e)
        {

            circleTimer.Start();
        }
    }
}


