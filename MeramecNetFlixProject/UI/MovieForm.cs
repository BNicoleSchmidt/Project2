using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;
using MeramecNetFlixProject.Services;

namespace MeramecNetFlixProject.UI
{
    public partial class MovieForm : Form
    {
        private MovieService _movieService;
        public MovieForm()
        {
            InitializeComponent();
            _movieService = new MovieService();
            cboGenre.Items.Insert(0, @"Select Genre");
            var genreDb = new GenreDB();
            foreach (var genre in genreDb.GetGenres())
            {
                cboGenre.Items.Add(genre);
            }
            cboGenre.DisplayMember = "Name";
            cboGenre.SelectedIndex = 0;

            var ratings = new string[] {"G", "PG", "PG-13", "R", "NC-17", "Unrated"};
            cboRating.Items.Insert(0, @"Select Rating");
            foreach (var rating in ratings)
            {
                cboRating.Items.Add(rating);
            }
            cboRating.SelectedIndex = 0;

            cboMediaType.Items.Insert(0, @"Select Media Type");
            var media = new string[] {"DVD", "Digital", "Blu-ray", "VHS"};
            foreach (var type in media)
            {
                cboMediaType.Items.Add(type);
            }
            cboMediaType.SelectedIndex = 0;
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMovieExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMovieClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnMovieAdd_Click(object sender, EventArgs e)
        {
            var movie = ValidateForm();
            if (movie == null) return;
            if (_movieService.AddMovie(movie))
            {
                Clear();
            }
        }

        private Movie ValidateForm()
        {
            int year, copies;
            decimal cost;
            if (String.IsNullOrWhiteSpace(txtMovieTitle.Text))
            {
                errorLabel.Text = @"Movie must have a Title.";
                return null;
            }
            if (String.IsNullOrWhiteSpace(txtMovieDescription.Text))
            {
                errorLabel.Text = @"Movie must have a Description.";
                return null;
            }
            if (String.IsNullOrWhiteSpace(txtYearMade.Text) || !int.TryParse(txtYearMade.Text, out year))
            {
                errorLabel.Text = @"Movie must have valid Year Made.";
                return null;
            }
            if (String.IsNullOrWhiteSpace(txtRetailCost.Text) || !decimal.TryParse(txtRetailCost.Text, out cost))
            {
                errorLabel.Text = @"Movie must have valid Cost.";
                return null;
            }
            if (String.IsNullOrWhiteSpace(txtCopiesOnHand.Text) || !int.TryParse(txtCopiesOnHand.Text, out copies))
            {
                errorLabel.Text = @"Movie must have valid Copies on hand.";
                return null;
            }
            if (String.IsNullOrWhiteSpace(txtImageName.Text))
            {
                errorLabel.Text = @"Movie must have an Image.";
                return null;
            }
            if (String.IsNullOrWhiteSpace(txtTrailerLink.Text))
            {
                errorLabel.Text = @"Movie must have a Trailer.";
                return null;
            }
            if (cboGenre.SelectedIndex == 0)
            {
                errorLabel.Text = @"Movie must have a Genre.";
                return null;
            }
            if (cboRating.SelectedIndex == 0)
            {
                errorLabel.Text = @"Movie must have a Rating.";
                return null;
            }
            if (cboMediaType.SelectedIndex == 0)
            {
                errorLabel.Text = @"Movie must have a Media type.";
                return null;
            }
            errorLabel.Text = "";
            return new Movie
            {
                MovieTitle = txtMovieTitle.Text,
                Description = txtMovieDescription.Text,
                MovieYearMade = year,
                MovieRetailCost = cost,
                CopiesOnHand = copies,
                GenreId = ((Genre)cboGenre.SelectedItem).Id,
                MovieRating = cboRating.Text,
                MediaType = cboMediaType.Text,
                Image = txtImageName.Text,
                Trailer = txtTrailerLink.Text
            };
        }

        private void Clear()
        {
            txtMovieNumber.Text = String.Empty;
            txtMovieTitle.Text = String.Empty;
            txtMovieDescription.Text = String.Empty;
            txtRentalCost.Text = String.Empty;
            txtRetailCost.Text = String.Empty;
            txtCopiesOnHand.Text = String.Empty;
            txtImageName.Text = String.Empty;
            txtTrailerLink.Text = String.Empty;
            txtYearMade.Text = String.Empty;
            cboGenre.SelectedIndex = 0;
            cboMediaType.SelectedIndex = 0;
            cboRating.SelectedIndex = 0;
        }
    }
}
