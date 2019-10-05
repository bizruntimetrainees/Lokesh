using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Array1
    {
        public void Arraya()
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine("content of the array");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
        
    }
}
