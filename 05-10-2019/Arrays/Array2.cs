using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Array2
    {
        public void Arrayb()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter elements of array");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Value of arr[" + i + "]-");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Content of the array");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
            
    }
}
