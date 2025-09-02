namespace ConsoleApp;

public class Student
{
    public static void StudentMain()
    {
        Console.Write("Enter student's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter grade (optional, default is B): ");
        string grade = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(grade))
        {
            grade = "B"; 
        }

        Console.Write("Enter initial score: ");
        int score = int.Parse(Console.ReadLine());

        Display(name, grade);
        Console.WriteLine($"Initial Score: {score}");

        ApplyBonus(grade, ref score);
        Console.WriteLine($"Updated Score : {score}");
    }

    public static void Display(string name, string grade = "B")
    {
        Console.WriteLine($"Student: {name}\nGrade: {grade}");
    }

    public static void ApplyBonus(string grade, ref int score)
    {
        if (grade == "A")
            score += 10;
        else if (grade == "B")
            score += 5;
        
    }
    
}
