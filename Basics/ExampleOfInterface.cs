using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public interface IVehicle
    {
        string Name { get; set; }
        int Speed { get; set; }
        void Move();
        void DriverQualification();
    }

    public interface IDrivingLicense
    {
        void ShowDrivingLicense();
    }


    public class SumoCar : IVehicle, IDrivingLicense
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public void Move()
        {
            Console.WriteLine($"{Name} moves on roads.");
        }
        public void DriverQualification()
        {
            Console.WriteLine("Road ways licenses");
        }

        public void ShowDrivingLicense()
        {
            Console.WriteLine("License Shown");
        }
    }

    public class SpeedBoat : IVehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public void Move()
        {
            Console.WriteLine($"{Name} moves on water.");
        }
        public void DriverQualification()
        {
            Console.WriteLine("Water ways licenses");
        }

    }

    public class SpeedJet : IVehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public void Move()
        {
            Console.WriteLine($"{Name} moves in air.");
        }
        public void DriverQualification()
        {
            Console.WriteLine("Air ways licenses");
        }
    }



    public class ExampleOfInterface
    {
        public static void Main()
        {
            SumoCar car = new SumoCar { Name = "Tesla", Speed = 150 };
            car.Move();
            car.DriverQualification();
            car.ShowDrivingLicense();
            SpeedBoat boat = new SpeedBoat { Name = "Yacht", Speed = 50 };
            boat.Move();
            boat.DriverQualification();
            SpeedJet jet = new SpeedJet { Name = "F-16", Speed = 1000 };
            jet.Move();
            jet.DriverQualification();
 
            DisplayInfo(car);
            DisplayInfo(boat);
            DisplayInfo(jet);
        }
        public static string DisplayInfo(IVehicle vehicle)
        {
            if ( vehicle is IDrivingLicense )
            {
                IDrivingLicense drivingLicense = vehicle as IDrivingLicense;
                drivingLicense.ShowDrivingLicense();
            }
            return $"Vehicle Name: {vehicle.Name}, Speed: {vehicle.Speed} km/h";
        }

    }
}
 
