using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApplication
{
    public delegate void linktoeventhandler();
    class Master
    {
        public string name;
        public Master(string argname)
        {
            name = argname;
        }
        public void eventhandler()
        {
            Console.WriteLine("Notification from {0} ", name);
        }
    }
    class Program
    {
        public static event linktoeventhandler evt;
        public static void Sendnotifications()
        {
            if (evt!=null)
            {
                evt();
            }
        }
        static void Main(string[] args)
        {
            Master m1 = new Master("Objects of master");
            evt += new linktoeventhandler(m1.eventhandler);

            Master m2 = new Master("Objects2 of master");
            evt += new linktoeventhandler(m2.eventhandler);

            Master m3 = new Master("Objects3 of master");
            evt += new linktoeventhandler(m3.eventhandler);


            Sendnotifications();
            Console.ReadKey();
        }
    }
}
