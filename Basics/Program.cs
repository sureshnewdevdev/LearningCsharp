using Microsoft.VisualBasic;

namespace Maths  // Collection of classes
{
    internal class Program // Collection of member vaiable and Member function
    {
        //static void Main(string[] args) // function
        //{
        //    Console.WriteLine("Enter the value for A");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the value for B");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the value for C");
        //    int c = int.Parse(Console.ReadLine());

        //    #region Nested if statement
        //    //Nested if statement
        //    //if (a > b)
        //    //{
        //    //    if (a > c)
        //    //    {
        //    //        Console.WriteLine("A is greater");
        //    //    }
        //    //    else
        //    //    {
        //    //        Console.WriteLine("C is greater");
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    if (b > c)
        //    //    {
        //    //        Console.WriteLine("B is greater");
        //    //    }
        //    //    else
        //    //    {
        //    //        Console.WriteLine("C is greater");
        //    //    }
        //    //}
        //    #endregion

        //    #region if else if statement
        //    if (a > b && a > c) // AND Condition
        //    {
        //        Console.WriteLine("A is greater");
        //    }
        //    else if (b > c)
        //    {
        //        Console.WriteLine("B is greater");
        //    }
        //    else
        //    {
        //        Console.WriteLine("C is greater");
        //    }
        //    #endregion


        //}

        #region Example for OR
        //static void Main()
        //{
        //    int age = 20;
        //    string country = "USA";

        //    if (age >= 18 || country == "India")
        //    {
        //        Console.WriteLine("Eligible for the program.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not eligible for the program.");
        //    }
        //}
        #endregion

        #region Example for NOT
        //static void Main()
        //{
        //    int n = 0;
        //    if (n != 0)
        //    {
        //        Console.WriteLine("The number is not zero.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The number is zero.");
        //    }

        //    if (!(n == 0))
        //    {
        //        Console.WriteLine("The number is not zero.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The number is zero.");
        //    }

        //    n = 0;
        //    bool result = !(n == 0);


        //}
        #endregion

        #region If else if statement
        static void Main()
        {
            string fruitName = string.Empty;

            Console.WriteLine("Enter the fruit name");
            fruitName = Console.ReadLine();

            if (fruitName == "Apple")
            {
                Console.WriteLine("The fruit is Apple");
            }
            else if (fruitName == "Banana")
            {
                Console.WriteLine("The fruit is Banana");
            }
            else if (fruitName == "Mango")
            {
                Console.WriteLine("The fruit is Mango");
            }
            else
            {
                Console.WriteLine("The fruit is not available");
            }
            #endregion
        }
    }
}




