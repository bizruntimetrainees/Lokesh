using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern2
    {
        public void Patternb()
        {
            for (int i = 1; i <= 5; i++) 
            {
                for (int j = 1; j <= 5; j++) 
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
