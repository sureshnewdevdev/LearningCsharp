using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public enum AvailableProducts
    {
        Apple,
        Mango,
        Orange
    }
    public class EnumeratorsExample
    {
        public static string GetRateOfAProduct(AvailableProducts productName)
        {
            switch (productName)
            {
                case AvailableProducts.Apple:
                    return "100";
                    break;
                case AvailableProducts.Mango:
                    var tt = Gravity.Speed;
                    return "200";

                    break;
                case AvailableProducts.Orange:
                    return "250";

                    break;
                default:
                    return "Product Not Available";
                    break;
            }
           
        }

        public static void Main(string[] args)
        {
            GetRateOfAProduct(AvailableProducts.Apple);
        }
    }
}
