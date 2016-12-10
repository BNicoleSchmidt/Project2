using System;
using System.Windows.Forms;

namespace MeramecNetFlixProject.UI
{
    public partial class Genre : Form
    {
        public Genre()
        {
            InitializeComponent();
            
        }

        private void btnGenreExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClearClear_Click(object sender, EventArgs e)
        {
            txtID.Text = String.Empty;
            txtGenreName.Text = String.Empty;
        }
    }
}
