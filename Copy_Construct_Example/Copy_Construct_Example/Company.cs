using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Construct_Example
{
    internal class Company
    {


        public string companyName;
        public string companyAddras;

        // parameterized constructor
        public Company(string name, string addras)
        {
            companyName = name;
            companyAddras = addras;
        }


        // copy constructor

        public Company(Company company)
        {
            companyName = company.companyName;
            companyAddras = company.companyAddras;
        }
        
           
        


       public void DisplayCompanyInfo()
        {
            Console.WriteLine("Company Name: " + companyName);
            Console.WriteLine("Company Address: " + companyAddras);

        }


    }

}
