using System;
using System.Collections.Generic;
using MeramecNetFlixProject.Business_Objects;
//The System.Data.SqlClient reference is needed to access SQL Server database

namespace MeramecNetFlixProject.Data_Access_Layer
{
    // ReSharper disable once InconsistentNaming
    public class MemberDB : AccessDataSQLServer
    {
        
        //Instructions: 
        //Replace all ???TableNameHere phrases with the name of your specific SQL Server Database Table Name
        //Replace yourCustomeObject phrase with the name of the business object (represents database table name) you are referencing or returning
        //Replace datatype phrase with the appropriate C# data type or custom data type based on Project #2 CRUD specs
        //Replace parameter phrase with the appropriate input parameter based on Project #2 CRUD specs
        //Refer to the ADO.Net Demo for method examples below
        
        
        public List<Member> GetMembers()
        {
            //Change the MyCustomObject name to your customer business object that is returning data from the specific table
            List<Member> objTemp = new List<Member>();
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object

            //Step #2: Code Logic to create appropriate SQL Server objects calls
            //         Code Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            //Step #3: Return the objtemp generic list variable  back to the calling UI 
            
            return objTemp;
        }
      
               
        public Member GetMember(object Parameter)
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            Member objTemp = new Member();
           

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object

            //Step #2: Code logic to create appropriate SQL Server objects calls
            //         Code logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program            

            //Step #3: Return the objtemp variable back to the calling UI 
            return objTemp;
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

    }
}
