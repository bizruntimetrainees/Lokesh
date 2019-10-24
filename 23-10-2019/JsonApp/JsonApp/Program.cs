using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            p.Name = "Apple";
            p.ExpiryDate = new DateTime(2019, 10, 23);
            p.Price = 3.99;
            p.Sizes = new string[] { "Small", "Medium", "Large" };

            string output = JsonConvert.SerializeObject(p);
            Console.WriteLine(output);

            Product newOutput = JsonConvert.DeserializeObject<Product>(output);

            Console.WriteLine(newOutput);
            Console.WriteLine("Name : " + newOutput.Name);
            Console.WriteLine("ExpiryDate : " + newOutput.ExpiryDate);
            Console.WriteLine("Price : " + newOutput.Price);
            //Console.WriteLine("Sizes : " + JsonConvert.SerializeObject(newOutput.Sizes));
            //Console.WriteLine(newOutput.Sizes[0]);
            //Console.WriteLine(newOutput.Sizes[1]);
            //Console.WriteLine(newOutput.Sizes[1]);

            foreach (string i in newOutput.Sizes)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------------------------------------");

            JsonSerializer s = new JsonSerializer();
            s.Converters.Add(new JavaScriptDateTimeConverter());
            s.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"C:\Users\C LOKESH\source\repos\JsonApp\JsonApp\test.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                s.Serialize(writer, p);
                Console.WriteLine("Stored");


            }

            Console.WriteLine("------------------------------------------------------");


            using (StreamReader sr = new StreamReader(@"C:\Users\C LOKESH\source\repos\JsonApp\JsonApp\test.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                var x= s.Deserialize(reader);
                Console.WriteLine(x);
            }

           



            Console.ReadKey();
        }
    
    }
}
