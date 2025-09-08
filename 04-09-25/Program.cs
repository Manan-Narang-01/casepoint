namespace _04_09_25;

using System;

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee("M", 101, 5000, EmployeeType.Developer);

        emp.DisplayDetails();
        
        double annualSalary = emp.CalculateAnnualSalary();
        Console.WriteLine($"Annual Salary: ${annualSalary}");


    }
}