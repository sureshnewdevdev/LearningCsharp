using Microsoft.VisualBasic;
using System.Threading.Channels;

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


        //static void Main()
        //{
        #region If else if statement
        //string fruitName = string.Empty;

        //Console.WriteLine("Enter the fruit name");
        //fruitName = Console.ReadLine();

        //if (fruitName == "Apple")
        //{
        //    Console.WriteLine("The fruit is Apple");
        //}
        //else if (fruitName == "Banana")
        //{
        //    Console.WriteLine("The fruit is Banana");
        //}
        //else if (fruitName == "Mango")
        //{
        //    Console.WriteLine("The fruit is Mango");
        //}
        //else
        //{
        //    Console.WriteLine("The fruit is not available");
        //}
        #endregion

        #region Switch operator
        // Switch case statement
        //string fruit = string.Empty;
        //Console.WriteLine("Enter the fruit name");
        //fruit = Console.ReadLine();
        //switch (fruit)
        //{
        //    case "Apple":
        //        Console.WriteLine("The fruit is Apple");
        //        return; // Mandatory
        //    case "Banana":
        //        Console.WriteLine("The fruit is Banana");
        //        break;
        //    case "Mango":
        //        Console.WriteLine("The fruit is Mango");
        //        break;
        //    //default:
        //    //    Console.WriteLine("The fruit is not available");
        //    //    break;
        //}

        // input a,b, choice
        //    if choice is +then add a, b
        //            if choice is -then sub a, b
        //            if choice is *then mul a, b
        //            if choice is / then div a, b
        //
        // if , else if, else if, else, switch case, ternary operator
        #endregion
        //}


        //For loop
        //static void Main()
        //{
        //    //for (int i = 2; i <= 10; i=i+2)
        //    int sum = 0;
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        sum = sum + i;
        //    }
        //    Console.Write("Sum = ");
        //    Console.WriteLine(sum);
        //    //Write a program to summ all the odd numbers between 1 to n
        //}

        //Nested for loop
        //static void Main()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {

        //        Console.WriteLine("******** i  " + i);
        //        for (int j = 1; j <= 5; j++)
        //        {

        //            Console.WriteLine("**************************** j " + j);
        //        }

        //    }

        //    Console.WriteLine("Enter the value for n");
        //    int n = int.Parse(Console.ReadLine());
        //    // 3,5,7,...n
        //    int sum = 0;
        //    for (int i = 3; i < n; i += 2)
        //    {
        //        // i = 10;
        //        sum = sum + i;
        //        Console.WriteLine(i);

        //    }
        //    Console.WriteLine("Sum of all the for loop values = " + sum);
        //    Console.ReadLine();


        //    //  write a program to print the table of 5
        //}

        static void Mainss()
        {
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);
            //Write a program to print the table of 5 using while loop
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("5 * " + i + " = " + 5 * i);
            //    i++;
            //}
            //Write a program to print the table of 5 using do while loop
            //int i = 1;
            //do
            //{
            //    Console.WriteLine("5 * " + i + " = " + 5 * i);
            //    i++;
            //} while (i <= 10);
            //Write a program to print the table of 5 using for loop
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("5 * " + i + " = " + 5 * i);
            //}
            //Write a program to print the table of 5 using for loop
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("5 * " + i + " = " + 5 * i);
            //}
            //Write a program to print the table of 5 using for loop
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("5 * " + i + " = " + 5 * i);
            //}
            //Write a program to print the table of 5 using for loop
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("5 * " + i + " = " + 5 * i);
            //}
            //Write a program to print the table of 5 using for loop
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("5 * " + i + " = " + 5 * i);
            //}
            //Write a program to print the table of

        }

        // FOr loop example
        //static void Main()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        i = 1;
        //        if (i == 5)
        //        {
        //            break;
        //        }
        //        Console.WriteLine(i);
        //    }
        //}

        // For loop Continue
        //static void Main()
        //{
        //    for (int i = 2; i <= 10; i++)
        //    {
        //        if (i % 2 == 0) // if 5 then i dont want to show the results 
        //        {
        //            continue;
        //        }
        //        Console.WriteLine(i*i);
        //    }
        //}

        // For loop break
        //static void Main()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        if (i == 5) // loop break at five
        //            break;
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine("Loop disconnect from the flow");
        //}

        // while - example -1 
        //static void Main()
        //{
        //    Console.WriteLine("Enter the value for N");
        //    int n = int.Parse(Console.ReadLine()); //5

        //    int i = 0;
        //    while (i<n)
        //    {
        //        // Come to this line if the condition is true
        //        Console.WriteLine(i);
        //        i = i + 1; // i++

        //        if (i == 4)
        //            break;

        //    }
        //    // if the condition is false
        //}

        // while - example -2

        //static void Main()
        //{
        //    string choice = string.Empty;
        //    Console.WriteLine("Enter your choice (Type Continue to Get the input, show the result");
        //    choice = Console.ReadLine();
        //    int a = 0;
        //    int b = 0;
        //    int result = 0;

        //    while (choice == "Continue")
        //    {
        //        Console.WriteLine("Enter the value for A");
        //        a = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter the value for B");
        //        b = int.Parse(Console.ReadLine());

        //        result = a + b;
        //        Console.WriteLine("The result is " + result);

        //        Console.WriteLine("Enter your choice (Type Continue to Get the input, show the result, other values to exit");

        //        choice = Console.ReadLine();

        //    }
        //}

        // do while - example -1
        //static void Main()
        //{
        //    string choice = string.Empty;
        //    int a = 0;
        //    int b = 0;
        //    int result = 0;
        //    do
        //    {
        //        Console.WriteLine("Enter the value for A");
        //        a = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter the value for B");
        //        b = int.Parse(Console.ReadLine());

        //        result = a + b;
        //        Console.WriteLine("The result is " + result);

        //        Console.WriteLine("Enter your choice (Type Continue to Get the input, show the result, other values to exit");
        //        choice = Console.ReadLine();
        //    } while (choice == "Continue");


        //}

        // Write a program to print the table of 5 using while loop
        // write a program to print the folwoing 10,15,20,25,30,35,40,45,50 ..... N
        // f=-1,s=1, t=f+s
        // 0,1,1,2,3,5,8,13 .... N
        // Prime number  -- n/1 and n/n . In between no other values can be divided and bring reminder is zero.
        // 5/1, 5/2, 5/3,5/4.5/5

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for n");
            int maxLimit = int.Parse(Console.ReadLine());
            if (maxLimit <= 0)
            {
                Console.WriteLine("Invlid input");
                return;
            }

            Console.WriteLine("Prime number are ...");
            if (maxLimit >= 2)
            {
                Console.WriteLine(2);
            }
            // this function check each value and print that value is prime or not
            for (int i = 3; i <= maxLimit; i=i+2)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        /// <summary>
        /// This function check the number is prime or not
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static bool IsPrime(int n)
        {
            int c = 0;
            for (int i = 2; i <= n-1; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}




