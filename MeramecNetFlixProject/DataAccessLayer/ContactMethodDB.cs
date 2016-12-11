using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.Exceptions;

namespace MeramecNetFlixProject.DataAccessLayer
{
    // ReSharper disable once InconsistentNaming
    public class ContactMethodDB : AccessDataSQLServer
    {
        public List<ContactMethod> GetContactMethods()
        {
            const string sqlStatement = @"Select * from Contact_Method";
            using (var com = new SqlCommand(sqlStatement))
            {
                var rawData = GetQuery(com);
                var contactMethods = new List<ContactMethod>();
                foreach (var item in rawData)
                {
                    var contactMethod = MapContactMethod(item);
                    contactMethods.Add(contactMethod);
                }
                return contactMethods;
            }
        }

        public ContactMethod GetContactMethod(int id)
        {
            var sqlStatement = "Select * from Contact_Method where id = @id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                var rawData = GetQuery(com);
                if (rawData.Count < 1)
                {
                    throw new NotFoundException("ContactMethod not found");
                }
                var item = rawData.First();
                return MapContactMethod(item);
            }
        }

        public bool AddContactMethod(ContactMethod contactMethod)
        {
            const string sqlStatement = "Insert into Contact_Method (name) values (@name)";
            return DoNonQuery(contactMethod, sqlStatement);
        }

        public bool UpdateContactMethod(ContactMethod contactMethod)
        {
            const string sqlStatement = "Update Contact_Method set name=@name where id=@id";
            return DoNonQuery(contactMethod, sqlStatement);
        }

        public bool DeleteContactMethod(int id)
        {
            var sqlStatement = "Delete from Contact_Method where id=@id";
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", id);
                return NonQuery(com);
            }
        }

        private static ContactMethod MapContactMethod(object[] item)
        {
            return new ContactMethod
            {
                Id = int.Parse(item[0].ToString()),
                Name = item[1].ToString().TrimEnd()
            };
        }

        private bool DoNonQuery(ContactMethod contactMethod, string sqlStatement)
        {
            using (var com = new SqlCommand(sqlStatement))
            {
                com.Parameters.AddWithValue("@id", contactMethod.Id);
                com.Parameters.AddWithValue("@name", contactMethod.Name);
                return NonQuery(com);
            }
        }
    }
}
