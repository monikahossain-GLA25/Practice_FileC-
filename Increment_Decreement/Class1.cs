namespace Increment_Decreement
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int a = 10;
            int b = a++;
            int c = 5;
            int d = ++c;

            Console.WriteLine("Value of a: " + a);
            Console.WriteLine("Value of b: " + b);
            Console.WriteLine("Value of c: " + c);
            Console.WriteLine("Value of d: " + d);

            number++;
            Console.WriteLine("After Increment: " + number);
            
            number--;
            Console.WriteLine("After Decrement: " + number);
        }
    }
}
