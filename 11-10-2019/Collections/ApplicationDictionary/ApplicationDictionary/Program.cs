using System;
using System.Collections.Generic;
using System.Collections;


namespace ApplicationDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> countrycode = new Dictionary<int, string>();
            countrycode.Add(+91, "India");
            countrycode.Add(86, "China");
            countrycode.Add(56, "USA");
            countrycode.Add(78, "Ukrain");
            countrycode.Add(98, "Japan");
            countrycode.Add(34, "Korea");

            foreach (KeyValuePair<int, string> item in countrycode)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine(countrycode.ContainsKey(56));
            Console.WriteLine("-------------------------------------");

            Console.WriteLine(countrycode.Remove(56));
            Console.WriteLine("-------------------------------------");

            foreach (KeyValuePair<int, string> item in countrycode)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }
}
