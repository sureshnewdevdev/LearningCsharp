using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Basics
{
    public class CollectionExamples
    {
        static void Main(string[] args)
        {
            ArrayList arrayList= new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Raja");
            arrayList.Add(1.2);
            arrayList.Add(1.2f);
            arrayList.Add(1.2m);
            arrayList.Add(1.2d);
            arrayList.Add(true);
            // 10 is converted  to object then it is added to the list
            // When we read the value we need to cast it to the original type

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine("**********************************************************************");
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
                
            stack.Push(4);

            int len = stack.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();
        }
    }
}
