using System;
using System.Windows.Forms;

namespace MeramecNetFlixProject.UI
{
    public partial class BrowseInventory : Form
    {
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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblMovDescription.Text = "Arthur Dent (Martin Freeman) is trying to prevent his" +
                                     " house from being bulldozed when his friend \nFord Prefect " +
                                     "(Mos Def) whisks him into outer space. It turns out " +
                                     "Ford is an alien who has just \nsaved Arthur from Earth's" +
                                     " total annihilation. Ford introduces Arthur to his " +
                                     "myriad friends, including \nmany-headed President " +
                                     "Zaphod Beeblebrox (Sam Rockwell) and sexy refugee " +
                                     "Trillian \n(Zooey Deschanel). Arthur makes his way " +
                                     "across the stars while seeking the meaning of life, " +
                                     "\nor something close to it.";

            
            webBrowser1.Navigate("http://www.youtube.com/v/" + "8uCEeCUecNI" + "?html5=1");

            btnOrderMovie.Visible = true;
            btnSimilarTitles.Visible = true;
        }
    }
}
