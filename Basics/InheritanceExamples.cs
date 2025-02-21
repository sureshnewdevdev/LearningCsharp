using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }

        public int Address { get; set; }
    }

    public class Mangager : Employee { 
    
        public int PercentagePRofitShare { get; set; }
    }

    public class Director : Mangager
    {
       
        public int HolidayPlanCost { get; set; }
    }

    public class InheritanceEx
    {
        public static void Main()
        {
            Employee employee = new Employee();// Parent
            
            employee.EmpID = 101;
            employee.EmpName = "John";
            employee.Address = 101;

            Mangager mangager = new Mangager(); // Child

            mangager.EmpID = 102;
            mangager.EmpName = "Smith";
            mangager.Address = 102;
            mangager.PercentagePRofitShare = 10;

            employee = mangager; // Implicit conversion

            Console.WriteLine(employee.EmpID);
            Console.WriteLine(employee.EmpName);
            Console.WriteLine(employee.Address);

            Mangager originalManager = (Mangager)employee; // Explicit 
            Console.WriteLine(originalManager.PercentagePRofitShare);

           

        } 
    }
}
