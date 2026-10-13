using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_Each_Loop_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Array Example

            int[] marks = { 14, 32, 73 };

            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }

            */


            /*
            Console.WriteLine("enter any language name");

            string addlanguage=Console.ReadLine();

            string[] techskill = { "c", "cpp", "java", "python", }; //addlanguage };
            

            foreach (var skill in techskill)
            {
                Console.WriteLine(skill);
            }
            */

            ArrayList  mixValue = new ArrayList();
            mixValue.Add(10);
            mixValue.Add("Hello");
            mixValue.Add(3.14);

            foreach (var  value in mixValue)
            {
                Console.WriteLine(value);
            }




        }
    }
}
