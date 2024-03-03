using System;
using System.Threading;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App!\n");
        string choice;
        
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App!\n");

            Console.WriteLine("Here are your activities: ");
            Console.WriteLine("1. Breathing\n2. Reflection\n3. Listing\n4. Quit");

            Console.WriteLine("Select an activity to begin: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Please choose how long you would like the activity to last (in seconds): ");
                int duration = int.Parse(Console.ReadLine());
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration);
                breathingActivity.RunActivity();
                breathingCount++;
            }
            else if (choice == "2")
            {
                Console.WriteLine("Please choose how long you would like the activity to last (in seconds): ");
                int duration = int.Parse(Console.ReadLine());
                ReflectingActivity reflectionActivity = new ReflectingActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration);
                reflectionActivity.RunActivity();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                Console.WriteLine("Please choose how long you would like the activity to last (in seconds): ");
                int duration = int.Parse(Console.ReadLine());
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration);
                listingActivity.RunActivity();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.WriteLine($"You have used the Breathing activity {breathingCount} times.");
                Console.WriteLine($"You have used the Reflection activity {reflectionCount} times.");
                Console.WriteLine($"You have used the Listing activity {listingCount} times.");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            // Prompt user to press any key to return to the menu
            if (choice != "4")
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey(true);
            }

        } while (choice != "4");
    }
}