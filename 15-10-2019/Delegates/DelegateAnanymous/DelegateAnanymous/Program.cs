using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnanymous
{
    class Program
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            int i = 33;
            Print pr = delegate (int val)
            {
                val = val + i;
                Console.WriteLine("Anonymous method: {0}", val);
            };
            pr(300);

            Console.ReadKey();
        }
    }
}
