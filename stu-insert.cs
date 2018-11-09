using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class insert
    {
        static void Main(string[] args)
        {
            new insert().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=Hemadri; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into stu(id, sname, address, join_date)values('101', 'RonaldTrump', 'kerala', '1/12/2017')", con);
                SqlCommand cm1 = new SqlCommand("insert into stu(id, sname, address, join_date)values('102', 'naveen', 'andhrapradeh1', '11/12/2017')", con);
                SqlCommand cm2 = new SqlCommand("insert into stu(id, sname, address, join_date)values('103', 'sateesh', 'anantapuram', '11/12/2017')", con);
                SqlCommand cm3 = new SqlCommand("insert into stu(id, sname, address, join_date)values('104', 'raja', 'rajamandry', '11/12/2017')", con);
                SqlCommand cm4 = new SqlCommand("insert into stu(id, sname, address, join_date)values('105', 'hemadri', 'chittoor', '11/12/2017')", con);// Opening Connection  
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