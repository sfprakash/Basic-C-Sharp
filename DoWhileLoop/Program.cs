using System;
using System.Globalization;
namespace DoWhileLoop;

class Program
{
    public static void Main(string[] args)
    {
        char yesOrNo = '\0';
        int number;
        
        do{
            Console.Write($"Enter a number: ");
            number = int.Parse(Console.ReadLine());

            //checking Odd or Even
            if(number % 2 != 0){
                Console.WriteLine($"{number} is Odd Number");
            }else{
                Console.WriteLine($"{number} is Even number");
            }

            Console.Write($"Do you want to check another number? Type -> 'Y' for Yes | 'N' for No : ");
            yesOrNo = char.Parse(Console.ReadLine());

            //Checking input is valid or not
            while(true)
            {
                if(yesOrNo == 'Y' || yesOrNo =='N'){
                    break;
                }
                else{
                    Console.Write("Invalid Input. Enter Valid Input: ");
                    yesOrNo = char.Parse(Console.ReadLine());
                }
            }
            
        }while(yesOrNo == 'Y');
    }
}
