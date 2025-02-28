using Basics;
namespace OtherProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // internal class is accessable only the base project not outside of the base project
          // Basics.IamInternal iamInternal = new Basics.IamInternal();   
            Person p = new Person();
            Console.WriteLine("Hello, World!");
        }
    }
}
