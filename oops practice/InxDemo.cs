namespace _03_09_25;

public class InxDemo
{
    private string[] name = new string[10];
    public string this[int i]
    {
        get
        {
            return name[i];
        }
        set
        {
            name[i] = value;
        }
    }
    public static void IndexMain()
    {
        InxDemo id = new InxDemo();
        id[0] = "A";
        id[1] = "B";
        id[2] = "C";
        id[3] = "D";
        id[4] = "E";

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(id[i]);
        }

    }


}
