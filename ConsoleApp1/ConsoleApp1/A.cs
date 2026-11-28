using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class A
    {

        public virtual void Print(string str)
        {
            Console.WriteLine(str + "A");
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
        public new void Print(string str)
        {
            Console.WriteLine(str + "C");
        }
    }
}
