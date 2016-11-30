//The System.Data.SqlClient reference is needed to access SQL Server database

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MeramecNetFlixProject.Data_Access_Layer
{
    // ReSharper disable once InconsistentNaming
    public class AccessDataSQLServer
    {
        private const string ConnectionString = "Data Source=198.209.220.125;Initial Catalog=Teamc;User ID=teamc;Password=teamc";

        public AccessDataSQLServer()
        {
            //198.209.220.125 Teamc teamc
        }

        public List<object[]> Query(string query)
        {
            var cnn = new SqlConnection(ConnectionString);
            try
            {
                cnn.Open();
                var com = new SqlCommand(query, cnn);
                var reader = com.ExecuteReader();
                var rows = new List<object[]>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var values = new object[reader.FieldCount];
                        reader.GetValues(values);
                        rows.Add(values);
                    }
                }
                reader.Close();
                return rows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"SQL Exception: " + ex.Message);
                return new List<object[]>();
            }
        }
    }

   
}
