namespace Swap_Two_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            //Console.WriteLine("Before swap"+ "a= " +a + ",b= "+b);
            //Swap(ref a, ref b);
            //Console.WriteLine($"After swap : a = {a} ,b = {b}"); // string formatting
            int userChoice;
            do
            {
                string menu = """
                    Enter 1: to add 2 numbers,
                    Enter 2: to substract 2 numbers,
                    Enter 3: to multiply 2 numbers,
                    Enter 4: to Exit

                    """;


                Console.WriteLine(menu);

                string userChoiceStr=Console.ReadLine();
              //  int userChoice;

                if (int.TryParse(userChoiceStr,out userChoice))// we use out keyword
                {
                    switch(userChoice)
                    {
                        case 1:
                            // Add two numbers
                            Add();
                            break;
                        case 2:
                            // Subtract two numbers
                            Subtract();
                            break;
                        case 3:
                            // Multiply two numbers
                            Multiply();
                            break;
                        case 4:
                            // Exit
                            Console.WriteLine("thank you");
                            break;
                        default:
                            Console.WriteLine(" Please Enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input , please enter numeric value");
                }




            }while(userChoice != 5);
        }

        static void Swap( ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Add()
        {
            Console.WriteLine("Enter First numbers  :");
           int FirstNum1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second numbers  :");
            int SecondNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum is: {FirstNum1 + SecondNum2}");
        }

        static void Subtract()
        {
            Console.WriteLine("Enter First numbers  :");
            int FirstNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second numbers  :");
            int SecondNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sub is: {FirstNum1 - SecondNum2}");
        }

        static void Multiply()
        {
            Console.WriteLine("Enter First numbers  :");
            int FirstNum1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter Second numbers  :");
            int SecondNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The mul is: {FirstNum1 * SecondNum2 }");
        }


      

    }
}
