using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class CompareString
    {
        public void Comapre()
        {
            string s1, s2;

            Console.Write("Enter first string: ");
            s1 = Convert.ToString(Console.ReadLine());
            Console.Write("Enter second string: ");
            s2 = Convert.ToString(Console.ReadLine());

            if(s1==s2)
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
        }
    }
}
