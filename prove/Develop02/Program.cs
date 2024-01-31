using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "1";
        while (userChoice != "5") {

        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

        userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                
                break;
            case "2":

                break;
            case "3":

                break;
            case "4":

                break;
            case "5":

                break;
            default:
                Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                break;
        }
        }
    }
}