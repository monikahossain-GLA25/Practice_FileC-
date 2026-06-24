using System.Diagnostics.CodeAnalysis;

public class newFunction
{
    public void AddNumber(int x,int y)
    {
        int sum = x + y;
        Console.WriteLine(sum);
    }

    //user define function
    public void Multiplication()
    {
        int a = 12;
        int b = 2;
        Console.WriteLine(a * b);
    }

    //create function as a argument
    public void Subtraction(double p , double y)
    {
        double value = p - y;
        Console.WriteLine(value);

    }
    //no arguments with return type
    public string  message() {
        return "Welcome to LBSL";
    }
    //FUNCTION WITH Argument and return type
    public int news(int o , int r)
    {
        return o + r; 
    }
    public static void Main(string[] args)
    {
        newFunction obj = new newFunction();
    obj.AddNumber(678,2);
        obj.Multiplication();
        obj.Subtraction(678, 23);
        Console.WriteLine(obj.message());
        int result = obj.news(89,69);
        Console.WriteLine("The function with argument is : " + result);
    }
}