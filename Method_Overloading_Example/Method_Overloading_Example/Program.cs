using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.PersonName("onkar");
            person.PersonName("Balasaheb", "Shendkar");
        }
    }
}
