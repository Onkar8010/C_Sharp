using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_inhertance_example
{
    public class Person
    {


        public Person()
       {

            Console.WriteLine("Default Constructer person");

        }
        public string PersonName(string name)
        {
            return name;
        }
    }

    public class Employee :Person
    { 


           public Employee()
        {
            Console.WriteLine("Default Constructer");
        }


        public int EmployeeId(int id)
        {
            return id;
        }

    }
    public class Devloper :Employee
    { 
        public Devloper()
        {
            Console.WriteLine("Default Constructer");
        }

        public string DevloperWork(string work)
        {
            return work;
        }
    }




}
