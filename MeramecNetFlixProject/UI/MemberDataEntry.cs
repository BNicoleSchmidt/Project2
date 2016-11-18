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
    public partial class MemberDataEntry : Form
    {
        public MemberDataEntry()
        {
            InitializeComponent();
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
