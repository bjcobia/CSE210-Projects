using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        SquareNumber(userNumber);



       static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
       }

       static string PromptUserName(){
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
       }
       static int PromptUserNumber(){
            Console.WriteLine("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
       }
       static int SquareNumber(int userNumber){
            int Squared = userNumber^2;
            return Squared;
       }


    }
}