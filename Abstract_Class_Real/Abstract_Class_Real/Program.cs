namespace Abstract_Class_Real
{
    internal class Program
    {
       internal static void Main(string[] args)
        {
            Person p1;

            AbstractCal cal = new FastCal();

            p1= new Person("Ram",23,cal);

            p1.RandomMethod();


            A a = new C();
            B b = new C();
            C c = new C();

            a.Print("Hello");
            b.Print("Helllo");
            c.Print("Hello");   
        }
    }
} 
