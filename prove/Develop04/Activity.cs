using System;
using System.Threading;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void PausingWhileShowingSpinner()
    {
         Console.WriteLine("Get ready...");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void PausingWhileCountingDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"You have {i} seconds remaining...");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine(i - 1);
        }
    }

    public void DisplayingEndMessage()
    {
        Console.WriteLine($"You have completed the {_activityName} Activity!");
        Console.WriteLine($"Total Duration: {_duration} seconds");
        Console.WriteLine("Well done!");
        PausingWhileCountingDown(3);
    }

    public void DisplayingStartMessage()
    {
        Console.WriteLine($"Starting {_activityName} Activity:");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Get ready to begin...");
        PausingWhileCountingDown(3);
    }

}