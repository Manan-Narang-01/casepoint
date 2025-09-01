namespace ConsoleApp;

public class PrivateConstructor
{
    private PrivateConstructor()
    {

    }
    public static int cv;
    public static int vc()
    {
        return ++cv;
    }

}
