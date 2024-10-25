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

            LoadingForm loadingForm = new LoadingForm();
            Application.Run(loadingForm);

            //MainAdminForm mainAdminForm = new MainAdminForm();
            //Application.Run(mainAdminForm);
        }
    }
}
