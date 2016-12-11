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

            if (mySignIn.isLoggedIn)
            {
                menuStrip1.Enabled = true;
                _currentMember = mySignIn.memberLoggedIn;
                btnMemberSignIn.Text = @"Welcome " + _currentMember.FirstName;
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
 