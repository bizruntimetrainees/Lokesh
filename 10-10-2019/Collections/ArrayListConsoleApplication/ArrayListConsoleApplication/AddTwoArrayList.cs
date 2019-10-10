using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListConsoleApplication
{
    class AddTwoArrayList
    {
        public void ArrayList2()
        {
            ArrayList list1 = new ArrayList();

            list1.Add(3);
            list1.Add(7);

            ArrayList list2 = new ArrayList();

            list2.Add(6);
            list2.Add(14);

            list1.AddRange(list2);

            foreach(int i in list1 )
            {
                Console.WriteLine("Content: {0}", i);
            }
            
            Console.ReadKey();
        }
    }
}
