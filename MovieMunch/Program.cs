using MovieMunch.Admin;
using MovieMunch.Admin.FilmsInCinema;
using MovieMunch.Forms.Components;
using MovieMunch.Frontend.Forms;
using MovieMunch.Frontend.Forms.Components;
using MovieMunch.Services;
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

            //editEmail em = new editEmail();
            //Application.Run(em);
        }
    }
}
