using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class StudentInfoinsert
    {
        static void Main(string[] args)
        {
            new StudentInfoinsert().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=Hemadri; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into studentIInfo(rollNo, name, class)values('101', 'chenna', '6')", con);
                SqlCommand cm1 = new SqlCommand("insert into studentIInfo(rollNo, name, class)values('102', 'naveen', '7')", con);
                SqlCommand cm2 = new SqlCommand("insert into studentIInfo(rollNo, name, class)values('103', 'sateesh', '8')", con);
                SqlCommand cm3 = new SqlCommand("insert into studentIInfo(rollNo, name, class)values('104', 'raja', '9')", con);
                SqlCommand cm4 = new SqlCommand("insert into studentIInfo(rollNo, name, class)values('105', 'hemadri', '10')", con); 
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                cm1.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();

                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
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