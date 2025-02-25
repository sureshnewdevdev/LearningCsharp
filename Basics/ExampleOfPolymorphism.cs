using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Polymorphism is one of the key principles of Object-Oriented Programming (OOP). 
 * It allows a method to have multiple implementations based on the object that invokes it. 
 * Polymorphism can be achieved in C# in two ways:

1. Compile-time (Method Overloading)
2. Runtime (Method Overriding)
*/

namespace Basics
{
    // Example for Compile-time (Method Overloading)
    public class ExampleOfPolymorphism
    {
        public ExampleOfPolymorphism()
        {
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Add(float n, int m)
        {
            return  (int)n + m;
        }
        public static int Add( int m, float n)
        {
            return (int)n + m;
        }
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public static void Main(string[] args)
        {
            int c = Add(10, 20);
            Console.WriteLine( "Addition ="+c);
        }
    }
}
