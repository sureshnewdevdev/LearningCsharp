using System;

namespace AccessModifiersExample
{
    // Base Class
    class Parent
    {
        public string PublicVar = "Public - Accessible anywhere";
        private string PrivateVar = "Private - Only inside this class";
        protected string ProtectedVar = "Protected - Inside this class & derived classes";
        internal string InternalVar = "Internal - Accessible within the same assembly";
        protected internal string ProtectedInternalVar = "Protected Internal - Accessible in same assembly and derived classes";
        private protected string PrivateProtectedVar = "Private Protected - Only in derived classes inside the same assembly";

        // Public Method
        public void Display()
        {
            Console.WriteLine(PublicVar);
            Console.WriteLine(PrivateVar);
            Console.WriteLine(ProtectedVar);
            Console.WriteLine(InternalVar);
            Console.WriteLine(ProtectedInternalVar);
            Console.WriteLine(PrivateProtectedVar);
        }
    }

    // Derived Class
    class Child : Parent
    {
        public void Show()
        {
            Console.WriteLine(PublicVar);  // ✅ Accessible
            // Console.WriteLine(PrivateVar);  // ❌ Not Accessible (Private)
            Console.WriteLine(ProtectedVar);  // ✅ Accessible (Protected)
            Console.WriteLine(InternalVar);  // ✅ Accessible (Internal - Same Assembly)
            Console.WriteLine(ProtectedInternalVar);  // ✅ Accessible (Protected Internal)
            Console.WriteLine(PrivateProtectedVar);  // ✅ Accessible (Private Protected - Same Assembly)
        }
    }

    class Program
    {
        static void Main()
        {
            Parent parent = new Parent();
            Console.WriteLine(parent.PublicVar);  // ✅ Accessible
            // Console.WriteLine(parent.PrivateVar);  // ❌ Not Accessible
            // Console.WriteLine(parent.ProtectedVar);  // ❌ Not Accessible
            Console.WriteLine(parent.InternalVar);  // ✅ Accessible (Same Assembly)
            Console.WriteLine(parent.ProtectedInternalVar);  // ✅ Accessible (Same Assembly)
            // Console.WriteLine(parent.PrivateProtectedVar);  // ❌ Not Accessible (Outside Derived Class)

            Child child = new Child();
            child.Show();  // Displays accessible variables
        }
    }
}
