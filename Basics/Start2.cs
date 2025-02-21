using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
 

namespace Basics
{
    struct Student
    {
        public string Name;
        public int Age;
        public string Address;
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
        }
    }

    public class Car
    {
        public string Model;
        public string Color;
        public int Year;

        public Car()
        {

        }
        public Car(string model, string color, int year)
        {
            Model = model;
            Color = color;
            Year = year;
        }

        public Car(string model, string color)
        {
            Model = model;
            Color = color;

        }

        public void Display()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Year: " + Year);
        }
    }
    public class Start2
    {
        static void Main()
        {
            //Car myCar = new Car();

            //Car car2 = new Car("Toyota", "Red", 2020);

            //Car car3=new Car("Honda", "Blue");

            //myCar.Display();

            //BankAccount bankAccount = new BankAccount();
            //bankAccount.AccountId = "c234567890";
            //bankAccount.AccountId = "c2345678";

            //Console.WriteLine(bankAccount.AccountId);
            //BankAccount bankAccount1 = new BankAccount();
            //Basics1.BankAccount bankAccount2 = new Basics1.BankAccount();

            //Employee employee = new Employee();

            //employee.Id = 1;
            //employee.Name = "Mani";

            //var result = employee.Display();

            //Console.WriteLine(result);

            Account account = new Account();
            account.AccountName = "Mani";
            account.AccountId = "1234567890";

            Console.WriteLine(account.AccountName);
            //Console.WriteLine(account.AccountId);

            Simple simple = new Simple();

            Object obj = new Object();
          

            int n = 10;

            obj = n; // boxing
            obj = simple;

            int m = (int)obj; // unboxing

            Console.ReadLine();

        }
    }
}
