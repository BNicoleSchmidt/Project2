using MeramecNetFlixProject.Services;
using System;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;


namespace MeramecNetFlixProject.UI
{
    public partial class SignInPage : Form
    {
        public bool IsLoggedIn { get; set; }
        public Member MemberLoggedIn { get; set; }

        public SignInPage(Member currentMember)
        {
            InitializeComponent();
            if (currentMember != null)
            {
                alreadyLoggedInLabel.Text = @"You are logged in as " + currentMember.FirstName + @". Change user?";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MemberDataEntry member = new MemberDataEntry();
            member.ShowDialog();
        }

        private void btnSignInCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //make an instance of the MemberService class
            var memberService = new MemberService();
            
            if (memberService.ValidateLogin(txtLogin.Text, txtPassword.Text))
            {
                IsLoggedIn = true;
                var memberDb = new MemberDB();
                MemberLoggedIn =  memberDb.GetMember(txtLogin.Text);
                
                Close();
            }
            else
            {
                IsLoggedIn = false;
                errorLabel.Text = @"Username or Password is incorrect. Try again or Sign Up.";
                txtPassword.Text = String.Empty;
            }
        }
    }
}
