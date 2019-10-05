using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class ForLoop
    {
        public void SquareRoot()
        {
            int n;
            Console.Write("Enter number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine("Square of " + i + " is " + i * i);
            }
            Console.ReadKey(true);
        }
    }
}
