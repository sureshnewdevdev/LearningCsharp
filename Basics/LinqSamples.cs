using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class UGStudent
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
    }
    public class LinqSamples
    {
        static void Main(string[] args)
        {
            List<UGStudent> students = new List<UGStudent>();
            List<int> studentIds = new List<int>();

            students.Add(new UGStudent() { Name="Anu", RollNo=1 });
            students.Add(new UGStudent() { Name="Banu", RollNo=2 });
            students.Add(new UGStudent() { Name="Chinnu", RollNo=3 });
            students.Add(new UGStudent() { Name="Dinu", RollNo=4 });
            students.Add(new UGStudent() { Name="Emmu", RollNo=5 });

            var filterNames = from student in students
                                  where student.RollNo >=3
                                  orderby student.Name descending
                                  select student.Name;

            foreach (var name in filterNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
