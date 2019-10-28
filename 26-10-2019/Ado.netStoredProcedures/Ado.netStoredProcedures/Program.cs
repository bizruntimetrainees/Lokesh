using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ado.netStoredProcedures
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4VSIHKJ;Initial Catalog=LOKESH;Integrated Security=True");
            //string query1 =
            //  @"
            //    CREATE PROCEDURE Insert_Records
            //    (
            //    @Name VARCHAR(50),
            //    @Price VARCHAR(50),
            //    @Date DATETIME
            //    )
            //  AS
            //    INSERT INTO Products(Name,Price,Date) Values(@Name,@Price,@Date)
            //";

            //SqlCommand cmd = new SqlCommand(query1, con);
            //try
            //{
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    Console.WriteLine("Store Procedure Created Successfully");
            //}
            //catch (SqlException e)
            //{
            //    Console.WriteLine("Error Generated. Details: " + e.ToString());
            //}
            //finally
            //{
            //    con.Close();
            //    Console.ReadKey();
            //}


            SqlCommand cmd = new SqlCommand("Insert_Records", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Name", "SSD DRIVE"));
                cmd.Parameters.Add(new SqlParameter("@Price", "$300"));
                cmd.Parameters.Add(new SqlParameter("@Date", "25 August 14"));
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Records Inserted Successfully.");
                }

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
