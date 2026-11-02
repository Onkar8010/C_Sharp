using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructer_Example02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student parant = new Student("onkar", 11,23);


            Student child = new Student(parant);



            parant.DisplayStudentInfo();
            child.DisplayStudentInfo();
            
            
        }


        
    }
}
