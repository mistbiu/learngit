using System;
public class Product
{
    public static void Main(string[] args)
    {
        string s = "";
        int n1 = 0;
        int n2 = 0;
        Console.Write("Input the first number:");
        s = Console.ReadLine();
        n1 = Int32.Parse(s);
        Console.Write("Input the second number:");
        s = Console.ReadLine();
        n2 = Int32.Parse(s);
        n1 = n1 * n2;
        Console.WriteLine("The result is " + n1 + " .");
    }
}