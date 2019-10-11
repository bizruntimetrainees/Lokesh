using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ApplicationStack
{
    interface Icars
    {
        void Add();
        void Remove();
        void Retriev();
        void Present();
        
        
    }
    class Implements : Icars
    {

        public void Add()
        {

            Stack product = new Stack();
            product.Push("BMW");
            product.Push("Lamborgini");
            product.Push("Ferrari");
            product.Push("Audi");
            product.Push("Benze");
            product.Push("Koenigsegg");


            foreach (string i in product)
            {
                Console.WriteLine(i);
            }

        }

        public void Retriev()
        {
            Stack product = new Stack();
            product.Push("BMW");
            product.Push("Lamborgini");
            product.Push("Ferrari");
            product.Push("Audi");
            product.Push("Benze");
            product.Push("Koenigsegg");

            Console.WriteLine(product.Peek());

        }

        public void Present()
        {
            Stack product = new Stack();
            product.Push("BMW");
            product.Push("Lamborgini");
            product.Push("Ferrari");
            product.Push("Audi");
            product.Push("Benze");
            product.Push("Koenigsegg");

            Console.WriteLine(product.Contains("Koenigsegg"));

        }
        public void Remove()
        {
            Stack product = new Stack();
            product.Push("BMW");
            product.Push("Lamborgini");
            product.Push("Ferrari");
            product.Push("Audi");
            product.Push("Benze");
            product.Push("Koenigsegg");


            while (product.Count > 0)
            {
                Console.WriteLine(product.Pop());
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine(product.Count);

        }
        

    }
}
