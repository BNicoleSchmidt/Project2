using System;
using System.Windows.Forms;

namespace MeramecNetFlixProject.UI
{
    public partial class SignInScreen : Form
    {
        public SignInScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignInPage mySignIn = new SignInPage();
            mySignIn.ShowDialog();

            if (mySignIn.isLoggedIn)
            {
                menuStrip1.Enabled = true;
                btnMemberSignIn.Text = "Welcome " + mySignIn.memberLoggedIn.FirstName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSignIn myAdminSignIn = new AdminSignIn();
            myAdminSignIn.ShowDialog();
        }

        private void browseInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseInventory myInventoryBrowser = new BrowseInventory();
            myInventoryBrowser.ShowDialog();
        }
    }
}
 