namespace _02_09_25;

static class StringExtensions{

    public static int wordCount(this string str){
        return str.Split(new char[]{' ','.','?','!'},StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static string MyConcat(this string str1, string str2){
        return str1+" "+str2;
    }
}


public class StringExtension
{
    public static void ExtensionTestMain()
    {
        string s= "Hello world! How are you?";

        Console.WriteLine(s.wordCount());

        Console.WriteLine("Hello".MyConcat("Hello"));
    }

}
