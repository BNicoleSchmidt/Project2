//The System.Data.SqlClient reference is needed to access SQL Server database

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MeramecNetFlixProject.Data_Access_Layer
{
    public class AccessDataSQLServer
    {
        private const string ConnectionString = "Data Source=198.209.220.125;Initial Catalog=Teamc;User ID=teamc;Password=teamc";

        public AccessDataSQLServer()
        {
            //198.209.220.125 Teamc teamc
        }
        
        public void TestConnection()
        {
            var cnn = new SqlConnection(ConnectionString);
            try
            {
                cnn.Open();
                MessageBox.Show(@"Connection Open!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Can not open connection: " + ex.Message);
            }
        }
    }

   
}
