using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class ExampleFunctionParameterTypes
    {

        public int Add(ref int a, int b)
        {
            a = 10;
            return a + b;
        }

        public int Add(ref int a, int b, out int c)
        {
            a = 10;
            c = 200;
            return a + b;
        }
        public static void Main()
        {
            int a = 5;
            int b = 10;
            int c;
           
            ExampleFunctionParameterTypes obj = new ExampleFunctionParameterTypes();
            int result = obj.Add(ref a, b);


            result = obj.Add(ref a, b, out c);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
       
       
    }
}
