using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AdoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=DESKTOP-4VSIHKJ;Initial Catalog=LOKESH;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "select * from Customers";
            
            con.Open();
            
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " +reader[3].ToString());
            }
            con.Close();



            Console.ReadLine();
        }
    }
}
