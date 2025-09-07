namespace _02_09_25;

public class EnumDemo
{
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public static void AbsentStudents()
    {
        int[][] a;
        int n = (int)DayOfWeek.Saturday + 1;
        a = new int[n][];

        Console.WriteLine("\n Enter Absent Students: \n");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Day : " + (DayOfWeek)i + ": ");

            Console.Write("\n Enter Total Number of Absent Students: ");
            int m = int.Parse(Console.ReadLine());
            a[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                Console.Write("Enter Roll Number {0}: ", j + 1);
                a[i][j] = int.Parse(Console.ReadLine());
            }

        }

        Console.WriteLine("\n Absent Students: \n");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nDay : " + (DayOfWeek)i + ": ");
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.WriteLine("Roll Number {0}: {1}", j + 1, a[i][j]);
            }
            Console.WriteLine();
        }
    }

}
