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
    public partial class Favorites : Form
    {
        public Favorites()
        {
            InitializeComponent();

            cboSearchBy.Items.Add("Genre");
            cboSearchBy.Items.Add("Release Date");
            cboSearchBy.Items.Add("Title");
            cboSearchBy.Items.Add("Rating");

        }
    }
}
