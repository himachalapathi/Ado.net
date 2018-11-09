using System;
using System.Data.SqlClient;
using System.Configuration;
namespace ADOxamples
{
    class LeftOuter
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=Hemadri; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("Select * from studentIInfo left outer join classInfo on studentIInfo.class=classInfo.class", con);
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();

                while (sdr.Read())
                {
                    Console.WriteLine("ID : " + sdr["rollNo"] + "  NAME : " + sdr["name"] + " CLASS : " + sdr["class"] + " SUB1 : " + sdr["sub1"] + " SUB2 : " + sdr["sub2"] + " SUB3 : " + sdr["sub3"]);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}