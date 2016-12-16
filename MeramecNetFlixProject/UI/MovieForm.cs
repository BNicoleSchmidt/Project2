using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.UI
{
    public partial class MovieForm : Form
    {
        private readonly MovieDB _movieDb;
        private Movie _currentMovie;
        public MovieForm()
        {
            InitializeComponent();
            _movieDb = new MovieDB();
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

            LoadTable();
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
            if (_movieDb.AddMovie(movie))
            {
                Clear();
                LoadTable();
                errorLabel.Text = @"Movie added successfully.";
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
            txtRetailCost.Text = String.Empty;
            txtCopiesOnHand.Text = String.Empty;
            txtImageName.Text = String.Empty;
            txtTrailerLink.Text = String.Empty;
            txtYearMade.Text = String.Empty;
            cboGenre.SelectedIndex = 0;
            cboMediaType.SelectedIndex = 0;
            cboRating.SelectedIndex = 0;
            _currentMovie = null;
        }
        private void LoadTable()
        {
            try
            {
                String connectionString = "Data Source=198.209.220.125;Initial Catalog=Teamc;User ID=teamc;Password=teamc";
                var dataAdapter = new SqlDataAdapter("Select * from Movie", connectionString);
                var table = new DataTable { Locale = System.Globalization.CultureInfo.InvariantCulture };
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException e)
            {
                MessageBox.Show(@"SQL Error: " + e.Message);
            }
        }

        private void btnMovieDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtMovieNumber.Text, out id))
            {
                errorLabel.Text = @"Enter valid Movie Number.";
                return;
            }
            _currentMovie = _movieDb.GetMovie(id);
            if (_currentMovie == null)
            {
                errorLabel.Text = "Movie " + id + " does not exist.";
                return;
            }
            if (_movieDb.DeleteMovie(id))
            {
                errorLabel.Text = "Movie " + id + " deleted successfully.";
                return;
            }
            errorLabel.Text = "Could not delete Movie " + id + ".";
        }

        private void btnMovieFind_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtMovieNumber.Text, out id))
            {
                errorLabel.Text = @"Enter valid Movie Number.";
                return;
            }
            _currentMovie = _movieDb.GetMovie(id);
            if (_currentMovie == null)
            {
                errorLabel.Text = "Movie " + id + " does not exist.";
                return;
            }
            LoadMovie();
            errorLabel.Text = "";
        }

        private void LoadMovie()
        {
            txtMovieNumber.Text = _currentMovie.Id.ToString();
            txtMovieTitle.Text = _currentMovie.MovieTitle;
            txtMovieDescription.Text = _currentMovie.Description;
            txtYearMade.Text = _currentMovie.MovieYearMade.ToString();
            txtRetailCost.Text = _currentMovie.MovieRetailCost.ToString();
            txtCopiesOnHand.Text = _currentMovie.CopiesOnHand.ToString();
            txtImageName.Text = _currentMovie.Image;
            txtTrailerLink.Text = _currentMovie.Trailer;
            cboGenre.SelectedIndex = _currentMovie.GenreId;
            cboRating.SelectedValue = _currentMovie.MovieRating;
            cboMediaType.SelectedValue = _currentMovie.MediaType;
        }
    }
}
