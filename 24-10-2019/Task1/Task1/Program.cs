using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.WriteLine("Enter Name");
            p.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter ExpiryDate");
            p.ExpiryDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter price");
            p.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter sizes");

            Console.WriteLine("Enter Array Size : ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] Sizes = new string[size];
            Console.WriteLine("Enter Values:");

            for (int i = 0; i < Sizes.Length; i++)
            {
                Sizes[i] = Convert.ToString(Console.ReadLine());
            }




            string output = JsonConvert.SerializeObject(p);
            Console.WriteLine(output);


            Console.ReadLine();
        }
    }
}
