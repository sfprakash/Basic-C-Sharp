using System;
using System.Diagnostics;
namespace SwitchCase;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write($"Enter First Number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write($"Enter Second Number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write($"Operations --> '+' '-' '*' '/' '%'\nEnter the Operation you need to Perform:\n");
        char operation = char.Parse(Console.ReadLine());

        switch(operation)
        {
            case '+':
            {
                double sumValue = num1 + num2;
                Console.WriteLine($"Sum Value = {sumValue}");
                break;
            }
            case '-':
            {
                double subtractedValue = num1 - num2;
                Console.WriteLine($"Subtracted Value = {subtractedValue}");
                break;
            }
            case '*':
            {
                double multipliedValue = num1 * num2;
                Console.WriteLine($"Multiplied value = {multipliedValue}");
                break;
            }
            case '/':
            {
                double dividedValue = num1 / num2;
                Console.WriteLine($"Divided Value = {dividedValue}");
                break;
            }
            case '%':
            {
                double modulusValue = num1 % num2;
                Console.WriteLine($"modulus Value = {modulusValue}");
                break;
            }
            default:
            {
                Console.WriteLine($"Invalid input");
                break;
            }

        }
    }
}
