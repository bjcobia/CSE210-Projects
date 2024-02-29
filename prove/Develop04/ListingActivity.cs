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
        DisplayingStartMessage();
        PausingWhileShowingSpinner();
        foreach (var prompt in _prompts)
        {
            Console.WriteLine(prompt);
            Thread.Sleep(3000);
        }
    }

    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
    }

}