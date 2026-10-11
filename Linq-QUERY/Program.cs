using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace CSharpConceptBoldLab.Linq
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

        public int DepartmentId { get; set; }
    }
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "Fazila",
                Job = "Manager",
                City = "New York",
                Salary = 50000,
                Age = 35
            },
            new Employee
            {
                Id = 2,
                Name = "John",
                Job = "Developer",
                City = "Los Angeles",
                Salary = 60000,
                Age = 28
            },
            new Employee
            {
                Id=3,
                Name="Monika",
                Job="Developer",
                City="Dhaka",
                Salary=70000,
                Age = 27
            },
            new Employee
            {
                Id=4,
                Name="Rashid",
                Job="Manager",
                City="Dhaka",
                Salary=80000,
                Age = 40
            }
        };
            List<Department> departments = new()
                {
                    new Department { Id = 1, Name = "IT" },
                    new Department { Id = 2, Name = "HR" },
                    new Department { Id = 3, Name = "QA" }
                };
            var empDhk = emp.Where(e => e.City == "Dhaka" && e.Salary >= 50000).ToList();
            foreach (var employee in empDhk)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Job: {employee.Job}, City: {employee.City}, Salary: {employee.Salary}, Age: {employee.Age}");
            }


            var empInfo = emp.Select(e => new
            {
                e.Name,
                e.Job,
                e.Salary
            }).ToList();
            foreach (var employee in empInfo)
            {
                Console.WriteLine($"Name: {employee.Name}, Job: {employee.Job}, Salary: {employee.Salary}");
            }


            var empName = emp.OrderByDescending(e => e.Salary).OrderBy(e => e.Name).ToList();
            foreach (var employee in empName)
            {
                Console.WriteLine($"Name: {employee.Name}, Job: {employee.Job}, Salary: {employee.Salary}");
            }

            var empID = emp.Find(e => e.Id == 3);

            if (empID != null)
            {
                Console.WriteLine($"Id: {empID.Id}, Name: {empID.Name}, Job: {empID.Job}, City: {empID.City}, Salary: {empID.Salary}, Age: {empID.Age}");
            }
            else
            {
                Console.WriteLine("Employee with Id 3 not found.");

            }

            var developers = emp.Count(e => e.Job == "Developer");
            Console.WriteLine($"Number of developers: {developers}");
            ////For employees whose Job is exactly "Developer", calculate:
            //-number of developers
            //-total salary
            //- average salary
            //- highest salary
            //- lowest salary
            var Developers = emp.Where(e => e.Job == "Developer").ToList();
            var totalSalary = Developers.Sum(e => e.Salary);
            var averageSalary = Developers.Average(e => e.Salary);
            var highestSalary = Developers.Max(e => e.Salary);
            var lowestSalary = Developers.Min(e => e.Salary);
            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Average Salary: {averageSalary}");
            Console.WriteLine($"Highest Salary: {highestSalary}");
            Console.WriteLine($"Lowest Salary: {lowestSalary}");

            //GroupBy() — Group and summarize
            //Group employees by City.For each city return:
            //-City
            //- TotalEmployees
            //- AverageSalary
            //- HighestSalary
            var results = emp.GroupBy(e => e.City).Select(g => new
            {
                City = g.Key,
                TotalEmployees = g.Count(),
                AverageSalary = g.Average(e => e.Salary),
                highestSalary = g.Max(e => e.Salary)
            }

                );

            foreach (var items in results)
            {
                Console.WriteLine($"City: {items.City}, Total Employees: {items.TotalEmployees}, Average Salary: {items.AverageSalary}, Highest Salary: {items.highestSalary}");
            }

            //different cities 
            var uniqueCities = emp.Select(e => e.City).Distinct().ToList();
            foreach (var items in uniqueCities)
            {
                Console.WriteLine($"Unique City: {items}");
            }
            var joinResult = from Employee in emp
                             join Department in departments
                             on Employee.DepartmentId
                             equals Department.Id
                             select new
                             {
                                 EmployeeName = Employee.Name,
                                 DepartmentName = Department.Name,
                                 EmployeeJob = Employee.Job,
                                 EmployeeSalary = Employee.Salary,

                             };
            foreach (var item in joinResult)
            {
                Console.WriteLine($"Employee Name: {item.EmployeeName}, Department Name: {item.DepartmentName}, Employee Job: {item.EmployeeJob}, Employee Salary: {item.EmployeeSalary}");

            }
        }
    }
}

