using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMunch.Frontend.Forms
{
    public partial class WatchListForm : Form
    {
        public WatchListForm()
        {
            InitializeComponent();
        }

        private void FavBtn_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainPage mainPage = new MainPage();
            mainPage.Visible = true;
        }
    }
}
