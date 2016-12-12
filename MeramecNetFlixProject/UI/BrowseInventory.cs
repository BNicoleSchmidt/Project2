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


    }
}
