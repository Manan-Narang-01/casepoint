using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp;

public class FunctionTest
{
    public int fact(int n)
    {
        if (n == 0)
        {
            return 1;

        }
        else
        {
            return n * fact(n - 1);
        }

    }
    public static int pow(int x, int y)
    {
        if (y == 0)
        {
            return 1;
        }
        else
        {
            return x * pow(x, y - 1);
        }
    }
    public int add(int x, int y, int z = 3)
    {
        return x + y + z;

    }
    public int add(int x, int y)
    {
        return x + y;

    }
    public float add(float x, float y)
    {
        return x + y;
    }
    public void max(int x, int y, ref int mx)
    {
        if (x > y)
        {
            mx = x;
        }
        else
        {
            mx = y;
        }
    }
   
    
        
}
