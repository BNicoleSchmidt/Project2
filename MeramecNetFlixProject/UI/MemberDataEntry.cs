using MeramecNetFlixProject.BusinessObjects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.UI
{
    public partial class MemberDataEntry : Form
    {
        private Member _currentMember;
        private MemberDB _memberDb;

        public MemberDataEntry()
        {
            InitializeComponent();
            _memberDb = new MemberDB();
            _currentMember = new Member();
            txtJoinDate.Enabled = false;
            LoadTable();
        }

        public MemberDataEntry(string signup)
        {
            InitializeComponent();
            _memberDb = new MemberDB();
            _currentMember = new Member();
            txtMemberNumber.Enabled = false;
            txtJoinDate.Enabled = false;
            btnMemberBrowse.Enabled = false;
            btnMemberUpdate.Enabled = false;
            btnMemberDelete.Enabled = false;
        }

        public MemberDataEntry(Member currentMember)
        {
            InitializeComponent();
            _memberDb = new MemberDB();
            _currentMember = currentMember;

            txtMemberNumber.Enabled = false;
            txtJoinDate.Enabled = false;
            btnMemberAdd.Enabled = false;
            btnMemberBrowse.Enabled = false;
            btnMemberUpdate.Enabled = true;
            btnMemberDelete.Enabled = false;
            LoadMember();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnMemberUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateForm() != null)
            {
                if (_memberDb.UpdateMember(_currentMember))
                {
                    errorLabel.Text = "Update success";
                    LoadTable();
                }
            }
        }

        private Member ValidateForm()
        {
            if (!rdoActive.Checked && !rdoInactive.Checked)
            {
                errorLabel.Text = @"Must be active or inactive.";
                return null;
            }
            _currentMember.MemberStatus = rdoActive.Checked ? "A" : "I";
            if (!rdoEmail.Checked && !rdoPhoneText.Checked && !rdoFaceBook.Checked && !rdoTwitter.Checked)
            {
                errorLabel.Text = @"Must have contact method.";
                return null;
            }
            _currentMember.ContactMethod = rdoEmail.Checked ? 1 : rdoPhoneText.Checked ? 2 : rdoFaceBook.Checked ? 3 : 4;
            if (!rdoStandard.Checked && !rdoPlus.Checked && !rdoTrial.Checked && !rdoStudent.Checked)
            {
                errorLabel.Text = @"Must have subscription type.";
                return null;
            }
            _currentMember.SubscriptionId = rdoStandard.Checked ? 1 : rdoPlus.Checked ? 2 : rdoTrial.Checked ? 3 : 4;
            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                errorLabel.Text = @"Must have first name.";
                return null;
            }
            _currentMember.FirstName = txtFirstname.Text;
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorLabel.Text = @"Must have last name.";
                return null;
            }
            _currentMember.LastName = txtLastName.Text;
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorLabel.Text = @"Must have state.";
                return null;
            }
            _currentMember.Address = txtAddress.Text;
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                errorLabel.Text = @"Must have city.";
                return null;
            }
            _currentMember.City = txtCity.Text;
            if (string.IsNullOrWhiteSpace(txtState.Text))
            {
                errorLabel.Text = @"Must have state.";
                return null;
            }
            _currentMember.State = txtState.Text;
            int zip;
            if (string.IsNullOrWhiteSpace(txtZipCode.Text) || !int.TryParse(txtZipCode.Text, out zip))
            {
                errorLabel.Text = @"Must have valid zipcode.";
                return null;
            }
            _currentMember.Zipcode = zip;
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorLabel.Text = @"Must have phone number.";
                return null;
            }
            _currentMember.Phone = txtPhone.Text;
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorLabel.Text = @"Must have email.";
                return null;
            }
            _currentMember.Email = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(txtLoginName.Text))
            {
                errorLabel.Text = @"Must have login name.";
                return null;
            }
            _currentMember.LoginName = txtLoginName.Text;
            if (!string.IsNullOrWhiteSpace(txtPassword.Text) || !string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                if (!string.Equals(txtPassword.Text, txtConfirmPassword.Text, StringComparison.Ordinal))
                {
                    errorLabel.Text = @"Passwords do not match.";
                    return null;
                }
                _currentMember.Password = txtPassword.Text;
            }
            //var member = new Member
            //{
            //    FirstName = txtFirstname.Text,
            //    LastName = txtLastName.Text,
            //    Address = txtAddress.Text,
            //    City = txtCity.Text,
            //    State = txtState.Text,
            //    Zipcode = zip,
            //    Phone = txtPhone.Text,
            //    Email = txtEmail.Text,
            //    Password = txtPassword.Text,
            //    LoginName =



            //};

            return _currentMember;
        }

        private void clear()
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

        private void btnMemberBrowse_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtMemberNumber.Text, out id))
            {
                errorLabel.Text = @"Enter valid Member Number.";
                return;
            }
            _currentMember = _memberDb.GetMemberById(id);
            if (_currentMember == null)
            {
                errorLabel.Text = "Member " + id + " does not exist.";
                return;
            }
            LoadMember();
            errorLabel.Text = "";
        }

        private void LoadMember()
        {
            if (_currentMember.MemberStatus == "A") rdoActive.Checked = true;
            else rdoInactive.Checked = true;
            if (_currentMember.ContactMethod == 1) rdoPhoneText.Checked = true;
            if (_currentMember.ContactMethod == 2) rdoEmail.Checked = true;
            if (_currentMember.ContactMethod == 3) rdoFaceBook.Checked = true;
            if (_currentMember.ContactMethod == 4) rdoTwitter.Checked = true;
            txtMemberNumber.Text = _currentMember.Id.ToString();
            txtJoinDate.Text = _currentMember.JoinDate.ToShortDateString();
            txtFirstname.Text = _currentMember.FirstName;
            txtLastName.Text = _currentMember.LastName;
            txtEmail.Text = _currentMember.Email;
            txtLoginName.Text = _currentMember.LoginName;
            txtAddress.Text = _currentMember.Address;
            txtCity.Text = _currentMember.City;
            txtState.Text = _currentMember.State;
            txtZipCode.Text = _currentMember.Zipcode.ToString();
            txtPhone.Text = _currentMember.Phone;
        }

        private void LoadTable()
        {
            try
            {
                String connectionString = "Data Source=198.209.220.125;Initial Catalog=Teamc;User ID=teamc;Password=teamc";
                var dataAdapter = new SqlDataAdapter("Select * from Member", connectionString);
                var table = new DataTable { Locale = System.Globalization.CultureInfo.InvariantCulture };
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException e)
            {
                MessageBox.Show(@"SQL Error: " + e.Message);
            }
        }

        private void btnMemberAdd_Click(object sender, EventArgs e)
        {
            var newMember = ValidateForm();
            if (newMember == null) return;
            newMember.JoinDate = DateTime.Today;
            if (_memberDb.AddMember(newMember))
            {
                clear();
                LoadTable();
                errorLabel.Text = @"Member added successfully.";
            }

        }
    }
}
