using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_example
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*
            // 1) concat of  two string

            String t1 = "onkar";

            String t2 = "shendkar";

            string result = t1 + " " + t2;

            Console.WriteLine(result);
            */



            /*

            // 2) give the  string inpunt from user and display it

            Console.WriteLine("Enter a string");

            string str = Console.ReadLine();

            Console.WriteLine(str);

            
            */
            /*

            // 3) find the length of string

            string str2 = "shendkar";
            Console.WriteLine("length Of string "+ str2.Length);

            */

            /*
            // 4)  uppercase and lower case

            string str = "onkar shendkar";
            string result = str.ToUpper();
            Console.WriteLine(result);



            string str1 = "ONKAR SHENDKAR";
            string result1 = str.ToLower();
            Console.WriteLine(result1);

            */

            // 5) compare two string
            /*
            string str1 = "onkar";
            string str2 = "shendkar";


            if(str1 == str2)
            {
                Console.WriteLine("string are equal");
            }
            else
            {
                Console.WriteLine("string are not equal");
            }

            

            // take the input from user and check

            Console.WriteLine("Enter a string one");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter a string two");
            string str2 = Console.ReadLine();

            if (str1 == str2)
            {
                Console.WriteLine("string are equal");
            }

            else
            {
                Console.WriteLine("string are not equal");
            }

            */

            // 6)  extract substring from given string

            /*
            string str = "oshendkarr";
            string result = str.Substring(1,8);
            Console.WriteLine(result);
            */

            /*

            // 7) search a pertucler word in a string

            string str = "hii i am learning a c#";
            Console.WriteLine(str.Contains("c#"));
            */


            /*
            // 8)  Replace the word to another word in a string 

            string str = " onkar s";
            Console.WriteLine(str.Replace("s", "shendkar"));
            */


            /*
            // 9)  remove  space from string  to start & End

            string str = "  onkar shendkar   ";
            Console.WriteLine(str.Trim());
            Console.WriteLine(str.TrimEnd());
            Console.WriteLine(str.TrimStart());
            Console.WriteLine(str.Length);

            */

            /*

            // 10) remove character from string 

            string str = "SHENDKAR ONKAR";
            Console.WriteLine(str.Remove(4,2));
            */

            /*
            // 11) Insert text at middle of string 

            string str = "shedkar";
            Console.WriteLine(str.Insert(3,"n"));
            */

            /*
            // 12)  find index of character

            string str = "SHENDKAR";
            Console.WriteLine(str.IndexOf('K'));

            */

        }
    }
}
