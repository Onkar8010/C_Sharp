using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Real
{
    public class Calculater :AbstractCal, Interface1
    {
        public override int Add(int a,int b)
        {
            return a + b;
        }
        public override int Sub(int a, int b)
        {
            return a - b;
        }

        public  int multiply(int a, int b)
        {
            return a * b;
        }


    }
}
