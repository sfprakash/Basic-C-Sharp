using System;
namespace WhileLoop;

class Program
{
    public static void Main(string[] args)
    {
        //Question 1
        int startNumber = 0;
        while(startNumber <= 25){
            if(startNumber % 2 == 0){
                Console.WriteLine(startNumber);
            }
            startNumber++;
        }

        //Question 2
        Console.Write($"Enter a valid Number: ");
        int number = 0;
        

        while(true){

            bool isTrue = int.TryParse(Console.ReadLine(), out number);

            if(isTrue)
            {
                Console.WriteLine($"number = {number}");
                break;
            }
            else{
                Console.WriteLine($"Invalid Input Format. Please enter the input in number format");
            }
            
        }
    }
}