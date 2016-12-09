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

        public List<object[]> GetQuery(SqlCommand com)
        {
            using (var cnn = new SqlConnection(ConnectionString))
            {
                try
                {
                    com.Connection = cnn;
                    cnn.Open();
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

        public bool NonQuery(SqlCommand com)
        {
            using (var cnn = new SqlConnection(ConnectionString))
            {
                try
                {
                    com.Connection = cnn;
                    cnn.Open();
                    var result = com.ExecuteNonQuery();
                    cnn.Close();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"SQL Exception: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
