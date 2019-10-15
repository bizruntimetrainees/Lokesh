using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Money obj = new Money();
            ReturnMoney obj1 = new ReturnMoney(obj.PrintNumber);
            ReturnMoney obj2 = new ReturnMoney(obj.Printmoney);

            /*obj1(10000);
            obj1(200);

            obj2(10000);
            obj2(200);*/

            obj1.Invoke(10000);
            obj1.Invoke(200);

            obj2.Invoke(10000);
            obj2.Invoke(200);

            Console.ReadKey();
        }
    }
}
