using System; // #include stdio.h
// high level program

namespace Maths  // Collection of classes
{
    internal class Program // Collection of member vaiable and Member function
    {
        static void Main(string[] args) // function
        {
            #region Lession 1
            //if (args.Length > 0)
            //{
            //    foreach (var item in args)
            //    {
            //        Console.WriteLine("Hello, " + item + "!");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Hello, World!");
            //    Console.WriteLine("Hello, World!");
            //}
            #endregion lession1


            string strA = "";
            string strB = "";

            int a;
            int b;
            int c;

            Console.WriteLine("Please enter value for A");
            strA = Console.ReadLine();
            Console.WriteLine("Please enter value for B");
            strB = Console.ReadLine();

            a = int.Parse(strA);
            b = int.Parse(strB);

            c = a + b;

            Console.WriteLine("Sum of a and b is " + c);


            Console.ReadLine();
        }
    }
}
