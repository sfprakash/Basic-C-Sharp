using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of Subject1: ");
        double mark1 = double.Parse(Console.ReadLine());
        Console.Write("Enter mark of Subject2: ");
        double mark2 = double.Parse(Console.ReadLine());
        Console.Write("Enter mark of Subject3: ");
        double mark3 = double.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        long mobileNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter Mail id: ");
        string mailId = Console.ReadLine();

        double total = mark1 + mark2 + mark3;
        double average = total / 3;

        Console.WriteLine();
        // Console.WriteLine("Trainee Details are:");
        // Console.WriteLine("Name: " + name);
        // Console.WriteLine("Age: " + age);
        // Console.WriteLine("Mobile: " + mobileNumber);
        // Console.WriteLine("Marks1: " + mark1);
        // Console.WriteLine("Marks2: " + mark2);
        // Console.WriteLine("Marks3: " + mark3);
        // Console.WriteLine("Total: " + total);
        // Console.WriteLine("Average: " + average);
        // Console.WriteLine("Grade: " + grade);
        // Console.WriteLine("Mail id: " + mailId);

        Console.WriteLine($"Trainee Details are:\nName: {name}\nAge: {age}\nMobile: {mobileNumber}\nMarks1: {mark1}\nMarks2: {mark2}\nMarks3: {mark3}\nTotal: {total}\nAverage: {average}\nGrade: {grade}\nMail id: {mailId}");


    }
}