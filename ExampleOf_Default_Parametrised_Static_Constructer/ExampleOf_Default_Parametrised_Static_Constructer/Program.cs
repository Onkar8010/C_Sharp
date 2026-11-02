using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOf_Default_Parametrised_Static_Constructer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank obj = new Bank();                 //default constructor

            Bank obj1 = new Bank();                    //parametrised constructor
            obj1.Bank1("Baroda Bank", "Pune", 12345);

            
            //Static constructor
            // can't create a object of static Constructor we can call function on class name

            Bank.DisplayName();
            Bank.IfscCode();            
            Bank.AccountNo();


        }
    }
}
