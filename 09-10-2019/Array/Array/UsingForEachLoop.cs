using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class UsingForEachLoop
    {
        public void Array2()
        {
            int[] arr = new int[100];

            for (int i = 0; i < 10; i++)
            
            {
                arr[i] = i + 100;
            }

            foreach (int j in arr)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
            Console.ReadKey();
        }   
    }
}
