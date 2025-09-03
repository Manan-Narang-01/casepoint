using System;
using System.Text.RegularExpressions; 

namespace _03_09_25
{
    public class RegexDemo
    {
        public static void RegexMain()
        {
            string badstring = @"Here is a strig with ton of whitespace.";
            
            string CleanedString = Regex.Replace(badstring, @"\s+", "");
            Console.WriteLine($"Cleaned string: {CleanedString}"); 

            string PlusString = Regex.Replace(badstring, @"\s+", "+");
            Console.WriteLine($"Cleaned String: {PlusString}"); 

            Regex r = new Regex(@"^\+?\d{1,2}-?\d{4,5}-?\d{5,6}");

            string[] str = { "+91-967896710", "9678967101", "+91-9678-967101", "090980", "+91-96789-67101", "+919678967101" };
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s, r.IsMatch(s) ? "is" : "is not");
            }

            string firstName = Console.ReadLine();
            if (Regex.Match(firstName, "^[A-Z][a-zA-Z]*$").Success)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Not Valid");

            string Text = "1 One,2 Two|3 Three";
            string[] strs = Regex.Split(Text, @"[,|]");
            foreach (string value in strs)
            {
                Console.WriteLine(value);
            }
        }
    }
}
