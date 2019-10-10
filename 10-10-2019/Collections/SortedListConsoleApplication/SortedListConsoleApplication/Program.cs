using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace SortedListConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add("1", "Lokesh");
            sl.Add("2", "Karishma");
            sl.Add("3", "Bishnu prasad");
            sl.Add("4", "Kavya");
            sl.Add("5", "Gaurav");
            sl.Add("6", "Rahul");
            sl.Add("7", "Thanmai");

            Console.WriteLine("Count:{0}", sl.Count);
            Console.WriteLine("--------------------------------");

            ICollection key = sl.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Contains key: {0}",sl.ContainsKey("1"));
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Contains value: {0}", sl.ContainsValue("Bishnu prasad"));
            Console.WriteLine("--------------------------------");

            sl.Remove("4");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
            Console.WriteLine("--------------------------------");

            sl.RemoveAt(5);
            foreach(string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Index of key: {0}", sl.IndexOfKey("1"));
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Index of value:{0}", sl.IndexOfValue("Karishma"));
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Get key:{0}", sl.GetKey(2));
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Get by index:{0}", sl.GetByIndex(0));
            Console.WriteLine("--------------------------------");

            sl.Clear();
            Console.WriteLine("After clear");
            Console.WriteLine("Count:{0}", sl.Count);



            Console.ReadKey();
        }
    }
}
