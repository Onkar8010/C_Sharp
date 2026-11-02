using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Example
{
    internal class Person
    {

        public void PersonName(string name)
        {
            Console.WriteLine($"First Name of Person +=  {name}");
        }
        

        public void PersonName(string mname , string lname) 
        {

            Console.WriteLine($" middle name and last name +=  {mname}   {lname}");
        
        }
    }
}
