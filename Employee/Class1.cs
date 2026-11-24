namespace Employee
{
    public class Employee
    {
        public int Experience { get; set; }

        public void CalculateSalary()
        {
            int salary = Experience * 1000;
            Console.WriteLine($"Salary: {salary}");
        }
    }

    public class PermanentEmployee : Employee
    {

    }
    public sealed class Employee2
    {
        public void GetSalary()
        {
            Console.WriteLine("100000000000");
        }
    }
    public static class EmployeeStatic
    {
        public static void GetMoney()
        {
            Console.WriteLine("200000000000");
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {

            Employee2 objSealed = new Employee2();

            PermanentEmployee permanentEmployee = new PermanentEmployee();
            permanentEmployee.Experience = 8;
            permanentEmployee.CalculateSalary();
        }
    }
    
}
