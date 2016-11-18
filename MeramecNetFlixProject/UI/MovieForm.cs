using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeramecNetFlixProject.UI
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnMovieExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMovieClear_Click(object sender, EventArgs e)
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
            cboGenre.SelectedIndex = -1;
            cboMediaType.SelectedIndex = -1;
            cboRating.SelectedIndex = -1;
        }
    }
}
