using static System.Runtime.InteropServices.JavaScript.JSType;

public  class program
{
    //CallByValue
    public void change(int data)
    {
         data = 9;
    }

    //callbyreference
    static void ChangeValue(int num)
    {
        num = 20;
        Console.WriteLine("Inside method, num = " + num);
    }
    public static void Main(string[] args)
    {
        program obj = new program();
        int data = 12;
        Console.WriteLine(data);


        //call by value
        int num = 34;
        Console.WriteLine(num);
        Console.WriteLine("Inside method, num = " + num);
        ChangeValue(num);
        Console.WriteLine("After the method call, number = " + num);
    }
}