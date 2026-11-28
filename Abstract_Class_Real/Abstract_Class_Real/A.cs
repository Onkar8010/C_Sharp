using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Real
{
    public  class A
    {

        public virtual void Print(string str)
        {
            Console.WriteLine( str +"A");
        }
    }

    public class B : A
    {
        public override void Print(string str)
        {
            Console.WriteLine(str + "B");
        }
    }


    public class C : B
    {
        public override void Print(string str)
        {
            Console.WriteLine(str + "C");
        }
    }
}
