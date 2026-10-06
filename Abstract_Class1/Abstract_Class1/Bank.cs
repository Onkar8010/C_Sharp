using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class1
{
    internal abstract class Bank
    {
        public abstract void BankName();

    }

    class SBI : Bank
    { 
        public override void BankName()
        {
            Console.WriteLine("SBI Bank");
        }
    
    }
}
