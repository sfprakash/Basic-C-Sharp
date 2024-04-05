using System;
namespace ForLoop;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write($"Enter the Starting number: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write($"Enter the Ending number: ");
        int endNumber = int.Parse(Console.ReadLine());
        int sum = 0;

        for( int i = startNumber + 1; i < endNumber; i++){
            sum += i * i;
        }
        Console.WriteLine($"Sum Of square of the numbers between {startNumber} and {endNumber} = {sum}");
    }
}