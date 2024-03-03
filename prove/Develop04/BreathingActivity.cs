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
        PausingWhileShowingSpinner();
        DisplayingStartMessage();

        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(GetDuration());
        DateTime endTime = startTime + duration;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(BreathIn());
            Thread.Sleep(1000);
            PausingWhileCountingDown(5);
            Console.WriteLine(BreathOut());
            PausingWhileCountingDown(5);
            Thread.Sleep(1000);
        }
        DisplayingEndMessage();
    }

    public BreathingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
    }
}