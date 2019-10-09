using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class ReverseString
    {
        public void Reverse()
        {
            string name, revname = "";

            Console.Write("Enter String: ");
            name =Convert.ToString(Console.ReadLine());

            for (int i = name.Length; i > 0; i--)
            {
                revname = revname + name[i];
            }
            Console.WriteLine("Reverse of String: " + revname);

        }
    }
}
