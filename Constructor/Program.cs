using System.Security.Principal;

public class ConstructorModel
{

    public string Name { get; set; }
    public int Age { get; set; }

    public int Salary { get; set; }
    public ConstructorModel(int age, int salary , string name)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
    //now method to write a employee details
    public void methodEmployee()
    {
        Console.WriteLine("The name of the emeployee is " + Name);
        Console.WriteLine("The age of the employee is " + Age);
        Console.WriteLine("The amount of the salary is " + Salary);

    }
    public static void Main(string[] args)
    {
        ConstructorModel obj = new ConstructorModel(27 , 34000 , "Monika Hossain");
        obj.methodEmployee();
    }
}