using System.Windows.Forms;
using MeramecNetFlixProject.Services;

namespace MeramecNetFlixProject.UI
{
    public partial class BrowseInventory : Form
    {
        private MovieService _movieService;

        public BrowseInventory()
        {
            InitializeComponent();

            pnlMovieScroller.AutoScroll = false;
            pnlMovieScroller.HorizontalScroll.Enabled = false;
            pnlMovieScroller.HorizontalScroll.Visible = false;
            pnlMovieScroller.HorizontalScroll.Maximum = 0;
            pnlMovieScroller.AutoScroll = true;

            pnlDescription.AutoScroll = false;
            pnlDescription.HorizontalScroll.Enabled = false;
            pnlDescription.HorizontalScroll.Visible = false;
            pnlDescription.HorizontalScroll.Maximum = 0;
            pnlDescription.AutoScroll = true;

            _movieService = new MovieService();
        }


    }
}
