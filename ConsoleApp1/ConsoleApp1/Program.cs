namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           A a = new C();
            B b = new C();
            C c = new C();

            a.Print("Hello");
            b.Print("Hello");
            c.Print("hello");
        }
    }
}
