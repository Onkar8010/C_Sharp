using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarachical_Inheritance_example
{
    internal class Employee :AuditEntity
    {

        public int EmployeeNAme { get; set; }

        public int Name { get; set; }

        public int Salary { get; set; }





    }




    public class Company : AuditEntity
    { 
    
          public int CompanyId { get; set; }

        public string CompanyName { get; set; }


        public string CompanyAddress { get; set; }

        public string WebsiteUrl { get; set; }

    }

}
