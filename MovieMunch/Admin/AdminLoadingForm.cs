using AxWMPLib;
using MovieMunch.Admin;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MovieMunch.Admin
{
    public partial class AdminLoadingForm : Form
    {
        private MainAdmin mainAdmin;

        public AdminLoadingForm()
        {
            InitializeComponent();

            guna2Panel1.BackColor = ColorTranslator.FromHtml("#2D142C"); 
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.BringToFront();

            string path = "C:/Users/jakem/Downloads/admin.mp4";
            axWindowsMediaPlayer1.URL = path;

            axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;

            mainAdmin = new MainAdmin();
            mainAdmin.SetUserNamme(_userName, _profilePic);
            mainAdmin.Hide();
        }

        public string _userName;
        public string _profilePic;
        public void setUserNamme(string name, string profilePic)
        {
            _userName = name;
            _profilePic = profilePic;
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
            mainAdmin.Show();
            mainAdmin.SetUserNamme(_userName, _profilePic);
            this.Hide();
        }
    }
}
