using AxWMPLib;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MovieMunch
{
    public partial class LoadingForm : Form
    {
        private MainPage mainPage;

        public LoadingForm()
        {
            InitializeComponent();

            guna2Panel1.BackColor = ColorTranslator.FromHtml("#2D142C"); 
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.BringToFront();

            string path = "C:/Users/jakem/Downloads/user.mp4";
            axWindowsMediaPlayer1.URL = path;

            axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;

            mainPage = new MainPage();
            mainPage.Hide();
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPPlayState)e.newState == WMPPlayState.wmppsPlaying)
            {
                guna2Panel1.Visible = true;  
                TransitionOverlay(false);   
            }
            else if ((WMPPlayState)e.newState == WMPPlayState.wmppsStopped)
            {
                guna2Panel1.Visible = true; 
                TransitionOverlay(true);   
                NavigateToMainPage();
            }
        }


        private async void TransitionOverlay(bool show)
        {
            float opacity = show ? 0f : 1f;
            float increment = show ? 0.1f : -0.1f;

            while ((show && opacity < 1f) || (!show && opacity > 0f))
            {
                guna2Panel1.BackColor = Color.FromArgb((int)(opacity * 255), 45, 20, 44);  
                opacity += increment;
                await Task.Delay(50);  
            }

            guna2Panel1.Visible = true;
        }

        private void NavigateToMainPage()
        {
            mainPage.Show();
            this.Hide();
        }
    }
}
