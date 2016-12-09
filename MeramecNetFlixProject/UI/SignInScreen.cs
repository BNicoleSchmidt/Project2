using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeramecNetFlixProject.UI;

namespace MeramecNetFlixProject
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSignIn myAdminSignIn = new AdminSignIn();
            myAdminSignIn.ShowDialog();
        }
    }
}
 