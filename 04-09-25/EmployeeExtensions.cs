namespace _04_09_25;

public static class EmployeeExtensions
{
    public static double CalculateAnnualSalary(this Employee emp)
    {
        return emp.Salary * 12;
    }
}
