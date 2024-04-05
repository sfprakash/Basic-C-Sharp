using System;
using System.Linq;
namespace StringManipulation;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter main String: ");
        string mainString = Console.ReadLine();
        Console.Write("Enter sub string: ");
        string subString = Console.ReadLine();

        string[] newString = mainString.Split(subString);
        Console.WriteLine($"{newString.Length-1}");

    
    }
}