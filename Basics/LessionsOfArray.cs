using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class LessionsOfArray
    {
        public void ArrayExample()
        {
            // Without array handling multiple variables
            //int n = 0;
            //int n1 = 0;
            //int n2 = 0;
            //int n3 = 0;
            //int n4 = 0;
            //int n5 = 0;
            //int n6 = 0;
            //int n7 = 0;
            //int n8 = 0;
            //int n9 = 0;
            //int n10 = 0;

            int[] n = new int[10];
            n[0] = 10;
            n[1] = 20;
            n[2] = 30;
            n[3] = 40;
            n[4] = 50;
            n[5] = 60;
            n[6] = 70;
            n[7] = 80;
            n[8] = 90;
            n[9] = 100;

            string[] names = new string[5];
            names[0] = "Rahul";
            names[1] = "Rohit";
            names[2] = "Raj";
            names[3] = "Ravi";
            names[4] = "Rajesh";

            Console.WriteLine("Array Example");
            Console.WriteLine("Enter the number elements in array");
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter the number");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Number at index " + i + " is " + numbers[i]);
            }
        }

        public void FindASmallestValue()
        {
            Console.WriteLine("Enter the number of values in an Array");
            int numberOfElements = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number elements in array");
            int[] numbers = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter the number");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int smallest = FindSmallest(numberOfElements, numbers);

            Console.WriteLine("The smallest value is ", smallest);
        }

        private static int FindSmallest(int numberOfElements, int[] numbers)
        {
            int smallest = numbers[0];
            for (int i = 1; i < numberOfElements; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            return smallest;
        }
    }
}
