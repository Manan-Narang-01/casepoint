namespace _03_09_25;

public class StringDemo
{
    public static void StringMain()
    {
        string fname = "Manan", lname = "Narang";
        Console.WriteLine("First Name: {0} Last Name: {1}", fname, lname);
        char[] letters = { 'm', 'a', 'n', 'a', 'n' };
        string name = new string(letters);
        Console.WriteLine(name);
        string s1 = new string('v', 5);
        Console.WriteLine(s1);
        string s2 = new string(letters, 1, 2);
        Console.WriteLine(s2);

        string firstname = "Manan";
        string lastname = "Narang";

        for (int i = 0; i <= firstname.Length - 1; i++)
        {
            Console.WriteLine("{0}", firstname[i]);
        }

        Console.WriteLine(firstname.Equals(fname));
        Console.WriteLine(firstname.Equals(lastname));
        Console.WriteLine(firstname.CompareTo(fname));
        Console.WriteLine(firstname.CompareTo(lastname));
        Console.WriteLine(firstname.CompareTo("Mannat"));
        Console.WriteLine("Mannat".CompareTo(firstname));
        Console.WriteLine("Manan Narang".CompareTo(firstname));
        
        Console.WriteLine("Mannat".CompareTo(firstname));
        Console.WriteLine("Manan Narang".CompareTo(firstname));
        Console.WriteLine(firstname.StartsWith("M"));
        Console.WriteLine(firstname.Contains("an"));
        Console.WriteLine(firstname.EndsWith("n"));
        Console.WriteLine(firstname.EndsWith("v"));
        Console.WriteLine(firstname.GetType());
        Console.WriteLine(firstname.GetTypeCode());
        Console.WriteLine(firstname.IndexOf("n"));
        Console.WriteLine("Hello".LastIndexOf("1"));
        Console.WriteLine(firstname.ToLower());
        Console.WriteLine(firstname.ToUpper());
        Console.WriteLine(firstname.Insert(0, "Hello "));
        Console.WriteLine(firstname.Length);
        Console.WriteLine(firstname.Remove(2,1));
        Console.WriteLine(firstname.Substring(1, 2));
        Console.WriteLine(firstname.ToCharArray());
        Console.WriteLine(" Varun ".Trim());
        Console.WriteLine(firstname.PadLeft(10));
        Console.WriteLine(firstname.PadRight(10,'z'));
        
        
    }
}
