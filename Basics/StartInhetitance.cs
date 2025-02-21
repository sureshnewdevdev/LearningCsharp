using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    //public class Parent : System.Object //parent is extened from Object
    public class Parent  //parent is extened from Object
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Child  : Parent
    {
        public string SchoolName { get; set; }
    }

    public class StartInhetitance
    {
        static void Main()
        {
            Child child = new Child();
            
        }
    }
}

// Multi Level
// Multiple inheritance
//
///
//A inherti to B, B in hert to C
// A, B to C
