using System;
namespace Method;

class Program{
    public static void Main(string[] args)
    {
        double a = 14.2;
        double b = 14.2;
        double result = Multiply(a,b);
        Console.WriteLine($"{result}");

        float c = 20.4F;
        float d = 10.2F;
        Divide(c,d);
    }
    static double Multiply(double num1, double num2){
        double sum = num1 * num2;
        return sum;
    }

    static void Divide(float x, float y){
        float dividedValue = x / y;
        Console.WriteLine($"{dividedValue}");
    }
}