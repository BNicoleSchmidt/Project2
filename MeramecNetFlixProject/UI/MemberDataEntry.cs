using MeramecNetFlixProject.BusinessObjects;
using System;
using System.Windows.Forms;

namespace MeramecNetFlixProject.UI
{
    public partial class MemberDataEntry : Form
    {
        private Member _currentMember;

        public MemberDataEntry()
        {
            InitializeComponent();
        }

        public MemberDataEntry(Member currentMember)
        {
            InitializeComponent();

            _currentMember = currentMember;

            txtMemberNumber.Enabled = false;
            txtJoinDate.Enabled = false;
            btnMemberAdd.Enabled = false;
            btnMemberBrowse.Enabled = false;
            btnMemberUpdate.Enabled = true;

            txtFirstname.Text = currentMember.FirstName;
            txtLastName.Text = currentMember.LastName;
            txtEmail.Text = currentMember.Email;
            txtLoginName.Text = currentMember.LoginName;
            txtAddress.Text = currentMember.Address;
            txtCity.Text = currentMember.City;
            txtState.Text = currentMember.State;
            txtZipCode.Text = currentMember.Zipcode.ToString();
            txtPhone.Text = currentMember.Phone.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoActive.Checked = false;
            rdoInactive.Checked = false;
            rdoEmail.Checked = false;
            rdoFaceBook.Checked = false;
            rdoPhoneText.Checked = false;
            rdoTwitter.Checked = false;
            txtMemberNumber.Text = String.Empty;
            txtJoinDate.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtFirstname.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtLoginName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtConfirmPassword.Text = String.Empty;

        }
    }
}
