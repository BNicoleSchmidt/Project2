using System.Drawing;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.UI
{
    public partial class BrowseInventory : Form
    {
        public BrowseInventory()
        {
            InitializeComponent();

            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = true;

            pnlDescription.AutoScroll = false;
            pnlDescription.HorizontalScroll.Enabled = false;
            pnlDescription.HorizontalScroll.Visible = false;
            pnlDescription.HorizontalScroll.Maximum = 0;
            pnlDescription.AutoScroll = true;

            var movieDb = new MovieDB();
            var movies = movieDb.GetMovies();
            foreach (var movie in movies)
            {
                var panel = new FlowLayoutPanel();
                panel.Size = new Size(545, 140);
                var title = new LinkLabel { Text = movie.MovieTitle + "\r\n(" + movie.MovieYearMade + ")", LinkBehavior = linkLabelLinkClicked(movie) };
                title.LinkColor = Color.DeepSkyBlue;
                title.AutoSize = true;
                title.Anchor = AnchorStyles.None;
                title.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                var image = new PictureBox();
                image.ImageLocation = "Resources/" + movie.Image;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Size = new Size(105, 140);
                panel.Controls.Add(image);
                panel.Controls.Add(title);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private LinkBehavior linkLabelLinkClicked(Movie movie)
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

            
            webBrowser1.Navigate("http://www.youtube.com/v/" + "eLdiWe_HJv4" + "?html5=1");

            btnOrderMovie.Visible = true;
            btnSimilarTitles.Visible = true;
            return LinkBehavior.SystemDefault;
        }
    }
}
