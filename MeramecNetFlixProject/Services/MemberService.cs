using System;
using MeramecNetFlixProject.Data_Access_Layer;
using System.Windows.Forms;

namespace MeramecNetFlixProject.Services
{
    public class MemberService
    {
        public bool ValidateLogin(string username, string password)
        {
            //select customer from DB using MemberDB
            //match password field
            //return true if match, false if mismatch or customer not found

            var memberDB = new MemberDB();
            var member = memberDB.GetMember(username);

            if (member == null)
            {
                return false;
            }

            if (string.Equals(password, member.Password, StringComparison.Ordinal))
            {
                return true;
            }

            return false;

        }
    }
}