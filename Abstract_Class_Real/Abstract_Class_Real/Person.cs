using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Real
{
    public class Person
    {
        private string name;
        private int age;

        private Calcul calcul;

        public Person()
        {
            name = "";
            age = 0;
        }
        public Person(string name, int age, Calcul calcul)
        {
            this.name = name;
            this.age = age;
            this.calcul = calcul;
        }

        public void RandomMethod()
        {
            int a = 12;
            int b = 13;
            int c = calcul.Add(a, b);
            Console.WriteLine("Addition = " + c);
            int d = calcul.Sub(a, b);
            Console.WriteLine("substraction =" + d);
        }
    }
}
