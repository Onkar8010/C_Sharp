using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate__Example_01
{
    internal class Bank
    {


        public delegate void mydel();

        public void BankName()
        {
            Console.WriteLine("Bank Of Baroda");
        }

        public void Display()  
        {


            mydel del = new mydel(BankName);

            del();
        
        }

    }
}
