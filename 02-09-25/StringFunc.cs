namespace _02_09_25;

public class StringFunc
{
    public static void StringMain(){

        string str = "Hello World";

        Console.WriteLine("First = {0}, Last = {1}", str[0], str[str.Length - 1]); 


        char[] ch={'H','e','l','l','o'};
        string str1 = new string(ch);

        Console.WriteLine(str1);

        string str2=new string('H',5);
        Console.WriteLine(str2);

        string str3=new string(ch,2,3);
        Console.WriteLine(str3);

        string name="Manan";
        string surname="Narang";

        for(int i=0;i<name.Length;i++){
            Console.WriteLine(name[i]);
        }


        Console.WriteLine(name.Equals(surname));
        Console.WriteLine(name.Equals("Manan"));

        Console.WriteLine(name.CompareTo(surname));
        Console.WriteLine(name.CompareTo("Manan"));
        Console.WriteLine(name.CompareTo("Manan"));


        Console.WriteLine(name.Contains("Manan"));
        Console.WriteLine(name.Contains("Manan"));
        Console.WriteLine(name.Contains("M"));
        Console.WriteLine(name.StartsWith("M"));
        Console.WriteLine(name.EndsWith("a"));

        Console.WriteLine(name.ToLower());
        Console.WriteLine(name.ToUpper());

        Console.WriteLine(surname.Substring(2,3));
        Console.WriteLine(surname.Substring(2));

        Console.WriteLine(name.IndexOf("Manan"));
        Console.WriteLine(name.IndexOf("M"));
        Console.WriteLine(surname.LastIndexOf("l"));

        Console.WriteLine(name.Replace("Manan","Developer"));

        Console.WriteLine(name.Trim());

        Console.WriteLine(name.PadLeft(20));
        Console.WriteLine(name.PadRight(20,'*'));

        Console.WriteLine(surname.ToCharArray());

        Console.WriteLine(name+surname.Split(' '));

        Console.WriteLine(surname.Remove(3,2));

        Console.WriteLine(surname.Insert(3,"Narang"));
        Console.WriteLine(surname.Replace("a","i"));

    }
}
