using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
namespace MethodAssignment;

class Program{
    public static void Main(string[] args)
    {
        bool isContinue = true;
        do{
            Console.Write($"Enter number 1: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter number 2: ");
            int input2 = int.Parse(Console.ReadLine());
            Console.Write($"1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\nEnter your choice of operation: ");
            int option = int.Parse(Console.ReadLine());
            
            while(true){
                if(option == 1 || option == 2 || option == 3 || option == 4){
                    break;
                }else{
                    Console.Write($"Invalid option. Enter valid option: ");
                    option = int.Parse(Console.ReadLine());
                }
            }


            int result = operation(option, input1, input2);
            Console.WriteLine($"Result = {result}");

            Console.Write($"Do you want to continue? yes/no: ");
            string str = Console.ReadLine();

            while(true){
                if(str == "yes" || str == "no"){
                    break;
                }else{
                  Console.Write($"Invalid format. Enter valid input: ");
                  str = Console.ReadLine();
                }
            }
            if(str == "yes"){
                isContinue = true;
            }else{
                isContinue = false;
            }

        }while(isContinue);
    }
    static int operation(int choice, int num1, int num2){
        switch(choice){
            case 1:{

                return num1 + num2;
                
            }
            case 2:{
                
                return num1 - num2;
                
            }
            case 3:{
                
                return num1 * num2;

            }
            case 4:{
                
                return num1 / num2;

            }
            default:{

                return 0;

            }
        }
    }

}