namespace _02_09_25;

public partial class PartialDemo
{
    private int RollNo;
    private string StudentName;

    public PartClass(int RollNo, string StudentName)
    {
        this.RollNo = RollNo;
        this.StudentName = StudentName;
    }
}

public partial class PartialDemo
{
    public void display()
    {
        Console.WriteLine("Roll No is:" + RollNo);
        Console.WriteLine("Student Name is:" + StudentName);
        
    }
}