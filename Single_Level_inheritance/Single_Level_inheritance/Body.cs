using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Level_inheritance
{
    public class Body
    {

        public void DisplayBody()
        {
            Console.WriteLine("i am a heart");
        }
    }



        public class Heart : Body
        {
        
            public void  BodyName( )
            {
                Console.WriteLine("i am body");
            }
        
        }


    
}
