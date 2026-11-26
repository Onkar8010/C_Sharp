using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Real
{
    public abstract  class Calcul
    {

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public abstract int Add(int a, int b);

        public abstract int Sub(int a, int b);

    }
}
