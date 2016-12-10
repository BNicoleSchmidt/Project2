using MeramecNetFlixProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;


namespace MeramecNetFlixProject.UI
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MemberDataEntry myMemeber = new MemberDataEntry();
            myMemeber.ShowDialog();
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
                isLoggedIn = true;

                memberLoggedIn =  memberService.GetMember(txtLogin.Text);

                
                Close();
            }
            else
            {
                isLoggedIn = false;
            }
                        
        }

        public bool isLoggedIn { get; set; }
        public Member memberLoggedIn { get; set; }



        //public bool isSignedIn()
        //{

        //}
    }
}
