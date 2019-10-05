using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern5
    {
        public void Patterne()
        {
            for (int i = 65; i <= 70; i++)
            {
                for (int j = 65; j <= 70; j++)
                {
                    Console.Write((char)j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
