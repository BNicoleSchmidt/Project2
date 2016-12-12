using System;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;

namespace MeramecNetFlixProject.UI
{
    public partial class SignInScreen : Form
    {
        private Member _currentMember;
        public SignInScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignInPage mySignIn = new SignInPage(_currentMember);
            mySignIn.ShowDialog();

            if (mySignIn.MemberLoggedIn != null)
            {
                if (mySignIn.MemberLoggedIn.IsAdmin == true)
                {
                    btnUpdateGenre.Visible = true;
                    btnUpdateMovies.Visible = true;
                }

                menuStrip1.Enabled = true;
                _currentMember = mySignIn.MemberLoggedIn;
                btnMemberSignIn.Text = @"Welcome " + _currentMember.FirstName;
            }
            
            
        }

        private void browseInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseInventory myInventoryBrowser = new BrowseInventory();
            myInventoryBrowser.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GenreForm genreForm = new GenreForm();
            genreForm.ShowDialog();
        }

        private void btnUpdateMovies_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.ShowDialog();                        
        }

        private void manageAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberDataEntry memberEdit = new MemberDataEntry(_currentMember);
            memberEdit.ShowDialog();
            

        }

        private void createWatchListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Favorites favoritesPage = new Favorites();
            favoritesPage.ShowDialog();
        }
    }
}
 