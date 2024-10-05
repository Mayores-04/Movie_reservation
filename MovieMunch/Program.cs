using System;
using System.Windows.Forms;

namespace MovieMunch
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the loading form first
            LoadingForm loadingForm = new LoadingForm();
            Application.Run(loadingForm); // Application will start with LoadingForm
        }
    }
}
