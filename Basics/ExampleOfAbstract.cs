using System;

abstract class Vehicle
{
    public string Name { get; set; }
    public int Speed { get; set; }

    // Abstract method (must be implemented by derived classes)
    public abstract void Move();
    public abstract void DriverQualification();


    // Concrete method (can be used as is)
    public void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Name: {Name}, Speed: {Speed} km/h");
    }
}

// Derived class
class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"{Name} moves on roads.");
    }

    public override void DriverQualification()
    {
        Console.WriteLine("Road ways licenses");
    }
}

// Another derived class
class Boat : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"{Name} moves on water.");
    }

    public override void DriverQualification()
    {
        Console.WriteLine("Water ways licenses");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car { Name = "Tesla", Speed = 150 };
        car.DisplayInfo();
        car.Move();

        Boat boat = new Boat { Name = "Yacht", Speed = 50 };
        boat.DisplayInfo();
        boat.Move();

        Vehicle mycar = new Car { Name = "Toyota", Speed = 100 };

        //Vehicle v = new Vehicle();// Cannot create an instance of the abstract class or interface 'Vehicle'
    }
}

// Example for abstract class and abstract method domestic and wild animals
// Methods: Eat, Sleep, Sound
