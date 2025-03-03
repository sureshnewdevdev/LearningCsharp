using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class Gravity
    {
        static Gravity()
        {
            
        }
        public static string Earth { get; set; } = "9.8";

        public static string Speed { get; set; }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class StaticExample
    {
        public static void Main(string[] args)
        {
            var g = Gravity.Earth;
        }
    }
}
