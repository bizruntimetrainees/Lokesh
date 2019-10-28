using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoInsertDeleteRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4VSIHKJ;Initial Catalog=LOKESH;Integrated Security=True");
            string query = "INSERT INTO Customers (CustomerId,Name,Location,Email) VALUES('5','Thanmai','Nellore','thanmai.c@bizruntime.net')";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
