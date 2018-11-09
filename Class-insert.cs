using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Classinsert
    {
        static void Main(string[] args)
        {
            new Classinsert().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
               
                con = new SqlConnection("data source=.; database=Hemadri; integrated security=SSPI");
               
                SqlCommand cm = new SqlCommand("insert into classInfo(class, sub1, sub2, sub3)values('6', '86', '54', '17')", con);
                SqlCommand cm1 = new SqlCommand("insert into classInfo(class, sub1, sub2, sub3)values('7', '89', '74', '57')", con);
                SqlCommand cm2 = new SqlCommand("insert into classInfo(class, sub1, sub2, sub3)values('8', '86', '54', '87')", con);
                SqlCommand cm3 = new SqlCommand("insert into classInfo(class, sub1, sub2, sub3)values('9', '06', '04', '07')", con);
                SqlCommand cm4 = new SqlCommand("insert into classInfo(class, sub1, sub2, sub3)values('10', '86', '54', '17')", con);
                con.Open();
               
                cm.ExecuteNonQuery();
               cm1.ExecuteNonQuery();

                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();

                
                Console.WriteLine("Record Inserted Successfully");
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