using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Collection of member variables and functions
namespace Basics
{
    public class Employee
    {
        public int Id;
        public string Name;

        public string Display()
        {
            return Id + "  "+Name;
        }
        
    }
}
