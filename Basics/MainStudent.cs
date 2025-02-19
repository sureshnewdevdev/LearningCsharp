using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    using System;

    public class MainStudent
    {
        // Field
        private string name ="First Name";
        private double marks;

        // Read-Only Property (can only be accessed, not set)
        public string Name
        {
            get { return name; }
        }

        // Write-Only Property (can only be set, not accessed)
        public double Marks
        {
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Marks must be between 0 and 100.");
                marks = value;
            }
        }

        // Constructor to initialize name
        public MainStudent(string studentName)
        {
            name = studentName;
        }

        // Method to display student details
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
        }
    }

}

// Write a program to demonstrate the use of properties in C#.
// wrtie a program to demonstrate the use of read only and write only properties in C#.