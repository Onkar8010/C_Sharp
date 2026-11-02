using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    public class Dog
    {

        public string Eat()
        {
            return "Animal is Eating";

        }
    }
      public class Animal : Dog
    {
            public string Bark()
        {
            return "Dog is Barking";
        }




    }
}
