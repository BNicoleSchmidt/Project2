using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MeramecNetFlixProject.Business_Objects;
using MeramecNetFlixProject.Exceptions;

namespace MeramecNetFlixProject.Data_Access_Layer
{
    // ReSharper disable once InconsistentNaming
    public class MemberDB : AccessDataSQLServer
    {
        public List<Member> GetMembers()
        {
            const string sqlStatement = @"Select * from Member";
            using (var com = new SqlCommand(sqlStatement))
            {
                var rawData = GetQuery(com);
                var members = new List<Member>();
                foreach (var item in rawData)
                {
                    var member = MapMember(item);
                    members.Add(member);
                }
                return members;
            }
        }

        public Member GetMember(string loginName)
        {
            var sqlStatement = "Select * from Member where login_name = @loginname";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@loginname", loginName);
                var rawData = GetQuery(com);
                if (rawData.Count < 1)
                {
                    return null;
                }
                if (rawData.Count > 1)
                {
                    throw new DuplicateEntryException("Duplicate members found");
                }
                var item = rawData.First();
                return MapMember(item);
            }
        }

        public bool AddMember(Member member)
        {
            const string sqlStatement = "Insert into Member (joindate, firstname, lastname, address, city, state, zipcode, phone, member_status, login_name, password, email, contact_method, subscription_id, photo, is_admin) values " +
                                        "(@joindate, @firstname, @lastname, @address, @city, @state, @zipcode, @phone, @member_status, @login_name, @password, @email, @contact_method, @subscription_id, @photo, @is_admin)";
            return DoNonQuery(member, sqlStatement);
        }

        public bool UpdateMember(Member member)
        {
            const string sqlStatement = "Update Member set joindate=@joindate, firstname=@firstname, lastname=@lastname, address=@address, city=@city, " +
                                        "state=@state, zipcode=@zipcode, phone=@phone, member_status=@member_status, login_name=@login_name, password=@password, email=@email, " +
                                        "contact_method=@contact_method, subscription_id=@subscription_id, photo=@photo, is_admin=@is_admin where id=@id";
            return DoNonQuery(member, sqlStatement);
        }

        public bool DeleteMember(int id)
        {
            var sqlStatement = "Delete from Member where id=@id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                return NonQuery(com);
            }
        }

        private static Member MapMember(object[] item)
        {
            return new Member
            {
                Id = int.Parse(item[0].ToString()),
                JoinDate = (DateTime)item[1],
                FirstName = item[2].ToString().TrimEnd(),
                LastName = item[3].ToString().TrimEnd(),
                Address = item[4].ToString().TrimEnd(),
                City = item[5].ToString().TrimEnd(),
                State = item[6].ToString(),
                Zipcode = int.Parse(item[7].ToString()),
                Phone = item[8].ToString().TrimEnd(),
                MemberStatus = item[9].ToString(),
                LoginName = item[10].ToString().TrimEnd(),
                Password = item[11].ToString().TrimEnd(),
                Email = item[12].ToString().TrimEnd(),
                ContactMethod = int.Parse(item[13].ToString()),
                SubscriptionId = int.Parse(item[14].ToString()),
                Photo = item[15].ToString().TrimEnd(),
                IsAdmin = (bool)item[16]
            };
        }

        private bool DoNonQuery(Member member, string sqlStatement)
        {
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", member.Id);
                com.Parameters.AddWithValue("@joindate", member.JoinDate);
                com.Parameters.AddWithValue("@firstname", member.FirstName);
                com.Parameters.AddWithValue("@lastname", member.LastName);
                com.Parameters.AddWithValue("@address", member.Address);
                com.Parameters.AddWithValue("@city", member.City);
                com.Parameters.AddWithValue("@state", member.State);
                com.Parameters.AddWithValue("@zipcode", member.Zipcode);
                com.Parameters.AddWithValue("@phone", member.Phone);
                com.Parameters.AddWithValue("@member_status", member.MemberStatus);
                com.Parameters.AddWithValue("@login_name", member.LoginName);
                com.Parameters.AddWithValue("@password", member.Password);
                com.Parameters.AddWithValue("@email", member.Email);
                com.Parameters.AddWithValue("@contact_method", member.ContactMethod);
                com.Parameters.AddWithValue("@subscription_id", member.SubscriptionId);
                com.Parameters.AddWithValue("@photo", member.Photo);
                com.Parameters.AddWithValue("@is_admin", member.IsAdmin);
                return NonQuery(com);
            }
        }
    }
}
