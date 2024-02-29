using System;
using System.Threading;

public class BreathingActivity : Activity
{
public string BreathIn()
{
    return "Breathe in...";
}

public string BreathOut()
{
    return "Breathe out...";
}

public void RunActivity()
{
    DisplayingStartMessage();
    PausingWhileShowingSpinner();
    for(int i = 0; i < GetDuration(); i++)
    {
        Console.WriteLine(BreathIn());
        Thread.Sleep(1000);
        Console.WriteLine(BreathOut());
        Thread.Sleep(1000);
    }
    DisplayingEndMessage();
}

public BreathingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
{
}
}