using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_Form_WithFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter Mobile: ");
            string mobile = Console.ReadLine();

            // Calling AddData function
           // AddData(name, age, gender, mobile);

            Console.ReadLine();
        }




    }
    
}
