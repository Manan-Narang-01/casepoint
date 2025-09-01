namespace ConsoleApp;

public class ControlStatement
{
    public static void test()
    {
        int age;
        Console.WriteLine("Enter Age:");
        age = Convert.ToInt32(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote");

        }
    }

    public static void Switchtest()
    {
        string statement = "ternary";
        switch (statement)
        {
            case "if.else":
                Console.WriteLine("if statement");
                break;

            case "ternary":
                Console.WriteLine("ternary statement");
                break;

            case "switch":
                Console.WriteLine("switch statement");
                break;

        }

    }


    public static void Whiletest()
    {
        int i, n;
        Console.WriteLine("Enter N:");
        n = Convert.ToInt32(Console.ReadLine());
        i = 1;
        while (i <= n)
        {
            Console.WriteLine(i++);

        }

    }

    public static void Dowhiletest()
    {
        int i, n;
        Console.WriteLine("Enter N:");
        n = Convert.ToInt32(Console.ReadLine());
        i = 1;
        do
        {
            Console.WriteLine(i++);

        } while (i <= n);

    }

    public static void Fortest()
    {
        int n;
        Console.WriteLine("Enter N:");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(i);
        }

    }


    public static void Foreachtest()
    {

        int[] a = { 1, 2, 3, 4 };
        foreach (int e in a)
        {
            Console.WriteLine(e);
        }
    }

    public static void Breaktest()
    {
        int i, n;
        Console.WriteLine("Enter N:");
        n = Convert.ToInt32(Console.ReadLine());
        i = 1;
        while (i <= n)
        {
            if (i == 4)
            {
                break;
            }
            Console.WriteLine(i++);

        }

    }

    public static void Continuetest()
    {
        int i, n;
        Console.WriteLine("Enter N:");
        n = Convert.ToInt32(Console.ReadLine());
        i = 1;
        while (i <= n)
        {
            if (i == 4)
            {
                i++;
                continue;
            }
            Console.WriteLine(i++);

        }

    }


    public static void Gototest()
    {
        int n, i, j, k;
        Console.WriteLine("Enter N:");
        n = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i <= n; i++)
        {
            for (j = 0; j <= n; j++)
            {
                for (k = 0; k <= n; k++)
                {
                    if (i == 2 && j == 3 && k == 4)
                    {
                        goto outer;
                        Console.WriteLine("i={0} j={1} k={2}", i, j, k);
                    }
                }
            }
        }
    outer:
        Console.WriteLine("end");

    }

    public static void SingleArraytest()
    {
        int n;
        int[] a;
        Console.WriteLine("Enter N:");
        n = int.Parse(Console.ReadLine());
        a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter [{0}] :", i);
            a[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter [{0}] : {1}", i, a[i]);

        }
    }


    public static void MultiArraytest()
    {
        int[,] arr;
        int n;
        Console.WriteLine("Enter N:");
        n = int.Parse(Console.ReadLine());
        arr = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int k = n; k >= i; k--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    arr[i, j] = 1;
                }
                else
                {
                    arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];

                }
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

    }

    

    public static void JArraytest()
    {
        int[][] jarr;
        int n;
        Console.WriteLine("Enter N:");
        n = int.Parse(Console.ReadLine());
        jarr = new int[n][];
        for (int i = 0; i < n; i++)
        {
            jarr[i] = new int[i + 1];
            for (int k = n; k >= i; k--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    jarr[i][j] = 1;
                }
                else
                {
                    jarr[i][j] = jarr[i - 1][j] + jarr[i - 1][j - 1];

                }
                Console.Write(jarr[i][j] + " ");
            }
            Console.WriteLine();
        }

    }
   


}
