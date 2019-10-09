using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class UsingForLoop
    {
        public void Array1()
        {
            int[] arr = new int[100];

            for (int j = 0; j < 56; j++)
            {
                Console.WriteLine("Element[{0}] = {0}", j, arr[j]);
            }
            Console.ReadKey();
        }
    }
}
