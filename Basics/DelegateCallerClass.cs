using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class DelegateCallerClass
    {
        public static void Main()
        {
            ExampleOfDelegate myProhram = new ExampleOfDelegate();
            myProhram.DisplayDelegateProperty = new DisplayDelegate(MyClientMethodVersion2);
            myProhram.CallDelegateMwthod();
        }

        private static void MyClientMethodVersion2()
        {
            Console.WriteLine("I am running from Client classs Version 2. I have Created Later..");
        }

        private static void MyClientMethod()
        {
            Console.WriteLine("I am running from Client classs . I have Created Later..");
        }
    }
}
