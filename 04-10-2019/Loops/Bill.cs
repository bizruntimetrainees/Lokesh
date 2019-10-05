using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class Bill
    {
        public void Ifelseif()
        {
            int amount;
            Console.Write("Enter your bill amount: ");
            amount = Convert.ToInt32(Console.ReadLine());
            if(amount>=100)
            {
                amount = amount - 200;
            }
            else if(amount>=500)
            {
                amount = amount - 100;
            }
            else if(amount>=100)
            {
                amount = amount - 50;
            }
            else
            {
                Console.WriteLine("no discount");
            }
            Console.WriteLine("Bill to pay after discount: " + amount);
            Console.ReadKey(true);
        }
    }
}
