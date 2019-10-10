using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using OpenQA.Selenium;

namespace HashtableConsoleApplication
{
    class Hashtable1
    {
        public void StudentDetails()
        {
            Hashtable ht = new Hashtable();

            ht.Add("1", "Zara Ali");
            ht.Add("2", "Abida Rehman");
            ht.Add("3", "Joe Holzner");
            ht.Add("4", "Mausam Benazir Nur");
            ht.Add("5", "M. Amlan");
            ht.Add("6", "M. Arif");
            ht.Add("7", "Ritesh Saikia");

            ICollection key = ht.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();

        }
    }
}
