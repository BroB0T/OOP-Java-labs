using System;
using System.Text;

class Program 
{
    static void Main()
    {
        // 1
        char[] universityText = "NLTU, IKNIT, IPZ-21, software engineering".ToCharArray();

        string fullString = new string(universityText);
        Console.WriteLine("Full string: " + fullString);

        // 2
        string string1 = fullString.Replace("software engineering", "");
        Console.WriteLine("\nString without specialty: " + string1);

        // 3
        char[] arr = string1.ToCharArray();
        Array.Reverse(arr);
        string string2 = new string(arr);
        Console.WriteLine("\nReverse string : " + string2);

        // 4
        string string3 = string1.ToUpper();
        Console.WriteLine("\nCapital letters string: " + string3);
        Console.WriteLine(string1.Equals(string3) ? "\nstring1 == string3" : "\nstring1 != string3");

        // 5
        string institute = fullString.Split(',')[1];
        Console.WriteLine("\nInstitute: " + institute);

        // 6
        string string4 = string1 + " " + string3;
        Console.WriteLine("\n1 and 3 string together: " + string4);

        // 7
        Console.WriteLine("\nfirst index: " + string1.IndexOf('n') + "\tlast index: " + string1.LastIndexOf('n'));

        // 8
        StringBuilder stringBuilder = new StringBuilder("Tryhuba Ivan Igorovich 19 01 2007");
        Console.WriteLine("\nstringBuilder: " + stringBuilder);

        // 9
        stringBuilder.Replace("19 01", "");
        Console.WriteLine("\nDelete day and month: " + stringBuilder);

        // 10
        stringBuilder.Append(" c. Belz");
        Console.WriteLine("\nAdd place of birth: " + stringBuilder);

        // 11
        stringBuilder.Insert(stringBuilder.ToString().IndexOf("2007") + 4, " Male");
        Console.WriteLine("\nAdd gender: " + stringBuilder);

        //12
        Console.WriteLine("\nString length: " + stringBuilder.Length);
        Console.WriteLine("\nBite length: " + Encoding.UTF8.GetByteCount(stringBuilder.ToString()));
    }
}