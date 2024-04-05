using System;
namespace Array;

class Program
{
    public static void Main(string[] args)
    {
        string[] array = new string[5]{"Mani", "Ganesh", "Venkat", "Suresh", "Venkat"};

        //Printing array elements
        for(int i = 0; i < array.Length; i++){
            Console.WriteLine($"{array[i]}");
        }

        Console.Write("Enter name to search: ");
        //For Loop
        string name = Console.ReadLine();
        int flag = 0;
        for( int i = 0; i < array.Length; i++){
            if(name == array[i]){
                Console.WriteLine($"The name is present in array");
                break;
            }
            flag++;
        }
        if(flag == 5){
                Console.WriteLine($"The name is not present in array");
        }

        int count = 0;
        //Foreach Loop
        foreach(string i in array){
            if(name == i){
                Console.WriteLine($"The name is present in array");
                break;
            }
            count++;
        }
        if(count == 5){
                Console.WriteLine($"The name is not present in array");
        }
    }
}