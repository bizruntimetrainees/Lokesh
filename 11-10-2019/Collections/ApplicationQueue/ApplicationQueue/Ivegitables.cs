using System;
using System.Collections.Generic;
using System.Collections;

namespace ApplicationQueue
{
    interface Ivegitables
    {
            void Add();
            void Remove();
            void Retriev();
            void Present();
    }
    class Implements : Ivegitables
    {
        public void Add()
        {
            Queue vegitable = new Queue();
            vegitable.Enqueue("Carraot");
            vegitable.Enqueue("Beans");
            vegitable.Enqueue("nuts");

            foreach (string i in vegitable)
            {
                Console.WriteLine(i);
            }
        }
        public void Retriev()
        {
            Queue vegitable = new Queue();
            vegitable.Enqueue("Carraot");
            vegitable.Enqueue("Beans");
            vegitable.Enqueue("nuts");

            Console.WriteLine(vegitable.Peek());
        }
        public void Present()
        {
            Queue vegitable = new Queue();
            vegitable.Enqueue("Carraot");
            vegitable.Enqueue("Beans");
            vegitable.Enqueue("nuts");

            Console.WriteLine(vegitable.Contains("nuts"));
        }
        public void Remove()
        {
            Queue vegitable = new Queue();
            vegitable.Enqueue("Carraot");
            vegitable.Enqueue("Beans");
            vegitable.Enqueue("nuts");

            while (vegitable.Count > 0)
            {
                Console.WriteLine(vegitable.Dequeue());
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine(vegitable.Count);
        }
        
        
    }
}
