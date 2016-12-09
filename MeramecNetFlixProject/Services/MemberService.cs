using System;
using MeramecNetFlixProject.Data_Access_Layer;
using MeramecNetFlixProject.Business_Objects;

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

        public Member GetMember(string username)
        {
            return _memberDb.GetMember(username);
        }

    }
 }