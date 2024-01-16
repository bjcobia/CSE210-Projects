using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string Answer = Console.ReadLine();
        int Grade = int.Parse(Answer);

        string letter = "";

        if (Grade >= 90){
            letter = "A";
        }
        else if(Grade >= 80){
            letter = "B";
        }
        else if(Grade >= 70){
            letter = "C";
        }
        else if (Grade >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }

        Console.WriteLine($"Your Grade is: {letter}");

        if (Grade >= 70){
            Console.WriteLine("Congratulations, you passed!");
        }
        else{
            Console.WriteLine("You have failed.");
        }
    }
}