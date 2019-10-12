using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before start thread");

            Thread tid1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread tid2 = new Thread(new ThreadStart(MyThread.Thread2));
            Thread tid3 = new Thread(new ThreadStart(MyThread.Thread1));

            tid1.Start();
            tid2.Start();
            tid3.Start();

            try
            {
                tid1.Abort();
                tid2.Abort();
            }
            catch (ThreadAbortException tae)
            {
                Console.WriteLine(tae.ToString());
            }
            Console.WriteLine("End of Main");

            tid1.Join();

            //tid2.Priority = ThreadPriority.Highest;
            //tid1.Priority = ThreadPriority.Lowest;


            Console.ReadLine();
        }
        
        
    }
}
