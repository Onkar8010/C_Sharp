using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructer_Example
{
    public class School
    {

        private School()
        {
            Console.WriteLine("Deafult const");
        }

        public int TotalRev() 
        {
            return 1000;

        }






    }
}
