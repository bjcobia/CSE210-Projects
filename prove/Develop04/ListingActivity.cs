using System;
using System.Threading;

public class ListingActivity : Activity
{
    private Random _random;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public int GenerateRandomNumber(int min, int max)
    {
        return _random.Next(min, max);
    }
    public void RunActivity()
    {
        PausingWhileShowingSpinner();
        DisplayingStartMessage();

        Console.WriteLine("Think about the following prompt for a few seconds:\b");
        Thread.Sleep(3000);

        string prompt = _prompts[GenerateRandomNumber(0, _prompts.Count)];
        Console.WriteLine(prompt);
        Thread.Sleep(5000); // Countdown for 5 seconds
        PausingWhileCountingDown(3);

        Console.WriteLine();
        Console.WriteLine("Now start listing items. Press Enter after each item.");
        Console.WriteLine($"You have {GetDuration()} seconds to list as many items as you can.");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items.");

        DisplayingEndMessage();
    }

    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
        _random = new Random();
    }

}