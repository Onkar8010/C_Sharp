using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Real
{
    internal class FastCal:Calcul
    {
        public override int Add(int a, int b)
        {
            return a + b;
        }
        public override int Sub(int a, int b)
        {
            return a - b;
        }
    }
}

