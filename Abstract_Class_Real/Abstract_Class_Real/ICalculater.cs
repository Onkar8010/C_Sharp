using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Real
{
    internal interface ICalculater
    {
        private ICalculater calculater; 



        public Student()
        {

        }

        public Student(ICalculater calculater)
        {
            this.calculater = calculater;
        }
        public void Random()
        {
            int a = 10;
            int b = 20;
            int sum = calculater.Add(a, b);
            Console.WriteLine("Sum: " + sum);
        }
    }
}
