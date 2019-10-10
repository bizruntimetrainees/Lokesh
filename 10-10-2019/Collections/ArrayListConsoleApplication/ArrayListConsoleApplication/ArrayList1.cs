using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListConsoleApplication
{
    class ArrayList1
    {
        public void Array()
        {
            ArrayList a1 = new ArrayList();

            Console.WriteLine("Adding some numbers");
            a1.Add(98);
            a1.Add(76);
            a1.Add(34);
            a1.Add(322);
            a1.Add(43);
            a1.Add(12);
            a1.Add(22);
            a1.Add(10);

            Console.WriteLine("Capacity: {0}", a1.Capacity);
            Console.WriteLine("Count: {0}", a1.Count);
            Console.WriteLine("Content: ");
            foreach(int i in a1)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            a1.Sort();
            foreach (int i in a1)
            {
                Console.Write(i + " ");
            }

            a1.Remove(43);

            Console.WriteLine("Count: {0}", a1.Count);

            Console.WriteLine("Content: ");
            foreach (int i in a1)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            a1.Sort();
            foreach (int i in a1)
            {
                Console.Write(i + " ");
            }

                Console.WriteLine();
            Console.ReadKey();
        }
    }
}
