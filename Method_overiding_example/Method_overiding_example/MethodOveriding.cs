using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overiding_example
{
    public class MethodOveriding
    {
        public virtual void Add(int a, int b)
        {

            Console.WriteLine($"sum +{a + b}");
        }

        public virtual void sub(int a, int b)
        {
            Console.WriteLine($"substraction of two +{a - b}");
        }


    }


    public class mult : MethodOveriding 
    
    {
        public override void Add(int a, int b)
        {

            Console.WriteLine($"sum +{a + b}");
        }


    }




}
