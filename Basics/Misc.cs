using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class AClass
    {
        public override string ToString()
        {
            return "This is My Class";
        }
    }

    public sealed class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get;  set; }

        public override string ToString()
        {
            return $"{Name}-{Description}-{Category}";
        }

    }

    public sealed class SoldProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get;  set; }

        public override string ToString()
        {
            return $"{Name}-{Description}-{Category}";
        }

    }

    ///// <summary>
    ///// Sealed class cant be over riddes
    ///// </summary>
    //public class SubProduct : Product
    //{

    //}

    public class BClass
    {

    }
    public class Misc
    {
        public static void Main(string[] args)
        {
            var ss = Gravity.Earth;

            Gravity.Speed = "10";

            var dd = Gravity.Add(10, 83);

            AClass aClass = new AClass();
            Type t = aClass.GetType();
            Console.WriteLine(t.Name);

            // Print the complete data type
            var g = aClass.GetType().ToString();
            Console.WriteLine(g);

            Product p = new Product() { Name="Mango", Category="Fruitd", Description="Indian Healthy Food" };
            Console.WriteLine(p.ToString());
            Console.WriteLine(aClass.ToString());
            Console.ReadLine();



        }
    }
}
