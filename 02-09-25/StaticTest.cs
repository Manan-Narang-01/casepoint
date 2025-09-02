namespace _02_09_25;

public class StaticTest
{
    static public string company_name = "casepoint";
    public string studentname;

    public void dsplay1()
    {
        Console.WriteLine("company name: " + company_name);
        Console.WriteLine("student name: " + studentname);


    }
    public static void dsplay2()
    {
        Console.WriteLine("company name: " + company_name);
        // Console.WriteLine("student name: " + studentname);


    }
}

static class Test
{
    static int a = 5;
    public static void display()
    {
        Console.WriteLine("Value of A " + 5);
    }
}
