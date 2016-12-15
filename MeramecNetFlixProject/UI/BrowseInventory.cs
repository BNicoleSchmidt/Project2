using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.UI
{
    public partial class BrowseInventory : Form
    {
        private readonly ICollection<Movie> _movies;
        public BrowseInventory()
        {
            InitializeComponent();

            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = true;

            lblMovDescription.Size = new Size(450, 180);
            lblMovDescription.AutoSize = false;

            var movieDb = new MovieDB();
            _movies = movieDb.GetMovies();
            foreach (var movie in _movies)
            {
                var panel = new FlowLayoutPanel {Size = new Size(545, 140)};
                var title = new LinkLabel { Text = movie.MovieTitle + Environment.NewLine + "(" + movie.MovieYearMade + ")", Name = movie.Id.ToString() };
                title.LinkClicked += LinkLabelLinkClicked;
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

        private void LinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id;
            int.TryParse(((LinkLabel)sender).Name, out id);
            var movie = _movies.First(x => x.Id == id);
            lblMovDescription.Text = movie.Description;
            
            webBrowser1.Navigate("http://www.youtube.com/v/" + movie.Trailer + "?html5=1");

            btnOrderMovie.Visible = true;
            btnSimilarTitles.Visible = true;
        }
    }
}
