using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Modifier_example
{
    internal class Employee
    {
        /*
                public Employee()  // special function  // default constructor
                { 

                   Console.WriteLine("Deafult  Constructor");

                }

        */
        static Employee()  
        {

            Console.WriteLine("Deafult  Constructor");

        }

        public static void Display()
        {
            Console.WriteLine("Display Method");
        }
        public static void Show()
        {
            Console.WriteLine("Show Method");
        }







        private static int GetSalary() { 
            return 50000;
        }
          
        /*
        public  Employee(string name)
        {
            // GetSalary();
            Console.WriteLine(name);
        }
        */
        /*

        // parametrised constructer
        public Employee (string name, int salary)
        {
            Console.WriteLine(name + " " + salary);
        }

        */



    }
}
