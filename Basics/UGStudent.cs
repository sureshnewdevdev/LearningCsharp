using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class UGStudent
    {

        private int studentId;
        public int StudentId 
        { 
            get => studentId;
            set 
            { 
                if (value <= 0)
                    throw new Exception("Student Id should be greater than 0");
                else
                    studentId = value;
            } 
        }

        public int StudentAge 
        {

            get; 
        }

   

        public int Id;
        public string Name;
        public string Branch;


        public string Display()
        {
            return Id + "  " + Name + "  " + Branch;
        }
    }
}
