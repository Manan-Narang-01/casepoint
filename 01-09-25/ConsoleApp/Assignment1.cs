using System;

namespace ConsoleApp
{
    public class Assignment1
    {
        public static void CalenderTest()
        {
            int Month, Year;

            Console.Write("Enter Month (1-12): ");
            Month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Year: ");
            Year = Convert.ToInt32(Console.ReadLine());

            DisplayCalendar(Month, Year);
        }

        static void DisplayCalendar(int Month, int Year)
        {
            DateTime ft = new DateTime(Year, Month, 1);
            int st = (int)ft.DayOfWeek;
            int dim = DateTime.DaysInMonth(Year, Month);

            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            int curday = 1;

            // Print initial spacing for the first week
            for (int i = 0; i < st; i++)
            {
                Console.Write("    ");
            }

            // Print the days
            for (int week = 0; week < 6; week++)
            {
                for (int day = 0; day < 7; day++)
                {
                    if (week == 0 && day < st)
                    {
                        continue;
                    }

                    if (curday > dim)
                    {
                        break;
                    }

                    Console.Write($"{curday,3} ");

                    curday++;

                    if (curday > dim)
                    {
                        break;
                    }
                }
                Console.WriteLine(); 
                if (curday > dim)
                {
                    break;
                }
            }
        }
    }
}
