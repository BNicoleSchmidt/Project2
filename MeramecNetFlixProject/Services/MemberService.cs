using System;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.Services
{
    public class MemberService
    {
        private readonly MemberDB _memberDb;
        public MemberService()
        {
            _memberDb = new MemberDB();
        }
        public bool ValidateLogin(string username, string password)
        {
            var member = _memberDb.GetMember(username);

            if (member == null)
            {
                return false; 
            }

            return string.Equals(password, member.Password, StringComparison.Ordinal);
        }
    }
 }