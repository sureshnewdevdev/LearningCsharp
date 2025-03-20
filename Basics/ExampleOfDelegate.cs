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


        public DisplayDelegate DisplayDelegateProperty { get; set; }
        public static void Main()
        {

            

            ExampleOfDelegate myProhram = new ExampleOfDelegate();
            myProhram.CallDelegateMwthod();


            //myProhram.displayDelegate();
            //myProhram.displayDelegate = new DisplayDelegate(MyDelegatedMethod);
            //myProhram.displayDelegate();

        }

        public void CallDelegateMwthod()
        {
            if (DisplayDelegateProperty != null)
            {
                DisplayDelegateProperty();
            }
            else
            {
                Console.WriteLine("Delegate is not assigned");
            }
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
