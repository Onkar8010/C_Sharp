using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_Form_WithFunction
{
    internal class Student
    {




   


   
        // Function 1: Check Name
        static bool ValidateName(string name)
        {
            if (name == "")
            {
                return false;
            }

            return true;
        }

        // Function 2: Check Age
        static bool ValidateAge(int age)
        {
            if (age >= 18 && age <= 60)
            {
                return true;
            }

            return false;
        }

        // Function 3: Check Mobile
        static bool ValidateMobile(string mobile)
        {
            if (mobile.Length == 10)
            {
                return true;
            }

            return false;
        }

        // Function 4: Check Gender
        static bool ValidateGender(string gender)
        {
            if (gender == "Male" || gender == "Female")
            {
                return true;
            }

            return false;
        }

        // Main validation function
        static bool ValidateData(
            string name,
            int age,
            string gender,
            string mobile)
        {
            if (!ValidateName(name))
            {
                Console.WriteLine("Invalid Name");
                return false;
            }

            if (!ValidateAge(age))
            {
                Console.WriteLine("Invalid Age");
                return false;
            }

            if (!ValidateGender(gender))
            {
                Console.WriteLine("Invalid Gender");
                return false;
            }

            if (!ValidateMobile(mobile))
            {
                Console.WriteLine("Invalid Mobile Number");
                return false;
            }

            return true;
        }

        // Add Data function
        static void AddData(
            string name,
            int age,
            string gender,
            string mobile)
        {
            // Calling validation function
            if (ValidateData(name, age, gender, mobile))
            {
                Console.WriteLine("\nData Added Successfully!");

                Console.WriteLine("Name   : " + name);
                Console.WriteLine("Age    : " + age);
                Console.WriteLine("Gender : " + gender);
                Console.WriteLine("Mobile : " + mobile);
            }
            else
            {
                Console.WriteLine("\nData is not valid.");
            }
        }


}
}
