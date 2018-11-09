using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Create
    {
        static void Main(string[] args)
        {
            new Create().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=Hemadri; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table stu(id int not null,sname varchar(100), address varchar(100), join_date date)", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}