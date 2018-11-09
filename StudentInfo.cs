using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOExamples
{
    class StudentInfo
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=Hemadri; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("create table studentIInfo(rollNo int unique,name varchar(100),class varchar(100))", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Student Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}