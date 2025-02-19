using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics1
{
    public class BankAccount
    {
    }
}

namespace Basics
{
    public class BankAccount
    {
        private string accountId;

        public string AccountId 
        {
            get {
                return "DDDDFFWDW"+accountId+"DDDDDDD";
            }
            set {
                if (value.Length == 10)
                {
                    accountId = value;
                }
                else
                {
                    Console.WriteLine("Account ID must be 10 characters long");
                }
            } 
        }
    }
}
