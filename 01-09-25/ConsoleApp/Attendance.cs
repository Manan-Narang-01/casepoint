namespace ConsoleApp;

public class Attendance
{
    public static void Attendancemain()
    {
         Console.Write("Enter no of days: ");
        int days = int.Parse(Console.ReadLine());

        int[][] absent = new int[days][];

        for (int i = 0; i < days; i++)
        {
            Console.WriteLine($"\nEnter attendance for Day {i + 1}:");
            Console.Write("Enter no of wstudents absent: ");
            int count = int.Parse(Console.ReadLine());

            absent[i] = new int[count];

            Console.Write("Enter absent roll numbers: ");
            string[] inputs = Console.ReadLine().Split(' ');

            for (int j = 0; j < count; j++)
            {
                absent[i][j] = int.Parse(inputs[j]);
            }
        }

        Console.WriteLine("\nAbsent roll numbers:");
        for (int i = 0; i < days; i++)
        {
            Console.Write($"Day {i + 1}: ");
            foreach (int roll in absent[i])
            {
                Console.Write(roll + " ");
            }
            Console.WriteLine();
        }
    }
}
