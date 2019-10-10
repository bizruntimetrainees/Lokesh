using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashtableConsoleApplication
{
    class MethodsInHashtable
    {
        public void Hashtable2()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Lokesh");
            ht.Add("2", "Karishma");
            ht.Add("3", "Bishnu prasad");
            ht.Add("4", "Kavya");
            ht.Add("5", "Gaurav");
            ht.Add("6", "Rahul");
            ht.Add("7", "Thanmai");

            Console.WriteLine("Count: {0}", ht.Count);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Contains key:{0}", ht.ContainsKey("2"));
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Contains value: {0}", ht.ContainsValue("Lokesh"));
            Console.WriteLine("---------------------------------");

            ICollection key = ht.Keys;

            foreach(string k in key)
            {
                Console.WriteLine(k+": " + ht[k]);
            }

            Console.WriteLine("---------------------------------");

            ht.Remove("4");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.WriteLine("---------------------------------");

            ht.Clear();
            Console.WriteLine("Count: {0}", ht.Count);


            Console.ReadKey();
        }
    }
}
