using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MeramecNetFlixProject
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
