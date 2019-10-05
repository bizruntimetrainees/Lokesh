using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class NumberIsEvenOrOdd
    {
        public void EvenOdd()
        {
            int x;
            Console.Write("Enter Integer: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            Console.ReadKey(true);
        }
    }
}
