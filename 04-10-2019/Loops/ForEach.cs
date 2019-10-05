using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class ForEach
    {
        public void Iteratation()
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            foreach (int k in arr)
            {
                Console.WriteLine("" + k);
            }
            Console.ReadKey(true);
        }
    }
}
