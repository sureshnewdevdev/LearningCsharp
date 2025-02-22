using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{

    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
    }

    public class Man : Person
    {
        public string FatherWork { get; set; }
    }

    public class Woman : Person
    {
        public string MotherWork { get; set; }
    }

    public class Children : Person
    {
        public string SchoolName { get; set; }
    }

    public class InheritanceExample2
    {

        public static void Main()
        {
            Man man = new Man();
            man.PersonId = 10;
            man.PersonName = "Deva";

            Woman woman = new Woman();
            woman.PersonId = 2;
            woman.PersonName = "Sita";

            Children children = new Children();
            children.PersonId = 3;
            children.PersonName = "Lava";

            string result = DisplayInfo(man);
            result = DisplayInfo(woman);
            result = DisplayInfo(children);

        }

        public static string DisplayInfo(Person person)
        {
            if (person is Man)
            {
                //Man converted = (Man) person;// Explicit conversion
                Man converted = person as Man;
                return converted.PersonId + " " + converted.PersonName + converted.FatherWork;

            }
            if (person is Woman)
            {
                Woman converted = (Woman)person;// Explicit conversion
                return converted.PersonId + " " + converted.PersonName + converted.MotherWork;
            }
            if (person is Children)
            {
                Children converted = (Children)person;// Explicit conversion
                return converted.PersonId + " " + converted.PersonName + converted.SchoolName;
            }
            return person.PersonId + " " + person.PersonName;
        }
    }
}
// Telegram 
// Phone
// Cell Phone
// Mobile Phone