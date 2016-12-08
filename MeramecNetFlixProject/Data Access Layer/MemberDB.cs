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
                    throw new NotFoundException("Member not found");
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

        public bool DeleteMember(object Parameter)
        {
            //Pre-step: Replace the general object parameter with the appropriate business class object that you are using to delete from the underline database table.
            var SQLStatement = string.Empty;

            //Step# 1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object

            //Step #2: Code logic to create appropriate SQL Server objects calls
            //         Code logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program
            
            //Step #3: return false if record was not added successfully
            //         return true if record was added successfully

            return true; //temporary return until your code is fully flushed out. Remove or comment out this line
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
