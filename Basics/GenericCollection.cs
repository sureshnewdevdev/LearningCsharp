using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public interface IEvenCollection<T>
    {
        void Add(T value);
        void Display();
        void DisplayEvenIndexValues();

        void DisplayOddIndexValues();
    }

    public class EvenGenericCollection2<T> : IEvenCollection<T>
    {
        private List<T> list = new List<T>();

        public void Add(T value)
        {
            list.Add(value);
        }
        public void Display()
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void DisplayEvenIndexValues()
        {
            int length = list.Count;
            for (int i = 1; i < length; i = i + 2)
            {
                Console.WriteLine(list[i]);
            }
        }

        public void DisplayOddIndexValues()
        {
            int length = list.Count;
            for (int i = 0; i < length; i = i + 2)
            {
                Console.WriteLine(list[i]);
            }
        }
    }

    public class EvenGenericCollection<T> : IEvenCollection<T>
    {
        private List<T> list = new List<T>();

        public void Add(T value)
        {
            list.Add(value);
        }
        public void Display()
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void DisplayEvenIndexValues()
        {
            int length = list.Count;
            for (int i = 1; i < length; i = i + 2)
            {
                Console.WriteLine(list[i]);
            }
        }

        public void DisplayOddIndexValues()
        {
            int length = list.Count;
            for (int i = 1; i < length; i = i + 2)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
    //public class EvenGenericCollection<T>
    //{ 
    //   private List<T> list = new List<T>();

    //    public void Add(T value)
    //    {
    //        list.Add(value);
    //    }
    //    public void Display()
    //    {
    //        foreach (T item in list)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    public void DisplayEvenIndexValues()
    //    {
    //        int length = list.Count;
    //        for (int i = 1; i < length; i=i+2)
    //        {
    //           Console.WriteLine(list[i]);
    //        }
    //    }
    //}
    public class GernericsCreateExample
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            List<string> listStr = new List<string>();

            EvenGenericCollection<int> evenInt = new EvenGenericCollection<int>();
            evenInt.Add(1);
            evenInt.Add(2);
            evenInt.Add(3);
            evenInt.Add(4);
            evenInt.Add(5);
            evenInt.Add(6);
            evenInt.Add(7);
            evenInt.Add(8);
            evenInt.Add(9);
            evenInt.Add(10);

            evenInt.Display();
            Console.WriteLine("************************************************************");
            evenInt.DisplayEvenIndexValues();

            EvenGenericCollection2<int> evenInt2 = new EvenGenericCollection2<int>();

            SomeMethod(evenInt);
            SomeMethod(evenInt2);
        }

        private static void SomeMethod(IEvenCollection<int> evenInt)
        {
            throw new NotImplementedException();
        }
    }
}

