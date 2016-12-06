using System;
using System.Collections.Generic;
using System.Linq;
using MeramecNetFlixProject.Business_Objects;

namespace MeramecNetFlixProject.Data_Access_Layer
{
    // ReSharper disable once InconsistentNaming
    public class MemberDB : AccessDataSQLServer
    {
        public List<Member> GetMembers()
        {
            const string sqlStatement = @"Select * from Member";
            var rawData = Query(sqlStatement);
            var members = new List<Member>();
            foreach (var item in rawData)
            {
                var member = MapMember(item);
                members.Add(member);
            }
            return members;
        }

        public Member GetMember(string loginName)
        {
            var sqlStatement = "Select * from Member where login_name = '" + loginName + "'";
            var rawData = Query(sqlStatement);
            if (rawData.Count < 1)
            {
                throw new Exception("Member not found");
            }
            if (rawData.Count > 1)
            {
                throw new Exception("Duplicate members found");
            }
            var item = rawData.First();
            return MapMember(item);
        }

        public bool AddMember(object Parameter)
        {
            //Pre-step: Replace the general object parameter with the appropriate business class object that you are using to insert data in the underline database table 
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object

            //Step #2: Code logic to create appropriate SQL Server objects calls
            //         Cod Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program
            
            //Step #3: return false if record was not added successfully
            //         return true if record was added successfully  
            
            return true; //temporary return until your code is fully flushed out. Remove or comment out this line
        }

        public bool UpdateMember(object Parameter)
        {
            //Pre-step: Replace the general object parameter with the appropriate business class object that you are using to update the underline database table. 
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object

            //Step #2: Code logic to create appropriate SQL Server objects calls
            //         Code logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program
            
            //Step #3: return false if record was not added successfully
            //         return true if record was added successfully           

            return true; //temporary return until your code is fully flushed out. Remove or comment out this line
        }

        public bool DeleteMember(object Parameter)
        {
            //Pre-step: Replace the general object parameter with the appropriate business class object that you are using to delete from the underline database table.
            string SQLStatement = String.Empty;

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
                Number = int.Parse(item[0].ToString()),
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
    }
}
