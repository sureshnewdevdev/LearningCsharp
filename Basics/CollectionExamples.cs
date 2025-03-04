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
            ArrListExample();
            Console.WriteLine("**********************************************************************");
            StackExample();

            HashTableExample();
            QueueExample();
            ExampleOfSortedList();
            Console.ReadLine();
        }

        private static void ExampleOfSortedList()
        {
            // Creating a SortedList
            SortedList sortedList = new SortedList();

            // Adding key-value pairs
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");

            // Display elements (sorted by key)
            Console.WriteLine("SortedList Elements:");
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            // Removing an element
            sortedList.Remove(2);
            Console.WriteLine("\nAfter Removing key 2:");
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        private static void QueueExample()
        {

           
            // Creating a Queue
            Queue queue = new Queue();

            // Enqueueing elements
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue(4);

            // Dequeueing (removes front)
            Console.WriteLine("Dequeued: " + queue.Dequeue());

            // Peek (view front element)
            Console.WriteLine("Front Element: " + queue.Peek());

            // Display remaining elements
            Console.WriteLine("\nQueue Elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        private static void HashTableExample()
        {
            // Creating a Hashtable
            Hashtable ht = new Hashtable();

            // Adding key-value pairs
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add("Raja", "Rani");

            Person p = new Person { PersonId= 1, PersonName="Tulsi" };

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            ht.Add("Stack Sub Collection", stack);

            // Can Store custom Objects
            ht.Add( "Person Object",p);


            // Printing the value of key "Raja"
            Console.WriteLine(ht["Raja"]);

            // Displaying Hashtable
            Console.WriteLine("Hashtable Elements:");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            // Accessing value using key
            Console.WriteLine($"\nValue for key 2: {ht[2]}");

            // Removing an element
            ht.Remove(1);
            Console.WriteLine("\nAfter Removing key 1:");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        private static void StackExample()
        {
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
        }

        private static void ArrListExample()
        {
            ArrayList arrayList = new ArrayList();
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
        }
    }
}
