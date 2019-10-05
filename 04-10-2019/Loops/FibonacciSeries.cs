using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class FibonacciSeries
    {
        public void Fibonaccis()
        {
            int num1 = 0, num2 = 1, n;
            int user_no;
            int count = 0;

            Console.Write("Enter any Number: ");
            user_no = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                n = num1 + num2;
                count++;
                if (n >= user_no)
                {
                    break;
                }
                num1 = num2;
                num2 = n;
                Console.Write(" "+n+" ");
            }
            Console.ReadKey();
        }
    }
}
