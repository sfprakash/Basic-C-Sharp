using System;
using System.Globalization;
using System.Net;
namespace DateTimeAssignment;

class Program{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime(2021,8,10,10,40,32);
        Console.WriteLine($"{date.ToString("yyyy")}\n{date.ToString("MM")}\n{date.ToString("dd")}\n{date.ToString("hh")}\n{date.ToString("mm")}\n{date.ToString("ss")}");

        string dt = date.ToString();
        Console.WriteLine($"{dt}");

        string[] revString = dt.Split('/', ' ', ':');
        // foreach(string i in revString){
        //     Console.Write($"{i} ");
        // }
        for(int i = revString.Length - 1; i >= 0; i--){
            Console.Write($"{revString[i]} ");
        }

        Console.WriteLine();
        DateTime date2 = new DateTime();
        bool temp = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss:fff tt",null,DateTimeStyles.None,out date2);
        while(!temp){
            Console.Write($"Invalid Format. Enter valid format: ");
            temp = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss:fff tt",null,DateTimeStyles.None,out date2);
        }
        string toPrint = date2.ToString("yyyy/MM/dd");
        Console.WriteLine($"{toPrint}");
    }
}