using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    class MyThread
    {
        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread1 {0}", i);
                //Thread.Sleep(5000);
            }
            
        }
        
        public static void Thread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread2 {0}", i);
                
            }
        }

    }
}
