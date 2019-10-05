using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern4
    {
        public void Patternd()
        {
            for (int i = 65; i <= 70; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write((char)i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
