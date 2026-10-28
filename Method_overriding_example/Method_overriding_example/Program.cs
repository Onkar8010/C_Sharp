using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overriding_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SubBank obj = new SubBank();

            obj.DisplayBankName();
            obj.DisplayCreditAmount();
            obj.displayBalance();


            Bank obj1 = new Bank();
            obj.DisplayBankName();


        }
    }
}
