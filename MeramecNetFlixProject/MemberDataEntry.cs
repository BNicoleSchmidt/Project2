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

        }
    }
}
