using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForInterface
{
    public interface IMan
    {
        string Name { get; set; }
        int Age { get; set; }
        void DoWork();
    }

    public interface IWomen
    {
        string Name { get; set; }
        int Age { get; set; }
        void DoWorkAndTakeCareOfHome();
    }

    public class Child : IMan, IWomen
    {
        string IMan.Name { get ; set ; }
        int IMan.Age { get ; set ; }

        string IWomen.Name { get; set; }
        int IWomen.Age { get ; set ; }

        void IMan.DoWork()
        {
            Console.WriteLine("Do work");
        }

        void IWomen.DoWorkAndTakeCareOfHome()
        {
            Console.WriteLine("Do work and take care of home");
        }
    }

    public class ExampleForInterface2
    {
        public static void Main()
        {
            Child child = new Child();
            ((IMan)child).Name = "John";
            ((IMan)child).Age = 10;
            ((IMan)child).DoWork();

            ((IWomen)child).Name = "Jane";
            ((IWomen)child).Age = 8;
            ((IWomen)child).DoWorkAndTakeCareOfHome();
        }
    }
}
