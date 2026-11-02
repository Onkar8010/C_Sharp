using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overriding_example
{
    public  class Bank
    {
            
          public virtual void DisplayBankName()
        {
            Console.WriteLine("Bank Of Baroda");

        }

        public virtual void DisplayCreditAmount()
        {
            Console.WriteLine(1000);
        }

        public virtual void displayBalance()
        {
            Console.WriteLine(100);
        }


    }
    public class SubBank:Bank
    {

        public override void DisplayBankName()
        {
            Console.WriteLine("State Bank Of Maha");
        }

    }


}
