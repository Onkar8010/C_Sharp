namespace Abstract_Class_Real
{
    internal class Program
    {
       internal static void Main(string[] args)
        {
            Person p1;

            Calcul cal = new FastCal();

            p1= new Person("Ram",23,cal);

            p1.RandomMethod();
        }
    }
}
