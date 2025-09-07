namespace _04_09_25;

using System;


public interface IEmployee
{
    void DisplayDetails();
    void CalculateBonus();
    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int employeeID, double salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }

        public virtual void CalculateBonus()
        {
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name} (ID: {EmployeeID})");
            Console.WriteLine($"Salary: ${Salary}");
        }
    }

    public class Manager : Employee
    {
        public Manager(string name, int employeeID, double salary)
            : base(name, employeeID, salary) { }

        public override void CalculateBonus()
        {
            double bonus = Salary * 0.20;
            Console.WriteLine($"Bonus: ${bonus}");
        }

        public new void DisplayDetails()
        {
            Console.WriteLine("Manager: " + Name);
            base.DisplayDetails();
        }
    }

    public class Developer : Employee
    {
        public Developer(string name, int employeeID, double salary)
            : base(name, employeeID, salary) { }

        public override void CalculateBonus()
        {
            double bonus = Salary * 0.10;
            Console.WriteLine($"Bonus: ${bonus}");
        }

        public new void DisplayDetails()
        {
            Console.WriteLine("Developer: " + Name);
            base.DisplayDetails();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEmployee manager = new Manager("M", 1, 8000);
            IEmployee developer = new Developer("V", 2, 6000);

            manager.DisplayDetails();
            manager.CalculateBonus();

            Console.WriteLine();

            developer.DisplayDetails();
            developer.CalculateBonus();
        }
    }

