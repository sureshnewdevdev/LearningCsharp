using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public interface IPeron
    {
        string Name { get; set; }
        int Age { get; set; }
        void DisplayInfo();
    }


    public class SMan : IPeron
    {
        public string Name { get ; set ; }
        public int Age { get ; set ; }

        public string FreeTravelMode()
        {
            return "Walking";
        }
        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }

    public class SWoman : IPeron
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string FreeTravelMode()
        {
            return "Bus";
        }
        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }

    public class FunnyInterfaceExample
    {

    }
}
