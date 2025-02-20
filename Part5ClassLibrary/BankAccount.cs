using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5ClassLibrary
{
    public class BankAccount
    {
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public static decimal InterestRate { get; set; }

    }
}
