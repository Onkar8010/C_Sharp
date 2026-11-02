using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructer_Example02
{
    internal class Student
    {

        public string StudentName;
        public int StudentID;

        public int StudentAge;

        //parametrised constructer
        public Student(string name, int id, int age)
        {

            StudentName = name;
            StudentID = id;
            StudentAge = age;
        
        }

        public Student(Student student) 
        {

            StudentName = student.StudentName;
            StudentID = student.StudentID;
            StudentAge = student.StudentAge;
        
        }

        public void DisplayStudentInfo()
        {

            Console.WriteLine("Student Name is =  " + StudentName );
            Console.WriteLine("student id = " +StudentID);
            Console.WriteLine("Student Age is  = " +  StudentAge);



        } 





    }
}
