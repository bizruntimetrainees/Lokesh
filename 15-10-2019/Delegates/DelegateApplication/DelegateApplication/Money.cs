using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApplication
{
    public delegate void ReturnMoney(int a);
    class Money
    {
        public void PrintNumber(int num)
        {
            Console.WriteLine("Number : {0,-12:N0} ",num);
        }
        public void Printmoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
    }
}
