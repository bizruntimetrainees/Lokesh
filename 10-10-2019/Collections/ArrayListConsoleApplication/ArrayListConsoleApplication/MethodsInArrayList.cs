using System;
using System.Collections;

namespace ArrayListConsoleApplication
{
    class MethodsInArrayList
    {
        public void ArrayList3()
        {
            ArrayList l1 = new ArrayList();
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);
            l1.Add(6);

            ArrayList l2 = new ArrayList();
            l2.Add(9);
            l2.Add(8);
            l2.Add(7);
            l2.Add(6);

            l2.AddRange(l1);
            foreach(int i in l2)
            {
                Console.WriteLine("Content: {0}",i);
            }
            l2.Sort();
            foreach(int i in l2)
            {
                Console.WriteLine("Sorted Content: {0} ", i);
            }
            Console.WriteLine("Count: {0}", l2.Count);

            l2.Reverse();
            foreach (int i in l2)
            {
                Console.WriteLine("Reverse Content: {0} ", i);
            }


            l2.Remove(6);
            foreach (int i in l2)
            {
                Console.WriteLine("Sorted Content: {0} ", i);
            }
            Console.WriteLine("IndexOf:{0} ", l2.IndexOf(6));

            
            l2.Insert(4, 3);
            foreach (int i in l2)
            {
                Console.WriteLine("Add Index Content: {0}", i);
            }

            l2.RemoveAt(4);
            foreach (int i in l2)
            {
                Console.WriteLine("Remove Index Content: {0}", i);
            }

            Console.WriteLine("Contains:{0}", l2.Contains(3));

            l2.Clear();
            Console.WriteLine("Count:{0}", l2.Count);
            



            Console.ReadKey();
        }
        
    }
}
