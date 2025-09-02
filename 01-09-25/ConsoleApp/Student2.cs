namespace ConsoleApp;

public class Student2
{
    private string name;
    private int age;
    private string grade;

    public static int TotalStudents = 0;


    public Student2(string name, int age, string grade)
    {
        this.Name = name;
        this.Age = age;
        this.Grade = grade;
        TotalStudents++;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Grade
    {
        get { return grade; }
        set
        {
            if (value == "A" || value == "B" || value == "C")
                grade = value;
            else
                grade = "";
        }
    }
     public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        Console.WriteLine($"Total Students: {TotalStudents}");
    }

}
