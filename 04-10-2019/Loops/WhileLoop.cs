using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class WhileLoop
    {
        public void Loop()
        {
            int i = 0;
            while(i!=3)
            {
                Console.WriteLine("Inside loop");
                Console.WriteLine("Enter 3 to exit: ");
                i = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Out of loop");
            Console.ReadKey(true);
        }
    }
}
