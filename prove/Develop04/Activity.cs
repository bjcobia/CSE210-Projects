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
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }



    public void PausingWhileCountingDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"\rYou have {i} seconds remaining...");
            Thread.Sleep(1000);
        }
    }

    public void DisplayingEndMessage()
    {
        Console.WriteLine($"You have completed the {_activityName} Activity!");
        Console.WriteLine($"Total Duration: {_duration} seconds");
        Console.WriteLine("Well done!");
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey(true);
        Console.Clear();
        PausingWhileShowingSpinner();
        
    }

    public void DisplayingStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_activityName} Activity:");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Press Enter to begin");
        Console.ReadLine();
        Console.WriteLine("Get Ready...\n");
        PausingWhileCountingDown(3);
        Console.Clear();

    }

}