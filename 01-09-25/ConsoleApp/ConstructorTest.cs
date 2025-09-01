using System.ComponentModel.Design.Serialization;

namespace ConsoleApp;

public class ConstructorTest
{
    public int a, b;
    public ConstructorTest()
    {
        a = 10;
        b = 20;
    }
    public ConstructorTest(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public ConstructorTest(ConstructorTest te1)
    {
        a = te1.a;
        b = te1.b;

    }
    public int add()
    {
        return a + b;
    }
}
