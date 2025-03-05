using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Basics
{
    public class ExampleGenerics
    {
        static void Main()
        {
            // ListExample();
            //DictionaryExample();
            LinqExamples();
        }

        private static void DictionaryExample()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(101, "Alice");
            students.Add(102, "Bob");
            students.Add(103, "Charlie");
            Console.WriteLine("Dictionary<TKey, TValue>: " + students[102]); // Accessing value by key
        }

        private static void ListExample()
        {
            // Initialize a List of integers
            List<int> numbers = new List<int> { 5, 3, 8, 1, 9 };

            // 1. Add an element to the list
            numbers.Add(10); // Adds 10 at the end
            Console.WriteLine("After Add(10): " + string.Join("* ", numbers));

            // 2. Add multiple elements using AddRange()
            numbers.AddRange(new List<int> { 12, 15, 18 });
            Console.WriteLine("After AddRange(): " + string.Join(", ", numbers));

            // 3. Insert an element at a specific index
            numbers.Insert(2, 7); // Inserts 7 at index 2
            Console.WriteLine("After Insert(2, 7): " + string.Join(", ", numbers));


            // 4. Remove an element by value
            numbers.Remove(3); // Removes first occurrence of 3
            Console.WriteLine("After Remove(3): " + string.Join(", ", numbers));

            // 5. Remove an element by index
            numbers.RemoveAt(4); // Removes element at index 4
            Console.WriteLine("After RemoveAt(4): " + string.Join(", ", numbers));

            // 6. Remove a range of elements (from index 2, remove 2 elements)
            numbers.RemoveRange(2, 2);
            Console.WriteLine("After RemoveRange(2,2): " + string.Join(", ", numbers));

            // 7. Check if a value exists in the list
            Console.WriteLine("Contains(8): " + numbers.Contains(8)); // true
            Console.WriteLine("Contains(100): " + numbers.Contains(100)); // false


            // 8. Find the index of a specific element
            int index = numbers.IndexOf(7);
            Console.WriteLine("Index of 9: " + index);



            // 9. Sort the list in ascending order
            numbers.Sort();
            Console.WriteLine("After Sort(): " + string.Join(", ", numbers));

            // 10. Sort in descending order using custom comparison
            numbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine("After Descending Sort(): " + string.Join(", ", numbers));

            // 11. Reverse the list
            numbers.Reverse();
            numbers.Reverse();
            Console.WriteLine("After Reverse(): " + string.Join(", ", numbers));

            // 12. Find the first element greater than 4
            int found = numbers.Find(x => x > 4);
            Console.WriteLine("Find(x > 4): " + found);

            // 13. Find all even numbers
            List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
            Console.WriteLine("FindAll(even numbers): " + string.Join(", ", evenNumbers));

            // 14. Iterate over list using ForEach()
            Console.WriteLine("Using ForEach():");
            numbers.ForEach(num => Console.Write(num + " "));
            Console.WriteLine();

            // 15. Convert list to array
            int[] numArray = numbers.ToArray();
            Console.WriteLine("Converted to Array: " + string.Join(", ", numArray));

            // 16. Clear all elements from the list
            numbers.Clear();
            Console.WriteLine("After Clear(): Count = " + numbers.Count);

            // Select * from Student where Age > 20
        }


        public static void LinqExamples()
        {
            //List<int> numbers = new List<int> { 5, 3, 8, 1, 9 };
            //// 1. Find all numbers greater than 4
            //IEnumerable<int> result = numbers.Where(x => x > 4);
            //Console.WriteLine("Where(x > 4): " + string.Join(", ", result));
            //// 2. Find the first number greater than 4
            //int first = numbers.First(x => x > 4);
            //Console.WriteLine("First(x > 4): " + first);
            //// 3. Find the last number greater than 4
            //int last = numbers.Last(x => x > 4);
            //Console.WriteLine("Last(x > 4): " + last);
            //// 4. Find the count of numbers greater than 4
            //int count = numbers.Count(x => x > 4);
            //Console.WriteLine("Count(x > 4): " + count);
            //// 5. Find the sum of all numbers
            //int sum = numbers.Sum();
            //Console.WriteLine("Sum(): " + sum);
            //// 6. Find the average of all numbers
            //double avg = numbers.Average();
            //Console.WriteLine("Average(): " + avg);
            //// 7. Find the maximum number
            //int max = numbers.Max();
            //Console.WriteLine("Max(): " + max);
            //// 8. Find the minimum number
            //int min = numbers.Min();
            //Console.WriteLine("Min(): " + min);
            //// 9. Find the sum of all even numbers
            //int sumEven = numbers.Where(x => x % 2 == 0).Sum();
            //Console.WriteLine("Sum of Even numbers: " + sumEven);
            //// 10. Check if all numbers are even
            //bool allEven = numbers.All(x => x % 2 == 0);
            //Console.WriteLine("All numbers are even: " + allEven);
            //// 11. Check if any number is even
            //bool anyEven = numbers.Any(x => x % 2 == 0);
            //Console.WriteLine("Any number is even: " + anyEven);
            //// 12. Find the first even number
            //int firstEven = numbers.First(x => x % 2 == 0);
            //Console.WriteLine("First even number: " + firstEven);
            //// 13. Find the last even number

            string[] strings = { "one", "two", "three", "four", "five" };

            var selected = from str in strings
                           where str.Length == 3
                           select str;

            foreach (var str in selected)
            {
                Console.WriteLine(str);
            }

            string[] names = { "Ram", "Kapoor", "Babu", "Arun" };

            IEnumerable selectedNames = from name in names
                                where name == "Kapoor"
                                select name;

            var selectedName1 = from name in names
                                     where name == "Kapoor"
                                     select name;

            string[] selectedName2 = (from name in names
                                where name == "Kapoor"
                                select name).ToArray();

            List<string> selectedName3 = (from name in names
                                      where name == "Kapoor"
                                      select name).ToList();

            //Dictionary<string> selectedName3 = (from name in names
            //                              where name == "Kapoor"
            //                              select name).ToDictionary()


            List<Person> people = new List<Person>
            {
                new Person { PersonName = "Ram", Age = 20 },
                new Person { PersonName = "Kapoor", Age = 30 },
                new Person { PersonName = "Babu", Age = 40 },
                new Person { PersonName = "Arun", Age = 50 }
            };

            var selectedPeople = from person in people
                                 orderby person.Age descending
                                 select person;


            var selectedPeopleAge = from person in people
                                 orderby person.Age descending
                                 select person.Age;

            object selectedPeopleAge3 = from person in people
                                    orderby person.Age descending
                                    select person.Age;

            foreach (var str in selectedNames)
            {
                Console.WriteLine(str);
            }


            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 50000, Category ="EC" },
                new Product { Name = "Mobile", Price = 20000 ,Category ="DC"},
                new Product { Name = "Tablet", Price = 10000 , Category="DC"},
                new Product { Name = "Desktop", Price = 30000 , Category = "EC"}
            };

            var selectedProducts = from product in products
                                    
                                   select  new { product.Name, product.Category };

            var soldProducts = from product in products
                               group product by product.Category into g
                               select new  { Category = g.Key, AvgPrice=g.Average(pr=>pr.Price)};


            foreach (var product in selectedProducts)
            {
                Console.WriteLine(product.Name + " " + product.Category);
            }

            foreach(var ss in soldProducts)
            {
                Console.WriteLine( ss.Category);
            }







        }
    }
}
