using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class DoWhile
    {
        public void Loop()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Inside Loop");
                Console.WriteLine("Press 2 to exit: ");
                i = Convert.ToInt32(Console.ReadLine());
            } while (2 != 0);
            Console.WriteLine("Out of loop");
            Console.ReadKey(true);

            
        }
    }
}
