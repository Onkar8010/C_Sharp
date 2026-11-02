using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Construct_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company Parantcompany = new Company("ABC", "123 Main St");   
            

            Company sistercompany = new Company(Parantcompany);


            Parantcompany.DisplayCompanyInfo();
            sistercompany.DisplayCompanyInfo();


        }
    }
}
