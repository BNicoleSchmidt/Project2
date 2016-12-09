using System;
using MeramecNetFlixProject.Data_Access_Layer;
using MeramecNetFlixProject.Business_Objects;

namespace MeramecNetFlixProject.Services
{
    public class MemberService
    {
        public bool ValidateLogin(string username, string password)
        {
            var memberDB = new MemberDB();
            var member = memberDB.GetMember(username);

            if (member == null)
            {
                return false; 
            }

            return string.Equals(password, member.Password, StringComparison.Ordinal);
        }

        public Member GetMember(string username)
        {
            var memberDB = new MemberDB();
            return memberDB.GetMember(username);
        }

    }
 }