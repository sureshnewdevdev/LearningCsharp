using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{

    public class  A
    {
        public int SomeValue { get; set; }
    }

    public class B  
    {
        public int SampleValue { get; set; }

    }

    // Multiple inhertiance
    public class C : A/*, B*/
    {
        public int TotalValue { get; set; }
    }

    // Constructor?
    // Parent Can convert to child . Implicit conversion
    // Child can convert to parent. Explicit conversion
}
