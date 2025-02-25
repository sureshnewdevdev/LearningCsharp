using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{

    public class EmployeeParent
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int Address { get; set; }

        public virtual string GetHolidays()
        {
            return "Deepavali";
        }
    }

    public class EmployeeUS : EmployeeParent
    {
        public int PercentagePRofitShare { get; set; }

        public override string GetHolidays()
        {
            return "GreatFriday";
        }
    }

    public class RuntimePolymorpismExample2
    {
        public static void Main()
        {
            int n = Add(10, 20);
            n= Add(10,20,30);
            n = Add(10, 20, 30, 40);

        }

        /// <summary>
        /// This method is not implemented
        /// </summary>
        /// <param name="v1">  </param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <param name="v4"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static int Add(int v1, int v2, int v3, int v4)
        {
            return Add(v1, v2, v3) + v4;   
        }

        /// <summary>
        /// This method is not implemented
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static int Add(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is not implemented
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        private static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        public static void Main(string[] args)
        {
           int c= Add(Add(10, 20), 30);
           Console.WriteLine("Addition =" + c);
        }
         
    }
}
