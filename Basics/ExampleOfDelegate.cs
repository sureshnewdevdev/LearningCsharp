using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public delegate void DisplayDelegate();
    public class ExampleOfDelegate
    {
        int x = 100;
        DisplayDelegate displayDelegate = new DisplayDelegate(MyBestDelegatedMethod);
        //public DisplayDelegate MyDelegateProperty { get; set; }

        public static void Main()
        {
            ExampleOfDelegate myProhram = new ExampleOfDelegate();
            myProhram.displayDelegate();
            myProhram.displayDelegate = new DisplayDelegate(MyDelegatedMethod);
            myProhram.displayDelegate();

        }



        private static void MyDelegatedMethod()
        {
            Console.WriteLine("I am a Main method, I can be called via delegate");
        }

        private static void MyBestDelegatedMethod()
        {
            Console.WriteLine("I am a Main method, I can be called via delegate- Mthod 2");
        }
    }
}
